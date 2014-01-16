using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace SqlServerConnectionTools
{
	public partial class frmMain : Form
	{
		private const string ConnectionStringIntegratedMasterFormat = "Data Source={0};Initial Catalog=Master;Integrated Security=True;Connect Timeout=10;";
		private const string ConnectionStringIntegratedDbFormat = "Data Source={0};Initial Catalog={1};Integrated Security=True;Connect Timeout=10;";
		private const string ConnectionStringUserMasterFormat = "Data Source={0};Initial Catalog=Master;Connect Timeout=10;User ID={1};Password={2};";
		private const string ConnectionStringUserDbFormat = "Data Source={0};Initial Catalog={1};Connect Timeout=10;User ID={2};Password={3};";
		private const string ConnectionStringUserInstance = ";User Instance=true;AttachDBFilename={0};";


		public frmMain()
		{
			InitializeComponent();
		}


		void EnableMassiveForm(bool enable)
		{
			if (InvokeRequired)
			{
				BeginInvoke(new Action<bool>(EnableMassiveForm), enable);
				return;
			}
			gpbMassiveSqlFile.Enabled = enable;
			gpbMassiveConnection.Enabled = enable;
			btnMassiveSqlRun.Enabled = enable;
			btnMassiveSqlStop.Enabled = !enable;
		}

		string ConnectionChanged()
		{
			var connStr = "";
			if (rbtnSqlWindowsAuthentication.Checked)
			{
				if (chkUserInstance.Checked)
				{
					connStr = string.Format(ConnectionStringIntegratedDbFormat, cmbDataSource.Text, cmbDatabaseName.Text);
					connStr += string.Format(ConnectionStringUserInstance, txtUserInstanceMdfile.Text);
				}
				else
				{
					connStr = string.Format(ConnectionStringIntegratedDbFormat, cmbDataSource.Text, cmbDatabaseName.Text);
				}
			}
			else
			{
				if (chkUserInstance.Checked)
				{
					connStr = string.Format(ConnectionStringUserDbFormat, cmbDataSource.Text, cmbDatabaseName.Text, txtSqlUser.Text, txtSqlPwd.Text);
					connStr += string.Format(ConnectionStringUserInstance, txtUserInstanceMdfile.Text);
				}
				else
				{
					connStr = string.Format(ConnectionStringUserDbFormat, cmbDataSource.Text, cmbDatabaseName.Text, txtSqlUser.Text, txtSqlPwd.Text);
				}
			}

			txtConnString.Text = connStr;
			return connStr;
		}

		string ConnectionMasterFormat(string dataSource, bool userInstance, string userInstanceMdfile, string userName, string pwd)
		{
			var connStr = "";
			if (rbtnSqlWindowsAuthentication.Checked)
			{
				connStr = string.Format(ConnectionStringIntegratedMasterFormat, dataSource);
				if (userInstance)
				{
					connStr += string.Format(ConnectionStringUserInstance, userInstanceMdfile);
				}
			}
			else
			{
				connStr = string.Format(ConnectionStringUserMasterFormat, dataSource, userName, pwd);
				if (userInstance)
				{
					connStr += string.Format(ConnectionStringUserInstance, userInstanceMdfile);
				}
			}

			return connStr;
		}

		List<String> GetDatabaseList(string dataSource, bool userInstance, string userInstanceMdfile, string userName, string pwd)
		{
			var result = new List<string>();
			using (var sql = new SqlConnection(ConnectionMasterFormat(dataSource, userInstance, userInstanceMdfile, userName, pwd)))
			{
				try
				{
					sql.Open();
					using (var cmd = sql.CreateCommand())
					{
						cmd.CommandText = "SELECT name FROM sysdatabases ORDER BY dbid DESC ";
						using (var reader = cmd.ExecuteReader(CommandBehavior.CloseConnection))
						{
							while (reader.Read())
							{
								try
								{
									result.Add(reader.GetString(0));
								}
								catch
								{
									// ignore
								}
							}
							reader.Close();
						}
					}
				}
				catch (Exception)
				{
				}
			}
			return result;
		}

		static List<string> GetLocalSqlInstances()
		{
			var machineName = Environment.MachineName;
			var result = new List<string>();
			try
			{

				RegistryKey key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Microsoft SQL Server\Instance Names");
				try
				{
					foreach (string sk in key.GetSubKeyNames())
					{
						RegistryKey rkey = key.OpenSubKey(sk);
						foreach (string s in rkey.GetValueNames())
						{
							if (!string.IsNullOrEmpty(s))
								result.Add(machineName + "\\" + s);
						}
					}
				}
				finally
				{
					key.Close();
				}
			}
			catch (Exception)
			{
				// ignore!
			}
			return result;
		}


		private void rbtnSQLAuthentication_CheckedChanged(object sender, EventArgs e)
		{
			txtSqlUser.Enabled = rbtnSQLAuthentication.Checked;
			txtSqlPwd.Enabled = rbtnSQLAuthentication.Checked;
			ConnectionChanged();
		}

		private void chkUserInstance_CheckedChanged(object sender, EventArgs e)
		{
			txtUserInstanceMdfile.Enabled = chkUserInstance.Checked;
			btnSelectMdf.Enabled = chkUserInstance.Checked;
			ConnectionChanged();
		}

		private void txtMdfFile_TextChanged(object sender, EventArgs e)
		{
			ConnectionChanged();
		}


		private void btnAttach_Click(object sender, EventArgs e)
		{
			var connectonMaster = ConnectionMasterFormat(cmbDataSource.Text, false, cmbDatabaseName.Text, txtSqlUser.Text, txtSqlPwd.Text);

			string attachCmd;
			if (txtAttachLDF.Text.Length > 0)
				attachCmd = string.Format("EXEC sp_attach_db  @dbname = N'{0}', @filename1 = N'{1}',@filename2 =N'{2}'",
					txtAttachDbName.Text, txtAttachMDF.Text, txtAttachLDF.Text);
			else
				attachCmd = string.Format("EXEC sp_attach_db  @dbname = N'{0}', @filename1 = N'{1}'",
					txtAttachDbName.Text, txtAttachMDF.Text);

			using (var conn = new SqlConnection(connectonMaster))
			using (var cmd = new SqlCommand(attachCmd, conn))
			{
				try
				{
					conn.Open();
				}
				catch (Exception ex)
				{
					//lblResult.Text = "Connection failed! " + ex.Message;
					MessageBox.Show(ex.ToString(), "Connection failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				try
				{
					cmd.ExecuteNonQuery();
					//lblResult.Text = "Database attach succeed!";
					MessageBox.Show("Database attach succeed!", "Database attach succeed!", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				catch (Exception ex)
				{
					//lblResult.Text = "Database attach failed! " + ex.Message;
					MessageBox.Show(GetExceptionTechMessage(ex), "Database attach failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				finally
				{
					conn.Close();
				}
			}
		}

		private void btnDetachDb_Click(object sender, EventArgs e)
		{
			var connectonMaster = ConnectionMasterFormat(cmbDataSource.Text, false, cmbDatabaseName.Text, txtSqlUser.Text, txtSqlPwd.Text);

			string attachCmd =
				string.Format("EXEC sp_detach_db  @dbname = N'{0}'",
							  txtAttachDbName.Text);
			using (var conn = new SqlConnection(connectonMaster))
			using (var cmd = new SqlCommand(attachCmd, conn))
			{
				try
				{
					SqlConnection.ClearAllPools();
					conn.Open();
				}
				catch (Exception ex)
				{
					MessageBox.Show(GetExceptionTechMessage(ex), "Connection failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				try
				{
					cmd.ExecuteNonQuery();
					MessageBox.Show("Database detach succeed!", "Database detach succeed!", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				catch (Exception ex)
				{
					MessageBox.Show(GetExceptionTechMessage(ex), "Database detach failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				finally
				{
					conn.Close();
				}
			}
		}

		private void btnSelectMdf_Click(object sender, EventArgs e)
		{
			using (var dlg = new OpenFileDialog())
			{
				dlg.Filter = "*.MDF|*.MDF";
				if (dlg.ShowDialog() == DialogResult.OK)
				{
					txtUserInstanceMdfile.Text = dlg.FileName;

					if (cmbDatabaseName.Text.Length == 0 || cmbDatabaseName.Text.Equals("master", StringComparison.InvariantCultureIgnoreCase))
					{
						cmbDatabaseName.Text = Path.GetFileNameWithoutExtension(txtUserInstanceMdfile.Text);
					}
				}
			}
		}

		private void frmMain_Load(object sender, EventArgs e)
		{
			try
			{
				var lst = GetLocalSqlInstances();
				var configList = AppConfig.Instance.DataSources;
				configList.AddIfNotExisted(lst);

				var datasource = cmbDataSource.Text;
				cmbDataSource.DataSource = configList;

				if (datasource.Length == 0 && configList.Count > 0)
				{
					cmbDataSource.SelectedIndex = 0;
				}
				else
					cmbDataSource.Text = datasource;

				txtQueryConn.DataSource = AppConfig.Instance.ConnectionStrings;
			}
			catch (Exception)
			{
			}
		}

		private void cmbDataSource_SelectedIndexChanged(object sender, EventArgs e)
		{
			ConnectionChanged();
			GetDatabasesList();
		}

		private void GetDatabasesList()
		{
			if (cmbDataSource.SelectedIndex >= 0)
			{
				var dataSource = cmbDataSource.Text;
				string userInstanceMdfile = txtUserInstanceMdfile.Text;
				string userName = txtSqlUser.Text;
				string pwd = txtSqlPwd.Text;
				bool userInstance = chkUserInstance.Checked;
				try
				{
					new Action(() =>
								{
									var list = GetDatabaseList(dataSource, userInstance, userInstanceMdfile, userName, pwd);
									DisplayDatabaseList(list);
								}).BeginInvoke(null, null);
				}
				catch (Exception)
				{
				}
			}
		}

		void DisplayDatabaseList(List<string> ds)
		{
			if (this.InvokeRequired)
			{
				this.BeginInvoke(new Action<List<string>>(DisplayDatabaseList), ds);
				return;
			}

			try
			{
				var oldName = cmbDatabaseName.Text;
				cmbDatabaseName.DataSource = ds;
				cmbDatabaseName.Text = (string.IsNullOrEmpty(oldName)) ? "master" : oldName;
			}
			catch (Exception)
			{
			}
		}

		private void rbtnSqlWindowsAuthentication_CheckedChanged(object sender, EventArgs e)
		{
			ConnectionChanged();
		}

		private void txtSqlUser_TextChanged(object sender, EventArgs e)
		{
			ConnectionChanged();
		}

		private void txtSqlPwd_TextChanged(object sender, EventArgs e)
		{
			ConnectionChanged();
		}

		private void cmbDatabaseName_TextChanged(object sender, EventArgs e)
		{
			ConnectionChanged();
			txtAttachDbName.Text = cmbDatabaseName.Text;
		}

		private void btnTestConn_Click(object sender, EventArgs e)
		{
			try
			{
				using (var conn = new SqlConnection(txtConnString.Text))
				{
					conn.Open();
				}
				MessageBox.Show("ConnectionString is ok!", "Test succeed!", MessageBoxButtons.OK, MessageBoxIcon.Information);

				var ds = cmbDataSource.Text.Trim();
				if (ds.Length > 0)
					AppConfig.Instance.DataSources.AddIfNotExisted(ds);
			}
			catch (Exception ex)
			{
				MessageBox.Show(GetExceptionTechMessage(ex), "Test failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnAccMDF_Click(object sender, EventArgs e)
		{
			using (var dlg = new OpenFileDialog())
			{
				dlg.Filter = "*.MDF|*.MDF";
				if (dlg.ShowDialog() == DialogResult.OK)
				{
					txtAttachMDF.Text = dlg.FileName;
					if (txtAttachDbName.Text.Length == 0 || txtAttachDbName.Text.Equals("master", StringComparison.InvariantCultureIgnoreCase))
					{
						txtAttachDbName.Text = Path.GetFileNameWithoutExtension(txtAttachMDF.Text);
					}
				}
			}
		}

		private void btnAccLDF_Click(object sender, EventArgs e)
		{
			using (var dlg = new OpenFileDialog())
			{
				dlg.Filter = "*.LDF|*.LDF";
				if (dlg.ShowDialog() == DialogResult.OK)
				{
					txtAttachLDF.Text = dlg.FileName;
				}
			}
		}

		public static string GetExceptionTechMessage(Exception ex, string seperator = "\n")
		{
			if (string.IsNullOrEmpty(seperator))
				seperator = "\r\n";
			string result = ex.GetType().Name + " -> " + ex.Message;
			Exception inner = ex.InnerException;

			while (inner != null)
			{
				result += seperator + inner.GetType().Name + " -> " + inner.Message;
				inner = inner.InnerException;
			}
			return result;
		}


		private void btnRefreshDbList_Click(object sender, EventArgs e)
		{
			ConnectionChanged();
			GetDatabasesList();

		}

		private void txtConnString_TextChanged(object sender, EventArgs e)
		{
			txtQueryConn.Text = txtConnString.Text;
		}

		private void btnQueryExecute_Click(object sender, EventArgs e)
		{
			var done = RunQuery();
			if (done)
			{
				AppConfig.Instance.ConnectionStrings.AddIfNotExisted(txtQueryConn.Text);
			}
		}

		private bool RunQuery()
		{
			using (SqlConnection conn = new SqlConnection(txtQueryConn.Text))
			using (var cmd = new SqlCommand(txtQueryCmd.Text, conn))
			using (var adapter = new SqlDataAdapter(cmd))
			using (var ds = new DataSet())
			{
				try
				{
					conn.Open();
				}
				catch (Exception ex)
				{
					lblResult.Text = "Connection failed! " + ex.Message;
					MessageBox.Show(ex.ToString(), "Connection failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return false;
				}
				try
				{
					adapter.Fill(ds);
					grdQueryResult.DataSource = ds;

					if (ds.Tables.Count > 0)
					{
						lblResult.Text = string.Format("Result has {0} table(s) and first table has {1} record(s).",
							ds.Tables.Count, ds.Tables[0].Rows.Count);
						grdQueryResult.DataSource = ds.Tables[0];
					}
					else
					{
						lblResult.Text = "No result generated!";
					}
					return true;
				}
				catch (Exception ex)
				{
					lblResult.Text = "Query failed! " + ex.Message;
					MessageBox.Show(ex.ToString(), "Query failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return false;
				}
			}
		}

		private void lnkBlog_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			try
			{
				Process.Start(new ProcessStartInfo()
				{
					FileName = "http://www.salarcode.com/",
					UseShellExecute = true
				});
			}
			catch { }
		}

		private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
		{
			AppConfig.Instance.SaveConfig();
		}

		private void txtQueryConn_TextChanged(object sender, EventArgs e)
		{
			txtMassiveSqlConnection.Text = txtQueryConn.Text;
		}

		private void btnSelectSql_Click(object sender, EventArgs e)
		{
			using (var dlg = new OpenFileDialog())
			{
				dlg.Filter = "*.sql|*.sql";
				if (dlg.ShowDialog() == DialogResult.OK)
				{
					txtMassiveSqlFile.Text = dlg.FileName;
					if (txtMassiveSqlFile.Text.Length == 0 || txtMassiveSqlFile.Text.Equals("master", StringComparison.InvariantCultureIgnoreCase))
					{
						txtMassiveSqlFile.Text = Path.GetFileNameWithoutExtension(txtMassiveSqlFile.Text);
					}
				}
			}
		}

		private delegate void RunMassiveAction(
			string connString, string sqlFile, bool useAdoNet, int seperate, Action<int, int> progress);

		private bool _massiveRunStopRequest = false;

		private void btnMassiveSqlStop_Click(object sender, EventArgs e)
		{
			_massiveRunStopRequest = true;
			btnMassiveSqlStop.Enabled = false;
		}
		private void btnMassiveSqlRun_Click(object sender, EventArgs e)
		{
			if (!File.Exists(txtMassiveSqlFile.Text))
			{
				MessageBox.Show("Sql file is not selected", "Massive Sql File", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			_massiveRunStopRequest = false;

			int seperate = 0;
			if (rbtnSepGo.Checked)
				seperate = 1;
			else if (rbtnSepSemiColon.Checked)
				seperate = 2;

			new RunMassiveAction(RunMassiveSqlFile)
				.BeginInvoke(
					txtMassiveSqlConnection.Text,
					txtMassiveSqlFile.Text,
					rbtnSqlUseAdo.Checked,
					seperate,
					UpdateProgress,
					null,
					null);
		}

		void UpdateProgress(int value, int max)
		{
			if (InvokeRequired)
			{
				BeginInvoke(new Action<int, int>(UpdateProgress), value, max);
				return;
			}
			barMassiveSql.Maximum = max;
			barMassiveSql.Value = value;
			if (max <= 0)
				lblMassivSqlCount.Text = "";
			else
				lblMassivSqlCount.Text = "Executed " + value + " commands out of " + max;
		}

		void RunMassiveSqlFile(string connString, string sqlFile, bool useAdoNet, int seperate, Action<int, int> progress)
		{
			bool sepGo = seperate == 1;
			bool sepSemi = seperate == 2;

			EnableMassiveForm(false);
			try
			{
				if (_massiveRunStopRequest) return;

				var sqlContent = File.ReadAllText(sqlFile);
				string[] commands;
				if (sepGo)
				{
					commands = sqlContent.Split(new string[] { "GO" }, StringSplitOptions.RemoveEmptyEntries);
					sqlContent = null;
				}
				else if (sepSemi)
				{
					commands = sqlContent.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
					sqlContent = null;
				}
				else
				{
					commands = new[] { sqlContent };
					sqlContent = null;
				}

				var progressMax = commands.Length;
				if (progress != null)
					progress(0, progressMax);

				if (useAdoNet)
				{
					using (var conn = new SqlConnection(connString))
					using (var cmd = conn.CreateCommand())
					{
						conn.Open();

						for (int i = 0; i < commands.Length; i++)
						{
							if (_massiveRunStopRequest) return;

							var sqlcmd = commands[i];
							cmd.CommandText = sqlcmd;

							cmd.ExecuteNonQuery();

							if (progress != null)
								progress(i + 1, progressMax);

							if (_massiveRunStopRequest) return;
						}
					}
					if (progress != null)
						progress(progressMax, progressMax);
				}
				else
				{
					throw new NotImplementedException("SQLCMD is not implemented yet!");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString(), "Massive Run Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				EnableMassiveForm(true);
				if (progress != null)
					progress(0, 0);
			}
		}




	}
}

namespace SqlServerConnectionTools
{
	partial class frmMain
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnRefreshDbList = new System.Windows.Forms.Button();
			this.txtSqlPwd = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.txtSqlUser = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.rbtnSQLAuthentication = new System.Windows.Forms.RadioButton();
			this.rbtnSqlWindowsAuthentication = new System.Windows.Forms.RadioButton();
			this.cmbDatabaseName = new System.Windows.Forms.ComboBox();
			this.cmbDataSource = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btnSelectMdf = new System.Windows.Forms.Button();
			this.txtUserInstanceMdfile = new System.Windows.Forms.TextBox();
			this.chkUserInstance = new System.Windows.Forms.CheckBox();
			this.label4 = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.btnTestConn = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.txtConnString = new System.Windows.Forms.TextBox();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.btnAttach = new System.Windows.Forms.Button();
			this.btnDetachDb = new System.Windows.Forms.Button();
			this.btnAccLDF = new System.Windows.Forms.Button();
			this.btnAccMDF = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.txtAttachMDF = new System.Windows.Forms.TextBox();
			this.txtAttachDbName = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txtAttachLDF = new System.Windows.Forms.TextBox();
			this.tabMain = new System.Windows.Forms.TabControl();
			this.tabBuilder = new System.Windows.Forms.TabPage();
			this.tabQuery = new System.Windows.Forms.TabPage();
			this.txtQueryConn = new System.Windows.Forms.ComboBox();
			this.chkQuerySplitGo = new System.Windows.Forms.CheckBox();
			this.lblResult = new System.Windows.Forms.Label();
			this.grdQueryResult = new System.Windows.Forms.DataGridView();
			this.btnQueryExecute = new System.Windows.Forms.Button();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.txtQueryCmd = new System.Windows.Forms.TextBox();
			this.tabMassiveQuery = new System.Windows.Forms.TabPage();
			this.groupBox7 = new System.Windows.Forms.GroupBox();
			this.lblMassivSqlCount = new System.Windows.Forms.Label();
			this.btnMassiveSqlStop = new System.Windows.Forms.Button();
			this.btnMassiveSqlRun = new System.Windows.Forms.Button();
			this.barMassiveSql = new System.Windows.Forms.ProgressBar();
			this.gpbMassiveConnection = new System.Windows.Forms.GroupBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.rbtnSepDont = new System.Windows.Forms.RadioButton();
			this.rbtnSepGo = new System.Windows.Forms.RadioButton();
			this.rbtnSepSemiColon = new System.Windows.Forms.RadioButton();
			this.panel1 = new System.Windows.Forms.Panel();
			this.rbtnSqlUseAdo = new System.Windows.Forms.RadioButton();
			this.rbtnSqlUseCmd = new System.Windows.Forms.RadioButton();
			this.txtMassiveSqlConnection = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.gpbMassiveSqlFile = new System.Windows.Forms.GroupBox();
			this.btnSelectSql = new System.Windows.Forms.Button();
			this.label13 = new System.Windows.Forms.Label();
			this.txtMassiveSqlFile = new System.Windows.Forms.TextBox();
			this.lnkBlog = new System.Windows.Forms.LinkLabel();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.tabMain.SuspendLayout();
			this.tabBuilder.SuspendLayout();
			this.tabQuery.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdQueryResult)).BeginInit();
			this.tabMassiveQuery.SuspendLayout();
			this.groupBox7.SuspendLayout();
			this.gpbMassiveConnection.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel1.SuspendLayout();
			this.gpbMassiveSqlFile.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.btnRefreshDbList);
			this.groupBox1.Controls.Add(this.txtSqlPwd);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.txtSqlUser);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.rbtnSQLAuthentication);
			this.groupBox1.Controls.Add(this.rbtnSqlWindowsAuthentication);
			this.groupBox1.Controls.Add(this.cmbDatabaseName);
			this.groupBox1.Controls.Add(this.cmbDataSource);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(8, 6);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(624, 160);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Server";
			// 
			// btnRefreshDbList
			// 
			this.btnRefreshDbList.Location = new System.Drawing.Point(316, 128);
			this.btnRefreshDbList.Name = "btnRefreshDbList";
			this.btnRefreshDbList.Size = new System.Drawing.Size(75, 21);
			this.btnRefreshDbList.TabIndex = 6;
			this.btnRefreshDbList.Text = "Refresh";
			this.btnRefreshDbList.UseVisualStyleBackColor = true;
			this.btnRefreshDbList.Click += new System.EventHandler(this.btnRefreshDbList_Click);
			// 
			// txtSqlPwd
			// 
			this.txtSqlPwd.Enabled = false;
			this.txtSqlPwd.Location = new System.Drawing.Point(110, 101);
			this.txtSqlPwd.Name = "txtSqlPwd";
			this.txtSqlPwd.Size = new System.Drawing.Size(200, 21);
			this.txtSqlPwd.TabIndex = 4;
			this.txtSqlPwd.TextChanged += new System.EventHandler(this.txtSqlPwd_TextChanged);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.label9.Location = new System.Drawing.Point(5, 131);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(99, 13);
			this.label9.TabIndex = 3;
			this.label9.Text = "Database name:";
			// 
			// txtSqlUser
			// 
			this.txtSqlUser.Enabled = false;
			this.txtSqlUser.Location = new System.Drawing.Point(110, 74);
			this.txtSqlUser.Name = "txtSqlUser";
			this.txtSqlUser.Size = new System.Drawing.Size(200, 21);
			this.txtSqlUser.TabIndex = 3;
			this.txtSqlUser.Text = "sa";
			this.txtSqlUser.TextChanged += new System.EventHandler(this.txtSqlUser_TextChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(47, 104);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(57, 13);
			this.label3.TabIndex = 3;
			this.label3.Text = "Password:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(45, 77);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(59, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Username:";
			// 
			// rbtnSQLAuthentication
			// 
			this.rbtnSQLAuthentication.Location = new System.Drawing.Point(110, 51);
			this.rbtnSQLAuthentication.Name = "rbtnSQLAuthentication";
			this.rbtnSQLAuthentication.Size = new System.Drawing.Size(200, 17);
			this.rbtnSQLAuthentication.TabIndex = 1;
			this.rbtnSQLAuthentication.Text = "SQL authentication";
			this.rbtnSQLAuthentication.UseVisualStyleBackColor = true;
			this.rbtnSQLAuthentication.CheckedChanged += new System.EventHandler(this.rbtnSQLAuthentication_CheckedChanged);
			// 
			// rbtnSqlWindowsAuthentication
			// 
			this.rbtnSqlWindowsAuthentication.Checked = true;
			this.rbtnSqlWindowsAuthentication.Location = new System.Drawing.Point(316, 51);
			this.rbtnSqlWindowsAuthentication.Name = "rbtnSqlWindowsAuthentication";
			this.rbtnSqlWindowsAuthentication.Size = new System.Drawing.Size(200, 17);
			this.rbtnSqlWindowsAuthentication.TabIndex = 2;
			this.rbtnSqlWindowsAuthentication.TabStop = true;
			this.rbtnSqlWindowsAuthentication.Text = "Windows authentication";
			this.rbtnSqlWindowsAuthentication.UseVisualStyleBackColor = true;
			this.rbtnSqlWindowsAuthentication.CheckedChanged += new System.EventHandler(this.rbtnSqlWindowsAuthentication_CheckedChanged);
			// 
			// cmbDatabaseName
			// 
			this.cmbDatabaseName.FormattingEnabled = true;
			this.cmbDatabaseName.Location = new System.Drawing.Point(110, 128);
			this.cmbDatabaseName.Name = "cmbDatabaseName";
			this.cmbDatabaseName.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cmbDatabaseName.Size = new System.Drawing.Size(200, 21);
			this.cmbDatabaseName.TabIndex = 5;
			this.cmbDatabaseName.TextChanged += new System.EventHandler(this.cmbDatabaseName_TextChanged);
			// 
			// cmbDataSource
			// 
			this.cmbDataSource.FormattingEnabled = true;
			this.cmbDataSource.Location = new System.Drawing.Point(110, 24);
			this.cmbDataSource.Name = "cmbDataSource";
			this.cmbDataSource.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cmbDataSource.Size = new System.Drawing.Size(200, 21);
			this.cmbDataSource.TabIndex = 0;
			this.cmbDataSource.SelectedIndexChanged += new System.EventHandler(this.cmbDataSource_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.label1.Location = new System.Drawing.Point(4, 27);
			this.label1.Name = "label1";
			this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label1.Size = new System.Drawing.Size(100, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "SQL DataSource:";
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox2.Controls.Add(this.btnSelectMdf);
			this.groupBox2.Controls.Add(this.txtUserInstanceMdfile);
			this.groupBox2.Controls.Add(this.chkUserInstance);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Location = new System.Drawing.Point(8, 172);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(624, 75);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "User Instance";
			// 
			// btnSelectMdf
			// 
			this.btnSelectMdf.Enabled = false;
			this.btnSelectMdf.Location = new System.Drawing.Point(316, 42);
			this.btnSelectMdf.Name = "btnSelectMdf";
			this.btnSelectMdf.Size = new System.Drawing.Size(75, 23);
			this.btnSelectMdf.TabIndex = 2;
			this.btnSelectMdf.Text = "Select MDF";
			this.btnSelectMdf.UseVisualStyleBackColor = true;
			this.btnSelectMdf.Click += new System.EventHandler(this.btnSelectMdf_Click);
			// 
			// txtUserInstanceMdfile
			// 
			this.txtUserInstanceMdfile.Location = new System.Drawing.Point(110, 44);
			this.txtUserInstanceMdfile.Name = "txtUserInstanceMdfile";
			this.txtUserInstanceMdfile.ReadOnly = true;
			this.txtUserInstanceMdfile.Size = new System.Drawing.Size(200, 21);
			this.txtUserInstanceMdfile.TabIndex = 1;
			this.txtUserInstanceMdfile.TextChanged += new System.EventHandler(this.txtMdfFile_TextChanged);
			// 
			// chkUserInstance
			// 
			this.chkUserInstance.Location = new System.Drawing.Point(110, 21);
			this.chkUserInstance.Name = "chkUserInstance";
			this.chkUserInstance.Size = new System.Drawing.Size(200, 17);
			this.chkUserInstance.TabIndex = 0;
			this.chkUserInstance.Text = "User Instance";
			this.chkUserInstance.UseVisualStyleBackColor = true;
			this.chkUserInstance.CheckedChanged += new System.EventHandler(this.chkUserInstance_CheckedChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 47);
			this.label4.Name = "label4";
			this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label4.Size = new System.Drawing.Size(98, 13);
			this.label4.TabIndex = 0;
			this.label4.Text = "Database MDF file:";
			// 
			// groupBox3
			// 
			this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox3.Controls.Add(this.btnTestConn);
			this.groupBox3.Controls.Add(this.label5);
			this.groupBox3.Controls.Add(this.txtConnString);
			this.groupBox3.Location = new System.Drawing.Point(6, 253);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(626, 69);
			this.groupBox3.TabIndex = 2;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Connection";
			// 
			// btnTestConn
			// 
			this.btnTestConn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnTestConn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.btnTestConn.Location = new System.Drawing.Point(531, 16);
			this.btnTestConn.Name = "btnTestConn";
			this.btnTestConn.Size = new System.Drawing.Size(89, 23);
			this.btnTestConn.TabIndex = 0;
			this.btnTestConn.Text = "Test";
			this.btnTestConn.UseVisualStyleBackColor = true;
			this.btnTestConn.Click += new System.EventHandler(this.btnTestConn_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.label5.Location = new System.Drawing.Point(9, 21);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(109, 13);
			this.label5.TabIndex = 5;
			this.label5.Text = "Connection string:";
			// 
			// txtConnString
			// 
			this.txtConnString.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtConnString.BackColor = System.Drawing.SystemColors.Info;
			this.txtConnString.Location = new System.Drawing.Point(9, 42);
			this.txtConnString.Name = "txtConnString";
			this.txtConnString.Size = new System.Drawing.Size(611, 21);
			this.txtConnString.TabIndex = 1;
			this.txtConnString.TextChanged += new System.EventHandler(this.txtConnString_TextChanged);
			// 
			// groupBox4
			// 
			this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox4.Controls.Add(this.btnAttach);
			this.groupBox4.Controls.Add(this.btnDetachDb);
			this.groupBox4.Controls.Add(this.btnAccLDF);
			this.groupBox4.Controls.Add(this.btnAccMDF);
			this.groupBox4.Controls.Add(this.label6);
			this.groupBox4.Controls.Add(this.label7);
			this.groupBox4.Controls.Add(this.txtAttachMDF);
			this.groupBox4.Controls.Add(this.txtAttachDbName);
			this.groupBox4.Controls.Add(this.label8);
			this.groupBox4.Controls.Add(this.txtAttachLDF);
			this.groupBox4.Location = new System.Drawing.Point(6, 328);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(626, 107);
			this.groupBox4.TabIndex = 3;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Attach/Detach";
			// 
			// btnAttach
			// 
			this.btnAttach.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAttach.Location = new System.Drawing.Point(543, 76);
			this.btnAttach.Name = "btnAttach";
			this.btnAttach.Size = new System.Drawing.Size(75, 23);
			this.btnAttach.TabIndex = 4;
			this.btnAttach.Text = "Attach";
			this.btnAttach.UseVisualStyleBackColor = true;
			this.btnAttach.Click += new System.EventHandler(this.btnAttach_Click);
			// 
			// btnDetachDb
			// 
			this.btnDetachDb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnDetachDb.Location = new System.Drawing.Point(462, 76);
			this.btnDetachDb.Name = "btnDetachDb";
			this.btnDetachDb.Size = new System.Drawing.Size(75, 23);
			this.btnDetachDb.TabIndex = 3;
			this.btnDetachDb.Text = "Detach";
			this.btnDetachDb.UseVisualStyleBackColor = true;
			this.btnDetachDb.Click += new System.EventHandler(this.btnDetachDb_Click);
			// 
			// btnAccLDF
			// 
			this.btnAccLDF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAccLDF.Location = new System.Drawing.Point(590, 49);
			this.btnAccLDF.Name = "btnAccLDF";
			this.btnAccLDF.Size = new System.Drawing.Size(28, 21);
			this.btnAccLDF.TabIndex = 14;
			this.btnAccLDF.Text = "...";
			this.btnAccLDF.UseVisualStyleBackColor = true;
			this.btnAccLDF.Click += new System.EventHandler(this.btnAccLDF_Click);
			// 
			// btnAccMDF
			// 
			this.btnAccMDF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAccMDF.Location = new System.Drawing.Point(590, 23);
			this.btnAccMDF.Name = "btnAccMDF";
			this.btnAccMDF.Size = new System.Drawing.Size(28, 21);
			this.btnAccMDF.TabIndex = 14;
			this.btnAccMDF.Text = "...";
			this.btnAccMDF.UseVisualStyleBackColor = true;
			this.btnAccMDF.Click += new System.EventHandler(this.btnAccMDF_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(6, 26);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(32, 13);
			this.label6.TabIndex = 9;
			this.label6.Text = "MDF:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(4, 81);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(51, 13);
			this.label7.TabIndex = 13;
			this.label7.Text = "DbName:";
			// 
			// txtAttachMDF
			// 
			this.txtAttachMDF.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtAttachMDF.Location = new System.Drawing.Point(62, 23);
			this.txtAttachMDF.Name = "txtAttachMDF";
			this.txtAttachMDF.Size = new System.Drawing.Size(522, 21);
			this.txtAttachMDF.TabIndex = 0;
			// 
			// txtAttachDbName
			// 
			this.txtAttachDbName.Location = new System.Drawing.Point(62, 76);
			this.txtAttachDbName.Name = "txtAttachDbName";
			this.txtAttachDbName.Size = new System.Drawing.Size(216, 21);
			this.txtAttachDbName.TabIndex = 2;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(6, 53);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(29, 13);
			this.label8.TabIndex = 11;
			this.label8.Text = "LDF:";
			// 
			// txtAttachLDF
			// 
			this.txtAttachLDF.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtAttachLDF.Location = new System.Drawing.Point(62, 50);
			this.txtAttachLDF.Name = "txtAttachLDF";
			this.txtAttachLDF.Size = new System.Drawing.Size(522, 21);
			this.txtAttachLDF.TabIndex = 1;
			// 
			// tabMain
			// 
			this.tabMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabMain.Controls.Add(this.tabBuilder);
			this.tabMain.Controls.Add(this.tabQuery);
			this.tabMain.Controls.Add(this.tabMassiveQuery);
			this.tabMain.Location = new System.Drawing.Point(12, 7);
			this.tabMain.Name = "tabMain";
			this.tabMain.SelectedIndex = 0;
			this.tabMain.Size = new System.Drawing.Size(646, 466);
			this.tabMain.TabIndex = 0;
			// 
			// tabBuilder
			// 
			this.tabBuilder.Controls.Add(this.groupBox4);
			this.tabBuilder.Controls.Add(this.groupBox1);
			this.tabBuilder.Controls.Add(this.groupBox3);
			this.tabBuilder.Controls.Add(this.groupBox2);
			this.tabBuilder.Location = new System.Drawing.Point(4, 22);
			this.tabBuilder.Name = "tabBuilder";
			this.tabBuilder.Padding = new System.Windows.Forms.Padding(3);
			this.tabBuilder.Size = new System.Drawing.Size(638, 440);
			this.tabBuilder.TabIndex = 0;
			this.tabBuilder.Text = "Connection Builder";
			this.tabBuilder.UseVisualStyleBackColor = true;
			// 
			// tabQuery
			// 
			this.tabQuery.Controls.Add(this.txtQueryConn);
			this.tabQuery.Controls.Add(this.chkQuerySplitGo);
			this.tabQuery.Controls.Add(this.lblResult);
			this.tabQuery.Controls.Add(this.grdQueryResult);
			this.tabQuery.Controls.Add(this.btnQueryExecute);
			this.tabQuery.Controls.Add(this.label10);
			this.tabQuery.Controls.Add(this.label11);
			this.tabQuery.Controls.Add(this.txtQueryCmd);
			this.tabQuery.Location = new System.Drawing.Point(4, 22);
			this.tabQuery.Name = "tabQuery";
			this.tabQuery.Padding = new System.Windows.Forms.Padding(3);
			this.tabQuery.Size = new System.Drawing.Size(638, 440);
			this.tabQuery.TabIndex = 1;
			this.tabQuery.Text = "Query Database";
			this.tabQuery.UseVisualStyleBackColor = true;
			// 
			// txtQueryConn
			// 
			this.txtQueryConn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtQueryConn.FormattingEnabled = true;
			this.txtQueryConn.Location = new System.Drawing.Point(9, 19);
			this.txtQueryConn.Name = "txtQueryConn";
			this.txtQueryConn.Size = new System.Drawing.Size(623, 21);
			this.txtQueryConn.TabIndex = 0;
			this.txtQueryConn.Text = "Data Source=(local)\\sql2008; Initial Catalog=Master; Persist Security Info=True; " +
    "User ID=SA; Password=PASSWORD; Connect Timeout=10;";
			this.txtQueryConn.TextChanged += new System.EventHandler(this.txtQueryConn_TextChanged);
			// 
			// chkQuerySplitGo
			// 
			this.chkQuerySplitGo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.chkQuerySplitGo.AutoSize = true;
			this.chkQuerySplitGo.Location = new System.Drawing.Point(511, 46);
			this.chkQuerySplitGo.Name = "chkQuerySplitGo";
			this.chkQuerySplitGo.Size = new System.Drawing.Size(121, 17);
			this.chkQuerySplitGo.TabIndex = 1;
			this.chkQuerySplitGo.Text = "Split queries by \'GO\'";
			this.chkQuerySplitGo.UseVisualStyleBackColor = true;
			this.chkQuerySplitGo.Visible = false;
			// 
			// lblResult
			// 
			this.lblResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblResult.Location = new System.Drawing.Point(100, 174);
			this.lblResult.Name = "lblResult";
			this.lblResult.Size = new System.Drawing.Size(532, 33);
			this.lblResult.TabIndex = 22;
			this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// grdQueryResult
			// 
			this.grdQueryResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.grdQueryResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.grdQueryResult.BackgroundColor = System.Drawing.SystemColors.Window;
			this.grdQueryResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.grdQueryResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdQueryResult.Location = new System.Drawing.Point(9, 214);
			this.grdQueryResult.Name = "grdQueryResult";
			this.grdQueryResult.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			this.grdQueryResult.Size = new System.Drawing.Size(623, 220);
			this.grdQueryResult.TabIndex = 4;
			// 
			// btnQueryExecute
			// 
			this.btnQueryExecute.Location = new System.Drawing.Point(9, 174);
			this.btnQueryExecute.Name = "btnQueryExecute";
			this.btnQueryExecute.Size = new System.Drawing.Size(85, 33);
			this.btnQueryExecute.TabIndex = 3;
			this.btnQueryExecute.Text = "Run Query";
			this.btnQueryExecute.UseVisualStyleBackColor = true;
			this.btnQueryExecute.Click += new System.EventHandler(this.btnQueryExecute_Click);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(6, 51);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(41, 13);
			this.label10.TabIndex = 18;
			this.label10.Text = "Query:";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(6, 3);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(96, 13);
			this.label11.TabIndex = 19;
			this.label11.Text = "Conenction String:";
			// 
			// txtQueryCmd
			// 
			this.txtQueryCmd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtQueryCmd.Location = new System.Drawing.Point(9, 67);
			this.txtQueryCmd.MaxLength = 2147483647;
			this.txtQueryCmd.Multiline = true;
			this.txtQueryCmd.Name = "txtQueryCmd";
			this.txtQueryCmd.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtQueryCmd.Size = new System.Drawing.Size(623, 101);
			this.txtQueryCmd.TabIndex = 2;
			this.txtQueryCmd.Text = "SELECT @@Version";
			// 
			// tabMassiveQuery
			// 
			this.tabMassiveQuery.Controls.Add(this.groupBox7);
			this.tabMassiveQuery.Controls.Add(this.gpbMassiveConnection);
			this.tabMassiveQuery.Controls.Add(this.gpbMassiveSqlFile);
			this.tabMassiveQuery.Location = new System.Drawing.Point(4, 22);
			this.tabMassiveQuery.Name = "tabMassiveQuery";
			this.tabMassiveQuery.Padding = new System.Windows.Forms.Padding(3);
			this.tabMassiveQuery.Size = new System.Drawing.Size(638, 440);
			this.tabMassiveQuery.TabIndex = 2;
			this.tabMassiveQuery.Text = "Run Massive Query";
			this.tabMassiveQuery.UseVisualStyleBackColor = true;
			// 
			// groupBox7
			// 
			this.groupBox7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox7.Controls.Add(this.lblMassivSqlCount);
			this.groupBox7.Controls.Add(this.btnMassiveSqlStop);
			this.groupBox7.Controls.Add(this.btnMassiveSqlRun);
			this.groupBox7.Controls.Add(this.barMassiveSql);
			this.groupBox7.Location = new System.Drawing.Point(6, 179);
			this.groupBox7.Name = "groupBox7";
			this.groupBox7.Size = new System.Drawing.Size(626, 79);
			this.groupBox7.TabIndex = 23;
			this.groupBox7.TabStop = false;
			this.groupBox7.Text = "The Task";
			// 
			// lblMassivSqlCount
			// 
			this.lblMassivSqlCount.AutoSize = true;
			this.lblMassivSqlCount.Location = new System.Drawing.Point(9, 30);
			this.lblMassivSqlCount.Name = "lblMassivSqlCount";
			this.lblMassivSqlCount.Size = new System.Drawing.Size(76, 13);
			this.lblMassivSqlCount.TabIndex = 2;
			this.lblMassivSqlCount.Text = "                       ";
			// 
			// btnMassiveSqlStop
			// 
			this.btnMassiveSqlStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnMassiveSqlStop.Enabled = false;
			this.btnMassiveSqlStop.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.btnMassiveSqlStop.ForeColor = System.Drawing.Color.Maroon;
			this.btnMassiveSqlStop.Location = new System.Drawing.Point(531, 20);
			this.btnMassiveSqlStop.Name = "btnMassiveSqlStop";
			this.btnMassiveSqlStop.Size = new System.Drawing.Size(89, 23);
			this.btnMassiveSqlStop.TabIndex = 1;
			this.btnMassiveSqlStop.Text = "Stop";
			this.btnMassiveSqlStop.UseVisualStyleBackColor = true;
			this.btnMassiveSqlStop.Click += new System.EventHandler(this.btnMassiveSqlStop_Click);
			// 
			// btnMassiveSqlRun
			// 
			this.btnMassiveSqlRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnMassiveSqlRun.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.btnMassiveSqlRun.Location = new System.Drawing.Point(436, 20);
			this.btnMassiveSqlRun.Name = "btnMassiveSqlRun";
			this.btnMassiveSqlRun.Size = new System.Drawing.Size(89, 23);
			this.btnMassiveSqlRun.TabIndex = 1;
			this.btnMassiveSqlRun.Text = "Execute";
			this.btnMassiveSqlRun.UseVisualStyleBackColor = true;
			this.btnMassiveSqlRun.Click += new System.EventHandler(this.btnMassiveSqlRun_Click);
			// 
			// barMassiveSql
			// 
			this.barMassiveSql.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.barMassiveSql.Location = new System.Drawing.Point(12, 49);
			this.barMassiveSql.Name = "barMassiveSql";
			this.barMassiveSql.Size = new System.Drawing.Size(608, 23);
			this.barMassiveSql.TabIndex = 0;
			// 
			// gpbMassiveConnection
			// 
			this.gpbMassiveConnection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gpbMassiveConnection.Controls.Add(this.panel2);
			this.gpbMassiveConnection.Controls.Add(this.panel1);
			this.gpbMassiveConnection.Controls.Add(this.txtMassiveSqlConnection);
			this.gpbMassiveConnection.Controls.Add(this.label12);
			this.gpbMassiveConnection.Location = new System.Drawing.Point(6, 81);
			this.gpbMassiveConnection.Name = "gpbMassiveConnection";
			this.gpbMassiveConnection.Size = new System.Drawing.Size(626, 92);
			this.gpbMassiveConnection.TabIndex = 22;
			this.gpbMassiveConnection.TabStop = false;
			this.gpbMassiveConnection.Text = "Massive Connection";
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.panel2.Controls.Add(this.rbtnSepDont);
			this.panel2.Controls.Add(this.rbtnSepGo);
			this.panel2.Controls.Add(this.rbtnSepSemiColon);
			this.panel2.Location = new System.Drawing.Point(293, 60);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(333, 26);
			this.panel2.TabIndex = 24;
			// 
			// rbtnSepDont
			// 
			this.rbtnSepDont.AutoSize = true;
			this.rbtnSepDont.Location = new System.Drawing.Point(230, 4);
			this.rbtnSepDont.Name = "rbtnSepDont";
			this.rbtnSepDont.Size = new System.Drawing.Size(97, 17);
			this.rbtnSepDont.TabIndex = 7;
			this.rbtnSepDont.Text = "Don\'t Seperate";
			this.rbtnSepDont.UseVisualStyleBackColor = true;
			// 
			// rbtnSepGo
			// 
			this.rbtnSepGo.AutoSize = true;
			this.rbtnSepGo.Checked = true;
			this.rbtnSepGo.Location = new System.Drawing.Point(17, 4);
			this.rbtnSepGo.Name = "rbtnSepGo";
			this.rbtnSepGo.Size = new System.Drawing.Size(102, 17);
			this.rbtnSepGo.TabIndex = 7;
			this.rbtnSepGo.TabStop = true;
			this.rbtnSepGo.Text = "Seperate by GO";
			this.rbtnSepGo.UseVisualStyleBackColor = true;
			// 
			// rbtnSepSemiColon
			// 
			this.rbtnSepSemiColon.AutoSize = true;
			this.rbtnSepSemiColon.Location = new System.Drawing.Point(125, 4);
			this.rbtnSepSemiColon.Name = "rbtnSepSemiColon";
			this.rbtnSepSemiColon.Size = new System.Drawing.Size(99, 17);
			this.rbtnSepSemiColon.TabIndex = 7;
			this.rbtnSepSemiColon.Text = "Seperate by (;)";
			this.rbtnSepSemiColon.UseVisualStyleBackColor = true;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.rbtnSqlUseAdo);
			this.panel1.Controls.Add(this.rbtnSqlUseCmd);
			this.panel1.Location = new System.Drawing.Point(0, 60);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(211, 26);
			this.panel1.TabIndex = 24;
			// 
			// rbtnSqlUseAdo
			// 
			this.rbtnSqlUseAdo.AutoSize = true;
			this.rbtnSqlUseAdo.Checked = true;
			this.rbtnSqlUseAdo.Location = new System.Drawing.Point(9, 3);
			this.rbtnSqlUseAdo.Name = "rbtnSqlUseAdo";
			this.rbtnSqlUseAdo.Size = new System.Drawing.Size(91, 17);
			this.rbtnSqlUseAdo.TabIndex = 7;
			this.rbtnSqlUseAdo.TabStop = true;
			this.rbtnSqlUseAdo.Text = "Use ADO.NET";
			this.rbtnSqlUseAdo.UseVisualStyleBackColor = true;
			// 
			// rbtnSqlUseCmd
			// 
			this.rbtnSqlUseCmd.AutoSize = true;
			this.rbtnSqlUseCmd.Enabled = false;
			this.rbtnSqlUseCmd.Location = new System.Drawing.Point(106, 3);
			this.rbtnSqlUseCmd.Name = "rbtnSqlUseCmd";
			this.rbtnSqlUseCmd.Size = new System.Drawing.Size(81, 17);
			this.rbtnSqlUseCmd.TabIndex = 7;
			this.rbtnSqlUseCmd.Text = "Use SqlCmd";
			this.rbtnSqlUseCmd.UseVisualStyleBackColor = true;
			// 
			// txtMassiveSqlConnection
			// 
			this.txtMassiveSqlConnection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtMassiveSqlConnection.BackColor = System.Drawing.SystemColors.Info;
			this.txtMassiveSqlConnection.Location = new System.Drawing.Point(9, 37);
			this.txtMassiveSqlConnection.Name = "txtMassiveSqlConnection";
			this.txtMassiveSqlConnection.Size = new System.Drawing.Size(611, 21);
			this.txtMassiveSqlConnection.TabIndex = 6;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.label12.Location = new System.Drawing.Point(9, 21);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(110, 13);
			this.label12.TabIndex = 5;
			this.label12.Text = "Connection String:";
			// 
			// gpbMassiveSqlFile
			// 
			this.gpbMassiveSqlFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gpbMassiveSqlFile.Controls.Add(this.btnSelectSql);
			this.gpbMassiveSqlFile.Controls.Add(this.label13);
			this.gpbMassiveSqlFile.Controls.Add(this.txtMassiveSqlFile);
			this.gpbMassiveSqlFile.Location = new System.Drawing.Point(6, 6);
			this.gpbMassiveSqlFile.Name = "gpbMassiveSqlFile";
			this.gpbMassiveSqlFile.Size = new System.Drawing.Size(626, 69);
			this.gpbMassiveSqlFile.TabIndex = 21;
			this.gpbMassiveSqlFile.TabStop = false;
			this.gpbMassiveSqlFile.Text = "Source Sql File";
			// 
			// btnSelectSql
			// 
			this.btnSelectSql.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSelectSql.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.btnSelectSql.Location = new System.Drawing.Point(531, 40);
			this.btnSelectSql.Name = "btnSelectSql";
			this.btnSelectSql.Size = new System.Drawing.Size(89, 23);
			this.btnSelectSql.TabIndex = 0;
			this.btnSelectSql.Text = "&Select";
			this.btnSelectSql.UseVisualStyleBackColor = true;
			this.btnSelectSql.Click += new System.EventHandler(this.btnSelectSql_Click);
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.label13.Location = new System.Drawing.Point(9, 21);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(84, 13);
			this.label13.TabIndex = 5;
			this.label13.Text = "Sql File Name:";
			// 
			// txtMassiveSqlFile
			// 
			this.txtMassiveSqlFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtMassiveSqlFile.Location = new System.Drawing.Point(9, 42);
			this.txtMassiveSqlFile.Name = "txtMassiveSqlFile";
			this.txtMassiveSqlFile.Size = new System.Drawing.Size(516, 21);
			this.txtMassiveSqlFile.TabIndex = 1;
			// 
			// lnkBlog
			// 
			this.lnkBlog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lnkBlog.AutoSize = true;
			this.lnkBlog.Location = new System.Drawing.Point(554, 7);
			this.lnkBlog.Name = "lnkBlog";
			this.lnkBlog.Size = new System.Drawing.Size(104, 13);
			this.lnkBlog.TabIndex = 16;
			this.lnkBlog.TabStop = true;
			this.lnkBlog.Text = "www.salarcode.com";
			this.lnkBlog.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkBlog_LinkClicked);
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(670, 485);
			this.Controls.Add(this.lnkBlog);
			this.Controls.Add(this.tabMain);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmMain";
			this.Text = "SQL Server Connection Tools";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
			this.Load += new System.EventHandler(this.frmMain_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.tabMain.ResumeLayout(false);
			this.tabBuilder.ResumeLayout(false);
			this.tabQuery.ResumeLayout(false);
			this.tabQuery.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdQueryResult)).EndInit();
			this.tabMassiveQuery.ResumeLayout(false);
			this.groupBox7.ResumeLayout(false);
			this.groupBox7.PerformLayout();
			this.gpbMassiveConnection.ResumeLayout(false);
			this.gpbMassiveConnection.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.gpbMassiveSqlFile.ResumeLayout(false);
			this.gpbMassiveSqlFile.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ComboBox cmbDataSource;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtSqlPwd;
		private System.Windows.Forms.TextBox txtSqlUser;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.RadioButton rbtnSQLAuthentication;
		private System.Windows.Forms.RadioButton rbtnSqlWindowsAuthentication;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.CheckBox chkUserInstance;
		private System.Windows.Forms.Button btnSelectMdf;
		private System.Windows.Forms.TextBox txtUserInstanceMdfile;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtConnString;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtAttachMDF;
		private System.Windows.Forms.TextBox txtAttachDbName;
		private System.Windows.Forms.Button btnAttach;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button btnDetachDb;
		private System.Windows.Forms.TextBox txtAttachLDF;
		private System.Windows.Forms.Button btnAccLDF;
		private System.Windows.Forms.Button btnAccMDF;
		private System.Windows.Forms.Button btnTestConn;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.ComboBox cmbDatabaseName;
		private System.Windows.Forms.Button btnRefreshDbList;
		private System.Windows.Forms.TabControl tabMain;
		private System.Windows.Forms.TabPage tabBuilder;
		private System.Windows.Forms.TabPage tabQuery;
		private System.Windows.Forms.Label lblResult;
		private System.Windows.Forms.DataGridView grdQueryResult;
		private System.Windows.Forms.Button btnQueryExecute;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtQueryCmd;
		private System.Windows.Forms.CheckBox chkQuerySplitGo;
		private System.Windows.Forms.LinkLabel lnkBlog;
        private System.Windows.Forms.ComboBox txtQueryConn;
		private System.Windows.Forms.TabPage tabMassiveQuery;
		private System.Windows.Forms.GroupBox gpbMassiveConnection;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.GroupBox gpbMassiveSqlFile;
		private System.Windows.Forms.Button btnSelectSql;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox txtMassiveSqlFile;
		private System.Windows.Forms.TextBox txtMassiveSqlConnection;
		private System.Windows.Forms.RadioButton rbtnSepDont;
		private System.Windows.Forms.RadioButton rbtnSepSemiColon;
		private System.Windows.Forms.RadioButton rbtnSepGo;
		private System.Windows.Forms.RadioButton rbtnSqlUseCmd;
		private System.Windows.Forms.RadioButton rbtnSqlUseAdo;
		private System.Windows.Forms.GroupBox groupBox7;
		private System.Windows.Forms.Button btnMassiveSqlRun;
		private System.Windows.Forms.ProgressBar barMassiveSql;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button btnMassiveSqlStop;
		private System.Windows.Forms.Label lblMassivSqlCount;
	}
}


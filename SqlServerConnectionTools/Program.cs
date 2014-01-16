using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace SqlServerConnectionTools
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
#if DEBUG
			Application.ThreadException += Application_ThreadException;
#endif
			Application.Run(new frmMain());
		}

		static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
		{
			try
			{
				File.WriteAllText("exceptions.log", e.Exception.ToString());
			}
			catch (Exception ex)
			{
			}
		}
	}
}

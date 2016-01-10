using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebSiteAdministrationToolStarter
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			string physicsPath = string.Empty;
			string applicationUrl = string.Empty;
			if (args.Length > 0)
				physicsPath = args[0];
			if (args.Length > 1)
				applicationUrl = args[1];
			Application.Run(new MainForm() { PhysicsPath = physicsPath, ApplicationUrl = applicationUrl });
		}
	}
}

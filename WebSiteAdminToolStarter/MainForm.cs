using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Management;


namespace WebSiteAdministrationToolStarter
{
	public partial class MainForm : Form
	{
		DropRightsProcess drp = new DropRightsProcess();

		public MainForm()
		{
			InitializeComponent();
		}

		//Modified 2013-12-21
		private void bStartInstant_Click(object sender, EventArgs e)
		{
			string iisArchitecture = string.Empty;
			string frameworkArchitecture = string.Empty;

			if (cbbPlatform.Text == "32位" && Environment.Is64BitOperatingSystem)
				iisArchitecture = " (x86)";
			if (cbbPlatform.SelectedText == "64位")
			{
				frameworkArchitecture = "64";
			}

			string applicationName = @"C:\Program Files" + iisArchitecture + @"\IIS Express\iisexpress.exe";
			string args = @"/path:C:\Windows\Microsoft.NET\Framework" + frameworkArchitecture + @"\v4.0.30319\ASP.NETWebAdminFiles /vpath:/ASP.NETWebAdminFiles /port:{0} /clr:4.0 /ntlm";

			args = string.Format(args, tbPort.Text.Trim());
			//using (var proc = new Process())
			//{
			//	proc.StartInfo.FileName = applicationName;
			//	proc.StartInfo.Arguments = args;
			//	proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			//	proc.Start();
			//}

			using (ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT commandline FROM Win32_Process where name='iisexpress.exe'"))
			{
				foreach (ManagementObject mo in searcher.Get())
				{
					string property = mo.GetPropertyValue("commandline") as string;
					if (property == null) continue;
					if (property.ToLower().Contains("/port:" + tbPort.Text.Trim()))//进程已存在退出
						return;
				}
			}

			drp.StartProcess(applicationName, args, cbHidden.Checked);//注意，此处降权执行iis express
			//var startInfo = new ProcessStartInfo(applicationName, args);
			//startInfo.WindowStyle = cbHidden.Checked ? ProcessWindowStyle.Hidden : ProcessWindowStyle.Normal;
			//Process.Start(startInfo);
		}

		/// <summary>
		/// 物理地址
		/// </summary>
		public string PhysicsPath { get; set; }

		/// <summary>
		/// 应用程序URL
		/// </summary>
		public string ApplicationUrl { get; set; }

		private void tbPort_MouseHover(object sender, EventArgs e)
		{
			tbPort.SelectAll();
			tbPort.Focus();
		}

		private void bStartIE_Click(object sender, EventArgs e)
		{
			//支持自动启动IIS Express进程逻辑
			bStartInstant.PerformClick();

			if (PhysicsPath == string.Empty)
			{
				var pathForm = new PathForm();
				pathForm.ShowDialog(this);
			}
			var args = @"http://localhost:{0}/asp.netwebadminfiles/default.aspx?applicationPhysicalPath={1}&applicationUrl=/{2}";
			args = string.Format(args, tbPort.Text, Uri.EscapeUriString(PhysicsPath), Uri.EscapeUriString(ApplicationUrl));
			//Process.Start(@"C:\Program Files\Internet Explorer\iexplore.exe", args);
			drp.StartProcess(@"C:\Program Files\Internet Explorer\iexplore.exe", args, false);//注意，此处降权执行ie
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			cbbPlatform.SelectedIndex = 0;
			//如果是32位系统，不允许修改启动iis的类型
			if (!Environment.Is64BitOperatingSystem)
				cbbPlatform.Enabled = false;
		}
	}
}

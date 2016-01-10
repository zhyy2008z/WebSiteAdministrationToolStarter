using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebSiteAdministrationToolStarter
{
	public partial class PathForm : Form
	{
		public PathForm()
		{
			InitializeComponent();
		}

		private void bOK_Click(object sender, EventArgs e)
		{
			var opener = Owner as MainForm;
			opener.PhysicsPath = tbPhysicsPath.Text;
			opener.ApplicationUrl = tbApplicationURL.Text;
			this.Close();
		}

		private void PathForm_Load(object sender, EventArgs e)
		{
			var opener = Owner as MainForm;
			tbPhysicsPath.Text = opener.PhysicsPath;
			tbApplicationURL.Text = opener.ApplicationUrl;
		}
	}
}

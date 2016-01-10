namespace WebSiteAdministrationToolStarter
{
	partial class PathForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.tbPhysicsPath = new System.Windows.Forms.TextBox();
			this.tbApplicationURL = new System.Windows.Forms.TextBox();
			this.bOK = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(34, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(67, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "物理地址：";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(10, 49);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(91, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "应用程序名称：";
			// 
			// tbPhysicsPath
			// 
			this.tbPhysicsPath.Location = new System.Drawing.Point(107, 19);
			this.tbPhysicsPath.Name = "tbPhysicsPath";
			this.tbPhysicsPath.Size = new System.Drawing.Size(460, 20);
			this.tbPhysicsPath.TabIndex = 1;
			// 
			// tbApplicationURL
			// 
			this.tbApplicationURL.Location = new System.Drawing.Point(107, 46);
			this.tbApplicationURL.Name = "tbApplicationURL";
			this.tbApplicationURL.Size = new System.Drawing.Size(168, 20);
			this.tbApplicationURL.TabIndex = 2;
			// 
			// bOK
			// 
			this.bOK.Location = new System.Drawing.Point(492, 54);
			this.bOK.Name = "bOK";
			this.bOK.Size = new System.Drawing.Size(75, 23);
			this.bOK.TabIndex = 3;
			this.bOK.Text = "确定";
			this.bOK.UseVisualStyleBackColor = true;
			this.bOK.Click += new System.EventHandler(this.bOK_Click);
			// 
			// PathForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(579, 89);
			this.Controls.Add(this.bOK);
			this.Controls.Add(this.tbApplicationURL);
			this.Controls.Add(this.tbPhysicsPath);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "PathForm";
			this.Text = "设置";
			this.Load += new System.EventHandler(this.PathForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbPhysicsPath;
		private System.Windows.Forms.TextBox tbApplicationURL;
		private System.Windows.Forms.Button bOK;
	}
}
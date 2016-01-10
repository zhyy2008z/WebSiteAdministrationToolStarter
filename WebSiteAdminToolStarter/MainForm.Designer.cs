namespace WebSiteAdministrationToolStarter
{
	partial class MainForm
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
			this.tbPort = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.bStartInstant = new System.Windows.Forms.Button();
			this.bStartIE = new System.Windows.Forms.Button();
			this.cbbPlatform = new System.Windows.Forms.ComboBox();
			this.cbHidden = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// tbPort
			// 
			this.tbPort.Location = new System.Drawing.Point(46, 20);
			this.tbPort.Name = "tbPort";
			this.tbPort.Size = new System.Drawing.Size(46, 20);
			this.tbPort.TabIndex = 0;
			this.tbPort.Text = "8082";
			this.tbPort.MouseHover += new System.EventHandler(this.tbPort_MouseHover);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(9, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(31, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "端口";
			// 
			// bStartInstant
			// 
			this.bStartInstant.Location = new System.Drawing.Point(240, 19);
			this.bStartInstant.Name = "bStartInstant";
			this.bStartInstant.Size = new System.Drawing.Size(75, 23);
			this.bStartInstant.TabIndex = 2;
			this.bStartInstant.Text = "启动实例";
			this.bStartInstant.UseVisualStyleBackColor = true;
			this.bStartInstant.Click += new System.EventHandler(this.bStartInstant_Click);
			// 
			// bStartIE
			// 
			this.bStartIE.Location = new System.Drawing.Point(321, 19);
			this.bStartIE.Name = "bStartIE";
			this.bStartIE.Size = new System.Drawing.Size(75, 23);
			this.bStartIE.TabIndex = 3;
			this.bStartIE.Text = "启动IE";
			this.bStartIE.UseVisualStyleBackColor = true;
			this.bStartIE.Click += new System.EventHandler(this.bStartIE_Click);
			// 
			// cbbPlatform
			// 
			this.cbbPlatform.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbbPlatform.FormattingEnabled = true;
			this.cbbPlatform.Items.AddRange(new object[] {
            "32位",
            "64位"});
			this.cbbPlatform.Location = new System.Drawing.Point(98, 20);
			this.cbbPlatform.Name = "cbbPlatform";
			this.cbbPlatform.Size = new System.Drawing.Size(56, 21);
			this.cbbPlatform.TabIndex = 4;
			// 
			// cbHidden
			// 
			this.cbHidden.AutoSize = true;
			this.cbHidden.Checked = true;
			this.cbHidden.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbHidden.Location = new System.Drawing.Point(160, 22);
			this.cbHidden.Name = "cbHidden";
			this.cbHidden.Size = new System.Drawing.Size(74, 17);
			this.cbHidden.TabIndex = 5;
			this.cbHidden.Text = "隐藏窗口";
			this.cbHidden.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(408, 60);
			this.Controls.Add(this.cbHidden);
			this.Controls.Add(this.cbbPlatform);
			this.Controls.Add(this.bStartIE);
			this.Controls.Add(this.bStartInstant);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tbPort);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "WebSiteAdminToolStarter";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox tbPort;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button bStartInstant;
		private System.Windows.Forms.Button bStartIE;
		private System.Windows.Forms.ComboBox cbbPlatform;
		private System.Windows.Forms.CheckBox cbHidden;
	}
}


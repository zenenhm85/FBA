namespace ProyectodeTesis
{
    partial class Principal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sbmlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.export = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fBAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optimize = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openfile = new System.Windows.Forms.OpenFileDialog();
            this.save1 = new System.Windows.Forms.SaveFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.optimizer2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.save2toolStrip = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.openfile2 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuStrip1.BackgroundImage")));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.fBAToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(594, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.toolStripMenuItem2,
            this.export,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sbmlToolStripMenuItem,
            this.txtToolStripMenuItem});
            this.loadToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("loadToolStripMenuItem.Image")));
            this.loadToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(231, 38);
            this.loadToolStripMenuItem.Text = "Load";
            // 
            // sbmlToolStripMenuItem
            // 
            this.sbmlToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sbmlToolStripMenuItem.Image")));
            this.sbmlToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.sbmlToolStripMenuItem.Name = "sbmlToolStripMenuItem";
            this.sbmlToolStripMenuItem.Size = new System.Drawing.Size(167, 38);
            this.sbmlToolStripMenuItem.Text = "Sbml";
            this.sbmlToolStripMenuItem.Click += new System.EventHandler(this.sbmlToolStripMenuItem_Click);
            // 
            // txtToolStripMenuItem
            // 
            this.txtToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("txtToolStripMenuItem.Image")));
            this.txtToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.txtToolStripMenuItem.Name = "txtToolStripMenuItem";
            this.txtToolStripMenuItem.Size = new System.Drawing.Size(167, 38);
            this.txtToolStripMenuItem.Text = "Txt";
            this.txtToolStripMenuItem.Click += new System.EventHandler(this.txtToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Enabled = false;
            this.toolStripMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem2.Image")));
            this.toolStripMenuItem2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(231, 38);
            this.toolStripMenuItem2.Text = "Save changes to the model";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // export
            // 
            this.export.Enabled = false;
            this.export.Image = ((System.Drawing.Image)(resources.GetObject("export.Image")));
            this.export.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.export.Name = "export";
            this.export.Size = new System.Drawing.Size(231, 38);
            this.export.Text = "Export Results";
            this.export.Click += new System.EventHandler(this.export_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Enabled = false;
            this.toolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem1.Image")));
            this.toolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(231, 38);
            this.toolStripMenuItem1.Text = "Close Model";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(231, 38);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // fBAToolStripMenuItem
            // 
            this.fBAToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optimize});
            this.fBAToolStripMenuItem.Name = "fBAToolStripMenuItem";
            this.fBAToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.fBAToolStripMenuItem.Text = "FBA";
            this.fBAToolStripMenuItem.Click += new System.EventHandler(this.fBAToolStripMenuItem_Click);
            // 
            // optimize
            // 
            this.optimize.Enabled = false;
            this.optimize.Image = ((System.Drawing.Image)(resources.GetObject("optimize.Image")));
            this.optimize.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.optimize.Name = "optimize";
            this.optimize.Size = new System.Drawing.Size(137, 38);
            this.optimize.Text = "Optimize";
            this.optimize.Click += new System.EventHandler(this.optimize_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.myHelpToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // myHelpToolStripMenuItem
            // 
            this.myHelpToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("myHelpToolStripMenuItem.Image")));
            this.myHelpToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.myHelpToolStripMenuItem.Name = "myHelpToolStripMenuItem";
            this.myHelpToolStripMenuItem.Size = new System.Drawing.Size(133, 36);
            this.myHelpToolStripMenuItem.Text = "My Help";
            // 
            // openfile
            // 
            this.openfile.FileName = "openFileDialog1";
            this.openfile.Filter = "\"Xml files (*.xml)|*.xml";
            // 
            // save1
            // 
            this.save1.DefaultExt = "txt";
            this.save1.Filter = "\"Text files (*.txt)|*.txt";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.toolStripButton5,
            this.toolStripSeparator4,
            this.optimizer2,
            this.toolStripSeparator2,
            this.save2toolStrip,
            this.toolStripSeparator3,
            this.toolStripButton2,
            this.toolStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(594, 38);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(35, 35);
            this.toolStripButton1.Text = "Load Sbml";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 38);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(34, 35);
            this.toolStripButton5.Text = "Load Txt";
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 38);
            // 
            // optimizer2
            // 
            this.optimizer2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.optimizer2.Enabled = false;
            this.optimizer2.Image = ((System.Drawing.Image)(resources.GetObject("optimizer2.Image")));
            this.optimizer2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.optimizer2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.optimizer2.Name = "optimizer2";
            this.optimizer2.Size = new System.Drawing.Size(35, 35);
            this.optimizer2.Text = "Optimize";
            this.optimizer2.Click += new System.EventHandler(this.toolStripButton2_Click);
            this.optimizer2.MouseLeave += new System.EventHandler(this.optimizer2_MouseLeave);
            this.optimizer2.MouseHover += new System.EventHandler(this.optimizer2_MouseHover);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 38);
            // 
            // save2toolStrip
            // 
            this.save2toolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.save2toolStrip.Enabled = false;
            this.save2toolStrip.Image = ((System.Drawing.Image)(resources.GetObject("save2toolStrip.Image")));
            this.save2toolStrip.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.save2toolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.save2toolStrip.Name = "save2toolStrip";
            this.save2toolStrip.Size = new System.Drawing.Size(34, 35);
            this.save2toolStrip.Text = "Save changes to the model";
            this.save2toolStrip.Click += new System.EventHandler(this.toolStripButton4_Click_1);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 38);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Enabled = false;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(34, 35);
            this.toolStripButton2.Text = "Close Model";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click_1);
            this.toolStripButton2.MouseLeave += new System.EventHandler(this.toolStripButton2_MouseLeave);
            this.toolStripButton2.MouseHover += new System.EventHandler(this.toolStripButton2_MouseHover);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(34, 35);
            this.toolStripButton3.Text = "Help";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.progressBar1.ForeColor = System.Drawing.Color.Blue;
            this.progressBar1.Location = new System.Drawing.Point(161, 590);
            this.progressBar1.Maximum = 1000;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(249, 10);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 8;
            this.progressBar1.Visible = false;
            // 
            // openfile2
            // 
            this.openfile2.Filter = "\"Text files (*.txt)|*.txt";
            // 
            // saveFileDialog2
            // 
            this.saveFileDialog2.Filter = "\"Text files (*.xml)|*.xml";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "\"Text files (*.txt)|*.txt";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectodeTesis.Properties.Resources.FBA;
            this.ClientSize = new System.Drawing.Size(594, 602);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HYDRA: Flux Balance Analysis";
            this.Activated += new System.EventHandler(this.Principal_Activated);
            this.Load += new System.EventHandler(this.Principal_Load);
            this.Shown += new System.EventHandler(this.Principal_Shown);
            this.Enter += new System.EventHandler(this.Principal_Enter);
            this.MouseLeave += new System.EventHandler(this.Principal_MouseLeave);
            this.MouseHover += new System.EventHandler(this.Principal_MouseHover);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Principal_MouseMove);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sbmlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem txtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem export;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fBAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optimize;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openfile;
        private System.Windows.Forms.SaveFileDialog save1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton optimizer2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem myHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.OpenFileDialog openfile2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton save2toolStrip;
        private System.Windows.Forms.SaveFileDialog saveFileDialog2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
    }
}
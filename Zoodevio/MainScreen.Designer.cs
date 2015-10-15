namespace Zoodevio
{
    partial class MainScreen
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.basicSearchControl1 = new Zoodevio.BasicSearchControl();
            this.metadataViewControl1 = new Zoodevio.MetadataViewControl();
            this.libraryPanelControl1 = new Zoodevio.LibraryPanelControl();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 462);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(946, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(946, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(312, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(351, 350);
            this.panel1.TabIndex = 5;
            // 
            // basicSearchControl1
            // 
            this.basicSearchControl1.Location = new System.Drawing.Point(312, 387);
            this.basicSearchControl1.Name = "basicSearchControl1";
            this.basicSearchControl1.Size = new System.Drawing.Size(351, 72);
            this.basicSearchControl1.TabIndex = 7;
            // 
            // metadataViewControl1
            // 
            this.metadataViewControl1.Location = new System.Drawing.Point(669, 31);
            this.metadataViewControl1.Name = "metadataViewControl1";
            this.metadataViewControl1.Size = new System.Drawing.Size(268, 428);
            this.metadataViewControl1.TabIndex = 6;
            // 
            // libraryPanelControl1
            // 
            this.libraryPanelControl1.AutoSize = true;
            this.libraryPanelControl1.Location = new System.Drawing.Point(0, 31);
            this.libraryPanelControl1.Name = "libraryPanelControl1";
            this.libraryPanelControl1.Size = new System.Drawing.Size(306, 432);
            this.libraryPanelControl1.TabIndex = 4;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 484);
            this.Controls.Add(this.basicSearchControl1);
            this.Controls.Add(this.metadataViewControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.libraryPanelControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainScreen";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainScreen_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private LibraryPanelControl libraryPanelControl1;
        private System.Windows.Forms.Panel panel1;
        private MetadataViewControl metadataViewControl1;
        private BasicSearchControl basicSearchControl1;
    }
}


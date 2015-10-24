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
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hideMetadataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hideSearchAreaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainSplitterContainer = new System.Windows.Forms.SplitContainer();
            this.libraryPanelControl1 = new Zoodevio.LibraryPanelControl();
            this.gridViewControl1 = new Zoodevio.GridViewControl();
            this.metadataViewControl1 = new Zoodevio.MetadataViewControl();
            this.basicSearchControl1 = new Zoodevio.BasicSearchControl();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitterContainer)).BeginInit();
            this.mainSplitterContainer.Panel1.SuspendLayout();
            this.mainSplitterContainer.Panel2.SuspendLayout();
            this.mainSplitterContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 462);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(882, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(882, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hideMetadataToolStripMenuItem,
            this.hideSearchAreaToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // hideMetadataToolStripMenuItem
            // 
            this.hideMetadataToolStripMenuItem.Name = "hideMetadataToolStripMenuItem";
            this.hideMetadataToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.hideMetadataToolStripMenuItem.Text = "Hide Metadata";
            this.hideMetadataToolStripMenuItem.Click += new System.EventHandler(this.hideMetadataToolStripMenuItem_Click);
            // 
            // hideSearchAreaToolStripMenuItem
            // 
            this.hideSearchAreaToolStripMenuItem.Name = "hideSearchAreaToolStripMenuItem";
            this.hideSearchAreaToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.hideSearchAreaToolStripMenuItem.Text = "Hide Search Area";
            this.hideSearchAreaToolStripMenuItem.Click += new System.EventHandler(this.hideSearchAreaToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // mainSplitterContainer
            // 
            this.mainSplitterContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainSplitterContainer.Location = new System.Drawing.Point(0, 28);
            this.mainSplitterContainer.Name = "mainSplitterContainer";
            // 
            // mainSplitterContainer.Panel1
            // 
            this.mainSplitterContainer.Panel1.Controls.Add(this.libraryPanelControl1);
            // 
            // mainSplitterContainer.Panel2
            // 
            this.mainSplitterContainer.Panel2.Controls.Add(this.gridViewControl1);
            this.mainSplitterContainer.Panel2.Controls.Add(this.metadataViewControl1);
            this.mainSplitterContainer.Panel2.Controls.Add(this.basicSearchControl1);
            this.mainSplitterContainer.Size = new System.Drawing.Size(882, 434);
            this.mainSplitterContainer.SplitterDistance = 316;
            this.mainSplitterContainer.TabIndex = 2;
            // 
            // libraryPanelControl1
            // 
            this.libraryPanelControl1.AutoSize = true;
            this.libraryPanelControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.libraryPanelControl1.Location = new System.Drawing.Point(3, 28);
            this.libraryPanelControl1.Name = "libraryPanelControl1";
            this.libraryPanelControl1.Size = new System.Drawing.Size(308, 432);
            this.libraryPanelControl1.TabIndex = 0;
            // 
            // gridViewControl1
            // 
            this.gridViewControl1.AutoSize = true;
            this.gridViewControl1.Location = new System.Drawing.Point(3, 28);
            this.gridViewControl1.Name = "gridViewControl1";
            this.gridViewControl1.Size = new System.Drawing.Size(314, 298);
            this.gridViewControl1.TabIndex = 3;
            // 
            // metadataViewControl1
            // 
            this.metadataViewControl1.Location = new System.Drawing.Point(323, 19);
            this.metadataViewControl1.Name = "metadataViewControl1";
            this.metadataViewControl1.Size = new System.Drawing.Size(288, 380);
            this.metadataViewControl1.TabIndex = 2;
            // 
            // basicSearchControl1
            // 
            this.basicSearchControl1.AutoSize = true;
            this.basicSearchControl1.Location = new System.Drawing.Point(3, 332);
            this.basicSearchControl1.Name = "basicSearchControl1";
            this.basicSearchControl1.Size = new System.Drawing.Size(314, 99);
            this.basicSearchControl1.TabIndex = 1;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 484);
            this.Controls.Add(this.mainSplitterContainer);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainScreen";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainScreen_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.mainSplitterContainer.Panel1.ResumeLayout(false);
            this.mainSplitterContainer.Panel1.PerformLayout();
            this.mainSplitterContainer.Panel2.ResumeLayout(false);
            this.mainSplitterContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitterContainer)).EndInit();
            this.mainSplitterContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.SplitContainer mainSplitterContainer;
        private LibraryPanelControl libraryPanelControl1;
        private GridViewControl gridViewControl1;
        private MetadataViewControl metadataViewControl1;
        private BasicSearchControl basicSearchControl1;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hideMetadataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hideSearchAreaToolStripMenuItem;
    }
}


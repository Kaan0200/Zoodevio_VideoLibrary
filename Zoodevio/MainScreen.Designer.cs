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
            this.setLibraryRootToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forceFolderHiarchyRefreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainSplitterContainer = new System.Windows.Forms.SplitContainer();
            this.libraryPanelControl = new Zoodevio.LibraryPanelControl();
            this.basicSearchControl = new Zoodevio.BasicSearchControl();
            this.metadataViewControl = new Zoodevio.MetadataViewControl();
            this.gridViewControl = new Zoodevio.GridViewControl();
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 340);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip1.Size = new System.Drawing.Size(784, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.debugToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hideMetadataToolStripMenuItem,
            this.hideSearchAreaToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // hideMetadataToolStripMenuItem
            // 
            this.hideMetadataToolStripMenuItem.Name = "hideMetadataToolStripMenuItem";
            this.hideMetadataToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.hideMetadataToolStripMenuItem.Text = "Hide Metadata";
            this.hideMetadataToolStripMenuItem.Click += new System.EventHandler(this.hideMetadataToolStripMenuItem_Click);
            // 
            // hideSearchAreaToolStripMenuItem
            // 
            this.hideSearchAreaToolStripMenuItem.Name = "hideSearchAreaToolStripMenuItem";
            this.hideSearchAreaToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.hideSearchAreaToolStripMenuItem.Text = "Hide Search Area";
            this.hideSearchAreaToolStripMenuItem.Click += new System.EventHandler(this.hideSearchAreaToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setLibraryRootToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // setLibraryRootToolStripMenuItem
            // 
            this.setLibraryRootToolStripMenuItem.Name = "setLibraryRootToolStripMenuItem";
            this.setLibraryRootToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.setLibraryRootToolStripMenuItem.Text = "Set Library Root";
            this.setLibraryRootToolStripMenuItem.Click += new System.EventHandler(this.setLibraryRootToolStripMenuItem_Click);
            // 
            // debugToolStripMenuItem
            // 
            this.debugToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.forceFolderHiarchyRefreshToolStripMenuItem});
            this.debugToolStripMenuItem.Name = "debugToolStripMenuItem";
            this.debugToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.debugToolStripMenuItem.Text = "Debug";
            // 
            // forceFolderHiarchyRefreshToolStripMenuItem
            // 
            this.forceFolderHiarchyRefreshToolStripMenuItem.Name = "forceFolderHiarchyRefreshToolStripMenuItem";
            this.forceFolderHiarchyRefreshToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.forceFolderHiarchyRefreshToolStripMenuItem.Text = "Force Folder Hiarchy Refresh";
            this.forceFolderHiarchyRefreshToolStripMenuItem.Click += new System.EventHandler(this.forceFolderHiarchyRefreshToolStripMenuItem_Click);
            // 
            // mainSplitterContainer
            // 
            this.mainSplitterContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainSplitterContainer.Location = new System.Drawing.Point(0, 24);
            this.mainSplitterContainer.Margin = new System.Windows.Forms.Padding(2);
            this.mainSplitterContainer.Name = "mainSplitterContainer";
            // 
            // mainSplitterContainer.Panel1
            // 
            this.mainSplitterContainer.Panel1.Controls.Add(this.libraryPanelControl);
            // 
            // mainSplitterContainer.Panel2
            // 
            this.mainSplitterContainer.Panel2.Controls.Add(this.basicSearchControl);
            this.mainSplitterContainer.Panel2.Controls.Add(this.metadataViewControl);
            this.mainSplitterContainer.Panel2.Controls.Add(this.gridViewControl);
            this.mainSplitterContainer.Size = new System.Drawing.Size(784, 316);
            this.mainSplitterContainer.SplitterDistance = 252;
            this.mainSplitterContainer.SplitterWidth = 3;
            this.mainSplitterContainer.TabIndex = 2;
            // 
            // libraryPanelControl
            // 
            this.libraryPanelControl.AutoSize = true;
            this.libraryPanelControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.libraryPanelControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.libraryPanelControl.Location = new System.Drawing.Point(0, 0);
            this.libraryPanelControl.Margin = new System.Windows.Forms.Padding(2);
            this.libraryPanelControl.Name = "libraryPanelControl";
            this.libraryPanelControl.Size = new System.Drawing.Size(252, 316);
            this.libraryPanelControl.TabIndex = 0;
            // 
            // basicSearchControl
            // 
            this.basicSearchControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.basicSearchControl.Location = new System.Drawing.Point(2, 242);
            this.basicSearchControl.Margin = new System.Windows.Forms.Padding(2);
            this.basicSearchControl.Name = "basicSearchControl";
            this.basicSearchControl.Size = new System.Drawing.Size(237, 70);
            this.basicSearchControl.TabIndex = 1;
            // 
            // metadataViewControl
            // 
            this.metadataViewControl.Location = new System.Drawing.Point(311, 4);
            this.metadataViewControl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.metadataViewControl.Name = "metadataViewControl";
            this.metadataViewControl.Size = new System.Drawing.Size(216, 310);
            this.metadataViewControl.TabIndex = 0;
            this.metadataViewControl.Load += new System.EventHandler(this.metadataViewControl_Load);
            // 
            // gridViewControl
            // 
            this.gridViewControl.AutoSize = true;
            this.gridViewControl.Location = new System.Drawing.Point(2, 6);
            this.gridViewControl.Margin = new System.Windows.Forms.Padding(2);
            this.gridViewControl.Name = "gridViewControl";
            this.gridViewControl.Size = new System.Drawing.Size(319, 373);
            this.gridViewControl.TabIndex = 2;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 362);
            this.Controls.Add(this.mainSplitterContainer);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainScreen";
            this.Text = "Zoodevio :: Library";
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
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hideMetadataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hideSearchAreaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setLibraryRootToolStripMenuItem;
        private MetadataViewControl metadataViewControl;
        private BasicSearchControl basicSearchControl;
        private GridViewControl gridViewControl;
        private System.Windows.Forms.ToolStripMenuItem debugToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forceFolderHiarchyRefreshToolStripMenuItem;
        private LibraryPanelControl libraryPanelControl;
    }
}


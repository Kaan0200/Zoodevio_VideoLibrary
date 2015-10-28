namespace Zoodevio
{
    partial class LibraryPanelControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.folderTreeview = new System.Windows.Forms.TreeView();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.SuspendLayout();
            // 
            // folderTreeview
            // 
            this.folderTreeview.Location = new System.Drawing.Point(2, 3);
            this.folderTreeview.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.folderTreeview.Name = "folderTreeview";
            this.folderTreeview.Size = new System.Drawing.Size(210, 306);
            this.folderTreeview.TabIndex = 1;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(214, 1);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(21, 308);
            this.vScrollBar1.TabIndex = 2;
            // 
            // LibraryPanelControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.folderTreeview);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "LibraryPanelControl";
            this.Size = new System.Drawing.Size(235, 311);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TreeView folderTreeview;
        private System.Windows.Forms.VScrollBar vScrollBar1;
    }
}

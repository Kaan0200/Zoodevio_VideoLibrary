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
            this.LibraryTitleLabel = new System.Windows.Forms.Label();
            this.folderTreeview = new System.Windows.Forms.TreeView();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LibraryTitleLabel
            // 
            this.LibraryTitleLabel.AutoSize = true;
            this.LibraryTitleLabel.Location = new System.Drawing.Point(3, 5);
            this.LibraryTitleLabel.Name = "LibraryTitleLabel";
            this.LibraryTitleLabel.Size = new System.Drawing.Size(52, 17);
            this.LibraryTitleLabel.TabIndex = 0;
            this.LibraryTitleLabel.Text = "Library";
            // 
            // folderTreeview
            // 
            this.folderTreeview.Location = new System.Drawing.Point(4, 26);
            this.folderTreeview.Name = "folderTreeview";
            this.folderTreeview.Size = new System.Drawing.Size(279, 403);
            this.folderTreeview.TabIndex = 1;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(286, 0);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(20, 432);
            this.vScrollBar1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(241, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 20);
            this.button1.TabIndex = 3;
            this.button1.Text = "<<";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.LibraryVisibility_Toggle);
            // 
            // LibraryPanelControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.folderTreeview);
            this.Controls.Add(this.LibraryTitleLabel);
            this.Name = "LibraryPanelControl";
            this.Size = new System.Drawing.Size(306, 432);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LibraryTitleLabel;
        private System.Windows.Forms.TreeView folderTreeview;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Button button1;
    }
}

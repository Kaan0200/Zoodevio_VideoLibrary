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
            this.LibraryLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // folderTreeview
            // 
            this.folderTreeview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.folderTreeview.Location = new System.Drawing.Point(2, 20);
            this.folderTreeview.Margin = new System.Windows.Forms.Padding(2);
            this.folderTreeview.MinimumSize = new System.Drawing.Size(150, 4);
            this.folderTreeview.Name = "folderTreeview";
            this.folderTreeview.Size = new System.Drawing.Size(241, 90);
            this.folderTreeview.TabIndex = 1;
            this.folderTreeview.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.folderTreeviewNode_Select);
            this.folderTreeview.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.folderTreeview_MouseDoubleClick);
            // 
            // LibraryLabel
            // 
            this.LibraryLabel.AutoSize = true;
            this.LibraryLabel.Location = new System.Drawing.Point(3, 0);
            this.LibraryLabel.Name = "LibraryLabel";
            this.LibraryLabel.Size = new System.Drawing.Size(38, 13);
            this.LibraryLabel.TabIndex = 2;
            this.LibraryLabel.Text = "Library";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.LibraryLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.folderTreeview, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.07143F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.92857F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(245, 112);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // LibraryPanelControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LibraryPanelControl";
            this.Size = new System.Drawing.Size(245, 112);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TreeView folderTreeview;
        private System.Windows.Forms.Label LibraryLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

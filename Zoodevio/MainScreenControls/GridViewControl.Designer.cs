namespace Zoodevio
{
    partial class GridViewControl
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
            this.gridView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // gridView
            // 
            this.gridView.Location = new System.Drawing.Point(4, 4);
            this.gridView.Name = "gridView";
            this.gridView.Size = new System.Drawing.Size(312, 302);
            this.gridView.TabIndex = 0;
            this.gridView.UseCompatibleStateImageBehavior = false;
            // 
            // GridViewControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.gridView);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GridViewControl";
            this.Size = new System.Drawing.Size(320, 310);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView gridView;
    }
}

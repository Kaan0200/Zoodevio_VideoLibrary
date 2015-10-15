namespace Zoodevio
{
    partial class MetadataViewControl
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
            this.MetadataControlLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MetadataControlLabel
            // 
            this.MetadataControlLabel.AutoSize = true;
            this.MetadataControlLabel.BackColor = System.Drawing.SystemColors.Control;
            this.MetadataControlLabel.Location = new System.Drawing.Point(3, 0);
            this.MetadataControlLabel.Name = "MetadataControlLabel";
            this.MetadataControlLabel.Size = new System.Drawing.Size(67, 17);
            this.MetadataControlLabel.TabIndex = 0;
            this.MetadataControlLabel.Text = "Metadata";
            // 
            // MetadataViewControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MetadataControlLabel);
            this.Name = "MetadataViewControl";
            this.Size = new System.Drawing.Size(321, 380);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MetadataControlLabel;
    }
}

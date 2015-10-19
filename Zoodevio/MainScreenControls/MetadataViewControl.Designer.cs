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
            this.titleBoxLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            // titleBoxLabel
            // 
            this.titleBoxLabel.AutoSize = true;
            this.titleBoxLabel.Location = new System.Drawing.Point(24, 31);
            this.titleBoxLabel.Name = "titleBoxLabel";
            this.titleBoxLabel.Size = new System.Drawing.Size(35, 17);
            this.titleBoxLabel.TabIndex = 1;
            this.titleBoxLabel.Text = "Title";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(65, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(204, 22);
            this.textBox1.TabIndex = 2;
            // 
            // MetadataViewControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.titleBoxLabel);
            this.Controls.Add(this.MetadataControlLabel);
            this.Name = "MetadataViewControl";
            this.Size = new System.Drawing.Size(288, 380);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MetadataControlLabel;
        private System.Windows.Forms.Label titleBoxLabel;
        private System.Windows.Forms.TextBox textBox1;
    }
}

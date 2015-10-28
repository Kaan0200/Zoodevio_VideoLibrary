namespace Zoodevio
{
    partial class BasicSearchControl
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.basicSearchGroupBox = new System.Windows.Forms.GroupBox();
            this.advancedSearchButton = new System.Windows.Forms.Button();
            this.basicSearchGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(4, 17);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(223, 20);
            this.textBox1.TabIndex = 0;
            // 
            // basicSearchGroupBox
            // 
            this.basicSearchGroupBox.AutoSize = true;
            this.basicSearchGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.basicSearchGroupBox.Controls.Add(this.advancedSearchButton);
            this.basicSearchGroupBox.Controls.Add(this.textBox1);
            this.basicSearchGroupBox.Location = new System.Drawing.Point(2, 2);
            this.basicSearchGroupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.basicSearchGroupBox.Name = "basicSearchGroupBox";
            this.basicSearchGroupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.basicSearchGroupBox.Size = new System.Drawing.Size(231, 76);
            this.basicSearchGroupBox.TabIndex = 3;
            this.basicSearchGroupBox.TabStop = false;
            this.basicSearchGroupBox.Text = "Quick Filter";
            // 
            // advancedSearchButton
            // 
            this.advancedSearchButton.Enabled = false;
            this.advancedSearchButton.Location = new System.Drawing.Point(126, 40);
            this.advancedSearchButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.advancedSearchButton.Name = "advancedSearchButton";
            this.advancedSearchButton.Size = new System.Drawing.Size(100, 19);
            this.advancedSearchButton.TabIndex = 1;
            this.advancedSearchButton.Text = "Advanced Search";
            this.advancedSearchButton.UseVisualStyleBackColor = true;
            // 
            // BasicSearchControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.basicSearchGroupBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "BasicSearchControl";
            this.Size = new System.Drawing.Size(235, 70);
            this.basicSearchGroupBox.ResumeLayout(false);
            this.basicSearchGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox basicSearchGroupBox;
        private System.Windows.Forms.Button advancedSearchButton;
    }
}

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
            this.textBox1.Location = new System.Drawing.Point(6, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(296, 22);
            this.textBox1.TabIndex = 0;
            // 
            // basicSearchGroupBox
            // 
            this.basicSearchGroupBox.Controls.Add(this.advancedSearchButton);
            this.basicSearchGroupBox.Controls.Add(this.textBox1);
            this.basicSearchGroupBox.Location = new System.Drawing.Point(3, 3);
            this.basicSearchGroupBox.Name = "basicSearchGroupBox";
            this.basicSearchGroupBox.Size = new System.Drawing.Size(308, 78);
            this.basicSearchGroupBox.TabIndex = 3;
            this.basicSearchGroupBox.TabStop = false;
            this.basicSearchGroupBox.Text = "Quick Filter";
            // 
            // advancedSearchButton
            // 
            this.advancedSearchButton.Location = new System.Drawing.Point(168, 49);
            this.advancedSearchButton.Name = "advancedSearchButton";
            this.advancedSearchButton.Size = new System.Drawing.Size(134, 23);
            this.advancedSearchButton.TabIndex = 1;
            this.advancedSearchButton.Text = "Advanced Search";
            this.advancedSearchButton.UseVisualStyleBackColor = true;
            // 
            // BasicSearchControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.basicSearchGroupBox);
            this.Name = "BasicSearchControl";
            this.Size = new System.Drawing.Size(314, 86);
            this.basicSearchGroupBox.ResumeLayout(false);
            this.basicSearchGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox basicSearchGroupBox;
        private System.Windows.Forms.Button advancedSearchButton;
    }
}

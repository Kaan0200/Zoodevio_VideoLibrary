namespace Zoodevio
{
    partial class AdvancedSearchScreen
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
            this.searchBoxLabel = new System.Windows.Forms.Label();
            this.searchTermField = new System.Windows.Forms.TextBox();
            this.tagsListBox = new System.Windows.Forms.CheckedListBox();
            this.searchTagsLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // searchBoxLabel
            // 
            this.searchBoxLabel.AutoSize = true;
            this.searchBoxLabel.Location = new System.Drawing.Point(13, 13);
            this.searchBoxLabel.Name = "searchBoxLabel";
            this.searchBoxLabel.Size = new System.Drawing.Size(71, 13);
            this.searchBoxLabel.TabIndex = 0;
            this.searchBoxLabel.Text = "Search Term:";
            // 
            // searchTermField
            // 
            this.searchTermField.Location = new System.Drawing.Point(90, 10);
            this.searchTermField.Name = "searchTermField";
            this.searchTermField.Size = new System.Drawing.Size(293, 20);
            this.searchTermField.TabIndex = 1;
            // 
            // tagsListBox
            // 
            this.tagsListBox.FormattingEnabled = true;
            this.tagsListBox.Location = new System.Drawing.Point(101, 45);
            this.tagsListBox.Name = "tagsListBox";
            this.tagsListBox.Size = new System.Drawing.Size(282, 94);
            this.tagsListBox.TabIndex = 2;
            // 
            // searchTagsLabel
            // 
            this.searchTagsLabel.AutoSize = true;
            this.searchTagsLabel.Location = new System.Drawing.Point(13, 45);
            this.searchTagsLabel.Name = "searchTagsLabel";
            this.searchTagsLabel.Size = new System.Drawing.Size(82, 13);
            this.searchTagsLabel.TabIndex = 3;
            this.searchTagsLabel.Text = "Search in Tags:";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(101, 145);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 4;
            this.searchButton.Text = "Search!";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(183, 145);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(cancelButton_Click);
            // 
            // AdvancedSearchScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 177);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchTagsLabel);
            this.Controls.Add(this.tagsListBox);
            this.Controls.Add(this.searchTermField);
            this.Controls.Add(this.searchBoxLabel);
            this.Name = "AdvancedSearchScreen";
            this.Text = "Advanced Tags Search";
            this.Load += new System.EventHandler(this.AdvancedSearchScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label searchBoxLabel;
        private System.Windows.Forms.TextBox searchTermField;
        private System.Windows.Forms.CheckedListBox tagsListBox;
        private System.Windows.Forms.Label searchTagsLabel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button cancelButton;
    }
}
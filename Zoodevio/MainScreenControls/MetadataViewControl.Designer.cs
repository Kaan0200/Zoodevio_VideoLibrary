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
            this.TitleLabel = new System.Windows.Forms.Label();
            this.URLTextBox = new System.Windows.Forms.TextBox();
            this.GenreTextBox = new System.Windows.Forms.TextBox();
            this.GenreLabel = new System.Windows.Forms.Label();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.WebsiteLabel = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.MetadataControlGroupBox = new System.Windows.Forms.GroupBox();
            this.ColorPickerPanel = new System.Windows.Forms.Panel();
            this.FiletypeValueLabel = new System.Windows.Forms.Label();
            this.BitrateValueLabel = new System.Windows.Forms.Label();
            this.LengthValueLabel = new System.Windows.Forms.Label();
            this.SaveMetadataButton = new System.Windows.Forms.Button();
            this.FiletypeLabel = new System.Windows.Forms.Label();
            this.BitrateLabel = new System.Windows.Forms.Label();
            this.LengthLabel = new System.Windows.Forms.Label();
            this.ThumbnailLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ColorTagLabel = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.TagColorDialog = new System.Windows.Forms.ColorDialog();
            this.MetadataControlGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(6, 24);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(35, 17);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Text = "Title";
            // 
            // URLTextBox
            // 
            this.URLTextBox.Location = new System.Drawing.Point(9, 134);
            this.URLTextBox.Name = "URLTextBox";
            this.URLTextBox.Size = new System.Drawing.Size(267, 22);
            this.URLTextBox.TabIndex = 2;
            // 
            // GenreTextBox
            // 
            this.GenreTextBox.Location = new System.Drawing.Point(9, 89);
            this.GenreTextBox.Name = "GenreTextBox";
            this.GenreTextBox.Size = new System.Drawing.Size(267, 22);
            this.GenreTextBox.TabIndex = 3;
            // 
            // GenreLabel
            // 
            this.GenreLabel.AutoSize = true;
            this.GenreLabel.Location = new System.Drawing.Point(6, 69);
            this.GenreLabel.Name = "GenreLabel";
            this.GenreLabel.Size = new System.Drawing.Size(48, 17);
            this.GenreLabel.TabIndex = 4;
            this.GenreLabel.Text = "Genre";
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(9, 44);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(206, 22);
            this.TitleTextBox.TabIndex = 5;
            // 
            // WebsiteLabel
            // 
            this.WebsiteLabel.AutoSize = true;
            this.WebsiteLabel.Location = new System.Drawing.Point(6, 114);
            this.WebsiteLabel.Name = "WebsiteLabel";
            this.WebsiteLabel.Size = new System.Drawing.Size(59, 17);
            this.WebsiteLabel.TabIndex = 6;
            this.WebsiteLabel.Text = "Website";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(6, 159);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(79, 17);
            this.DescriptionLabel.TabIndex = 7;
            this.DescriptionLabel.Text = "Description";
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Location = new System.Drawing.Point(9, 179);
            this.DescriptionTextBox.Multiline = true;
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(267, 77);
            this.DescriptionTextBox.TabIndex = 8;
            // 
            // MetadataControlGroupBox
            // 
            this.MetadataControlGroupBox.Controls.Add(this.ColorPickerPanel);
            this.MetadataControlGroupBox.Controls.Add(this.FiletypeValueLabel);
            this.MetadataControlGroupBox.Controls.Add(this.BitrateValueLabel);
            this.MetadataControlGroupBox.Controls.Add(this.LengthValueLabel);
            this.MetadataControlGroupBox.Controls.Add(this.SaveMetadataButton);
            this.MetadataControlGroupBox.Controls.Add(this.FiletypeLabel);
            this.MetadataControlGroupBox.Controls.Add(this.BitrateLabel);
            this.MetadataControlGroupBox.Controls.Add(this.LengthLabel);
            this.MetadataControlGroupBox.Controls.Add(this.ThumbnailLabel);
            this.MetadataControlGroupBox.Controls.Add(this.pictureBox1);
            this.MetadataControlGroupBox.Controls.Add(this.ColorTagLabel);
            this.MetadataControlGroupBox.Controls.Add(this.URLTextBox);
            this.MetadataControlGroupBox.Controls.Add(this.TitleLabel);
            this.MetadataControlGroupBox.Controls.Add(this.GenreLabel);
            this.MetadataControlGroupBox.Controls.Add(this.TitleTextBox);
            this.MetadataControlGroupBox.Controls.Add(this.GenreTextBox);
            this.MetadataControlGroupBox.Controls.Add(this.WebsiteLabel);
            this.MetadataControlGroupBox.Controls.Add(this.DescriptionLabel);
            this.MetadataControlGroupBox.Controls.Add(this.DescriptionTextBox);
            this.MetadataControlGroupBox.Location = new System.Drawing.Point(3, 3);
            this.MetadataControlGroupBox.Name = "MetadataControlGroupBox";
            this.MetadataControlGroupBox.Size = new System.Drawing.Size(282, 374);
            this.MetadataControlGroupBox.TabIndex = 9;
            this.MetadataControlGroupBox.TabStop = false;
            this.MetadataControlGroupBox.Text = "Metadata Editor";
            // 
            // ColorPickerPanel
            // 
            this.ColorPickerPanel.BackColor = System.Drawing.Color.White;
            this.ColorPickerPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ColorPickerPanel.Location = new System.Drawing.Point(78, 262);
            this.ColorPickerPanel.Name = "ColorPickerPanel";
            this.ColorPickerPanel.Size = new System.Drawing.Size(20, 20);
            this.ColorPickerPanel.TabIndex = 19;
            this.ColorPickerPanel.Click += new System.EventHandler(this.ColorPanel_Click);
            // 
            // FiletypeValueLabel
            // 
            this.FiletypeValueLabel.AutoSize = true;
            this.FiletypeValueLabel.Location = new System.Drawing.Point(75, 322);
            this.FiletypeValueLabel.Name = "FiletypeValueLabel";
            this.FiletypeValueLabel.Size = new System.Drawing.Size(43, 17);
            this.FiletypeValueLabel.TabIndex = 18;
            this.FiletypeValueLabel.Text = "[type]";
            // 
            // BitrateValueLabel
            // 
            this.BitrateValueLabel.AutoSize = true;
            this.BitrateValueLabel.Location = new System.Drawing.Point(75, 305);
            this.BitrateValueLabel.Name = "BitrateValueLabel";
            this.BitrateValueLabel.Size = new System.Drawing.Size(56, 17);
            this.BitrateValueLabel.TabIndex = 17;
            this.BitrateValueLabel.Text = "[bitrate]";
            // 
            // LengthValueLabel
            // 
            this.LengthValueLabel.AutoSize = true;
            this.LengthValueLabel.Location = new System.Drawing.Point(75, 288);
            this.LengthValueLabel.Name = "LengthValueLabel";
            this.LengthValueLabel.Size = new System.Drawing.Size(55, 17);
            this.LengthValueLabel.TabIndex = 16;
            this.LengthValueLabel.Text = "[length]";
            this.LengthValueLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // SaveMetadataButton
            // 
            this.SaveMetadataButton.Location = new System.Drawing.Point(38, 345);
            this.SaveMetadataButton.Name = "SaveMetadataButton";
            this.SaveMetadataButton.Size = new System.Drawing.Size(129, 23);
            this.SaveMetadataButton.TabIndex = 15;
            this.SaveMetadataButton.Text = "Save Metadata";
            this.SaveMetadataButton.UseVisualStyleBackColor = true;
            this.SaveMetadataButton.Click += new System.EventHandler(this.SaveMetadataButton_Click);
            // 
            // FiletypeLabel
            // 
            this.FiletypeLabel.AutoSize = true;
            this.FiletypeLabel.Location = new System.Drawing.Point(6, 322);
            this.FiletypeLabel.Name = "FiletypeLabel";
            this.FiletypeLabel.Size = new System.Drawing.Size(57, 17);
            this.FiletypeLabel.TabIndex = 14;
            this.FiletypeLabel.Text = "Filetype";
            // 
            // BitrateLabel
            // 
            this.BitrateLabel.AutoSize = true;
            this.BitrateLabel.Location = new System.Drawing.Point(6, 305);
            this.BitrateLabel.Name = "BitrateLabel";
            this.BitrateLabel.Size = new System.Drawing.Size(49, 17);
            this.BitrateLabel.TabIndex = 13;
            this.BitrateLabel.Text = "Bitrate";
            // 
            // LengthLabel
            // 
            this.LengthLabel.AutoSize = true;
            this.LengthLabel.Location = new System.Drawing.Point(6, 288);
            this.LengthLabel.Name = "LengthLabel";
            this.LengthLabel.Size = new System.Drawing.Size(52, 17);
            this.LengthLabel.TabIndex = 12;
            this.LengthLabel.Text = "Length";
            // 
            // ThumbnailLabel
            // 
            this.ThumbnailLabel.AutoSize = true;
            this.ThumbnailLabel.Location = new System.Drawing.Point(193, 268);
            this.ThumbnailLabel.Name = "ThumbnailLabel";
            this.ThumbnailLabel.Size = new System.Drawing.Size(74, 17);
            this.ThumbnailLabel.TabIndex = 11;
            this.ThumbnailLabel.Text = "Thumbnail";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(196, 288);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // ColorTagLabel
            // 
            this.ColorTagLabel.AutoSize = true;
            this.ColorTagLabel.Location = new System.Drawing.Point(6, 259);
            this.ColorTagLabel.Name = "ColorTagLabel";
            this.ColorTagLabel.Size = new System.Drawing.Size(70, 17);
            this.ColorTagLabel.TabIndex = 9;
            this.ColorTagLabel.Text = "Color Tag";
            // 
            // MetadataViewControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MetadataControlGroupBox);
            this.Name = "MetadataViewControl";
            this.Size = new System.Drawing.Size(288, 380);
            this.MetadataControlGroupBox.ResumeLayout(false);
            this.MetadataControlGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.TextBox URLTextBox;
        private System.Windows.Forms.TextBox GenreTextBox;
        private System.Windows.Forms.Label GenreLabel;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.Label WebsiteLabel;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.GroupBox MetadataControlGroupBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button SaveMetadataButton;
        private System.Windows.Forms.Label FiletypeLabel;
        private System.Windows.Forms.Label BitrateLabel;
        private System.Windows.Forms.Label LengthLabel;
        private System.Windows.Forms.Label ThumbnailLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label ColorTagLabel;
        private System.Windows.Forms.Label FiletypeValueLabel;
        private System.Windows.Forms.Label BitrateValueLabel;
        private System.Windows.Forms.Label LengthValueLabel;
        private System.Windows.Forms.ColorDialog TagColorDialog;
        private System.Windows.Forms.Panel ColorPickerPanel;
    }
}

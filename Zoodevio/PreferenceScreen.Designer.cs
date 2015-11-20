namespace Zoodevio
{
    partial class PreferenceScreen
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
            this.customPlayerCheckbox = new System.Windows.Forms.CheckBox();
            this.gridViewCheckBox = new System.Windows.Forms.CheckBox();
            this.defaultColorField = new System.Windows.Forms.TextBox();
            this.defaultColorLabel = new System.Windows.Forms.Label();
            this.customPlayerField = new System.Windows.Forms.TextBox();
            this.customPlayerBrowseButton = new System.Windows.Forms.Button();
            this.safePrefsButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // customPlayerCheckbox
            // 
            this.customPlayerCheckbox.AutoSize = true;
            this.customPlayerCheckbox.Location = new System.Drawing.Point(13, 23);
            this.customPlayerCheckbox.Name = "customPlayerCheckbox";
            this.customPlayerCheckbox.Size = new System.Drawing.Size(150, 17);
            this.customPlayerCheckbox.TabIndex = 0;
            this.customPlayerCheckbox.Text = "Use Custom Media Player:";
            this.customPlayerCheckbox.UseVisualStyleBackColor = true;
            this.customPlayerCheckbox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // gridViewCheckBox
            // 
            this.gridViewCheckBox.AutoSize = true;
            this.gridViewCheckBox.Location = new System.Drawing.Point(13, 48);
            this.gridViewCheckBox.Name = "gridViewCheckBox";
            this.gridViewCheckBox.Size = new System.Drawing.Size(107, 17);
            this.gridViewCheckBox.TabIndex = 1;
            this.gridViewCheckBox.Text = "Start in Grid View";
            this.gridViewCheckBox.UseVisualStyleBackColor = true;
            // 
            // defaultColorField
            // 
            this.defaultColorField.Location = new System.Drawing.Point(106, 71);
            this.defaultColorField.Name = "defaultColorField";
            this.defaultColorField.Size = new System.Drawing.Size(54, 20);
            this.defaultColorField.TabIndex = 2;
            this.defaultColorField.Text = "000000";
            // 
            // defaultColorLabel
            // 
            this.defaultColorLabel.AutoSize = true;
            this.defaultColorLabel.Location = new System.Drawing.Point(10, 74);
            this.defaultColorLabel.Name = "defaultColorLabel";
            this.defaultColorLabel.Size = new System.Drawing.Size(93, 13);
            this.defaultColorLabel.TabIndex = 3;
            this.defaultColorLabel.Text = "Default Tag Color:";
            // 
            // customPlayerField
            // 
            this.customPlayerField.Location = new System.Drawing.Point(164, 21);
            this.customPlayerField.Name = "customPlayerField";
            this.customPlayerField.Size = new System.Drawing.Size(100, 20);
            this.customPlayerField.TabIndex = 4;
            // 
            // customPlayerBrowseButton
            // 
            this.customPlayerBrowseButton.Location = new System.Drawing.Point(271, 19);
            this.customPlayerBrowseButton.Name = "customPlayerBrowseButton";
            this.customPlayerBrowseButton.Size = new System.Drawing.Size(75, 23);
            this.customPlayerBrowseButton.TabIndex = 5;
            this.customPlayerBrowseButton.Text = "Browse...";
            this.customPlayerBrowseButton.UseVisualStyleBackColor = true;
            // 
            // safePrefsButton
            // 
            this.safePrefsButton.Location = new System.Drawing.Point(171, 69);
            this.safePrefsButton.Name = "safePrefsButton";
            this.safePrefsButton.Size = new System.Drawing.Size(117, 23);
            this.safePrefsButton.TabIndex = 6;
            this.safePrefsButton.Text = "Save Preferences";
            this.safePrefsButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(294, 69);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // PreferenceScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 111);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.safePrefsButton);
            this.Controls.Add(this.customPlayerBrowseButton);
            this.Controls.Add(this.customPlayerField);
            this.Controls.Add(this.defaultColorLabel);
            this.Controls.Add(this.defaultColorField);
            this.Controls.Add(this.gridViewCheckBox);
            this.Controls.Add(this.customPlayerCheckbox);
            this.Name = "PreferenceScreen";
            this.Text = "Zoodevio Preferences";
            this.Load += new System.EventHandler(this.PreferenceScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox customPlayerCheckbox;
        private System.Windows.Forms.CheckBox gridViewCheckBox;
        private System.Windows.Forms.TextBox defaultColorField;
        private System.Windows.Forms.Label defaultColorLabel;
        private System.Windows.Forms.TextBox customPlayerField;
        private System.Windows.Forms.Button customPlayerBrowseButton;
        private System.Windows.Forms.Button safePrefsButton;
        private System.Windows.Forms.Button cancelButton;
    }
}
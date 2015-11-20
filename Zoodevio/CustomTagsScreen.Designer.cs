namespace Zoodevio
{
    partial class CustomTagsScreen
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
            this.tagGridView = new System.Windows.Forms.DataGridView();
            this.saveCustomTagsButton = new System.Windows.Forms.Button();
            this.discardChangesButton = new System.Windows.Forms.Button();
            this.TagID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TagName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CanSearch = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CanSort = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DataType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tagGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tagGridView
            // 
            this.tagGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tagGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TagID,
            this.TagName,
            this.CanSearch,
            this.CanSort,
            this.DataType});
            this.tagGridView.Location = new System.Drawing.Point(12, 12);
            this.tagGridView.Name = "tagGridView";
            this.tagGridView.Size = new System.Drawing.Size(513, 347);
            this.tagGridView.TabIndex = 0;
            // 
            // saveCustomTagsButton
            // 
            this.saveCustomTagsButton.Location = new System.Drawing.Point(142, 366);
            this.saveCustomTagsButton.Name = "saveCustomTagsButton";
            this.saveCustomTagsButton.Size = new System.Drawing.Size(118, 23);
            this.saveCustomTagsButton.TabIndex = 1;
            this.saveCustomTagsButton.Text = "Save Custom Tags";
            this.saveCustomTagsButton.UseVisualStyleBackColor = true;
            // 
            // discardChangesButton
            // 
            this.discardChangesButton.Location = new System.Drawing.Point(267, 366);
            this.discardChangesButton.Name = "discardChangesButton";
            this.discardChangesButton.Size = new System.Drawing.Size(102, 23);
            this.discardChangesButton.TabIndex = 2;
            this.discardChangesButton.Text = "Discard Changes";
            this.discardChangesButton.UseVisualStyleBackColor = true;
            this.discardChangesButton.Click += new System.EventHandler(this.discardChangesButton_Click);
            // 
            // TagID
            // 
            this.TagID.HeaderText = "ID";
            this.TagID.Name = "TagID";
            this.TagID.ReadOnly = true;
            this.TagID.Width = 50;
            // 
            // TagName
            // 
            this.TagName.HeaderText = "Tag Name";
            this.TagName.Name = "TagName";
            this.TagName.ReadOnly = true;
            this.TagName.Width = 170;
            // 
            // CanSearch
            // 
            this.CanSearch.HeaderText = "Searchable?";
            this.CanSearch.Name = "CanSearch";
            this.CanSearch.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CanSearch.Width = 75;
            // 
            // CanSort
            // 
            this.CanSort.HeaderText = "Sortable?";
            this.CanSort.Name = "CanSort";
            this.CanSort.Width = 75;
            // 
            // DataType
            // 
            this.DataType.HeaderText = "Data Type";
            this.DataType.Items.AddRange(new object[] {
            "string"});
            this.DataType.Name = "DataType";
            // 
            // CustomTagsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 402);
            this.Controls.Add(this.discardChangesButton);
            this.Controls.Add(this.saveCustomTagsButton);
            this.Controls.Add(this.tagGridView);
            this.Name = "CustomTagsScreen";
            this.Text = "Zoodevio Custom Tags";
            ((System.ComponentModel.ISupportInitialize)(this.tagGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tagGridView;
        private System.Windows.Forms.Button saveCustomTagsButton;
        private System.Windows.Forms.Button discardChangesButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn TagID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TagName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CanSearch;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CanSort;
        private System.Windows.Forms.DataGridViewComboBoxColumn DataType;
    }
}
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
            this.label1 = new System.Windows.Forms.Label();
            this.gridView = new System.Windows.Forms.ListView();
            this.iconViewButton = new System.Windows.Forms.Button();
            this.listViewButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 2;
            // 
            // gridView
            // 
            this.gridView.Location = new System.Drawing.Point(3, 29);
            this.gridView.Name = "gridView";
            this.gridView.Size = new System.Drawing.Size(313, 341);
            this.gridView.TabIndex = 1;
            this.gridView.UseCompatibleStateImageBehavior = false;
            this.gridView.SelectedIndexChanged += new System.EventHandler(this.gridView_SelectedIndexChanged);
            // 
            // iconViewButton
            // 
            this.iconViewButton.Location = new System.Drawing.Point(4, 3);
            this.iconViewButton.Name = "iconViewButton";
            this.iconViewButton.Size = new System.Drawing.Size(75, 23);
            this.iconViewButton.TabIndex = 3;
            this.iconViewButton.Text = "Icon View";
            this.iconViewButton.UseVisualStyleBackColor = true;
            this.iconViewButton.Click += new System.EventHandler(this.changeToIcon_Click);
            // 
            // listViewButton
            // 
            this.listViewButton.Location = new System.Drawing.Point(85, 3);
            this.listViewButton.Name = "listViewButton";
            this.listViewButton.Size = new System.Drawing.Size(75, 23);
            this.listViewButton.TabIndex = 4;
            this.listViewButton.Text = "Grid View";
            this.listViewButton.UseVisualStyleBackColor = true;
            this.listViewButton.Click += new System.EventHandler(this.changeToList_Click);
            // 
            // GridViewControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.listViewButton);
            this.Controls.Add(this.iconViewButton);
            this.Controls.Add(this.gridView);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GridViewControl";
            this.Size = new System.Drawing.Size(320, 373);
            this.ResumeLayout(false);

        }

        #endregion
        
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView gridView;
        private System.Windows.Forms.Button iconViewButton;
        private System.Windows.Forms.Button listViewButton;
    }
}

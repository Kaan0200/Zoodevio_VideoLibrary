using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zoodevio.DataModel.Objects;
using Zoodevio.Managers;

namespace Zoodevio
{
    public partial class MetadataViewControl : UserControl
    {
        public MetadataManager Manager;

        public MetadataViewControl()
        {
            InitializeComponent();
        }

        public void PopulateFields(VideoFile inputFile)
        {
            foreach (TagEntry t in inputFile.Tags)
            {
                // TODO: lookup tag in database, populate fields accordingly 
            }
        }

        private void SaveMetadataButton_Click(object sender, EventArgs e)
        {
            var newTitle = TitleTextBox.Text;
            var newGenre = GenreTextBox.Text;
            var newURL = URLTextBox.Text;
            var newDesc = DescriptionTextBox.Text;
            var newColor = ColorPickerPanel.BackColor;
        }

        private void ColorPanel_Click(object sender, EventArgs e)
        {
            if (TagColorDialog.ShowDialog() == DialogResult.OK)
            {
                ColorPickerPanel.BackColor = TagColorDialog.Color;
            }
        }

        private void BitrateLabel_Click(object sender, EventArgs e)
        {

        }
    }
}

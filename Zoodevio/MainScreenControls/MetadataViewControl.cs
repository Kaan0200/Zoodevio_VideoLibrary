using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zoodevio.DataModel;
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
            ClearFields();
            Manager.CurrentFile = inputFile;
            foreach (var t in inputFile.Tags)
            {
                if (t.Data == null) return;
                var type = Tags.GetTagType(t.TypeId);
                switch (type.Name)
                {
                    case "display_name":
                        TitleTextBox.Text = t.Data;
                        break;
                    case "file_type":
                        FiletypeValueLabel.Text = t.Data;
                        break;
                    case "length":
                        try
                        {
                            var length = Convert.ToInt32(t.Data);
                            length /= 1000;
                            var minutes = length / 60;
                            var seconds = length % 60;
                            LengthValueLabel.Text = minutes + " min " + seconds + " sec";
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("movie length grab failed"); 
                        }
                        break;
                    case "framerate":
                        BitrateValueLabel.Text = t.Data + " fps";
                        break;
                    case "genre":
                        GenreTextBox.Text = t.Data;
                        break;
                    case "url":
                        URLTextBox.Text = t.Data;
                        break;
                    case "description":
                        DescriptionTextBox.Text = t.Data;
                        break;
                    case "color":
                        ColorPickerPanel.BackColor = ColorTranslator.FromHtml("#" + t.Data);
                        break;
                    case "thumbnail":
                        pictureBox1.ImageLocation = t.Data;
                        break;
                    default:
                        Console.WriteLine("Unexpected Tag: " + t.Data);
                        break;
                }
            }
        }

        private void SaveMetadataButton_Click(object sender, EventArgs e)
        {
            var file = Manager.CurrentFile;

            var newTitle = TitleTextBox.Text;
            var newGenre = GenreTextBox.Text;
            var newURL = URLTextBox.Text;
            var newDesc = DescriptionTextBox.Text;
            var newColor = ColorPickerPanel.BackColor;

            foreach (var tag in file.Tags)
            {
                var type = Tags.GetTagType(tag.TypeId);
                string data = null;
                switch (type.Name)
                {
                    case "display_name":
                        data = newTitle;
                        break;
                    case "genre":
                        data = newGenre;
                        break;
                    case "url":
                        data = newURL;
                        break;
                    case "description":
                        data = newDesc;
                        break;
                    case "color":
                        //data = newColor.ToString();
                        break;
                }
                if (data == null) return;
                // Save new tag and update the DB
                //var newTag = new TagEntry(tag.TypeId, data);
                //Tags.UpdateFileTag(file.Id, newTag, file.Tags);
                //Manager.Update(file.Id);
            }
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

        private void ClearFields()
        {
            BitrateValueLabel.Text = "";
            DescriptionTextBox.Text = "";
            FiletypeValueLabel.Text = "";
            GenreTextBox.Text = "";
            LengthValueLabel.Text = "";
            TitleTextBox.Text = "";
            URLTextBox.Text = "";
            pictureBox1.Image = null;
        }
    }
}

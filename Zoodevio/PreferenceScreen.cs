using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zoodevio.DataModel;
using Zoodevio.DataModel.Objects;

namespace Zoodevio
{
    public partial class PreferenceScreen : Form
    {
        public PreferenceScreen()
        {
            InitializeComponent();
        }

        // get all preferences on load and update window accordingly 
        private void PreferenceScreen_Load(object sender, EventArgs e)
        {

            List<Preference> preferences = Preferences.GetAllPreferences();
            bool useDefaultPlayer =
                (preferences.First(item => item.Name.Equals("use_default_player")).Data) == "1";
            bool defaultToGridView =
                (preferences.First(item => item.Name.Equals("default_to_grid_view")).Data) == "1";
            string customVideoPlayer =
                preferences.First(item => item.Name.Equals("custom_video_player")).Data;
            string defaultColorTag =
                preferences.First(item => item.Name.Equals("default_color_tag")).Data;

            if (!useDefaultPlayer)
            {
                this.customPlayerCheckbox.Checked = true; 
                this.customPlayerField.Enabled = true;
                this.customPlayerField.Text = customVideoPlayer;
                this.customPlayerBrowseButton.Enabled = true; 
            }

            if (defaultToGridView)
            {
                this.gridViewCheckBox.Checked = true; 
            }

            this.defaultColorField.Text = defaultColorTag; 

        }

        /** EVENT HANDLERS **/ 

        private void customPlayerCheckbox_Click(object sender, EventArgs e)
        {
            this.customPlayerField.Enabled = this.customPlayerCheckbox.Checked;
            this.customPlayerBrowseButton.Enabled = this.customPlayerCheckbox.Checked;
        }

        private void customPlayerBrowseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog mediaPlayerFileDialog = new OpenFileDialog();
            mediaPlayerFileDialog.Filter = "Executables|*.exe";
            mediaPlayerFileDialog.FilterIndex = 1;
            mediaPlayerFileDialog.Multiselect = false;
            bool clickedOk = (mediaPlayerFileDialog.ShowDialog() == DialogResult.OK);
            if (clickedOk)
            {
                customPlayerField.Text = mediaPlayerFileDialog.FileName;
            }
        }

        private void savePrefsButton_Click(object sender, EventArgs e)
        {
            if (customPlayerCheckbox.Checked)
            {
                if(customPlayerField.Text.EndsWith(".exe") && File.Exists(customPlayerField.Text))
                {
                    Preferences.Modify("custom_video_player", customPlayerField.Text);
                }
                else
                {
                    MessageBox.Show("Invalid custom media player: File does not exist, or is not an executable.",
                        "Zoodevio Preferences - Failed to Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; 
                }
            } else if (defaultColorField.Text.Length > 6 || !OnlyHexInString(defaultColorField.Text))
            {
                MessageBox.Show("Invalid color code specified - must be six hexademical values!",
                    "Zoodevio Preferences - Failed to Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }
            Preferences.Modify("use_default_player", (!customPlayerCheckbox.Checked ? "1" : "0"));
            Preferences.Modify("default_to_grid_view", (gridViewCheckBox.Checked ? "1" : "0"));
            Preferences.Modify("default_color_tag", defaultColorField.Text);
            this.Close(); 
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }


        // helper to check if string contains only hexadecimal chars
        // based on stackoverflow #223832
        private bool OnlyHexInString(string test)
        {
            // For C-style hex notation (0xFF) you can use @"\A\b(0[xX])?[0-9a-fA-F]+\b\Z"
            return System.Text.RegularExpressions.Regex.IsMatch(test, @"\A\b[0-9a-fA-F]+\b\Z");
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        // the preferences in the DB
        private List<Preference> preferences;
        private bool useDefaultPlayer, defaultToGridView;
        private string customVideoPlayer, defaultColorTag;

        public PreferenceScreen()
        {
            InitializeComponent();
        }

        // get all preferences on load and update window accordingly 
        private void PreferenceScreen_Load(object sender, EventArgs e)
        {
            try
            {
                preferences = Preferences.GetAllPreferences();
                useDefaultPlayer =
                    (preferences.First(item => item.Name.Equals("use_default_player")).Data) == "1";
                defaultToGridView =
                    (preferences.First(item => item.Name.Equals("default_to_grid_view")).Data) == "1";
                customVideoPlayer =
                    preferences.First(item => item.Name.Equals("custom_video_player")).Data;
                defaultColorTag =
                    preferences.First(item => item.Name.Equals("default_color_tag")).Data;
            }
            catch(Exception ex)
            {
               Console.WriteLine(ex.ToString());
            }

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
    }
}

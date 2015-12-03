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
    public partial class AdvancedSearchScreen : Form
    {
        // the source so it can be accessed when adding a new Tag
        private BindingSource _source;

        public AdvancedSearchScreen()
        {
            InitializeComponent();
        }

        // get custom tags from the DB and display them
        private void AdvancedSearchScreen_Load(object sender, EventArgs e)
        {
            List<Tag> tagTableSource = Tags.GetAllTagTypes(true);
            _source = new BindingSource();
            _source.DataSource = tagTableSource;
            this.tagsListBox.DataSource = _source;
            this.tagsListBox.DisplayMember = "Name";
        }

        private void cancelButton_Click(Object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}

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
using Zoodevio.Managers;

namespace Zoodevio
{
    public partial class AdvancedSearchScreen : Form
    {
        // the source so it can be accessed when adding a new Tag
        private BindingSource _source;
        private SearchManager _manager;

        public AdvancedSearchScreen(SearchManager manager)
        {
            InitializeComponent();
            _manager = manager;
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

        private void searchButton_Click(object sender, EventArgs e)
        {
            _manager.AdvancedSearch(searchTermField.Text, tagsListBox.CheckedItems);
            this.Dispose();
        }
    }
}

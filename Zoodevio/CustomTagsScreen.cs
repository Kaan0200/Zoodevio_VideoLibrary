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
    public partial class CustomTagsScreen : Form
    {
        // the source so it can be accessed when adding a new Tag
        private BindingSource _source;

        public CustomTagsScreen()
        {
            InitializeComponent();
        }

        // get custom tags from the DB and display them
        private void CustomTagsScreen_Load(object sender, EventArgs e)
        {
            List<Tag> tagTableSource = Tags.GetAllTagTypes(false);
            _source = new BindingSource();
            _source.DataSource = tagTableSource;
            this.tagGridView.DataSource = _source; 
            this.tagGridView.Columns["TagID"].DataPropertyName = "Id";
            this.tagGridView.Columns["TagName"].DataPropertyName = "Name";
            this.tagGridView.Columns["CanSearch"].DataPropertyName = "CanSearch";
            this.tagGridView.Columns["CanSort"].DataPropertyName = "CanSort";
            this.tagGridView.Columns["DataType"].DataPropertyName = "DataType";
        }

        private void discardChangesButton_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void addTag_Click(object sender, EventArgs e)
        {
            _source.Add(new Tag("CreatedTag", "string", true));
        }

        private void saveCustomTagsButton_Click(object sender, EventArgs e)
        {
           
        }
    }
}

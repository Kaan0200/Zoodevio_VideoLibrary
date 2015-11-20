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
        public CustomTagsScreen()
        {
            InitializeComponent();
        }

        // get custom tags from the DB and display them
        private void CustomTagsScreen_Load(object sender, EventArgs e)
        {
            List<Tag> tags = Tags.GetAllTagTypes(false);
            BindingSource source = new BindingSource();
            source.DataSource = tags;
            this.tagGridView.DataSource = source; 
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

        private void tagGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

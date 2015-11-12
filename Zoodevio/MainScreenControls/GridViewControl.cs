﻿using System;
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
    public partial class GridViewControl : UserControl
    {
        public FileManager Manager;

        public GridViewControl()
        {
            InitializeComponent();
        }

        internal void CreateVideoIcon(VideoFile f)
        {

            gridView.Items.Add(f.Path);
        }
    }
}

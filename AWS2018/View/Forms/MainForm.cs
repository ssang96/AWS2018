using AWS2018.Controller;
using AWS2018.View.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AWS2018
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private CommunicationManager comManager = null;

        public MainForm()
        {
            InitializeComponent();
             
            comManager = new CommunicationManager();
        }

        private void textDisplayItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GraphForm graph = new GraphForm();
            graph.MdiParent = this;

            graph.Show();
        }
    }
}

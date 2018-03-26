using CommManager.DataLogger;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CommManager
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private CommunicationManager comManager = null;

        public MainForm()
        {
            InitializeComponent();

             comManager = new CommunicationManager();
        }
    }
}

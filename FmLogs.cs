using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RandomSelection
{
    public partial class FmLogs : Form
    {
        public FmLogs()
        {
            InitializeComponent();
        }

        private void FmLogs_Load(object sender, EventArgs e)
        {
            dgvMain.DataSource = Caches.Database.Log; 
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace Visual_Periodic_Table
{
    public partial class Bang_Tinh_Tan : Form
    {
        public Bang_Tinh_Tan()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnbangtinhtanwiki_Click(object sender, EventArgs e)
        {
            Process.Start("https://vi.wikipedia.org/wiki/B%E1%BA%A3ng_t%C3%ADnh_tan");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

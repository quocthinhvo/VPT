using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Visual_Periodic_Table
{
    public partial class Form_Chao_Mung : Form
    {
        int so_sanh = 1;
        public Form_Chao_Mung()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            so_sanh++;
            if (so_sanh == 100) 
            {
                timer1.Stop();
            }
        }
    }
}

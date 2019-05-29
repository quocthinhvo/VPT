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
    public partial class Video_Huong_Dan : Form
    {
        public Video_Huong_Dan()
        {
            InitializeComponent();
        }

        private void Video_Huong_Dan_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void Video_Huong_Dan_Load(object sender, EventArgs e)
        {
            play.URL = Application.StartupPath + "//Image Of Visual Periodic Table//hd.mp4";
        }
    }
}

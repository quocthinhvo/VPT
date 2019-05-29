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
    public partial class Tinh_Mol : Form
    {
        public Tinh_Mol()
        {
            InitializeComponent();
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            txbchattan .Text = "";
            txbthe .Text = "";
        }

        private void btntinh_Click(object sender, EventArgs e)
        {
            if (txbchattan.Text != "" && txbthe.Text != "")
            {
                double n, v, cm;
                n = Convert.ToDouble(txbchattan.Text);
                v = Convert.ToDouble(txbthe.Text);
                cm = n / v;
                MessageBox.Show("Nồng độ dung dịch trên là C = " + cm, "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else 
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ dữ kiện!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

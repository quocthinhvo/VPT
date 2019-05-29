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
    public partial class Nong_Do_Phan_Tram : Form
    {
        public Nong_Do_Phan_Tram()
        {
            InitializeComponent();
        }

        private void Nong_Do_Phan_Tram_Load(object sender, EventArgs e)
        {

        }

        private void btnce_Click(object sender, EventArgs e)
        {
            txbmct.Text = "";
            txbmdd.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btntinh_Click(object sender, EventArgs e)
        {
            if (txbmct.Text != "" && txbmdd.Text != "")
            {
                double mct, mdd, cp;
                mct = Convert.ToDouble(txbmct.Text);
                mdd = Convert.ToDouble(txbmdd.Text);
                cp = mct / mdd * 100;
                MessageBox.Show("Nồng độ phần trăm của dung dịch là:\n C% = " + cp+" %", "Kết Quả", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else 
            {
                MessageBox.Show("Bạn chưa nhập đủ dữ kiện!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

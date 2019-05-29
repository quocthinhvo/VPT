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
    public partial class Giai_Phuong_Trinh_Bac_Nhat_Hai_An : Form
    {
        public Giai_Phuong_Trinh_Bac_Nhat_Hai_An()
        {
            InitializeComponent();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnce_Click(object sender, EventArgs e)
        {
            txba1.Text = "";
            txba2.Text = "";
            txbb1.Text = "";
            txbb2.Text = "";
            txbc1.Text = "";
            txbc2.Text = "";
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btngiai_Click(object sender, EventArgs e)
        {
            if (txba1.Text != "" && txba2.Text != "" && txbb1.Text != "" && txbb2.Text != "" && txbc1.Text != "" && txbc2.Text != "")
            {
                double a1, a2, b1, b2, c1, c2, d, dx, dy, x, y;
                a1 = Convert.ToDouble(txba1.Text);
                a2 = Convert.ToDouble(txba2.Text);
                b1 = Convert.ToDouble(txbb1.Text);
                b2 = Convert.ToDouble(txbb2.Text);
                c1 = Convert.ToDouble(txbc1.Text);
                c2 = Convert.ToDouble(txbc2.Text);
                d = (a1 * b2) - (a2 * b1);
                dx = (c1 * b2) - (c2 * b1);
                dy = (a1 * c2) - (a2 * c1);
                if (d != 0) 
                {
                    x = dx / d;
                    y = dy / d;
                    MessageBox.Show("Phương trình trên có nghiệm là:\nX = " + x + "\nY = " + y, "Kết Quả", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                if (dx == 0 && d == 0) 
                {
                    MessageBox.Show("Phương trình vô số nghiệm!", "Kết Quả", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                if (d == 0 && dx != 0) 
                {
                    MessageBox.Show("Phương trình trên vô nghiệm!", "Kết Quả", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
            }
            else 
            {
                MessageBox.Show("Bạn chưa nhập đủ các hệ số!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

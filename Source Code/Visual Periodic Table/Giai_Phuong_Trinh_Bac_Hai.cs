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
    public partial class Giai_Phuong_Trinh_Bac_Hai : Form
    {
        public Giai_Phuong_Trinh_Bac_Hai()
        {
            InitializeComponent();
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnce_Click(object sender, EventArgs e)
        {
            txba.Text = "";
            txbb.Text = "";
            txbc.Text = "";
        }

        private void btngiai_Click(object sender, EventArgs e)
        {
            double a, b, c, delta, x1, x2;
            if (txba.Text != "" && txbb.Text != "" && txbc.Text != "")
            {
                a = Convert.ToDouble(txba.Text);
                b = Convert.ToDouble(txbb.Text);
                c = Convert.ToDouble(txbc.Text);
                if (a != 0)
                {
                    delta = (b * b) - (4 * a * c);
                    if (delta == 0)
                    {
                        x1 = -(b / (2 * a));
                        //x2 = -(b / (2 * a));
                        MessageBox.Show("Phương trình trên có nghiệm kép X1 = X2 = " + x1, "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.None);
                    }
                    if (delta < 0)
                    {
                        MessageBox.Show("Phương trình trên vô nghiệm!", "Kết Quả", MessageBoxButtons.OK, MessageBoxIcon.None);
                    }
                    if (delta > 0)
                    {
                        x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                        x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                        MessageBox.Show("Nghiệm của phương trình trên là.\nX1 = " + x1 + "\nX2 = " + x2, "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.None);
                    }
                }
                else
                {
                    MessageBox.Show("Dữ kiện bạn nhập không hợp lệ!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else 
            {
                MessageBox.Show("Bạn chưa nhập đủ các hệ số!!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}

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
    public partial class Giai_Phuong_Trinh_Bac_Nhat : Form
    {
        public Giai_Phuong_Trinh_Bac_Nhat()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btntrangchinh_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btngiai_Click(object sender, EventArgs e)
        {
            double a, b, x;
            a = Convert.ToDouble(txba.Text);
            b = Convert.ToDouble(txbb.Text);
            if (a != 0) 
            {
                x = -(b / a);
                MessageBox .Show ("Nghiệm của phương trình trên là x = "+x,"Kết quả",MessageBoxButtons .OK ,MessageBoxIcon .None );
            }
            else 
            {
                MessageBox .Show ("Nhập không hợp lệ! Vui lòng nhập lại","Cảnh Báo",MessageBoxButtons .OK ,MessageBoxIcon .Error );
            }
        }

        private void btnce_Click(object sender, EventArgs e)
        {
            txba.Text = "";
            txbb.Text = "";
           // MessageBox.Show("" + Math.Sqrt(5) + "Thông báo");
        }
    }
}

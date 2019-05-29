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
    public partial class Cai_Dat : Form
    {
        public Cai_Dat()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (rdbDo.Checked == true) 
            {
                fchinh fchinh = new fchinh();
                fchinh.BackColor = Color.Red;
                fchinh.pn7.BackColor = Color.Red;
                fchinh.ShowDialog();
                //this.Close();
            }
            if (rdbXanh.Checked == true) 
            {
                fchinh fchinh = new fchinh();
                fchinh.BackColor = Color.Green;
                fchinh.pn7.BackColor = Color.Green ;
                fchinh.ShowDialog();
            }
            if (rdbXam.Checked == true) 
            {
                fchinh fchinh = new fchinh();
                fchinh.BackColor = Color.Gray ;
                fchinh.pn7.BackColor = Color.Gray ;
                fchinh.ShowDialog();
            }
        }

        private void txbcochu_TextChanged(object sender, EventArgs e)
        {
           DialogResult Chon = MessageBox.Show("Xin lỗi!\nBạn Không Có Quyền Được Thực Hiện Hành Động Này!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
           if (Chon == DialogResult.OK)
           {
               txbcochu.Text = "Error";
               txbcochu.Enabled = false;
           }
        }

        private void btnchuy_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tính năng thay đổi cài đặt gốc trên phần mềm này chỉ có hiệu lực trong thời gian bạn tương tác với phần mềm!", "Chú Ý");
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

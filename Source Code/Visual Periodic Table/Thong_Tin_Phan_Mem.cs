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
    public partial class Thong_Tin_Phan_Mem : Form
    {
        public Thong_Tin_Phan_Mem()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void btnquocthinh_Click(object sender, EventArgs e)
        {
            Process.Start ("http://quocthinhvo.wordpress.com");
        }

        private void btnthongtinthem_Click(object sender, EventArgs e)
        {
            MessageBox .Show ("Phần mềm Visual Periodic Table là phần mềm hỗ trợ học tốt môn hóa học\nPhần mềm là bảng tuần hoàn được sắp xếp sinh động trực quan(vì thế nên có tên là Visual Perioidic Table)\nCác hình ảnh nguyên tố được lấy từ: http://images-ofelements.com \nTrong phần mềm có sử dụng các thông tin các nguyên tố được sưu tầm từ Wikipedia và vài nguồn khác.\nPhần mềm đang trong thời kì phát triển nên sẽ có những sai sót. Mọi ý kiến đóng góp xin gửi về quocthinhvo0@gmail.com.\nCảm ơn các bạn!","Thông tin thêm");
        }
    }
}

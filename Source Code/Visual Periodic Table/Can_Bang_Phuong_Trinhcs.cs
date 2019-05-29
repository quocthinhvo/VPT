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
    public partial class Can_Bang_Phuong_Trinhcs : Form
    {
        public Can_Bang_Phuong_Trinhcs()
        {
            InitializeComponent();
        }

        private void Can_Bang_Phuong_Trinhcs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBVPTDataSet2.PHUONGTRINH' table. You can move, or remove it, as needed.
            this.pHUONGTRINHTableAdapter.Fill(this.dBVPTDataSet2.PHUONGTRINH);
           
        }

        private void btncanbang_Click(object sender, EventArgs e)
        {
            lbxketqua.Items.Clear();
            rtbdieukien.Text = "";
            if (txbchat.Text != "")
            {
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    if (dataGridView1.Rows[i].Cells[0].Value.ToString() == txbchat.Text)
                    {
                        lbxketqua.Items.Add(dataGridView1.Rows[i].Cells[1].Value.ToString());
                        rtbdieukien.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
                    }
                 //   break;
                }
                if (lbxketqua .Items .Count == 0)
                {
                    DialogResult suli = MessageBox.Show("Xin lỗi! Chúng tôi không tìm thấy phương trình mà bạn nhập!\nVui lòng kiểm tra lại chất tham gia phản ứng và thử lại!\nBạn có muốn xem hướng dẫn cân bằng phương trình không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    txbchat.Text = "";
                    if (suli == DialogResult.Yes)
                    {
                        //MessageBox.Show("Để sử dụng tính năng này bạn cần nhập chất tham gia phản ứng.\n*Lưu Ý: Bạn cần nhập đúng kí hiệu của nguyên tố hóa học, chú ý chữ in hoa và chữ thường vì chúng tôi có phân biệt chữ hoa và chữ thường!\nSau đó nhấp Enter hoặc Click vào nút cân bằng đê tiến hành quá trình cân bằng!", "Hướng dẫn sử dụng tính năng cân bằng phương trình", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Video_Huong_Dan f = new Video_Huong_Dan();
                        f.Show();
                    }
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập chất tham gia phản ứng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            lbxketqua.Items.Clear();
            txbchat.Text = "";
            rtbdieukien.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

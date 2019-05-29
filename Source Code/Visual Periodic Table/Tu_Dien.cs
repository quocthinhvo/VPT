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
    public partial class Tu_Dien : Form
    {
        public Tu_Dien()
        {
            InitializeComponent();
        }

        private void Tu_Dien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBVPTDataSet3.TU_DIEN_HOA' table. You can move, or remove it, as needed.
            this.tU_DIEN_HOATableAdapter.Fill(this.dBVPTDataSet3.TU_DIEN_HOA);
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btntim_Click(object sender, EventArgs e)
        {
            rtbchay.Text = "";
            rtbdoc.Text = "";
            rtbhoa.Text = "";
            rtbkihieu.Text = "";
            rtbsoi.Text = "";
            rtbungdung.Text = "";
            if (txbnhap.Text != "")
            {
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    if (txbnhap.Text == dataGridView1.Rows[i].Cells[0].Value.ToString())
                    {
                        rtbkihieu.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
                        rtbdoc.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
                        rtbsoi.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
                        rtbchay.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
                        rtbhoa.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
                        rtbungdung.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
                    }
                }
                if (rtbkihieu.Text == "")
                {
                    DialogResult chon = MessageBox.Show("Chúng tôi khôn tìm thấy chất mà bạn nhập! Vui lòng kiểm tra và thử lại!\nBạn có muốn xem video hướng dẫn không?", "Cảnh báo", MessageBoxButtons.OKCancel , MessageBoxIcon.Error);
                    if (chon == DialogResult.OK)
                    {
                        Video_Huong_Dan f = new Video_Huong_Dan();
                        f.ShowDialog();
                    }
                    txbnhap.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

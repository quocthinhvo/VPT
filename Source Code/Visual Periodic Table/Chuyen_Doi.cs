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
    public partial class Chuyen_Doi : Form
    {
       
        public Chuyen_Doi()
        {
            InitializeComponent();
        }

        private void rtbvao_TextChanged(object sender, EventArgs e)
        {
           
        }

      

        private void Chuyen_Doi_Load(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string chon = listBox1.SelectedItem.ToString();
            if (rtbvao.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ dữ kiện!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                double vao = Convert.ToDouble(rtbvao.Text);
                if (chon == "cm-->In")
                {
                    double ra = vao / 2.54;
                    rtbra.Text = ra.ToString();
                }
                if (chon == "In-->cm")
                {
                    double ra = vao * 2.54;
                    rtbra.Text = ra.ToString();
                }
                if (chon == "kW.h-->J")
                {
                    double ra = vao * 3600000;
                    rtbra.Text = ra.ToString();
                }
                if (chon == "J-->kW.h")
                {
                    double ra = vao / 3600000;
                    rtbra.Text = ra.ToString();
                }
                if (chon == "km/h-->m/s")
                {
                    double ra = vao / 3.6;
                    rtbra.Text = ra.ToString();
                }
                if (chon == "m/s-->km/h")
                {
                    double ra = vao * 3.6;
                    rtbra.Text = ra.ToString();
                }
                if (chon == "'C-->'F")
                {
                    double ra = vao * 33.8;
                    rtbra.Text = ra.ToString();
                }
                if (chon == "'F-->'C")
                {
                    double ra = vao / 33.8;
                    rtbra.Text = ra.ToString();
                }
                if (chon == "J-->Calo")
                {
                    double ra = vao * 0.24;
                    rtbra.Text = ra.ToString();
                }
                if (chon == "Calo-->Jun")
                {
                    double ra = vao * 4.1858;
                    rtbra.Text = ra.ToString();
                }
                if (chon == "atm-->Pa")
                {
                    double ra = vao * 101325;
                    rtbra.Text = ra.ToString(); 
                }
                if (chon == "Pa-->atm")
                {
                    double ra = vao / 101325;
                    rtbra.Text = ra.ToString();
                }
                if (chon == "m-->ft")
                {
                    double ra = vao * 3.28;
                    rtbra.Text = ra.ToString();
                }
                if (chon == "ft-->m")
                {
                    double ra = vao * 0.3048;
                    rtbra.Text = ra.ToString();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rtbvao.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            rtbvao.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            rtbvao.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            rtbvao.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            rtbvao.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            rtbvao.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            rtbvao.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            rtbvao.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            rtbvao.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            rtbvao.Text = "";
            rtbra.Text = "";
            button11.Enabled = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (rtbvao.Text == "")
            {
                rtbvao.Text = "0.";
                button11.Enabled = false;
            }
            else
            {
                rtbvao.Text += ".";
                button11.Enabled = false;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

namespace Visual_Periodic_Table
{
    public partial class fchinh : Form
    {
        public fchinh()
        {
            Thread t = new Thread(new ThreadStart(FormChaoMung));
            t.Start();
           Thread.Sleep(500);
            InitializeComponent();
           t.Abort();
        }

        private void btbe_Click(object sender, EventArgs e)
        {
            Thong_Tin_Nguyen_To f = new Thong_Tin_Nguyen_To();
            f.Show();
            f.pictureBox1.Image = new Bitmap(Application.StartupPath + "\\Resources\\beryllium.jpg");
            f.lbkihieu.Text = "Be";
            f.lbtennguyento.Text = "Beri";
            f.lbloai.Text = "KIM LOẠI KIỀM THỔ";
            f.lbtenlatin.Text = "Tên Latin: Beryllium";
            f.lbtenanh.Text = "Tên Tiếng Anh: Beryllium";
            f.lbnam.Text = "Năm khám phá: 1797";
            f.lbnguoi.Text = "Người khám phá: Louis-Nicolas Vayquelin";
            f.lbcas.Text = "CAS số: CAS7440-41-7";
            f.lbvo.Text = "Vỏ điện tử: K2 L2";
            f.lbsongtu.Text = "Số nguyên tử: 4";
            f.lbmol.Text = "9.0121 g/mol";
            f.lbnguyentukhoi.Text = "Nguyên tử khối: 9.0121 (g/mol)";
            f.lbmatdo.Text = "Mật độ: 1.848 (g/cm3)";
            f.lbsoi.Text = "Điểm sôi: 2970 'C";
            f.lbnongchay.Text = "Điểm nóng chảy: 1278 'C";
            f.lbdientro.Text = "Điện trở: 4.10^-8";
            f.lbcauhinh.Text = "Cấu hình điện tử: [He]2s2 1s2 2s2";
            f.lbhoatri.Text = "Hóa trị: +1, +2";
            f.lbtiemnang.Text = "Tiềm năng Ion hóa: 9.50";
            f.lbbankinh.Text = "Bán kính nguyên tử: 112 pm";
            f.lbbankinhvan.Text = "Bán kính Van der Waals: 153 pm";
            f.lbamdien.Text = "Điện âm: 1.57";
            f.lbhoatriphanung.Text = "Hóa trị: +2";
            f.lbelectron.Text = "Electron mối quan hệ: 0 kJ/mole";
            f.lbvutru.Text = "Tỉ lệ có trong vũ trụ: 1.10^-7 %";
            f.lbvotraidat.Text = "Tỉ lệ có trong vỏ Trái Đất: 0.00019 %";
            f.lbconnguoi.Text = "Tỉ lệ trong cơ thể người: 4.10^-8 %";
            f.lblienket.Text = "Liên kết cộng hóa trị bán kính: 90pm"; 
        } //Beri

        private void bth_Click(object sender, EventArgs e)
        {
            Thong_Tin_Nguyen_To f = new Thong_Tin_Nguyen_To();
            f.Show();
            f.pictureBox1.Image = new Bitmap(Application.StartupPath + "\\Image Of Visual Periodic Table\\H.jpg");
            f.lbkihieu.Text = "H";
            f.lbtennguyento.Text = "Hyđrô";
            f.lbloai.Text = "PHI KIM KHÁC";
            f.lbmol.Text = "1.0079 g/mol";
            f.lbtenlatin.Text = "Tên Latin: Hydrogenium";
            f.lbtenanh.Text = "Tên tiếng Anh: Hydrogen";
            f.lbnam.Text = "Năm khám phá: 1766";
            f.lbnguoi.Text = "Người khám phá: Henry Cavendish";
            f.lbcas.Text = "CAS số: CAS1333-74-0";
            f.lbsongtu.Text = "Số nguyên tử: 1";
            f.lbnguyentukhoi.Text = "Nguyên tử khối: 1.0079 (g/mol)";
            f.lbmatdo.Text = "Mật độ: 0.0000899 (g/cm3)";
            f.lbnongchay.Text = "Điểm nóng chảy: -259.1 'C";
            f.lbsoi.Text = "Điểm sôi: -252.9 'C";
            f.lbcauhinh.Text = "Cấu hình điện tử: 1s1";
            f.lbhoatri.Text = "Hóa trị; -1 +1";
            f.lbtiemnang.Text = "Tiềm năng Ion hóa: 13.53";
            f.lbelectron.Text = "Electron mỗi vỏ: K1";
            f.lbbankinh.Text = "Bán kính nguyên tử: 25 pm";
            f.lbbankinhvan.Text = "Bán kính Van dẻ Waals: 120 pm";
            f.lbamdien.Text = "Âm điện: 2.2";
            f.lbhoatriphanung.Text = "Hóa trị: (-1), +1";
            f.lbelectron.Text = "Electron mối quan hệ: 72.8 kJ/mole";
            f.lbdientro.Text = "Điện trở: --*--";
            f.lbvotraidat.Text = "Tỉ lệ có trong voe Trái Đất: 0.15%";
            f.lblienket.Text = "Liên kết cộng hóa trị bán kính: 38 pm";
            f.lbvutru.Text = "Tỉ lệ có trong vũ trụ: 75%";
            f.lbconnguoi.Text = "Tỉ lệ trong con người: 10%";
        } //hidro

        private void bthe_Click(object sender, EventArgs e)
        {
            Thong_Tin_Nguyen_To f = new Thong_Tin_Nguyen_To();
            f.Show();
            f.pictureBox1.Image = new Bitmap(Application.StartupPath + "\\Image Of Visual Periodic Table\\helium.jpg");
            f.lbkihieu.Text = "He";
            f.lbtennguyento.Text = "Heli";
            f.lbloai.Text = "KHÍ TRƠ";
            f.lbmol.Text = "4.0026 (g/mol)";
            f.lbtenlatin.Text = "Tên Latin: Helium";
            f.lbtenanh.Text = "Tên tiếng Anh: Helium";
            f.lbnam.Text = "Năm khám phá: 1895";
            f.lbnam.Text = "Người khám phá: Pierre Jules César Janssen, Joseph Norman Lockyer";
            f.lbvo.Text = "Vỏ điện tử: K2";
            f.lbsongtu.Text = "Số nguyên tử: 2";
            f.lbnguyentukhoi.Text = "Nguyên tử khối: 4.0026 (g/mol)";
            f.lbmatdo.Text = "Mật độ: 0.00017846";
            f.lbnongchay.Text = "Điểm nóng chảy: -272.2'C";
            f.lbsoi.Text = "Điểm sôi: -268.9'C";
            f.lbcauhinh.Text = "Cấu hình điện tử: 1s2";
            f.lbhoatri.Text = "Hóa trị:--*--";
            f.lbtiemnang.Text = "Tiềm năng Ion hóa của nguyên tử: 24.47";
            f.lbelectron.Text = "Electron mỗi vỏ: K2";
            f.lbbankinh.Text = "Bán kính nguyên tử: 31 pm";
            f.lbbankinhvan.Text = "Bán kính Van Der Waals: 140 pm";
            f.lbamdien.Text = "Âm điện: --*--";
            f.lbhoatriphanung.Text = "Hóa trị: 0";
            f.lbelectron.Text = "Electron mối quan hệ: 0 kJ/mole";
            f.lbvotraidat.Text = "Tỉ lệ có trong vỏ Trái Đất: 5.5x10^-7 %";
            f.lbvutru.Text = "Tỉ lệ có trong vũ trụ: 23%";
            f.lbconnguoi.Text = "Tỉ lệ có trong con người: --*-- %";
            f.lblienket.Text = "Liên kết cộng hóa trị bán kính: 32 pm";
            f.lbdientro.Text = "Điện trở: --*--";
           
        } //he

        private void bili_Click(object sender, EventArgs e)
        {
            Thong_Tin_Nguyen_To f = new Thong_Tin_Nguyen_To();
            f.Show();
            f.pictureBox1.Image = new Bitmap(Application.StartupPath + "\\Image Of Visual Periodic Table\\lithium.jpg");
            f.lbkihieu.Text = "Li";
            f.lbtennguyento.Text = "Lithi";
            f.lbmol.Text = "6.941 (g/mol)";
            f.lbloai.Text = "KIÊM LOẠI KIỀM";
            f.lbtenlatin.Text = "Tên Latin: Lithium";
            f.lbtenanh.Text = "Tên tiếng Anh: Lithium";
            f.lbnam.Text = "Năm khám phá: 1817";
            f.lbnguoi.Text = "Người khám phá: Johan August Arfwedson";
            f.lbvo.Text = "Vỏ điện tử: K2 L1";
            f.lbcas.Text = "CAS số: CAS7439-93-2";
            f.lbsongtu.Text = "Số nguyên tử: 3";
            f.lbnguyentukhoi.Text = "Nguyên tử khối; 6.941 (g/mol)";
            f.lbmatdo.Text = "Mật độ: 0.534 (g/cm3)";
            f.lbnongchay.Text = "Điểm nóng chảy: 180.5 'C";
            f.lbsoi.Text = "Điểm sôi: 1342 'C";
            f.lbcauhinh.Text = "Cấu hình điện tử: [He]2s1 1s2 2s1";
            f.lbhoatri.Text = "Hóa trị: +1";
            f.lbtiemnang.Text = "Tiềm năng Ion hóa của nguyên tử: 5.37";
            f.lbbankinh.Text = "Bán kính nguyên tử: 145 pm";
            f.lbbankinhvan.Text = "Bán kính Van der Waals: 182 pm";
            f.lbamdien.Text = "Âm điện: 0.98";
            f.lbhoatriphanung.Text = "Hóa trị: +1";
            f.lbelectron.Text = "Electron mối quan hệ: 59.6 kJ/mole";
            f.lbdientro.Text = "Điện trở: 9.4x10^-8";
            f.lbvotraidat.Text = " Tỉ lệ có trong vỏ Trái Đất: 0.0017%";
            f.lbconnguoi.Text = "Tỉ lệ có trong con người: 3x10^-6%";
            f.lbvutru.Text = "Tỉ lệ có trong vũ trụ: 6x10^-7 %";
            f.lblienket.Text = "Liên kết cộng hóa trị bán kính: 134 pm";
        } //liti

        private void btb_Click(object sender, EventArgs e)
        {

            Thong_Tin_Nguyen_To f = new Thong_Tin_Nguyen_To();
            f.Show();
            f.pictureBox1.Image = new Bitmap(Application.StartupPath + "\\Image Of Visual Periodic Table\\boron.jpg");
            f.lbkihieu.Text = "B";
            f.lbtennguyento.Text = "Bo";
            f.lbmol.Text = "10.811 (g/mol)";
            f.lbloai.Text = "Á KIÊM";
            f.lbtenlatin.Text = "Tên Latin: Borum";
            f.lbtenanh.Text = "Tên tiếng Anh: Boron";
            f.lbnam.Text = "Năm khám phá: 1808";
            f.lbnguoi.Text = "Người khám phá: Joseph Louis Gay-Lussac";
            f.lbvo.Text = "Vỏ điện tử: K2 L3";
            f.lbcas.Text = "CAS số: CAS7440-42-8";
            f.lbsongtu.Text = "Số nguyên tử: 5";
            f.lbnguyentukhoi.Text = "Nguyên tử khối; 10.811 (g/mol)";
            f.lbmatdo.Text = "Mật độ: 2.34 (g/cm3)";
            f.lbnongchay.Text = "Điểm nóng chảy: 2075 'C";
            f.lbsoi.Text = "Điểm sôi: 3865 'C";
            f.lbcauhinh.Text = "Cấu hình điện tử: [He]2s2 2p1 1s2 2s2 2p1";
            f.lbhoatri.Text = "Hóa trị: +3, -3";
            f.lbtiemnang.Text = "Tiềm năng Ion hóa của nguyên tử: 8.33";
            f.lbbankinh.Text = "Bán kính nguyên tử: 98 pm";
            f.lbbankinhvan.Text = "Bán kính Van der Waals: 192 pm";
            f.lbamdien.Text = "Âm điện: 2.04";
            f.lbhoatriphanung.Text = "Hóa trị: +3, -3";
            f.lbelectron.Text = "Electron mối quan hệ: 26.7 kJ/mole";
            f.lbdientro.Text = "Điện trở: 10000";
            f.lbvotraidat.Text = " Tỉ lệ có trong vỏ Trái Đất: 0.00086 %";
            f.lbconnguoi.Text = "Tỉ lệ có trong con người: 0.00007 %";
            f.lbvutru.Text = "Tỉ lệ có trong vũ trụ: 1x10^-7 %";
            f.lblienket.Text = "Liên kết cộng hóa trị bán kính: 82 pm";
        } //bo

        private void btc_Click(object sender, EventArgs e)
        {

            Thong_Tin_Nguyen_To f = new Thong_Tin_Nguyen_To();
            f.Show();
            f.pictureBox1.Image = new Bitmap(Application.StartupPath + "\\Image Of Visual Periodic Table\\carbon.jpg");
            f.lbkihieu.Text = "C";
            f.lbtennguyento.Text = "Cacbon";
            f.lbmol.Text = "12.0107 (g/mol)";
            f.lbloai.Text = "PHI KIÊM KHÁC";
            f.lbtenlatin.Text = "Tên Latin: Carbonium (Carboneum)";
            f.lbtenanh.Text = "Tên tiếng Anh: Carbon";
            f.lbnam.Text = "Năm khám phá: 1791";
            f.lbnguoi.Text = "Người khám phá: Humphry Davy";
            f.lbvo.Text = "Vỏ điện tử: K2 L4";
            f.lbcas.Text = "CAS số: CAS7449-44-0";
            f.lbsongtu.Text = "Số nguyên tử: 6";
            f.lbnguyentukhoi.Text = "Nguyên tử khối; 12.0107 (g/mol)";
            f.lbmatdo.Text = "Mật độ: 2.26 (g/cm3)";
            f.lbnongchay.Text = "Điểm nóng chảy: 3550 'C";
            f.lbsoi.Text = "Điểm sôi: 4027 'C";
            f.lbcauhinh.Text = "Cấu hình điện tử: [He]2s2 2p2 1s2 2s2 2p2";
            f.lbhoatri.Text = "Hóa trị: +1, +2, +3, +4, -1, -2, -3, -4";
            f.lbtiemnang.Text = "Tiềm năng Ion hóa của nguyên tử: 11.22";
            f.lbbankinh.Text = "Bán kính nguyên tử: 77 pm";
            f.lbbankinhvan.Text = "Bán kính Van der Waals: 170 pm";
            f.lbamdien.Text = "Âm điện: 0.98";
            f.lbhoatriphanung.Text = "Hóa trị: +1, +2, +3, +4, -1, -2, -3, -4";
            f.lbelectron.Text = "Electron mối quan hệ: 153.9 kJ/mole";
            f.lbdientro.Text = "Điện trở: 1x10^-5";
            f.lbvotraidat.Text = " Tỉ lệ có trong vỏ Trái Đất: 0.18 %";
            f.lbconnguoi.Text = "Tỉ lệ có trong con người: 23 %";
            f.lbvutru.Text = "Tỉ lệ có trong vũ trụ: 0.5 %";
            f.lblienket.Text = "Liên kết cộng hóa trị bán kính: 77 pm";
        } //cacbon

        private void btn_Click(object sender, EventArgs e)
        {

            Thong_Tin_Nguyen_To f = new Thong_Tin_Nguyen_To();
            f.Show();
            f.pictureBox1.Image = new Bitmap(Application.StartupPath + "\\Image Of Visual Periodic Table\\nitrogen.jpg");
            f.lbkihieu.Text = "N";
            f.lbtennguyento.Text = "Nitơ";
            f.lbmol.Text = "14.0067 (g/mol)";
            f.lbloai.Text = "PHI KIÊM KHÁC";
            f.lbtenlatin.Text = "Tên Latin: Nitrogenium";
            f.lbtenanh.Text = "Tên tiếng Anh: Nitrogen";
            f.lbnam.Text = "Năm khám phá: 1772";
            f.lbnguoi.Text = "Người khám phá: Daniel Rutherford";
            f.lbvo.Text = "Vỏ điện tử: K2 L5";
            f.lbcas.Text = "CAS số: CAS7727-37-9";
            f.lbsongtu.Text = "Số nguyên tử: 7";
            f.lbnguyentukhoi.Text = "Nguyên tử khối; 14.0067 (g/mol)";
            f.lbmatdo.Text = "Mật độ: 0.001251 (g/cm3)";
            f.lbnongchay.Text = "Điểm nóng chảy: -209.9 'C";
            f.lbsoi.Text = "Điểm sôi: -195.8 'C";
            f.lbcauhinh.Text = "Cấu hình điện tử: [He]2s2 2p3 1s2 2s2 2p3";
            f.lbhoatri.Text = "Hóa trị: -1, -2, -3, +1, +2, +3, +4, +5";
            f.lbtiemnang.Text = "Tiềm năng Ion hóa của nguyên tử: 14.48";
            f.lbbankinh.Text = "Bán kính nguyên tử: 92 pm";
            f.lbbankinhvan.Text = "Bán kính Van der Waals: 155 pm";
            f.lbamdien.Text = "Âm điện: 3.04";
            f.lbhoatriphanung.Text = "Hóa trị: -1, -2, -3, +1, +2, +3, +4, +5";
            f.lbelectron.Text = "Electron mối quan hệ: 7 kJ/mole";
            f.lbdientro.Text = "Điện trở: --*--";
            f.lbvotraidat.Text = " Tỉ lệ có trong vỏ Trái Đất: 0.002 %";
            f.lbconnguoi.Text = "Tỉ lệ có trong con người: 2.6 %";
            f.lbvutru.Text = "Tỉ lệ có trong vũ trụ: 0.1 %";
            f.lblienket.Text = "Liên kết cộng hóa trị bán kính: 75 pm";
        } //nito

        private void fchinh_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void fchinh_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult tra_loi = MessageBox.Show("Bạn có chắc muốn thoát khỏi phần mềm?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information );
            if (tra_loi == DialogResult.Cancel ) 
            {
                //Application.Exit();
                e.Cancel = true;
            }
        }

        private void bto_Click(object sender, EventArgs e)
        {
            Thong_Tin_Nguyen_To f = new Thong_Tin_Nguyen_To();
            f.Show();
            f.pictureBox1.Image = new Bitmap(Application.StartupPath + "\\Image Of Visual Periodic Table\\oxygen.jpg");
            f.lbkihieu.Text = "O";
            f.lbtennguyento.Text = "Oxy";
            f.lbmol.Text = "15.9994 (g/mol)";
            f.lbloai.Text = "PHI KIÊM KHÁC";
            f.lbtenlatin.Text = "Tên Latin: Oxygenium";
            f.lbtenanh.Text = "Tên tiếng Anh: Oxygen";
            f.lbnam.Text = "Năm khám phá: 1774";
            f.lbnguoi.Text = "Người khám phá: Joseph Priestley";
            f.lbvo.Text = "Vỏ điện tử: K2 L6";
            f.lbcas.Text = "CAS số: CAS7782-44-7";
            f.lbsongtu.Text = "Số nguyên tử: 8";
            f.lbnguyentukhoi.Text = "Nguyên tử khối; 15.9994 (g/mol)";
            f.lbmatdo.Text = "Mật độ: 0.00142879 (g/cm3)";
            f.lbnongchay.Text = "Điểm nóng chảy: -218.4 'C";
            f.lbsoi.Text = "Điểm sôi: -182.9 'C";
            f.lbcauhinh.Text = "Cấu hình điện tử: [He]2s2 2p4 1s2 2s2 2p4";
            f.lbhoatri.Text = "Hóa trị: -1, -2, +1, +2";
            f.lbtiemnang.Text = "Tiềm năng Ion hóa của nguyên tử: 13.56";
            f.lbbankinh.Text = "Bán kính nguyên tử: 60 pm";
            f.lbbankinhvan.Text = "Bán kính Van der Waals: 152 pm";
            f.lbamdien.Text = "Âm điện: 3.44";
            f.lbhoatriphanung.Text = "Hóa trị: -1, -2, +1, +2";
            f.lbelectron.Text = "Electron mối quan hệ: 141 kJ/mole";
            f.lbdientro.Text = "Điện trở: --*--";
            f.lbvotraidat.Text = " Tỉ lệ có trong vỏ Trái Đất: 46 %";
            f.lbconnguoi.Text = "Tỉ lệ có trong con người: 61 %";
            f.lbvutru.Text = "Tỉ lệ có trong vũ trụ: 1 %";
            f.lblienket.Text = "Liên kết cộng hóa trị bán kính: 73 pm";
        } //oxy 

        private void btf_Click(object sender, EventArgs e)
        {
            Thong_Tin_Nguyen_To f = new Thong_Tin_Nguyen_To();
            f.Show();
            f.pictureBox1.Image = new Bitmap(Application.StartupPath + "\\Image Of Visual Periodic Table\\fluorine.jpg");
            f.lbkihieu.Text = "F";
            f.lbtennguyento.Text = "Flo";
            f.lbmol.Text = "18.9984 (g/mol)";
            f.lbloai.Text = "HALOGEN";
            f.lbtenlatin.Text = "Tên Latin: Fluorum";
            f.lbtenanh.Text = "Tên tiếng Anh: Fluorine";
            f.lbnam.Text = "Năm khám phá: 1886";
            f.lbnguoi.Text = "Người khám phá: Ferdinand Frederic Henri Moissan";
            f.lbvo.Text = "Vỏ điện tử: K2 L7";
            f.lbcas.Text = "CAS số: CAS7782-41-4";
            f.lbsongtu.Text = "Số nguyên tử: 9";
            f.lbnguyentukhoi.Text = "Nguyên tử khối; 18.9984 (g/mol)";
            f.lbmatdo.Text = "Mật độ: 0.001696 (g/cm3)";
            f.lbnongchay.Text = "Điểm nóng chảy: -219.7 'C";
            f.lbsoi.Text = "Điểm sôi: -188.1 'C";
            f.lbcauhinh.Text = "Cấu hình điện tử: [He]2s2 2p5 1s2 2s2 2p5";
            f.lbhoatri.Text = "Hóa trị: -1";
            f.lbtiemnang.Text = "Tiềm năng Ion hóa của nguyên tử: 18.6";
            f.lbbankinh.Text = "Bán kính nguyên tử: 73 pm";
            f.lbbankinhvan.Text = "Bán kính Van der Waals: 147 pm";
            f.lbamdien.Text = "Âm điện: 3.98";
            f.lbhoatriphanung.Text = "Hóa trị: -1";
            f.lbelectron.Text = "Electron mối quan hệ: 328 kJ/mole";
            f.lbdientro.Text = "Điện trở: --*--";
            f.lbvotraidat.Text = " Tỉ lệ có trong vỏ Trái Đất: 0.54 %";
            f.lbconnguoi.Text = "Tỉ lệ có trong con người: 0.0037 %";
            f.lbvutru.Text = "Tỉ lệ có trong vũ trụ: 0.00004 %";
            f.lblienket.Text = "Liên kết cộng hóa trị bán kính: 71 pm";
        } //flo

        private void btne_Click(object sender, EventArgs e)
        {
            Thong_Tin_Nguyen_To f = new Thong_Tin_Nguyen_To();
            f.Show();
            f.pictureBox1.Image = new Bitmap(Application.StartupPath + "\\Image Of Visual Periodic Table\\neon.jpg");
            f.lbkihieu.Text = "Ne";
            f.lbtennguyento.Text = "Neon";
            f.lbmol.Text = "20.1797 (g/mol)";
            f.lbloai.Text = "KHÍ TRƠ";
            f.lbtenlatin.Text = "Tên Latin: Neon";
            f.lbtenanh.Text = "Tên tiếng Anh: Neon";
            f.lbnam.Text = "Năm khám phá: 1898";
            f.lbnguoi.Text = "Người khám phá: Sir William Ramsay";
            f.lbvo.Text = "Vỏ điện tử: K2 L8";
            f.lbcas.Text = "CAS số: CAS744-01-9";
            f.lbsongtu.Text = "Số nguyên tử: 10";
            f.lbnguyentukhoi.Text = "Nguyên tử khối; 20.1797 (g/mol)";
            f.lbmatdo.Text = "Mật độ: 0.0009002 (g/cm3)";
            f.lbnongchay.Text = "Điểm nóng chảy: -248.6 'C";
            f.lbsoi.Text = "Điểm sôi: -246.1 'C";
            f.lbcauhinh.Text = "Cấu hình điện tử: [He]2s2 2p6 1s2 2s2 2p6";
            f.lbhoatri.Text = "Hóa trị: --*--";
            f.lbtiemnang.Text = "Tiềm năng Ion hóa của nguyên tử: 21.47";
            f.lbbankinh.Text = "Bán kính nguyên tử: 38 pm";
            f.lbbankinhvan.Text = "Bán kính Van der Waals: 154 pm";
            f.lbamdien.Text = "Âm điện: --*--";
            f.lbhoatriphanung.Text = "Hóa trị: -1, -2, +1, +2";
            f.lbelectron.Text = "Electron mối quan hệ: 0 kJ/mole";
            f.lbdientro.Text = "Điện trở: --*--";
            f.lbvotraidat.Text = " Tỉ lệ có trong vỏ Trái Đất: 3x10^-7 %";
            f.lbconnguoi.Text = "Tỉ lệ có trong con người: --*-- %";
            f.lbvutru.Text = "Tỉ lệ có trong vũ trụ: 0.13 %";
            f.lblienket.Text = "Liên kết cộng hóa trị bán kính: 69 pm";
        } //neon

        private void btmg_Click(object sender, EventArgs e)
        {
            Thong_Tin_Nguyen_To f = new Thong_Tin_Nguyen_To();
            f.Show();
            f.pictureBox1.Image = new Bitmap(Application.StartupPath + "\\Image Of Visual Periodic Table\\Magnesium.jpg");
            f.lbkihieu.Text = "Mg";
            f.lbtennguyento.Text = "Magiê";
            f.lbmol.Text = "24.3050 (g/mol)";
            f.lbloai.Text = "KIM LOẠI KIỀM THỔ";
            f.lbtenlatin.Text = "Tên Latin: Magnesium";
            f.lbtenanh.Text = "Tên tiếng Anh: Magnesium";
            f.lbnam.Text = "Năm khám phá: 1755";
            f.lbnguoi.Text = "Người khám phá: Joseph Black";
            f.lbvo.Text = "Vỏ điện tử: K2 L8 M2";
            f.lbcas.Text = "CAS số: CAS7439-95-4";
            f.lbsongtu.Text = "Số nguyên tử: 12";
            f.lbnguyentukhoi.Text = "Nguyên tử khối; 24.3050 (g/mol)";
            f.lbmatdo.Text = "Mật độ: 1.738 (g/cm3)";
            f.lbnongchay.Text = "Điểm nóng chảy: 650 'C";
            f.lbsoi.Text = "Điểm sôi: 1090 'C";
            f.lbcauhinh.Text = "Cấu hình điện tử: [Ne]3s2 1s2 2s2 2p6 3s2";
            f.lbhoatri.Text = "Hóa trị: +1, +2";
            f.lbtiemnang.Text = "Tiềm năng Ion hóa của nguyên tử: 7.61";
            f.lbbankinh.Text = "Bán kính nguyên tử: 160 pm";
            f.lbbankinhvan.Text = "Bán kính Van der Waals: 173 pm";
            f.lbamdien.Text = "Âm điện: 1.31";
            f.lbhoatriphanung.Text = "Hóa trị: +2";
            f.lbelectron.Text = "Electron mối quan hệ: 0 kJ/mole";
            f.lbdientro.Text = "Điện trở: 4.4x10^-8";
            f.lbvotraidat.Text = " Tỉ lệ có trong vỏ Trái Đất: 46 %";
            f.lbconnguoi.Text = "Tỉ lệ có trong con người: 61 %";
            f.lbvutru.Text = "Tỉ lệ có trong vũ trụ: 1 %";
            f.lblienket.Text = "Liên kết cộng hóa trị bán kính: 130 pm";
        } //magie

        private void btna_Click(object sender, EventArgs e)
        {
            Thong_Tin_Nguyen_To f = new Thong_Tin_Nguyen_To();
            f.Show();
            f.pictureBox1.Image = new Bitmap(Application.StartupPath + "\\Image Of Visual Periodic Table\\sodium.jpg");
            f.lbkihieu.Text = "Na";
            f.lbtennguyento.Text = "Natri";
            f.lbmol.Text = "22.9876 (g/mol)";
            f.lbloai.Text = "KIM LOẠI KIỀM";
            f.lbtenlatin.Text = "Tên Latin: Natrium";
            f.lbtenanh.Text = "Tên tiếng Anh: Sodium";
            f.lbnam.Text = "Năm khám phá: 1807";
            f.lbnguoi.Text = "Người khám phá: Humphry Davy";
            f.lbvo.Text = "Vỏ điện tử: K2 L8 M1";
            f.lbcas.Text = "CAS số: CAS7440-23-5";
            f.lbsongtu.Text = "Số nguyên tử: 11";
            f.lbnguyentukhoi.Text = "Nguyên tử khối; 22.9876 (g/mol)";
            f.lbmatdo.Text = "Mật độ: 0.971 (g/cm3)";
            f.lbnongchay.Text = "Điểm nóng chảy: 97.8 'C";
            f.lbsoi.Text = "Điểm sôi: 882.95 'C";
            f.lbcauhinh.Text = "Cấu hình điện tử: [Ne]3s1 1s2 2s2 2p6 3s1";
            f.lbhoatri.Text = "Hóa trị: -1, +1";
            f.lbtiemnang.Text = "Tiềm năng Ion hóa của nguyên tử: 5.12";
            f.lbbankinh.Text = "Bán kính nguyên tử: 190 pm";
            f.lbbankinhvan.Text = "Bán kính Van der Waals: 227 pm";
            f.lbamdien.Text = "Âm điện: 0.93";
            f.lbhoatriphanung.Text = "Hóa trị: -1, +1";
            f.lbelectron.Text = "Electron mối quan hệ: 52.8 kJ/mole";
            f.lbdientro.Text = "Điện trở: 4.7x10^-8";
            f.lbvotraidat.Text = " Tỉ lệ có trong vỏ Trái Đất: 2.3 %";
            f.lbconnguoi.Text = "Tỉ lệ có trong con người: 0.14 %";
            f.lbvutru.Text = "Tỉ lệ có trong vũ trụ: 0.002 %";
            f.lblienket.Text = "Liên kết cộng hóa trị bán kính: 154 pm";
        } //natri

        private void btal_Click(object sender, EventArgs e)
        {
            Thong_Tin_Nguyen_To f = new Thong_Tin_Nguyen_To();
            f.Show();
            f.pictureBox1.Image = new Bitmap(Application.StartupPath + "\\Image Of Visual Periodic Table\\Aluminium-4.jpg");
            f.lbkihieu.Text = "Al";
            f.lbtennguyento.Text = "Nhôm";
            f.lbmol.Text = "26.9815 (g/mol)";
            f.lbloai.Text = "CHẤT BÁN DẪN";
            f.lbtenlatin.Text = "Tên Latin: Aluminium";
            f.lbtenanh.Text = "Tên tiếng Anh: Aluminium";
            f.lbnam.Text = "Năm khám phá: 1825";
            f.lbnguoi.Text = "Người khám phá: Hans Christian";
            f.lbvo.Text = "Vỏ điện tử: K2 L8 M3";
            f.lbcas.Text = "CAS số: CAS7429-90-5";
            f.lbsongtu.Text = "Số nguyên tử: 13";
            f.lbnguyentukhoi.Text = "Nguyên tử khối; 28.9815 (g/mol)";
            f.lbmatdo.Text = "Mật độ: 2.6989 (g/cm3)";
            f.lbnongchay.Text = "Điểm nóng chảy: 660 'C";
            f.lbsoi.Text = "Điểm sôi: 2518.82 'C";
            f.lbcauhinh.Text = "Cấu hình điện tử: [Ne]3s2 3p1 1s2 2s2 2p6 3s2 3p1";
            f.lbhoatri.Text = "Hóa trị: -1, -2, +1, +2, +3";
            f.lbtiemnang.Text = "Tiềm năng Ion hóa của nguyên tử: 5.95";
            f.lbbankinh.Text = "Bán kính nguyên tử: 143 pm";
            f.lbbankinhvan.Text = "Bán kính Van der Waals: 184 pm";
            f.lbamdien.Text = "Âm điện: 1.61";
            f.lbhoatriphanung.Text = "Hóa trị: -1, -2, +1, +2, +3";
            f.lbelectron.Text = "Electron mối quan hệ: 42.5 kJ/mole";
            f.lbdientro.Text = "Điện trở: 2.6x10^-8";
            f.lbvotraidat.Text = " Tỉ lệ có trong vỏ Trái Đất: 8.1 %";
            f.lbconnguoi.Text = "Tỉ lệ có trong con người: 0.00009 %";
            f.lbvutru.Text = "Tỉ lệ có trong vũ trụ: 0.005 %";
            f.lblienket.Text = "Liên kết cộng hóa trị bán kính: 118 pm";
        } //nhôm

        private void btsi_Click(object sender, EventArgs e)
        {
            Thong_Tin_Nguyen_To f = new Thong_Tin_Nguyen_To();
            f.Show();
            f.pictureBox1.Image = new Bitmap(Application.StartupPath + "\\Image Of Visual Periodic Table\\silicon.jpg");
            f.lbkihieu.Text = "Si";
            f.lbtennguyento.Text = "Silic";
            f.lbmol.Text = "28.0855 (g/mol)";
            f.lbloai.Text = "Á KIÊM";
            f.lbtenlatin.Text = "Tên Latin: Silicium";
            f.lbtenanh.Text = "Tên tiếng Anh: Silicon";
            f.lbnam.Text = "Năm khám phá: 1824";
            f.lbnguoi.Text = "Người khám phá: Jons Jakob Berzelius";
            f.lbvo.Text = "Vỏ điện tử: K2 L8 M4";
            f.lbcas.Text = "CAS số: CAS7440-21-3";
            f.lbsongtu.Text = "Số nguyên tử: 14";
            f.lbnguyentukhoi.Text = "Nguyên tử khối; 28.0855 (g/mol)";
            f.lbmatdo.Text = "Mật độ: 2.33 (g/cm3)";
            f.lbnongchay.Text = "Điểm nóng chảy: 1414.85 'C";
            f.lbsoi.Text = "Điểm sôi: 2349.85 'C";
            f.lbcauhinh.Text = "Cấu hình điện tử: [Ne]3s2 3p2 1s2 2s2 2p6 3s2 3p2";
            f.lbhoatri.Text = "Hóa trị: -1, -2, -3, -4, +1, +2, +3, +4";
            f.lbtiemnang.Text = "Tiềm năng Ion hóa của nguyên tử: 8.12";
            f.lbbankinh.Text = "Bán kính nguyên tử: 132 pm";
            f.lbbankinhvan.Text = "Bán kính Van der Waals: 210 pm";
            f.lbamdien.Text = "Âm điện: 1.9";
            f.lbhoatriphanung.Text = "Hóa trị: -1, -2, -3, -4, +1, +2, +3, +4";
            f.lbelectron.Text = "Electron mối quan hệ: 133.6 kJ/mole";
            f.lbdientro.Text = "Điện trở: 0.001";
            f.lbvotraidat.Text = " Tỉ lệ có trong vỏ Trái Đất: 27 %";
            f.lbconnguoi.Text = "Tỉ lệ có trong con người: 0.026 %";
            f.lbvutru.Text = "Tỉ lệ có trong vũ trụ: 0.07 %";
            f.lblienket.Text = "Liên kết cộng hóa trị bán kính: 111 pm";
        } //silic

        private void btp_Click(object sender, EventArgs e)
        {
            Thong_Tin_Nguyen_To f = new Thong_Tin_Nguyen_To();
            f.Show();
            f.pictureBox1.Image = new Bitmap(Application.StartupPath + "\\Image Of Visual Periodic Table\\phosphorus.jpg");
            f.lbkihieu.Text = "P";
            f.lbtennguyento.Text = "Photpho";
            f.lbmol.Text = "30.9737 (g/mol)";
            f.lbloai.Text = "PHI KIÊM KHÁC";
            f.lbtenlatin.Text = "Tên Latin: Phosphorus";
            f.lbtenanh.Text = "Tên tiếng Anh: Phosphorus";
            f.lbnam.Text = "Năm khám phá: 1669";
            f.lbnguoi.Text = "Người khám phá: Hennij Brand";
            f.lbvo.Text = "Vỏ điện tử: K2 L8 M5";
            f.lbcas.Text = "CAS số: CAS7723-14-0";
            f.lbsongtu.Text = "Số nguyên tử: 15";
            f.lbnguyentukhoi.Text = "Nguyên tử khối; 30.9737 (g/mol)";
            f.lbmatdo.Text = "Mật độ: 2.82 (g/cm3)";
            f.lbnongchay.Text = "Điểm nóng chảy: 44.15 'C";
            f.lbsoi.Text = "Điểm sôi: 279.85 'C";
            f.lbcauhinh.Text = "Cấu hình điện tử: [Ne]3s2 3p3 1s2 2p6 3s2 3p3";
            f.lbhoatri.Text = "Hóa trị: -1, -2, -3, +1, +2, +3, +4, +5";
            f.lbtiemnang.Text = "Tiềm năng Ion hóa của nguyên tử: 10.3";
            f.lbbankinh.Text = "Bán kính nguyên tử: 128 pm";
            f.lbbankinhvan.Text = "Bán kính Van der Waals: 180 pm";
            f.lbamdien.Text = "Âm điện: 2.19";
            f.lbhoatriphanung.Text = "Hóa trị: -1, -2, -3, +1, +2, +3, +4, +5";
            f.lbelectron.Text = "Electron mối quan hệ: 72 kJ/mole";
            f.lbdientro.Text = "Điện trở: 1x10^-7";
            f.lbvotraidat.Text = " Tỉ lệ có trong vỏ Trái Đất: 0.099 %";
            f.lbconnguoi.Text = "Tỉ lệ có trong con người: 1.1 %";
            f.lbvutru.Text = "Tỉ lệ có trong vũ trụ: 0.0007 %";
            f.lblienket.Text = "Liên kết cộng hóa trị bán kính: 106 pm";
        } //photpho

        private void bts_Click(object sender, EventArgs e)
        {
            Thong_Tin_Nguyen_To f = new Thong_Tin_Nguyen_To();
            f.Show();
            f.pictureBox1.Image = new Bitmap(Application.StartupPath + "\\Image Of Visual Periodic Table\\sulfur-3.jpg");
            f.lbkihieu.Text = "S";
            f.lbtennguyento.Text = "Lưu Huỳnh";
            f.lbmol.Text = "32.065 (g/mol)";
            f.lbloai.Text = "PHI KIÊM KHÁC";
            f.lbtenlatin.Text = "Tên Latin: Sulphur";
            f.lbtenanh.Text = "Tên tiếng Anh: Sulphur";
            f.lbnam.Text = "Năm khám phá: 1774";
            f.lbnguoi.Text = "Người khám phá: --*--";
            f.lbvo.Text = "Vỏ điện tử: K2 L8 M6";
            f.lbcas.Text = "CAS số: CAS7704-34-9";
            f.lbsongtu.Text = "Số nguyên tử: 16";
            f.lbnguyentukhoi.Text = "Nguyên tử khối; 32.065 (g/mol)";
            f.lbmatdo.Text = "Mật độ: 2.070 (g/cm3)";
            f.lbnongchay.Text = "Điểm nóng chảy: 112.85 'C";
            f.lbsoi.Text = "Điểm sôi: 444.67 'C";
            f.lbcauhinh.Text = "Cấu hình điện tử: [Ne]3s2 3p4 1s2 2s2 2p6 3s2 3p4";
            f.lbhoatri.Text = "Hóa trị: -1, -2, +1, +2, +3, +4, +5, +6";
            f.lbtiemnang.Text = "Tiềm năng Ion hóa của nguyên tử: 10.31";
            f.lbbankinh.Text = "Bán kính nguyên tử: 127 pm";
            f.lbbankinhvan.Text = "Bán kính Van der Waals: 180 pm";
            f.lbamdien.Text = "Âm điện: 2.58";
            f.lbhoatriphanung.Text = "Hóa trị: -1, -2, +1, +2, +3, +4, +5, +6";
            f.lbelectron.Text = "Electron mối quan hệ: 200 kJ/mole";
            f.lbdientro.Text = "Điện trở: 1x10^15";
            f.lbvotraidat.Text = " Tỉ lệ có trong vỏ Trái Đất: 0.042 %";
            f.lbconnguoi.Text = "Tỉ lệ có trong con người: 0.2 %";
            f.lbvutru.Text = "Tỉ lệ có trong vũ trụ: 0.05 %";
            f.lblienket.Text = "Liên kết cộng hóa trị bán kính: 102 pm";
        } //lưu huỳnh

        private void btcl_Click(object sender, EventArgs e)
        {
            Thong_Tin_Nguyen_To f = new Thong_Tin_Nguyen_To();
            f.Show();
            f.pictureBox1.Image = new Bitmap(Application.StartupPath + "\\Image Of Visual Periodic Table\\chlorine.jpg");
            f.lbkihieu.Text = "Cl";
            f.lbtennguyento.Text = "Clo";
            f.lbmol.Text = "35.453 (g/mol)";
            f.lbloai.Text = "HALOGEN";
            f.lbtenlatin.Text = "Tên Latin: Clorum";
            f.lbtenanh.Text = "Tên tiếng Anh: Chlorine";
            f.lbnam.Text = "Năm khám phá: 1774";
            f.lbnguoi.Text = "Người khám phá: Calr Wilhelm Scheele";
            f.lbvo.Text = "Vỏ điện tử: K2 L8 M7";
            f.lbcas.Text = "CAS số: CAS7782-50-5";
            f.lbsongtu.Text = "Số nguyên tử: 17";
            f.lbnguyentukhoi.Text = "Nguyên tử khối; 35.453 (g/mol)";
            f.lbmatdo.Text = "Mật độ: 0.003214 (g/cm3)";
            f.lbnongchay.Text = "Điểm nóng chảy: -100.95 'C";
            f.lbsoi.Text = "Điểm sôi: -34.55 'C";
            f.lbcauhinh.Text = "Cấu hình điện tử: [Ne]3s2 3p5 1s2 2s2 2p6 3s2 2p5";
            f.lbhoatri.Text = "Hóa trị: -1, +1, +2, +3, +4, +5, +6, +7";
            f.lbtiemnang.Text = "Tiềm năng Ion hóa của nguyên tử: 12.96";
            f.lbbankinh.Text = "Bán kính nguyên tử: 99 pm";
            f.lbbankinhvan.Text = "Bán kính Van der Waals: 175 pm";
            f.lbamdien.Text = "Âm điện: 3.16";
            f.lbhoatriphanung.Text = "Hóa trị: -1, +1, (+2), +3, (+4), +5, +7";
            f.lbelectron.Text = "Electron mối quan hệ: 349 kJ/mole";
            f.lbdientro.Text = "Điện trở: --*--";
            f.lbvotraidat.Text = " Tỉ lệ có trong vỏ Trái Đất: 0.017 %";
            f.lbconnguoi.Text = "Tỉ lệ có trong con người: 0.12 %";
            f.lbvutru.Text = "Tỉ lệ có trong vũ trụ:0.0001 %";
            f.lblienket.Text = "Liên kết cộng hóa trị bán kính: 99 pm";
        }

        private void thôngTinPhầnMềmToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Thong_Tin_Phan_Mem f = new Thong_Tin_Phan_Mem();
            f.ShowDialog();
        }

        private void bảngTínhTanToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Bang_Tinh_Tan f = new Bang_Tinh_Tan();
            f.ShowDialog();
        }

        private void btar_Click(object sender, EventArgs e)
        {
            Thong_Tin_Nguyen_To f = new Thong_Tin_Nguyen_To();
            f.Show();
            f.pictureBox1.Image = new Bitmap(Application.StartupPath + "\\Image Of Visual Periodic Table\\argon.jpg");
            f.lbkihieu.Text = "Ar";
            f.lbtennguyento.Text = "Argon";
            f.lbmol.Text = "39.948 (g/mol)";
            f.lbloai.Text = "KHÍ TRƠ";
            f.lbtenlatin.Text = "Tên Latin: Argon";
            f.lbtenanh.Text = "Tên tiếng Anh: Argon";
            f.lbnam.Text = "Năm khám phá: 1894";
            f.lbnguoi.Text = "Người khám phá: Sir William Ramsay";
            f.lbvo.Text = "Vỏ điện tử: K2 L8 M8";
            f.lbcas.Text = "CAS số: CAS7440-37-1";
            f.lbsongtu.Text = "Số nguyên tử: 18";
            f.lbnguyentukhoi.Text = "Nguyên tử khối; 39.948 (g/mol)";
            f.lbmatdo.Text = "Mật độ: 0.001784 (g/cm3)";
            f.lbnongchay.Text = "Điểm nóng chảy: -189.35 'C";
            f.lbsoi.Text = "Điểm sôi: -185.85 'C";
            f.lbcauhinh.Text = "Cấu hình điện tử: [Ne]3s2 3p6 1s2 2s2 2p6 3s2 3p6";
            f.lbhoatri.Text = "Hóa trị: --*--";
            f.lbtiemnang.Text = "Tiềm năng Ion hóa của nguyên tử: 15.68";
            f.lbbankinh.Text = "Bán kính nguyên tử: 71 pm";
            f.lbbankinhvan.Text = "Bán kính Van der Waals: 188 pm";
            f.lbamdien.Text = "Âm điện: --*--";
            f.lbhoatriphanung.Text = "Hóa trị: --*--";
            f.lbelectron.Text = "Electron mối quan hệ: 0 kJ/mole";
            f.lbdientro.Text = "Điện trở: --*--";
            f.lbvotraidat.Text = " Tỉ lệ có trong vỏ Trái Đất: 0.0015 %";
            f.lbconnguoi.Text = "Tỉ lệ có trong con người: --*-- %";
            f.lbvutru.Text = "Tỉ lệ có trong vũ trụ:0.02 %";
            f.lblienket.Text = "Liên kết cộng hóa trị bán kính: 97 pm";
        }

        private void btk_Click(object sender, EventArgs e)
        {
            Thong_Tin_Nguyen_To f = new Thong_Tin_Nguyen_To();
            f.Show();
            f.pictureBox1.Image = new Bitmap(Application.StartupPath + "\\Image Of Visual Periodic Table\\kali.jpg");
            f.lbkihieu.Text = "K";
            f.lbtennguyento.Text = "Kali";
            f.lbmol.Text = "39.0983 (g/mol)";
            f.lbloai.Text = "KIM LOẠI KIỀM";
            f.lbtenlatin.Text = "Tên Latin: Kalium";
            f.lbtenanh.Text = "Tên tiếng Anh: Potassium";
            f.lbnam.Text = "Năm khám phá: 1807";
            f.lbnguoi.Text = "Người khám phá: Humphry Davy";
            f.lbvo.Text = "Vỏ điện tử: K2 L8 M8 N1";
            f.lbcas.Text = "CAS số: CAS7440-09-7";
            f.lbsongtu.Text = "Số nguyên tử: 19";
            f.lbnguyentukhoi.Text = "Nguyên tử khối; 39.0983 (g/mol)";
            f.lbmatdo.Text = "Mật độ: 0.856 (g/cm3)";
            f.lbnongchay.Text = "Điểm nóng chảy: 63.65 'C";
            f.lbsoi.Text = "Điểm sôi: 773.85 'C";
            f.lbcauhinh.Text = "Cấu hình điện tử: [Ar]4s1 1s2 2s2 2p6 3s2 3p6 4s1";
            f.lbhoatri.Text = "Hóa trị: -1, +1";
            f.lbtiemnang.Text = "Tiềm năng Ion hóa của nguyên tử: 4.32";
            f.lbbankinh.Text = "Bán kính nguyên tử: 235 pm";
            f.lbbankinhvan.Text = "Bán kính Van der Waals: 275 pm";
            f.lbamdien.Text = "Âm điện: 0.82";
            f.lbhoatriphanung.Text = "Hóa trị: -1, +1";
            f.lbelectron.Text = "Electron mối quan hệ: 48.4 kJ/mole";
            f.lbdientro.Text = "Điện trở: --*--";
            f.lbvotraidat.Text = " Tỉ lệ có trong vỏ Trái Đất: 1.5 %";
            f.lbconnguoi.Text = "Tỉ lệ có trong con người: 0.2 %";
            f.lbvutru.Text = "Tỉ lệ có trong vũ trụ:0.0003 %";
            f.lblienket.Text = "Liên kết cộng hóa trị bán kính: 196 pm";
        }

        private void btca_Click(object sender, EventArgs e)
        {
            Thong_Tin_Nguyen_To f = new Thong_Tin_Nguyen_To();
            f.Show();
            f.pictureBox1.Image = new Bitmap(Application.StartupPath + "\\Image Of Visual Periodic Table\\calcium.jpg");
            f.lbkihieu.Text = "Ca";
            f.lbtennguyento.Text = "Canxi";
            f.lbmol.Text = "30.078 (g/mol)";
            f.lbloai.Text = "KIM LOẠI KIỀM THỔ";
            f.lbtenlatin.Text = "Tên Latin: Calcium";
            f.lbtenanh.Text = "Tên tiếng Anh: Calcium";
            f.lbnam.Text = "Năm khám phá: 1808";
            f.lbnguoi.Text = "Người khám phá: Humphry Davy";
            f.lbvo.Text = "Vỏ điện tử: K2 L8 M8 N2";
            f.lbcas.Text = "CAS số: CAS7440-70-2";
            f.lbsongtu.Text = "Số nguyên tử: 20";
            f.lbnguyentukhoi.Text = "Nguyên tử khối; 40.078 (g/mol)";
            f.lbmatdo.Text = "Mật độ: 1.55 (g/cm3)";
            f.lbnongchay.Text = "Điểm nóng chảy: 838.85 'C";
            f.lbsoi.Text = "Điểm sôi: 1483.83 'C";
            f.lbcauhinh.Text = "Cấu hình điện tử: [Ar]4s2 1s2 2s2 2p6 3s2 3p6 4s2";
            f.lbhoatri.Text = "Hóa trị: +1, +2";
            f.lbtiemnang.Text = "Tiềm năng Ion hóa của nguyên tử: 6.09";
            f.lbbankinh.Text = "Bán kính nguyên tử: 197 pm";
            f.lbbankinhvan.Text = "Bán kính Van der Waals: 231 pm";
            f.lbamdien.Text = "Âm điện: 3.16";
            f.lbhoatriphanung.Text = "Hóa trị: +1, +2";
            f.lbelectron.Text = "Electron mối quan hệ: 2.37 kJ/mole";
            f.lbdientro.Text = "Điện trở: 3.4x10^-8";
            f.lbvotraidat.Text = " Tỉ lệ có trong vỏ Trái Đất: 5 %";
            f.lbconnguoi.Text = "Tỉ lệ có trong con người: 1.4 %";
            f.lbvutru.Text = "Tỉ lệ có trong vũ trụ: 0.007 %";
            f.lblienket.Text = "Liên kết cộng hóa trị bán kính: 174 pm";
        }

        private void phânBốVềKhốiLượngCácNguênTốTrênVỏTráiĐấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Phan_Bo_khoi_luong f = new Phan_Bo_khoi_luong();
            f.ShowDialog();
        }

        private void btsc_Click(object sender, EventArgs e)
        {
            Thong_Tin_Nguyen_To f = new Thong_Tin_Nguyen_To();
            f.Show();
            f.pictureBox1.Image = new Bitmap(Application.StartupPath + "\\Image Of Visual Periodic Table\\scandium.jpg");
            f.lbkihieu.Text = "Sc";
            f.lbtennguyento.Text = "Scandi";
            f.lbmol.Text = "44.9559 (g/mol)";
            f.lbloai.Text = "KIM LOẠI CHUYỂN TIẾP";
            f.lbtenlatin.Text = "Tên Latin: Scandium";
            f.lbtenanh.Text = "Tên tiếng Anh: Scandium";
            f.lbnam.Text = "Năm khám phá: 1879";
            f.lbnguoi.Text = "Người khám phá: Lars Fredrik Nilson";
            f.lbvo.Text = "Vỏ điện tử: K2 L8 M9 N2";
            f.lbcas.Text = "CAS số: CAS7440-20-2";
            f.lbsongtu.Text = "Số nguyên tử: 21";
            f.lbnguyentukhoi.Text = "Nguyên tử khối; 44.9559 (g/mol)";
            f.lbmatdo.Text = "Mật độ: 2.99 (g/cm3)";
            f.lbnongchay.Text = "Điểm nóng chảy: 1539 'C";
            f.lbsoi.Text = "Điểm sôi: 2835 'C";
            f.lbcauhinh.Text = "Cấu hình điện tử: [Ar]4s2 3d1 1s2 2s2 2p6 3s2 3p6 4s2 3d1";
            f.lbhoatri.Text = "Hóa trị: +1, +2, +3";
            f.lbtiemnang.Text = "Tiềm năng Ion hóa của nguyên tử: 6.57";
            f.lbbankinh.Text = "Bán kính nguyên tử: 162 pm";
            f.lbbankinhvan.Text = "Bán kính Van der Waals: 211 pm";
            f.lbamdien.Text = "Âm điện: 1.36";
            f.lbhoatriphanung.Text = "Hóa trị: +1, +2, +3";
            f.lbelectron.Text = "Electron mối quan hệ: 18.1 kJ/mole";
            f.lbdientro.Text = "Điện trở: 1.8x10^-7";
            f.lbvotraidat.Text = " Tỉ lệ có trong vỏ Trái Đất: 0.0026 %";
            f.lbconnguoi.Text = "Tỉ lệ có trong con người: --*-- %";
            f.lbvutru.Text = "Tỉ lệ có trong vũ trụ: 3x10^-6 %";
            f.lblienket.Text = "Liên kết cộng hóa trị bán kính: 144 pm";
        }

        private void btti_Click(object sender, EventArgs e)
        {
            Thong_Tin_Nguyen_To f = new Thong_Tin_Nguyen_To();
            f.Show();
            f.pictureBox1.Image = new Bitmap(Application.StartupPath + "\\Image Of Visual Periodic Table\\titanium-crystal.jpg");
            f.lbkihieu.Text = "Ti";
            f.lbtennguyento.Text = "Tital";
            f.lbmol.Text = "47.867 (g/mol)";
            f.lbloai.Text = "KIM LOẠI CHUYỂN TIẾP";
            f.lbtenlatin.Text = "Tên Latin: Titanium";
            f.lbtenanh.Text = "Tên tiếng Anh: Titanium";
            f.lbnam.Text = "Năm khám phá: 1791";
            f.lbnguoi.Text = "Người khám phá: William Gregor";
            f.lbvo.Text = "Vỏ điện tử: K2 L8 M10 N2";
            f.lbcas.Text = "CAS số: CAS7440-32-6";
            f.lbsongtu.Text = "Số nguyên tử: 22";
            f.lbnguyentukhoi.Text = "Nguyên tử khối; 47.867 (g/mol)";
            f.lbmatdo.Text = "Mật độ: 4.54 (g/cm3)";
            f.lbnongchay.Text = "Điểm nóng chảy: 1660 'C";
            f.lbsoi.Text = "Điểm sôi: 3285 'C";
            f.lbcauhinh.Text = "Cấu hình điện tử: [Ar]4s2 3d2 1s2 2s2 2p6 3s2 3p6 4s2 3d2";
            f.lbhoatri.Text = "Hóa trị: -1, -2, +1, +2, +3, +4";
            f.lbtiemnang.Text = "Tiềm năng Ion hóa của nguyên tử: 6.81";
            f.lbbankinh.Text = "Bán kính nguyên tử: 147 pm";
            f.lbbankinhvan.Text = "Bán kính Van der Waals: --*-- pm";
            f.lbamdien.Text = "Âm điện: 1.54";
            f.lbhoatriphanung.Text = "Hóa trị: -1, -2, +1, +2, +3, +4";
            f.lbelectron.Text = "Electron mối quan hệ: 7.6 kJ/mole";
            f.lbdientro.Text = "Điện trở: 4x10^-7";
            f.lbvotraidat.Text = " Tỉ lệ có trong vỏ Trái Đất: 0.66 %";
            f.lbconnguoi.Text = "Tỉ lệ có trong con người: --*-- %";
            f.lbvutru.Text = "Tỉ lệ có trong vũ trụ: 0.0003 %";
            f.lblienket.Text = "Liên kết cộng hóa trị bán kính: 136 pm";
           
        }

        private void btv_Click(object sender, EventArgs e)
        {
            Thong_Tin_Nguyen_To f = new Thong_Tin_Nguyen_To();
            f.Show();
            f.pictureBox1.Image = new Bitmap(Application.StartupPath + "\\Image Of Visual Periodic Table\\vanadium.jpg");
            f.lbkihieu.Text = "V";
            f.lbtennguyento.Text = "Vanađi";
            f.lbmol.Text = "50.9415 (g/mol)";
            f.lbloai.Text = "KIM LOẠI CHUYỂN TIẾP";
            f.lbtenlatin.Text = "Tên Latin: Vanadium";
            f.lbtenanh.Text = "Tên tiếng Anh: Vanadium";
            f.lbnam.Text = "Năm khám phá: 1801";
            f.lbnguoi.Text = "Người khám phá: Andres Manuel del Rio";
            f.lbvo.Text = "Vỏ điện tử: K2 L8 M11 N2";
            f.lbcas.Text = "CAS số: CAS7440-62-2";
            f.lbsongtu.Text = "Số nguyên tử: 23";
            f.lbnguyentukhoi.Text = "Nguyên tử khối; 50.9415 (g/mol)";
            f.lbmatdo.Text = "Mật độ: 6.11 (g/cm3)";
            f.lbnongchay.Text = "Điểm nóng chảy: 1887 'C";
            f.lbsoi.Text = "Điểm sôi: 3377 'C";
            f.lbcauhinh.Text = "Cấu hình điện tử: [Ar]4s2 3d3 1s2 2s2 2p6 3s2 4s2 3d3";
            f.lbhoatri.Text = "Hóa trị: -1, -3, +1, +2, +3, +4, +5";
            f.lbtiemnang.Text = "Tiềm năng Ion hóa của nguyên tử: 6.76";
            f.lbbankinh.Text = "Bán kính nguyên tử: 134 pm";
            f.lbbankinhvan.Text = "Bán kính Van der Waals: --*-- pm";
            f.lbamdien.Text = "Âm điện: 1.63";
            f.lbhoatriphanung.Text = "Hóa trị: +2, +3, +4, +5";
            f.lbelectron.Text = "Electron mối quan hệ: 50.6 kJ/mole";
            f.lbdientro.Text = "Điện trở: 2x10^-7";
            f.lbvotraidat.Text = " Tỉ lệ có trong vỏ Trái Đất: 0.019 %";
            f.lbconnguoi.Text = "Tỉ lệ có trong con người: 3x10^-6 %";
            f.lbvutru.Text = "Tỉ lệ có trong vũ trụ: 0.0001 %";
            f.lblienket.Text = "Liên kết cộng hóa trị bán kính: 125 pm";
        }

        private void biểuĐồĐiệnLoạtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bieu_Do_Dien_Loat f = new Bieu_Do_Dien_Loat();
            f.ShowDialog();
        }

        private void btcr_Click(object sender, EventArgs e)
        {
            Thong_Tin_Nguyen_To f = new Thong_Tin_Nguyen_To();
            f.Show();
            f.pictureBox1.Image = new Bitmap(Application.StartupPath + "\\Image Of Visual Periodic Table\\chromium.jpg");
            f.lbkihieu.Text = "Cr";
            f.lbtennguyento.Text = "Crom";
            f.lbmol.Text = "51.9961 (g/mol)";
            f.lbloai.Text = "KIM LOẠI CHUYỂN TIẾP";
            f.lbtenlatin.Text = "Tên Latin: Chromium";
            f.lbtenanh.Text = "Tên tiếng Anh: Chromium";
            f.lbnam.Text = "Năm khám phá: 1797";
            f.lbnguoi.Text = "Người khám phá: Luois-Nicolas Vauquelin";
            f.lbvo.Text = "Vỏ điện tử: K2 L8 M13 N1";
            f.lbcas.Text = "CAS số: CAS7440-47-3";
            f.lbsongtu.Text = "Số nguyên tử: 24";
            f.lbnguyentukhoi.Text = "Nguyên tử khối; 51.9961 (g/mol)";
            f.lbmatdo.Text = "Mật độ: 7.19 (g/cm3)";
            f.lbnongchay.Text = "Điểm nóng chảy: 1855 'C";
            f.lbsoi.Text = "Điểm sôi: 2670 'C";
            f.lbcauhinh.Text = "Cấu hình điện tử: [Ar]4s1 3d5 1s2 2s2 2p6 3s2 3p6 4s1 3d5";
            f.lbhoatri.Text = "Hóa trị: -1, -2, -4, +1, +2, +3, +4, +5, +6";
            f.lbtiemnang.Text = "Tiềm năng Ion hóa của nguyên tử: 6.74";
            f.lbbankinh.Text = "Bán kính nguyên tử: 130 pm";
            f.lbbankinhvan.Text = "Bán kính Van der Waals:--*-- pm";
            f.lbamdien.Text = "Âm điện: 1.66";
            f.lbhoatriphanung.Text = "Hóa trị: +2, +3, +6";
            f.lbelectron.Text = "Electron mối quan hệ: 64.3 kJ/mole";
            f.lbdientro.Text = "Điện trở: 1.3x1-^-7";
            f.lbvotraidat.Text = " Tỉ lệ có trong vỏ Trái Đất: 0.014 %";
            f.lbconnguoi.Text = "Tỉ lệ có trong con người: 3x10^-6 %";
            f.lbvutru.Text = "Tỉ lệ có trong vũ trụ: 0.0015 %";
            f.lblienket.Text = "Liên kết cộng hóa trị bán kính: 127 pm";
        }

        private void btmn_Click(object sender, EventArgs e)
        {
            Thong_Tin_Nguyen_To f = new Thong_Tin_Nguyen_To();
            f.Show();
            f.pictureBox1.Image = new Bitmap(Application.StartupPath + "\\Image Of Visual Periodic Table\\manganese-2.jpg");
            f.lbkihieu.Text = "Mn";
            f.lbtennguyento.Text = "Mangan";
            f.lbmol.Text = "54.9380 (g/mol)";
            f.lbloai.Text = "KIM LOẠI CHUYỂN TIẾP";
            f.lbtenlatin.Text = "Tên Latin: Manganum";
            f.lbtenanh.Text = "Tên tiếng Anh: Manganese";
            f.lbnam.Text = "Năm khám phá: 1774";
            f.lbnguoi.Text = "Người khám phá: Johan Gottlieb Gahn";
            f.lbvo.Text = "Vỏ điện tử: K2 L8 M13 N2";
            f.lbcas.Text = "CAS số: CAS7439-96-5";
            f.lbsongtu.Text = "Số nguyên tử: 25";
            f.lbnguyentukhoi.Text = "Nguyên tử khối; 55.9380 (g/mol)";
            f.lbmatdo.Text = "Mật độ: 7.21 (g/cm3)";
            f.lbnongchay.Text = "Điểm nóng chảy: 1242 'C";
            f.lbsoi.Text = "Điểm sôi: 1960 'C";
            f.lbcauhinh.Text = "Cấu hình điện tử: [Ar]4s2 3d5 1s2 2s2 2p6 3s2 3p6 4s2 3d5";
            f.lbhoatri.Text = "Hóa trị: -1, -2, -3, +1, +2, +3, +4, +5,+6, +7";
            f.lbtiemnang.Text = "Tiềm năng Ion hóa của nguyên tử: 7.40";
            f.lbbankinh.Text = "Bán kính nguyên tử: 127 pm";
            f.lbbankinhvan.Text = "Bán kính Van der Waals: --*-- pm";
            f.lbamdien.Text = "Âm điện: 1.55";
            f.lbhoatriphanung.Text = "Hóa trị: +2, (+3), +4, (+6), +7";
            f.lbelectron.Text = "Electron mối quan hệ: 0 kJ/mole";
            f.lbdientro.Text = "Điện trở: 1.6x10^-7";
            f.lbvotraidat.Text = " Tỉ lệ có trong vỏ Trái Đất: 0.11 %";
            f.lbconnguoi.Text = "Tỉ lệ có trong con người: 0.00002 %";
            f.lbvutru.Text = "Tỉ lệ có trong vũ trụ: 0.0008 %";
            f.lblienket.Text = "Liên kết cộng hóa trị bán kính: 139 pm";
        }

        private void btfe_Click(object sender, EventArgs e)
        {
            Thong_Tin_Nguyen_To f = new Thong_Tin_Nguyen_To();
            f.Show();
            f.pictureBox1.Image = new Bitmap(Application.StartupPath + "\\Image Of Visual Periodic Table\\iron.jpg");
            f.lbkihieu.Text = "Fe";
            f.lbtennguyento.Text = "Sắt";
            f.lbmol.Text = "55.845 (g/mol)";
            f.lbloai.Text = "KIM LOẠI CHUYỂN TIẾP";
            f.lbtenlatin.Text = "Tên Latin: Ferrum";
            f.lbtenanh.Text = "Tên tiếng Anh: Iron";
            f.lbnam.Text = "Năm khám phá: --*--";
            f.lbnguoi.Text = "Người khám phá: --*--";
            f.lbvo.Text = "Vỏ điện tử: K2 L8 M14 N2";
            f.lbcas.Text = "CAS số: CAS7439-89-6";
            f.lbsongtu.Text = "Số nguyên tử: 24";
            f.lbnguyentukhoi.Text = "Nguyên tử khối; 55.845 (g/mol)";
            f.lbmatdo.Text = "Mật độ: 7.88 (g/cm3)";
            f.lbnongchay.Text = "Điểm nóng chảy: 1535.85 'C";
            f.lbsoi.Text = "Điểm sôi: 2859 'C";
            f.lbcauhinh.Text = "Cấu hình điện tử: [Ar]4s2 3d6 1s2 2s2 2p6 3s2 3p6 4s2 3d6";
            f.lbhoatri.Text = "Hóa trị: -1, -2, -4, +1, +2, +3, +4, +5, +6, +7";
            f.lbtiemnang.Text = "Tiềm năng Ion hóa của nguyên tử: 7.83";
            f.lbbankinh.Text = "Bán kính nguyên tử: 126 pm";
            f.lbbankinhvan.Text = "Bán kính Van der Waals: --*-- pm";
            f.lbamdien.Text = "Âm điện: 1.83";
            f.lbhoatriphanung.Text = "Hóa trị: +2, +3, (+4), (+6)";
            f.lbelectron.Text = "Electron mối quan hệ: 15.7 kJ/mole";
            f.lbdientro.Text = "Điện trở: 9.7x10^-8";
            f.lbvotraidat.Text = " Tỉ lệ có trong vỏ Trái Đất: 6.3 %";
            f.lbconnguoi.Text = "Tỉ lệ có trong con người: 0.006 %";
            f.lbvutru.Text = "Tỉ lệ có trong vũ trụ: 0.11 %";
            f.lblienket.Text = "Liên kết cộng hóa trị bán kính: 125 pm";
        }

        private void btco_Click(object sender, EventArgs e)
        {
            Thong_Tin_Nguyen_To f = new Thong_Tin_Nguyen_To();
            f.Show();
            f.pictureBox1.Image = new Bitmap(Application.StartupPath + "\\Image Of Visual Periodic Table\\cobalt.jpg");
            f.lbkihieu.Text = "Co";
            f.lbtennguyento.Text = "Coban";
            f.lbmol.Text = "58.9331 (g/mol)";
            f.lbloai.Text = "KIM LOẠI CHUYỂN TIẾP";
            f.lbtenlatin.Text = "Tên Latin: Cobalt";
            f.lbtenanh.Text = "Tên tiếng Anh: Cobalt";
            f.lbnam.Text = "Năm khám phá: 1736";
            f.lbnguoi.Text = "Người khám phá: Georg Brandt";
            f.lbvo.Text = "Vỏ điện tử: K2 L8 M15 N2";
            f.lbcas.Text = "CAS số: CAS7440-48-4";
            f.lbsongtu.Text = "Số nguyên tử: 27";
            f.lbnguyentukhoi.Text = "Nguyên tử khối; 58.9331(g/mol)";
            f.lbmatdo.Text = "Mật độ: 8.9 (g/cm3)";
            f.lbnongchay.Text = "Điểm nóng chảy: 1493 'C";
            f.lbsoi.Text = "Điểm sôi: 2868 'C";
            f.lbcauhinh.Text = "Cấu hình điện tử: [Ar]4s2 3d7 1s2 2s2 2p6 3s2 3p6 4s2 3d7";
            f.lbhoatri.Text = "Hóa trị: -1, -3, +1, +2, +3, +4, +5";
            f.lbtiemnang.Text = "Tiềm năng Ion hóa của nguyên tử: 7.81";
            f.lbbankinh.Text = "Bán kính nguyên tử: 125 pm";
            f.lbbankinhvan.Text = "Bán kính Van der Waals: --*-- pm";
            f.lbamdien.Text = "Âm điện: 1.88";
            f.lbhoatriphanung.Text = "Hóa trị: +2, +3, (+4)";
            f.lbelectron.Text = "Electron mối quan hệ: 63.7 kJ/mole";
            f.lbdientro.Text = "Điện trở: 6x10^-8";
            f.lbvotraidat.Text = " Tỉ lệ có trong vỏ Trái Đất: 0.003 %";
            f.lbconnguoi.Text = "Tỉ lệ có trong con người: 2x10^-6 %";
            f.lbvutru.Text = "Tỉ lệ có trong vũ trụ: 0.0003 %";
            f.lblienket.Text = "Liên kết cộng hóa trị bán kính: 126 pm";
        }

        private void btni_Click(object sender, EventArgs e)
        {
            Thong_Tin_Nguyen_To f = new Thong_Tin_Nguyen_To();
            f.Show();
            f.pictureBox1.Image = new Bitmap(Application.StartupPath + "\\Image Of Visual Periodic Table\\nickel.jpg");
            f.lbkihieu.Text = "Ni";
            f.lbtennguyento.Text = "Nikel";
            f.lbmol.Text = "58.6934 (g/mol)";
            f.lbloai.Text = "KIM LOẠI CHUYỂN TIẾP";
            f.lbtenlatin.Text = "Tên Latin: Niccolum";
            f.lbtenanh.Text = "Tên tiếng Anh: Nikel";
            f.lbnam.Text = "Năm khám phá: 1751";
            f.lbnguoi.Text = "Người khám phá: Axel Frederic von Cronstedt";
            f.lbvo.Text = "Vỏ điện tử: K2 L8 M16 N2";
            f.lbcas.Text = "CAS số: CAS7440-01-0";
            f.lbsongtu.Text = "Số nguyên tử: 28";
            f.lbnguyentukhoi.Text = "Nguyên tử khối; 58.6934(g/mol)";
            f.lbmatdo.Text = "Mật độ: 8.902 (g/cm3)";
            f.lbnongchay.Text = "Điểm nóng chảy: 1453 'C";
            f.lbsoi.Text = "Điểm sôi: 2731 'C";
            f.lbcauhinh.Text = "Cấu hình điện tử: [Ar]4s2 3d8 1s2 2s2 2p6 3s2 3p6 4s2 3d8";
            f.lbhoatri.Text = "Hóa trị: -1, -2, +1, +2, +3, +4";
            f.lbtiemnang.Text = "Tiềm năng Ion hóa của nguyên tử: 7.61";
            f.lbbankinh.Text = "Bán kính nguyên tử: 124 pm";
            f.lbbankinhvan.Text = "Bán kính Van der Waals: 163 pm";
            f.lbamdien.Text = "Âm điện: 1.91";
            f.lbhoatriphanung.Text = "Hóa trị: (+1), +2, (+3), (+4)";
            f.lbelectron.Text = "Electron mối quan hệ: 112 kJ/mole";
            f.lbdientro.Text = "Điện trở: 7x10^-8";
            f.lbvotraidat.Text = " Tỉ lệ có trong vỏ Trái Đất: 0.089 %";
            f.lbconnguoi.Text = "Tỉ lệ có trong con người: 0.00001 %";
            f.lbvutru.Text = "Tỉ lệ có trong vũ trụ: 0.006 %";
            f.lblienket.Text = "Liên kết cộng hóa trị bán kính: 121 pm";
        }

        private void btcu_Click(object sender, EventArgs e)
        {
            Thong_Tin_Nguyen_To f = new Thong_Tin_Nguyen_To();
            f.Show();
            f.pictureBox1.Image = new Bitmap(Application.StartupPath + "\\Image Of Visual Periodic Table\\cu.jpg");
            f.lbkihieu.Text = "Cu";
            f.lbtennguyento.Text = "Đồng";
            f.lbmol.Text = "63.546 (g/mol)";
            f.lbloai.Text = "KIM LOẠI CHUYỂN TIẾP";
            f.lbtenlatin.Text = "Tên Latin: Cuprum";
            f.lbtenanh.Text = "Tên tiếng Anh: Copper";
            f.lbnam.Text = "Năm khám phá: 1735";
            f.lbnguoi.Text = "Người khám phá: --*--";
            f.lbvo.Text = "Vỏ điện tử: K2 L8 M18 N1";
            f.lbcas.Text = "CAS số: CAS7440-50-8";
            f.lbsongtu.Text = "Số nguyên tử: 29";
            f.lbnguyentukhoi.Text = "Nguyên tử khối; 63.546(g/mol)";
            f.lbmatdo.Text = "Mật độ: 8.92 (g/cm3)";
            f.lbnongchay.Text = "Điểm nóng chảy: 1083.4 'C";
            f.lbsoi.Text = "Điểm sôi: 2565 'C";
            f.lbcauhinh.Text = "Cấu hình điện tử: [Ar]3d10 4s1 1s2 2s2 2p6 3s2 3p6 3d10 4s1";
            f.lbhoatri.Text = "Hóa trị: -2, +1, +2, +3, +4";
            f.lbtiemnang.Text = "Tiềm năng Ion hóa của nguyên tử: 7.69";
            f.lbbankinh.Text = "Bán kính nguyên tử: 128 pm";
            f.lbbankinhvan.Text = "Bán kính Van der Waals: 140 pm";
            f.lbamdien.Text = "Âm điện: 1.9";
            f.lbhoatriphanung.Text = "Hóa trị: +1, +2, (+3)";
            f.lbelectron.Text = "Electron mối quan hệ: 118.4 kJ/mole";
            f.lbdientro.Text = "Điện trở: 1.7x10^-8";
            f.lbvotraidat.Text = " Tỉ lệ có trong vỏ Trái Đất: 0.0068 %";
            f.lbconnguoi.Text = "Tỉ lệ có trong con người: 0.0001 %";
            f.lbvutru.Text = "Tỉ lệ có trong vũ trụ: 6x10^-6 %";
            f.lblienket.Text = "Liên kết cộng hóa trị bán kính: 138 pm";
        }

        private void tínhNguyênTửKhốiCủaMộtChấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tinh_nguyen_tu_khoi f = new Tinh_nguyen_tu_khoi();
            f.ShowDialog();
        }

        private void cácKiếnThứcCơBảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kien_thuc_hoa_co_ban f = new Kien_thuc_hoa_co_ban();
            f.Show();
            f.lbkienthuchoacoban.Text = "Phân loại các chất vô cơ trong lớp 8";

        }

        private void btzn_Click(object sender, EventArgs e)
        {
            Thong_Tin_Nguyen_To f = new Thong_Tin_Nguyen_To();
            f.Show();
            f.pictureBox1.Image = new Bitmap(Application.StartupPath + "\\Image Of Visual Periodic Table\\zinc-2.jpg");
            f.lbkihieu.Text = "Zn";
            f.lbtennguyento.Text = "Kẽm";
            f.lbmol.Text = "65.409 (g/mol)";
            f.lbloai.Text = "KIM LOẠI CHUYỂN TIẾP";
            f.lbtenlatin.Text = "Tên Latin: Zincum";
            f.lbtenanh.Text = "Tên tiếng Anh: Zinc";
            f.lbnam.Text = "Năm khám phá: 1738";
            f.lbnguoi.Text = "Người khám phá: A.S Marggaf";
            f.lbvo.Text = "Vỏ điện tử: K2 L8 M18 N2";
            f.lbcas.Text = "CAS số: CAS7440-66-6";
            f.lbsongtu.Text = "Số nguyên tử: 30";
            f.lbnguyentukhoi.Text = "Nguyên tử khối; 65.409(g/mol)";
            f.lbmatdo.Text = "Mật độ: 7.133 (g/cm3)";
            f.lbnongchay.Text = "Điểm nóng chảy: 419.6 'C";
            f.lbsoi.Text = "Điểm sôi: 906.2 'C";
            f.lbcauhinh.Text = "Cấu hình điện tử: [Ar]4s2 3d10 1s2 2p6 3s2 3p6 4s2 3d10";
            f.lbhoatri.Text = "Hóa trị: -2, +1, +2";
            f.lbtiemnang.Text = "Tiềm năng Ion hóa của nguyên tử: 9.35";
            f.lbbankinh.Text = "Bán kính nguyên tử: 138 pm";
            f.lbbankinhvan.Text = "Bán kính Van der Waals: 139 pm";
            f.lbamdien.Text = "Âm điện: 1.65";
            f.lbhoatriphanung.Text = "Hóa trị: +2";
            f.lbelectron.Text = "Electron mối quan hệ: 0 kJ/mole";
            f.lbdientro.Text = "Điện trở: 5.9x10^-8";
            f.lbvotraidat.Text = " Tỉ lệ có trong vỏ Trái Đất: 0.0078 %";
            f.lbconnguoi.Text = "Tỉ lệ có trong con người: 0.0033%";
            f.lbvutru.Text = "Tỉ lệ có trong vũ trụ: 0.00003 %";
            f.lblienket.Text = "Liên kết cộng hóa trị bán kính: 131 pm";
        }

        private void btga_Click(object sender, EventArgs e)
        {
            Thong_Tin_Nguyen_To f = new Thong_Tin_Nguyen_To();
            f.Show();
            f.pictureBox1.Image = new Bitmap(Application.StartupPath + "\\Image Of Visual Periodic Table\\gallium.jpg");
            f.lbkihieu.Text = "Ga";
            f.lbtennguyento.Text = "Gali";
            f.lbmol.Text = "69.723 (g/mol)";
            f.lbloai.Text = "KIM LOẠI CHUYỂN TIẾP";
            f.lbtenlatin.Text = "Tên Latin: Gallium";
            f.lbtenanh.Text = "Tên tiếng Anh: Gallium";
            f.lbnam.Text = "Năm khám phá: 1875";
            f.lbnguoi.Text = "Người khám phá: P.E.L de Boisbaudran";
            f.lbvo.Text = "Vỏ điện tử: K2 L8 M18 N3";
            f.lbcas.Text = "CAS số: CAS7440-55-3";
            f.lbsongtu.Text = "Số nguyên tử: 31";
            f.lbnguyentukhoi.Text = "Nguyên tử khối; 69.723(g/mol)";
            f.lbmatdo.Text = "Mật độ: 5.91 (g/cm3)";
            f.lbnongchay.Text = "Điểm nóng chảy: 29.8 'C";
            f.lbsoi.Text = "Điểm sôi: 2202 'C";
            f.lbcauhinh.Text = "Cấu hình điện tử: [Ar]4s2 3d10 4p1 1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p1";
            f.lbhoatri.Text = "Hóa trị: -1, -2, -4, -5, +1, +2, +3";
            f.lbtiemnang.Text = "Tiềm năng Ion hóa của nguyên tử: 5.97";
            f.lbbankinh.Text = "Bán kính nguyên tử: 141 pm";
            f.lbbankinhvan.Text = "Bán kính Van der Waals: 187 pm";
            f.lbamdien.Text = "Âm điện: 1.81";
            f.lbhoatriphanung.Text = "Hóa trị: (+2), +3";
            f.lbelectron.Text = "Electron mối quan hệ: 28.9 kJ/mole";
            f.lbdientro.Text = "Điện trở: 1.4x10^-7";
            f.lbvotraidat.Text = " Tỉ lệ có trong vỏ Trái Đất: 0.0019 %";
            f.lbconnguoi.Text = "Tỉ lệ có trong con người: --*-- %";
            f.lbvutru.Text = "Tỉ lệ có trong vũ trụ: 1x10^-6 %";
            f.lblienket.Text = "Liên kết cộng hóa trị bán kính: 126 pm";
        }

        private void btge_Click(object sender, EventArgs e)
        {
            Thong_Tin_Nguyen_To f = new Thong_Tin_Nguyen_To();
            f.Show();
            f.pictureBox1.Image = new Bitmap(Application.StartupPath + "\\Image Of Visual Periodic Table\\germanium.jpg");
            f.lbkihieu.Text = "Ge";
            f.lbtennguyento.Text = "Gecmani";
            f.lbmol.Text = "72.64 (g/mol)";
            f.lbloai.Text = "Á KIÊM";
            f.lbtenlatin.Text = "Tên Latin: Germanium";
            f.lbtenanh.Text = "Tên tiếng Anh: Germanium";
            f.lbnam.Text = "Năm khám phá: 1886";
            f.lbnguoi.Text = "Người khám phá: Clement Alexander Winkler";
            f.lbvo.Text = "Vỏ điện tử: K2 L8 M18 N4";
            f.lbcas.Text = "CAS số: CAS7440-56-4";
            f.lbsongtu.Text = "Số nguyên tử: 32";
            f.lbnguyentukhoi.Text = "Nguyên tử khối; 72.64(g/mol)";
            f.lbmatdo.Text = "Mật độ: 5.323 (g/cm3)";
            f.lbnongchay.Text = "Điểm nóng chảy: 935.6 'C";
            f.lbsoi.Text = "Điểm sôi: 2828 'C";
            f.lbcauhinh.Text = "Cấu hình điện tử: [Ar]4s1 3d10 4p2 1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p2";
            f.lbhoatri.Text = "Hóa trị: -1, -2, -3, -4, +1, +2, +3, +4";
            f.lbtiemnang.Text = "Tiềm năng Ion hóa của nguyên tử: 7.85";
            f.lbbankinh.Text = "Bán kính nguyên tử: 122.5 pm";
            f.lbbankinhvan.Text = "Bán kính Van der Waals: 211 pm";
            f.lbamdien.Text = "Âm điện: 2.01";
            f.lbhoatriphanung.Text = "Hóa trị: -4, +2, +4";
            f.lbelectron.Text = "Electron mối quan hệ: 119 kJ/mole";
            f.lbdientro.Text = "Điện trở: 0.0005";
            f.lbvotraidat.Text = " Tỉ lệ có trong vỏ Trái Đất: 0.0004 %";
            f.lbconnguoi.Text = "Tỉ lệ có trong con người: 0.00002 %";
            f.lbvutru.Text = "Tỉ lệ có trong vũ trụ: 0.00002 %";
            f.lblienket.Text = "Liên kết cộng hóa trị bán kính: 122 pm";
        }

        private void btas_Click(object sender, EventArgs e)
        {
            Thong_Tin_Nguyen_To f = new Thong_Tin_Nguyen_To();
            f.Show();
            f.pictureBox1.Image = new Bitmap(Application.StartupPath + "\\Image Of Visual Periodic Table\\arsenic.jpg");
            f.lbkihieu.Text = "As";
            f.lbtennguyento.Text = "Asen";
            f.lbmol.Text = "74.9216 (g/mol)";
            f.lbloai.Text = "Á KIÊM";
            f.lbtenlatin.Text = "Tên Latin: Arsenicum";
            f.lbtenanh.Text = "Tên tiếng Anh: Arsenic";
            f.lbnam.Text = "Năm khám phá: 1250";
            f.lbnguoi.Text = "Người khám phá: --*--";
            f.lbvo.Text = "Vỏ điện tử: K2 L8 M18 N5";
            f.lbcas.Text = "CAS số: CAS7440-38-2";
            f.lbsongtu.Text = "Số nguyên tử: 33";
            f.lbnguyentukhoi.Text = "Nguyên tử khối; 74.9216(g/mol)";
            f.lbmatdo.Text = "Mật độ: 5.72 (g/cm3)";
            f.lbnongchay.Text = "Điểm nóng chảy: 816.8 'C";
            f.lbsoi.Text = "Điểm sôi: 613 'C";
            f.lbcauhinh.Text = "Cấu hình điện tử: [Ar]4s2 3d10 4p3 1s2 2p6 3s2 4s2 3d10 4p3";
            f.lbhoatri.Text = "Hóa trị: -1, -2, -3, +1, +2, +3, +4, +5";
            f.lbtiemnang.Text = "Tiềm năng Ion hóa của nguyên tử: 9.96";
            f.lbbankinh.Text = "Bán kính nguyên tử: 139 pm";
            f.lbbankinhvan.Text = "Bán kính Van der Waals: 185 pm";
            f.lbamdien.Text = "Âm điện: 2.18";
            f.lbhoatriphanung.Text = "Hóa trị: -3, (+2), +3, +5";
            f.lbelectron.Text = "Electron mối quan hệ: 78 kJ/mole";
            f.lbdientro.Text = "Điện trở: 3x10^-7";
            f.lbvotraidat.Text = " Tỉ lệ có trong vỏ Trái Đất: 0.00021 %";
            f.lbconnguoi.Text = "Tỉ lệ có trong con người: --*-- %";
            f.lbvutru.Text = "Tỉ lệ có trong vũ trụ: 8x10^-7 %";
            f.lblienket.Text = "Liên kết cộng hóa trị bán kính: 119 pm";
        }
        private void FormChaoMung() 
        {
            Application.Run(new Form_Chao_Mung());
        }

        private void btse_Click(object sender, EventArgs e)
        {
            Thong_Tin_Nguyen_To f = new Thong_Tin_Nguyen_To();
            f.Show();
            f.pictureBox1.Image = new Bitmap(Application.StartupPath + "\\Image Of Visual Periodic Table\\selenium.jpg");
            f.lbkihieu.Text = "Se";
            f.lbtennguyento.Text = "Selen";
            f.lbmol.Text = "78.96 (g/mol)";
            f.lbloai.Text = "PHI KIÊM KHÁC";
            f.lbtenlatin.Text = "Tên Latin: Selenium";
            f.lbtenanh.Text = "Tên tiếng Anh: Selenium";
            f.lbnam.Text = "Năm khám phá: 1817";
            f.lbnguoi.Text = "Người khám phá: J.J Bezelius";
            f.lbvo.Text = "Vỏ điện tử: K2 L8 M18 N6";
            f.lbcas.Text = "CAS số: CAS7782-49-2";
            f.lbsongtu.Text = "Số nguyên tử: 34";
            f.lbnguyentukhoi.Text = "Nguyên tử khối; 78.96(g/mol)";
            f.lbmatdo.Text = "Mật độ: 4.79 (g/cm3)";
            f.lbnongchay.Text = "Điểm nóng chảy: 215 'C";
            f.lbsoi.Text = "Điểm sôi: 638.1 'C";
            f.lbcauhinh.Text = "Cấu hình điện tử: [Ar]4s1 3d10 4p4 1s2 2p6 3s2 3p6 4s2 3d10 4p4";
            f.lbhoatri.Text = "Hóa trị: -1, -2, +1, +2, +3, +4, +5, +6";
            f.lbtiemnang.Text = "Tiềm năng Ion hóa của nguyên tử: 9.5";
            f.lbbankinh.Text = "Bán kính nguyên tử: 140 pm";
            f.lbbankinhvan.Text = "Bán kính Van der Waals: 190 pm";
            f.lbamdien.Text = "Âm điện: 2.55";
            f.lbhoatriphanung.Text = "Hóa trị: -2, (+2), +4, +6";
            f.lbelectron.Text = "Electron mối quan hệ: 195 kJ/mole";
            f.lbdientro.Text = "Điện trở: --*--";
            f.lbvotraidat.Text = " Tỉ lệ có trong vỏ Trái Đất: 5x10^-6 %";
            f.lbconnguoi.Text = "Tỉ lệ có trong con người: --*-- %";
            f.lbvutru.Text = "Tỉ lệ có trong vũ trụ: 3x10^-6 %";
            f.lblienket.Text = "Liên kết cộng hóa trị bán kính: 116 pm";
        }

        private void btbr_Click(object sender, EventArgs e)
        {
            Thong_Tin_Nguyen_To f = new Thong_Tin_Nguyen_To();
            f.Show();
            f.pictureBox1.Image = new Bitmap(Application.StartupPath + "\\Image Of Visual Periodic Table\\bromine.jpg");
            f.lbkihieu.Text = "Br";
            f.lbtennguyento.Text = "Brom";
            f.lbmol.Text = "79.904 (g/mol)";
            f.lbloai.Text = "HALOGEN";
            f.lbtenlatin.Text = "Tên Latin: Bromum";
            f.lbtenanh.Text = "Tên tiếng Anh: Bromine";
            f.lbnam.Text = "Năm khám phá: 1826";
            f.lbnguoi.Text = "Người khám phá: A-J Balard, K.J Leuwich";
            f.lbvo.Text = "Vỏ điện tử: K2 L8 M18 N7";
            f.lbcas.Text = "CAS số: CAS7726-95-6";
            f.lbsongtu.Text = "Số nguyên tử: 34";
            f.lbnguyentukhoi.Text = "Nguyên tử khối; 79.904(g/mol)";
            f.lbmatdo.Text = "Mật độ: 3.14 (g/cm3)";
            f.lbnongchay.Text = "Điểm nóng chảy: -7.3 'C";
            f.lbsoi.Text = "Điểm sôi: 58.8 'C";
            f.lbcauhinh.Text = "Cấu hình điện tử: [Ar]4s1 3d10 4p5 1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p5";
            f.lbhoatri.Text = "Hóa trị: -1, +1, +3, +4, +5, +7";
            f.lbtiemnang.Text = "Tiềm năng Ion hóa của nguyên tử: 11.8";
            f.lbbankinh.Text = "Bán kính nguyên tử: 115 pm";
            f.lbbankinhvan.Text = "Bán kính Van der Waals: 185 pm";
            f.lbamdien.Text = "Âm điện: 2.96";
            f.lbhoatriphanung.Text = "Hóa trị: -1, +1, (+3), (+4), +5";
            f.lbelectron.Text = "Electron mối quan hệ: 324.6 kJ/mole";
            f.lbdientro.Text = "Điện trở: 1x10^10";
            f.lbvotraidat.Text = " Tỉ lệ có trong vỏ Trái Đất: 0.0003 %";
            f.lbconnguoi.Text = "Tỉ lệ có trong con người: --*-- %";
            f.lbvutru.Text = "Tỉ lệ có trong vũ trụ: 7x10^-7 %";
            f.lblienket.Text = "Liên kết cộng hóa trị bán kính: 114 pm";
        }

        private void btkr_Click(object sender, EventArgs e)
        {
            Thong_Tin_Nguyen_To f = new Thong_Tin_Nguyen_To();
            f.Show();
            f.pictureBox1.Image = new Bitmap(Application.StartupPath + "\\Image Of Visual Periodic Table\\krypton.jpg");
            f.lbkihieu.Text = "Kr";
            f.lbtennguyento.Text = "Kripton";
            f.lbmol.Text = "83.798 (g/mol)";
            f.lbloai.Text = "KHÍ TRƠ";
            f.lbtenlatin.Text = "Tên Latin: Krypton";
            f.lbtenanh.Text = "Tên tiếng Anh: Kripton";
            f.lbnam.Text = "Năm khám phá: 1898";
            f.lbnguoi.Text = "Người khám phá: S.W Ramsay, M.W Travers";
            f.lbvo.Text = "Vỏ điện tử: K2 L8 M18 N8";
            f.lbcas.Text = "CAS số: CAS7739-90-9";
            f.lbsongtu.Text = "Số nguyên tử: 36";
            f.lbnguyentukhoi.Text = "Nguyên tử khối; 83.798(g/mol)";
            f.lbmatdo.Text = "Mật độ: 0.003749 (g/cm3)";
            f.lbnongchay.Text = "Điểm nóng chảy: -156.6 'C";
            f.lbsoi.Text = "Điểm sôi: -152.3 'C";
            f.lbcauhinh.Text = "Cấu hình điện tử: [Ar]4s1 3d10 4p4 1s2 2p6 3s2 3p6 4s2 3d10 4p4";
            f.lbhoatri.Text = "Hóa trị: +2";
            f.lbtiemnang.Text = "Tiềm năng Ion hóa của nguyên tử: 13.94";
            f.lbbankinh.Text = "Bán kính nguyên tử: 88 pm";
            f.lbbankinhvan.Text = "Bán kính Van der Waals: 202 pm";
            f.lbamdien.Text = "Âm điện: 3";
            f.lbhoatriphanung.Text = "Hóa trị: 0";
            f.lbelectron.Text = "Electron mối quan hệ: 0 kJ/mole";
            f.lbdientro.Text = "Điện trở: --*--";
            f.lbvotraidat.Text = " Tỉ lệ có trong vỏ Trái Đất: 1.5x10^-8 %";
            f.lbconnguoi.Text = "Tỉ lệ có trong con người: --*-- %";
            f.lbvutru.Text = "Tỉ lệ có trong vũ trụ: 4x10^-6 %";
            f.lblienket.Text = "Liên kết cộng hóa trị bán kính: 110 pm";
        }

        private void btrb_Click(object sender, EventArgs e)
        {
            Thong_Tin_Nguyen_To f = new Thong_Tin_Nguyen_To();
            f.Show();
            f.pictureBox1.Image = new Bitmap(Application.StartupPath + "\\Image Of Visual Periodic Table\\rubidium-2.jpg");
            f.lbkihieu.Text = "Rb";
            f.lbtennguyento.Text = "Rubidium";
            f.lbmol.Text = "85.467 (g/mol)";
            f.lbloai.Text = "KIM LOẠI KIỀM";
            f.lbtenlatin.Text = "Tên Latin: Rubidium";
            f.lbtenanh.Text = "Tên tiếng Anh: Rubidium";
            f.lbnam.Text = "Năm khám phá: 1861";
            f.lbnguoi.Text = "Người khám phá: R.W Bunsen, G.R Kirchohoff";
            f.lbvo.Text = "Vỏ điện tử: K2 L8 M18 N8 O1";
            f.lbcas.Text = "CAS số: CAS7740-17-7";
            f.lbsongtu.Text = "Số nguyên tử: 37";
            f.lbnguyentukhoi.Text = "Nguyên tử khối; 85.467(g/mol)";
            f.lbmatdo.Text = "Mật độ: 1.53 (g/cm3)";
            f.lbnongchay.Text = "Điểm nóng chảy: 39 'C";
            f.lbsoi.Text = "Điểm sôi: 688 'C";
            f.lbcauhinh.Text = "Cấu hình điện tử: [Kr]5s1 1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 5s1";
            f.lbhoatri.Text = "Hóa trị: -1, +1";
            f.lbtiemnang.Text = "Tiềm năng Ion hóa của nguyên tử: 4.16";
            f.lbbankinh.Text = "Bán kính nguyên tử: 248 pm";
            f.lbbankinhvan.Text = "Bán kính Van der Waals: 303 pm";
            f.lbamdien.Text = "Âm điện: 0.82";
            f.lbhoatriphanung.Text = "Hóa trị: +1";
            f.lbelectron.Text = "Electron mối quan hệ: 46.9 kJ/mole";
            f.lbdientro.Text = "Điện trở: 1.2x10^-7";
            f.lbvotraidat.Text = " Tỉ lệ có trong vỏ Trái Đất: 0.006 %";
            f.lbconnguoi.Text = "Tỉ lệ có trong con người: 0.00046 %";
            f.lbvutru.Text = "Tỉ lệ có trong vũ trụ: 1x10^-6 %";
            f.lblienket.Text = "Liên kết cộng hóa trị bán kính: 211 pm";
        }

        private void btsr_Click(object sender, EventArgs e)
        {
            Thong_Tin_Nguyen_To f = new Thong_Tin_Nguyen_To();
            f.Show();
            f.pictureBox1.Image = new Bitmap(Application.StartupPath + "\\Image Of Visual Periodic Table\\strontium.jpg");
            f.lbkihieu.Text = "Sr";
            f.lbtennguyento.Text = "Stronti";
            f.lbmol.Text = "87.62 (g/mol)";
            f.lbloai.Text = "KIM LOẠI KIỀM THỔ";
            f.lbtenlatin.Text = "Tên Latin: Stronti";
            f.lbtenanh.Text = "Tên tiếng Anh: Stroniti";
            f.lbnam.Text = "Năm khám phá: 1790";
            f.lbnguoi.Text = "Người khám phá: Adair Crawford";
            f.lbvo.Text = "Vỏ điện tử: K2 L8 M18 N8 O2";
            f.lbcas.Text = "CAS số: CAS7740-24-6";
            f.lbsongtu.Text = "Số nguyên tử: 38";
            f.lbnguyentukhoi.Text = "Nguyên tử khối; 87.62 (g/mol)";
            f.lbmatdo.Text = "Mật độ: 2.54 (g/cm3)";
            f.lbnongchay.Text = "Điểm nóng chảy: 767 'C";
            f.lbsoi.Text = "Điểm sôi: 1382 'C";
            f.lbcauhinh.Text = "Cấu hình điện tử: [Kr]5s2 1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 5s2";
            f.lbhoatri.Text = "Hóa trị: +1, +2";
            f.lbtiemnang.Text = "Tiềm năng Ion hóa của nguyên tử: 5.67";
            f.lbbankinh.Text = "Bán kính nguyên tử: 215 pm";
            f.lbbankinhvan.Text = "Bán kính Van der Waals: 249 pm";
            f.lbamdien.Text = "Âm điện: 0.95";
            f.lbhoatriphanung.Text = "Hóa trị: +2";
            f.lbelectron.Text = "Electron mối quan hệ: 5.03 kJ/mole";
            f.lbdientro.Text = "Điện trở: 1.3x10^-7";
            f.lbvotraidat.Text = " Tỉ lệ có trong vỏ Trái Đất: 0.036 %";
            f.lbconnguoi.Text = "Tỉ lệ có trong con người: 0.00046 %";
            f.lbvutru.Text = "Tỉ lệ có trong vũ trụ: 4x10^-6 %";
            f.lblienket.Text = "Liên kết cộng hóa trị bán kính: 192 pm";
        }

        private void bty_Click(object sender, EventArgs e)
        {
            Thong_Tin_Nguyen_To f = new Thong_Tin_Nguyen_To();
            f.Show();
            f.pictureBox1.Image = new Bitmap(Application.StartupPath + "\\Image Of Visual Periodic Table\\yttrium-2.jpg");
            f.lbkihieu.Text = "Y";
            f.lbtennguyento.Text = "Ytri";
            f.lbmol.Text = "88.905 (g/mol)";
            f.lbloai.Text = "KIM LOẠI CHUYỂN TIẾP";
            f.lbtenlatin.Text = "Tên Latin: Yttrium";
            f.lbtenanh.Text = "Tên tiếng Anh: Yttrium";
            f.lbnam.Text = "Năm khám phá: 1794";
            f.lbnguoi.Text = "Người khám phá: Johan Gadolin";
            f.lbvo.Text = "Vỏ điện tử: K2 L8 M18 N9 O2";
            f.lbcas.Text = "CAS số: CAS7740-65-5";
            f.lbsongtu.Text = "Số nguyên tử: 39";
            f.lbnguyentukhoi.Text = "Nguyên tử khối; 88.905 (g/mol)";
            f.lbmatdo.Text = "Mật độ: 4.47 (g/cm3)";
            f.lbnongchay.Text = "Điểm nóng chảy: 1532 'C";
            f.lbsoi.Text = "Điểm sôi: 3337 'C";
            f.lbcauhinh.Text = "Cấu hình điện tử: [Kr]5s2 4d1 1s2 2s2 2p6 3s2 4s2 3d10 4p6 5s2 4d1";
            f.lbhoatri.Text = "Hóa trị: +1, +2, +3";
            f.lbtiemnang.Text = "Tiềm năng Ion hóa của nguyên tử: 6.5";
            f.lbbankinh.Text = "Bán kính nguyên tử: 178 pm";
            f.lbbankinhvan.Text = "Bán kính Van der Waals: --*-- pm";
            f.lbamdien.Text = "Âm điện: 1.22";
            f.lbhoatriphanung.Text = "Hóa trị: +3";
            f.lbelectron.Text = "Electron mối quan hệ: 29.6 kJ/mole";
            f.lbdientro.Text = "Điện trở: 5.6x10^-7";
            f.lbvotraidat.Text = " Tỉ lệ có trong vỏ Trái Đất: 0.0029 %";
            f.lbconnguoi.Text = "Tỉ lệ có trong con người: --*-- %";
            f.lbvutru.Text = "Tỉ lệ có trong vũ trụ: 7x10^-7 %";
            f.lblienket.Text = "Liên kết cộng hóa trị bán kính: 162 pm"; 
        }

        private void btzr_Click(object sender, EventArgs e)
        {
            Thong_Tin_Nguyen_To f = new Thong_Tin_Nguyen_To();
            f.Show();
            f.pictureBox1.Image = new Bitmap(Application.StartupPath + "\\Image Of Visual Periodic Table\\zirconium.jpg");
            f.lbkihieu.Text = "Zr";
            f.lbtennguyento.Text = "Ziriconi";
            f.lbmol.Text = "91.224 (g/mol)";
            f.lbloai.Text = "KIM LOẠI CHUYỂN TIẾP";
            f.lbtenlatin.Text = "Tên Latin: Ziriconium";
            f.lbtenanh.Text = "Tên tiếng Anh: Ziriconium";
            f.lbnam.Text = "Năm khám phá: 1789";
            f.lbnguoi.Text = "Người khám phá: Martin Heinrich Klaproth";
            f.lbvo.Text = "Vỏ điện tử: K2 L8 M18 N10 O2";
            f.lbcas.Text = "CAS số: CAS7740-67-7";
            f.lbsongtu.Text = "Số nguyên tử: 40";
            f.lbnguyentukhoi.Text = "Nguyên tử khối; 91.224 (g/mol)";
            f.lbmatdo.Text = "Mật độ: 6.51 (g/cm3)";
            f.lbnongchay.Text = "Điểm nóng chảy: 1852 'C";
            f.lbsoi.Text = "Điểm sôi: 4377 'C";
            f.lbcauhinh.Text = "Cấu hình điện tử: [Kr]5s2 4d1 1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 5s2 4d2";
            f.lbhoatri.Text = "Hóa trị: -2, +1, +2, +3, +4";
            f.lbtiemnang.Text = "Tiềm năng Ion hóa của nguyên tử: 6";
            f.lbbankinh.Text = "Bán kính nguyên tử: 160 pm";
            f.lbbankinhvan.Text = "Bán kính Van der Waals: --*-- pm";
            f.lbamdien.Text = "Âm điện: 1.33";
            f.lbhoatriphanung.Text = "Hóa trị: (+2), (+3), +4";
            f.lbelectron.Text = "Electron mối quan hệ: 41.1 kJ/mole";
            f.lbdientro.Text = "Điện trở: 4.2x10^-7";
            f.lbvotraidat.Text = " Tỉ lệ có trong vỏ Trái Đất: 0.013 %";
            f.lbconnguoi.Text = "Tỉ lệ có trong con người: 5x10^-6 %";
            f.lbvutru.Text = "Tỉ lệ có trong vũ trụ: 5x10^-6 %";
            f.lblienket.Text = "Liên kết cộng hóa trị bán kính: 148 pm"; 
        }

        private void btnb_Click(object sender, EventArgs e)
        {
            Thong_Tin_Nguyen_To f = new Thong_Tin_Nguyen_To();
            f.Show();
            f.pictureBox1.Image = new Bitmap(Application.StartupPath + "\\Image Of Visual Periodic Table\\niobium.jpg");
            f.lbkihieu.Text = "Nb";
            f.lbtennguyento.Text = "Niobi";
            f.lbmol.Text = "92.906 (g/mol)";
            f.lbloai.Text = "KIM LOẠI CHUYỂN TIẾP";
            f.lbtenlatin.Text = "Tên Latin: Niobium";
            f.lbtenanh.Text = "Tên tiếng Anh: Niobium";
            f.lbnam.Text = "Năm khám phá: 1801";
            f.lbnguoi.Text = "Người khám phá: Charles Hatchett";
            f.lbvo.Text = "Vỏ điện tử: K2 L8 M18 N12 O1";
            f.lbcas.Text = "CAS số: CAS7740-67-7";
            f.lbsongtu.Text = "Số nguyên tử: 41";
            f.lbnguyentukhoi.Text = "Nguyên tử khối; 92.906 (g/mol)";
            f.lbmatdo.Text = "Mật độ: 8.58 (g/cm3)";
            f.lbnongchay.Text = "Điểm nóng chảy: 2468 'C";
            f.lbsoi.Text = "Điểm sôi: 4727 'C";
            f.lbcauhinh.Text = "Cấu hình điện tử: [Kr]5s1 4d4 1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 5s1 4d4";
            f.lbhoatri.Text = "Hóa trị: -1, -3, +1, +2, +3, +4, +5";
            f.lbtiemnang.Text = "Tiềm năng Ion hóa của nguyên tử: --*--";
            f.lbbankinh.Text = "Bán kính nguyên tử: 146 pm";
            f.lbbankinhvan.Text = "Bán kính Van der Waals: --*-- pm";
            f.lbamdien.Text = "Âm điện: 1.6";
            f.lbhoatriphanung.Text = "Hóa trị: (+2), +3, (+4), +5";
            f.lbelectron.Text = "Electron mối quan hệ: 86.1 kJ/mole";
            f.lbdientro.Text = "Điện trở: 1.5x10^-7";
            f.lbvotraidat.Text = " Tỉ lệ có trong vỏ Trái Đất: 0.0017 %";
            f.lbconnguoi.Text = "Tỉ lệ có trong con người: --*-- %";
            f.lbvutru.Text = "Tỉ lệ có trong vũ trụ: 2x10^-7 %";
            f.lblienket.Text = "Liên kết cộng hóa trị bán kính: 137 pm"; 
        }

        private void btmo_Click(object sender, EventArgs e)
        {
            Thong_Tin_Nguyen_To f = new Thong_Tin_Nguyen_To();
            f.Show();
            f.pictureBox1.Image = new Bitmap(Application.StartupPath + "\\Image Of Visual Periodic Table\\molybdenum.jpg");
            f.lbkihieu.Text = "Mo";
            f.lbtennguyento.Text = "Molypđen";
            f.lbmol.Text = "95.94 (g/mol)";
            f.lbloai.Text = "KIM LOẠI CHUYỂN TIẾP";
            f.lbtenlatin.Text = "Tên Latin: Molybdaenum";
            f.lbtenanh.Text = "Tên tiếng Anh: Molybdaenum";
            f.lbnam.Text = "Năm khám phá: 1781";
            f.lbnguoi.Text = "Người khám phá: Carl Wihelm Scheele";
            f.lbvo.Text = "Vỏ điện tử: K2 L8 M18 N13 O1";
            f.lbcas.Text = "CAS số: CAS7739-98-7";
            f.lbsongtu.Text = "Số nguyên tử: 42";
            f.lbnguyentukhoi.Text = "Nguyên tử khối; 95.94 (g/mol)";
            f.lbmatdo.Text = "Mật độ: 10.22 (g/cm3)";
            f.lbnongchay.Text = "Điểm nóng chảy: 2617 'C";
            f.lbsoi.Text = "Điểm sôi: 4610 'C";
            f.lbcauhinh.Text = "Cấu hình điện tử: [Kr]5s1 4d5 1s2 2s2 2p6 3s2 4s2 3d10 4p6 5s1 4d5";
            f.lbhoatri.Text = "Hóa trị: -1, -2, -4, +1, +2, +3, +4, +5, +6";
            f.lbtiemnang.Text = "Tiềm năng Ion hóa của nguyên tử: 7.35";
            f.lbbankinh.Text = "Bán kính nguyên tử: 139 pm";
            f.lbbankinhvan.Text = "Bán kính Van der Waals: --*-- pm";
            f.lbamdien.Text = "Âm điện: 2.16";
            f.lbhoatriphanung.Text = "Hóa trị: (+2), +3, (+4), (+5), +6";
            f.lbelectron.Text = "Electron mối quan hệ: 71.9 kJ/mole";
            f.lbdientro.Text = "Điện trở: 5x10^-8";
            f.lbvotraidat.Text = " Tỉ lệ có trong vỏ Trái Đất: 0.00011 %";
            f.lbconnguoi.Text = "Tỉ lệ có trong con người: 0.00001 %";
            f.lbvutru.Text = "Tỉ lệ có trong vũ trụ: 5x10^-7 %";
            f.lblienket.Text = "Liên kết cộng hóa trị bán kính: 145 pm"; 
        }

        private void bttc_Click(object sender, EventArgs e)
        {
            Thong_Tin_Nguyen_To f = new Thong_Tin_Nguyen_To();
            f.Show();
            f.pictureBox1.Image = new Bitmap(Application.StartupPath + "\\Image Of Visual Periodic Table\\Khong_co_anh_VPTN.png");
            f.lbkihieu.Text = "Tc";
            f.lbtennguyento.Text = "Tecnexi";
            f.lbmol.Text = "98.906 (g/mol)";
            f.lbloai.Text = "KIM LOẠI CHUYỂN TIẾP - PHÓNG XẠ";
            f.lbtenlatin.Text = "Tên Latin: Technetium";
            f.lbtenanh.Text = "Tên tiếng Anh: Technetium";
            f.lbnam.Text = "Năm khám phá: 1937";
            f.lbnguoi.Text = "Người khám phá: E.G Segrè, Carlo Perrier";
            f.lbvo.Text = "Vỏ điện tử: K2 L8 M18 N13 O2";
            f.lbcas.Text = "CAS số: CAS7740-26-8";
            f.lbsongtu.Text = "Số nguyên tử: 43";
            f.lbnguyentukhoi.Text = "Nguyên tử khối; 98.906 (g/mol)";
            f.lbmatdo.Text = "Mật độ: 11.49 (g/cm3)";
            f.lbnongchay.Text = "Điểm nóng chảy: 2157 'C";
            f.lbsoi.Text = "Điểm sôi: 2465 'C";
            f.lbcauhinh.Text = "Cấu hình điện tử: [Kr]5s1 4d5 1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 5s2 4d5";
            f.lbhoatri.Text = "Hóa trị: -1, -3, +1, +2, +3, +4, +5, +6, +7";
            f.lbtiemnang.Text = "Tiềm năng Ion hóa của nguyên tử: --*--";
            f.lbbankinh.Text = "Bán kính nguyên tử: 136 pm";
            f.lbbankinhvan.Text = "Bán kính Van der Waals: --*-- pm";
            f.lbamdien.Text = "Âm điện: 1.9";
            f.lbhoatriphanung.Text = "Hóa trị: +6";
            f.lbelectron.Text = "Electron mối quan hệ: 53 kJ/mole";
            f.lbdientro.Text = "Điện trở: 2x10^-7";
            f.lbvotraidat.Text = " Tỉ lệ có trong vỏ Trái Đất: --*-- %";
            f.lbconnguoi.Text = "Tỉ lệ có trong con người: --*-- %";
            f.lbvutru.Text = "Tỉ lệ có trong vũ trụ: --*-- %";
            f.lblienket.Text = "Liên kết cộng hóa trị bán kính: 156 pm"; 
        }

        private void btru_Click(object sender, EventArgs e)
        {
            Thong_Tin_Nguyen_To f = new Thong_Tin_Nguyen_To();
            f.Show();
            f.pictureBox1.Image = new Bitmap(Application.StartupPath + "\\Image Of Visual Periodic Table\\ruthenium-crystal.jpg");
            f.lbkihieu.Text = "Ru";
            f.lbtennguyento.Text = "Rutheni";
            f.lbmol.Text = "101.07 (g/mol)";
            f.lbloai.Text = "KIM LOẠI CHUYỂN TIẾP";
            f.lbtenlatin.Text = "Tên Latin: Ruthenium";
            f.lbtenanh.Text = "Tên tiếng Anh: Ruthenium";
            f.lbnam.Text = "Năm khám phá: 1844";
            f.lbnguoi.Text = "Người khám phá: Karl Ernst Claus";
            f.lbvo.Text = "Vỏ điện tử: K2 L8 M18 N15 O1";
            f.lbcas.Text = "CAS số: CAS7740-18-8";
            f.lbsongtu.Text = "Số nguyên tử: 44";
            f.lbnguyentukhoi.Text = "Nguyên tử khối; 101.07 (g/mol)";
            f.lbmatdo.Text = "Mật độ: 12.41 (g/cm3)";
            f.lbnongchay.Text = "Điểm nóng chảy: 2334 'C";
            f.lbsoi.Text = "Điểm sôi: 4077 'C";
            f.lbcauhinh.Text = "Cấu hình điện tử: [Kr]5s1 4d7 1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 5s1 4d7";
            f.lbhoatri.Text = "Hóa trị: -2, -4, +1, +2, +3, +4, +5, +6, +7, +8";
            f.lbtiemnang.Text = "Tiềm năng Ion hóa của nguyên tử: 7.5";
            f.lbbankinh.Text = "Bán kính nguyên tử: 134 pm";
            f.lblienket.Text = "Liên kết cộng hóa trị bán kính: 126 pm"; 
            f.lbbankinhvan.Text = "Bán kính Van der Waals: --*-- pm";
            f.lbamdien.Text = "Âm điện: 2.2";
            f.lbhoatriphanung.Text = "Hóa trị: (+2), +3, +4, (+6), (+7), +8";
            f.lbelectron.Text = "Electron mối quan hệ: 101.3 kJ/mole";
            f.lbdientro.Text = "Điện trở: 7.1x10^-8";
            f.lbvotraidat.Text = " Tỉ lệ có trong vỏ Trái Đất: 9.9x10^-8 %";
            f.lbconnguoi.Text = "Tỉ lệ có trong con người: --*-- %";
            f.lbvutru.Text = "Tỉ lệ có trong vũ trụ: 4x10^-7 %";
        }

        private void btrh_Click(object sender, EventArgs e)
        {
            Thong_Tin_Nguyen_To f = new Thong_Tin_Nguyen_To();
            f.Show();
            f.pictureBox1.Image = new Bitmap(Application.StartupPath + "\\Image Of Visual Periodic Table\\rhodium.jpg");
            f.lbkihieu.Text = "Rođi";
            f.lbtennguyento.Text = "Rođi";
            f.lbmol.Text = "102.905 (g/mol)";
            f.lbloai.Text = "KIM LOẠI CHUYỂN TIẾP";
            f.lbtenlatin.Text = "Tên Latin: Rhodium";
            f.lbtenanh.Text = "Tên tiếng Anh: Rhodium";
            f.lbnam.Text = "Năm khám phá: 1803";
            f.lbnguoi.Text = "Người khám phá: W.H Wollaston";
            f.lbvo.Text = "Vỏ điện tử: K2 L8 M18 N16 O1";
            f.lbcas.Text = "CAS số: CAS7740-16-6";
            f.lbsongtu.Text = "Số nguyên tử: 45";
            f.lbnguyentukhoi.Text = "Nguyên tử khối; 102.905 (g/mol)";
            f.lbmatdo.Text = "Mật độ: 12.41 (g/cm3)";
            f.lbnongchay.Text = "Điểm nóng chảy: 1966 'C";
            f.lbsoi.Text = "Điểm sôi: 3727 'C";
            f.lbcauhinh.Text = "Cấu hình điện tử: [Kr]5s1 4d8 1s2 2s2 2p6 3s2 3p6 3d10 4s2 4p6 5s1 4d8";
            f.lbhoatri.Text = "Hóa trị: -1, -3, +1, +2, +3, +4, +5, +6";
            f.lbtiemnang.Text = "Tiềm năng Ion hóa của nguyên tử: 7.7";
            f.lbbankinh.Text = "Bán kính nguyên tử: 134 pm";
            f.lblienket.Text = "Liên kết cộng hóa trị bán kính: 135 pm";
            f.lbbankinhvan.Text = "Bán kính Van der Waals: --*-- pm";
            f.lbamdien.Text = "Âm điện: 2.28";
            f.lbhoatriphanung.Text = "Hóa trị: (+2), (+3), +4, (+6)";
            f.lbelectron.Text = "Electron mối quan hệ: 109.7 kJ/mole";
            f.lbdientro.Text = "Điện trở: 4.3x10^-8";
            f.lbvotraidat.Text = " Tỉ lệ có trong vỏ Trái Đất: 7x10^-8 %";
            f.lbconnguoi.Text = "Tỉ lệ có trong con người: --*-- %";
            f.lbvutru.Text = "Tỉ lệ có trong vũ trụ: 6x10^-8 %";
        }

        private void màuChấtChỉThịToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Để tham gia thảo luận trực tiếp thì bạn cần có kết nối Internet!", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tinHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // Process.Start("https://cungnhauhoctot.wordpress.com/portfolio/tin-hoc/");
            DialogResult chon = MessageBox.Show("Bạn muốn duyệt trang Web này trên trình duyệt mặc định hay sử dụng trình duyệt của phần mềm?\nYes=Trình duyệt hệ thống\nNo = Trình duyệt phần mềm", "Câu hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (chon == DialogResult.Yes)
            {
                Process.Start("https://cungnhauhoctot.wordpress.com/portfolio/tin-hoc/");
            }
            else
            {
                Trinh_Duyet f = new Trinh_Duyet();
                f.Show();
                f.webBrowser1.Url = new Uri("https://cungnhauhoctot.wordpress.com/portfolio/tin-hoc/");
            }
        }

        private void cấuHìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cai_Dat f = new Cai_Dat();
            f.Show();
        }

        private void btpd_Click(object sender, EventArgs e)
        {
            Thong_Tin_Nguyen_To f = new Thong_Tin_Nguyen_To();
            f.Show();
            f.pictureBox1.Image = new Bitmap(Application.StartupPath + "\\Image Of Visual Periodic Table\\palladium.jpg");
            f.lbkihieu.Text = "Pd";
            f.lbtennguyento.Text = "Plađi";
            f.lbmol.Text = "106.42 (g/mol)";
            f.lbloai.Text = "KIM LOẠI CHUYỂN TIẾP";
            f.lbtenlatin.Text = "Tên Latin: Palladium";
            f.lbtenanh.Text = "Tên tiếng Anh: Palladium";
            f.lbnam.Text = "Năm khám phá: 1803";
            f.lbnguoi.Text = "Người khám phá: W.H Wollaston";
            f.lbvo.Text = "Vỏ điện tử: K2 L8 M18 N18";
            f.lbcas.Text = "CAS số: CAS7740-05-3";
            f.lbsongtu.Text = "Số nguyên tử: 46";
            f.lbnguyentukhoi.Text = "Nguyên tử khối; 106.42 (g/mol)";
            f.lbmatdo.Text = "Mật độ: 12.02 (g/cm3)";
            f.lbnongchay.Text = "Điểm nóng chảy: 1552 'C";
            f.lbsoi.Text = "Điểm sôi: 2665 'C";
            f.lbcauhinh.Text = "Cấu hình điện tử: [Kr]4d10 1s2 2p6 3s2 3p6 4s2 3d10 4p6 5s0 4d10";
            f.lbhoatri.Text = "Hóa trị: +1, +2, +3, +4";
            f.lbtiemnang.Text = "Tiềm năng Ion hóa của nguyên tử: 8.3";
            f.lbbankinh.Text = "Bán kính nguyên tử: 137 pm";
            f.lblienket.Text = "Liên kết cộng hóa trị bán kính: 131 pm";
            f.lbbankinhvan.Text = "Bán kính Van der Waals: 163 pm";
            f.lbamdien.Text = "Âm điện: 2.2";
            f.lbhoatriphanung.Text = "Hóa trị: +2, +4, (+6)";
            f.lbelectron.Text = "Electron mối quan hệ: 53.7 kJ/mole";
            f.lbdientro.Text = "Điện trở: 1x10^-7";
            f.lbvotraidat.Text = " Tỉ lệ có trong vỏ Trái Đất: 6.3x10^-7 %";
            f.lbconnguoi.Text = "Tỉ lệ có trong con người: --*-- %";
            f.lbvutru.Text = "Tỉ lệ có trong vũ trụ: 2x10^-7 %";
        }

        private void btag_Click(object sender, EventArgs e)
        {
            Thong_Tin_Nguyen_To f = new Thong_Tin_Nguyen_To();
            f.Show();
            f.pictureBox1.Image = new Bitmap(Application.StartupPath + "\\Image Of Visual Periodic Table\\Ag.jpg");
            f.lbkihieu.Text = "Ag";
            f.lbtennguyento.Text = "Bạc";
            f.lbmol.Text = "107.868 (g/mol)";
            f.lbloai.Text = "KIM LOẠI CHUYỂN TIẾP";
            f.lbtenlatin.Text = "Tên Latin: Argentium";
            f.lbtenanh.Text = "Tên tiếng Anh: Silver";
            f.lbnam.Text = "Năm khám phá: --*--";
            f.lbnguoi.Text = "Người khám phá: --*--";
            f.lbvo.Text = "Vỏ điện tử: K2 L8 M18 N18 O1";
            f.lbcas.Text = "CAS số: CAS7740-22-4";
            f.lbsongtu.Text = "Số nguyên tử: 47";
            f.lbnguyentukhoi.Text = "Nguyên tử khối; 107.868 (g/mol)";
            f.lbmatdo.Text = "Mật độ: 10.49 (g/cm3)";
            f.lbnongchay.Text = "Điểm nóng chảy: 961.9 'C";
            f.lbsoi.Text = "Điểm sôi: 2162 'C";
            f.lbcauhinh.Text = "Cấu hình điện tử: [Kr]4d10 5s1 1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 4d10 5s1";
            f.lbhoatri.Text = "Hóa trị: -1, -2, +1, +2, +3";
            f.lbtiemnang.Text = "Tiềm năng Ion hóa của nguyên tử: 7.54";
            f.lbbankinh.Text = "Bán kính nguyên tử: 144 pm";
            f.lblienket.Text = "Liên kết cộng hóa trị bán kính: 153 pm";
            f.lbbankinhvan.Text = "Bán kính Van der Waals: 172 pm";
            f.lbamdien.Text = "Âm điện: 1.93";
            f.lbhoatriphanung.Text = "Hóa trị: +1, (+2), (+3)";
            f.lbelectron.Text = "Electron mối quan hệ: 125.6 kJ/mole";
            f.lbdientro.Text = "Điện trở: 1.6x10^-8";
            f.lbvotraidat.Text = " Tỉ lệ có trong vỏ Trái Đất: 7.9x10^-6 %";
            f.lbconnguoi.Text = "Tỉ lệ có trong con người: --*-- %";
            f.lbvutru.Text = "Tỉ lệ có trong vũ trụ: 6x10^-8 %";
        }

        private void btcd_Click(object sender, EventArgs e)
        {
            Thong_Tin_Nguyen_To f = new Thong_Tin_Nguyen_To();
            f.Show();
            f.pictureBox1.Image = new Bitmap(Application.StartupPath + "\\Image Of Visual Periodic Table\\cadmium.jpg");
            f.lbkihieu.Text = "Cd";
            f.lbtennguyento.Text = "Catmi";
            f.lbmol.Text = "112.411 (g/mol)";
            f.lbloai.Text = "KIM LOẠI CHUYỂN TIẾP";
            f.lbtenlatin.Text = "Tên Latin: Cadmium";
            f.lbtenanh.Text = "Tên tiếng Anh: Cadmium";
            f.lbnam.Text = "Năm khám phá: 1817";
            f.lbnguoi.Text = "Người khám phá: --*--";
            f.lbvo.Text = "Vỏ điện tử: K2 L8 M18 N18 O2";
            f.lbcas.Text = "CAS số: CAS7740-43-9";
            f.lbsongtu.Text = "Số nguyên tử: 48";
            f.lbnguyentukhoi.Text = "Nguyên tử khối; 112.411 (g/mol)";
            f.lbmatdo.Text = "Mật độ: 8.64 (g/cm3)";
            f.lbnongchay.Text = "Điểm nóng chảy: 319.1 'C";
            f.lbsoi.Text = "Điểm sôi: 765 'C";
            f.lbcauhinh.Text = "Cấu hình điện tử: [Kr]4d10 5s2 1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 4d10 5s2";
            f.lbhoatri.Text = "Hóa trị: -2, +1, +2";
            f.lbtiemnang.Text = "Tiềm năng Ion hóa của nguyên tử: 8.95";
            f.lbbankinh.Text = "Bán kính nguyên tử: 154 pm";
            f.lblienket.Text = "Liên kết cộng hóa trị bán kính: 148 pm";
            f.lbbankinhvan.Text = "Bán kính Van der Waals: 158 pm";
            f.lbamdien.Text = "Âm điện: 1.69";
            f.lbhoatriphanung.Text = "Hóa trị: +2";
            f.lbelectron.Text = "Electron mối quan hệ: 0 kJ/mole";
            f.lbdientro.Text = "Điện trở: 7x10^-8";
            f.lbvotraidat.Text = " Tỉ lệ có trong vỏ Trái Đất: 0.000015 %";
            f.lbconnguoi.Text = "Tỉ lệ có trong con người: 0.00007 %";
            f.lbvutru.Text = "Tỉ lệ có trong vũ trụ: 2x10^-7 %";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Thong_Tin_Nguyen_To f = new Thong_Tin_Nguyen_To();
            f.Show();
            f.pictureBox1.Image = new Bitmap(Application.StartupPath + "\\Image Of Visual Periodic Table\\iridium.jpg");
            f.lbkihieu.Text = "In";
            f.lbtennguyento.Text = "Indi";
            f.lbmol.Text = "114.818 (g/mol)";
            f.lbloai.Text = "CHẤT BÁN DẪN";
            f.lbtenlatin.Text = "Tên Latin: Indium";
            f.lbtenanh.Text = "Tên tiếng Anh: Indium";
            f.lbnam.Text = "Năm khám phá: 1863";
            f.lbnguoi.Text = "Người khám phá: Ferdinand Reich";
            f.lbvo.Text = "Vỏ điện tử: K2 L8 M18 N18 O3";
            f.lbcas.Text = "CAS số: CAS7740-74-6";
            f.lbsongtu.Text = "Số nguyên tử: 49";
            f.lbnguyentukhoi.Text = "Nguyên tử khối; 114.818 (g/mol)";
            f.lbmatdo.Text = "Mật độ: 7.31 (g/cm3)";
            f.lbnongchay.Text = "Điểm nóng chảy: 156.2 'C";
            f.lbsoi.Text = "Điểm sôi: 2080 'C";
            f.lbcauhinh.Text = "Cấu hình điện tử: [Kr]4d10 5s2 5p1 1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 4d10 5s2 5p1";
            f.lbhoatri.Text = "Hóa trị: -1, -2, -5, +1, +2, +3";
            f.lbtiemnang.Text = "Tiềm năng Ion hóa của nguyên tử: 8.95";
            f.lbbankinh.Text = "Bán kính nguyên tử: 166 pm";
            f.lblienket.Text = "Liên kết cộng hóa trị bán kính: 144 pm";
            f.lbbankinhvan.Text = "Bán kính Van der Waals: 193 pm";
            f.lbamdien.Text = "Âm điện: 1.78";
            f.lbhoatriphanung.Text = "Hóa trị: (+1), (+2), +3";
            f.lbelectron.Text = "Electron mối quan hệ: 28.9 kJ/mole";
            f.lbdientro.Text = "Điện trở: 8x10^-8";
            f.lbvotraidat.Text = " Tỉ lệ có trong vỏ Trái Đất: 0.000016 %";
            f.lbconnguoi.Text = "Tỉ lệ có trong con người: --*-- %";
            f.lbvutru.Text = "Tỉ lệ có trong vũ trụ: 3x10^-8 %";
        }

        private void btsn_Click(object sender, EventArgs e)
        {
            Thong_Tin_Nguyen_To f = new Thong_Tin_Nguyen_To();
            f.Show();
            f.pictureBox1.Image = new Bitmap(Application.StartupPath + "\\Image Of Visual Periodic Table\\tin.jpg");
            f.lbkihieu.Text = "Sn";
            f.lbtennguyento.Text = "Thiếc";
            f.lbmol.Text = "118.710 (g/mol)";
            f.lbloai.Text = "CHẤT BÁN DẪN";
            f.lbtenlatin.Text = "Tên Latin: Stannum";
            f.lbtenanh.Text = "Tên tiếng Anh: Thiếc";
            f.lbnam.Text = "Năm khám phá: --*--";
            f.lbnguoi.Text = "Người khám phá: --*--";
            f.lbvo.Text = "Vỏ điện tử: K2 L8 M18 N18 O4";
            f.lbcas.Text = "CAS số: CAS7740-31-5";
            f.lbsongtu.Text = "Số nguyên tử: 50";
            f.lbnguyentukhoi.Text = "Nguyên tử khối; 118.710 (g/mol)";
            f.lbmatdo.Text = "Mật độ: 7.29 (g/cm3)";
            f.lbnongchay.Text = "Điểm nóng chảy: 232 'C";
            f.lbsoi.Text = "Điểm sôi: 2598 'C";
            f.lbcauhinh.Text = "Cấu hình điện tử: [Kr]4d10 5s2 5p2 1s2 2s2 2p6 3s2 4s2 3d10 4p6 5s2 5p2";
            f.lbhoatri.Text = "Hóa trị: -1, -2, -3, -4, +1, +2, +3, +4";
            f.lbtiemnang.Text = "Tiềm năng Ion hóa của nguyên tử: 7.37";
            f.lbbankinh.Text = "Bán kính nguyên tử: 162 pm";
            f.lblienket.Text = "Liên kết cộng hóa trị bán kính: 141 pm";
            f.lbbankinhvan.Text = "Bán kính Van der Waals: 217 pm";
            f.lbamdien.Text = "Âm điện: 1.96";
            f.lbhoatriphanung.Text = "Hóa trị: +2, +4";
            f.lbelectron.Text = "Electron mối quan hệ: 107.3 kJ/mole";
            f.lbdientro.Text = "Điện trở: 1.1X10^-7";
            f.lbvotraidat.Text = " Tỉ lệ có trong vỏ Trái Đất: 0.00022 %";
            f.lbconnguoi.Text = "Tỉ lệ có trong con người: 0.00002 %";
            f.lbvutru.Text = "Tỉ lệ có trong vũ trụ: 4X10^-7 %";
        }

        private void btsb_Click(object sender, EventArgs e)
        {
            Thong_Tin_Nguyen_To f = new Thong_Tin_Nguyen_To();
            f.Show();
            f.pictureBox1.Image = new Bitmap(Application.StartupPath + "\\Image Of Visual Periodic Table\\antimony.jpg");
            f.lbkihieu.Text = "Sb";
            f.lbtennguyento.Text = "Antimon";
            f.lbmol.Text = "121.760 (g/mol)";
            f.lbloai.Text = "Á KIÊM";
            f.lbtenlatin.Text = "Tên Latin: Stibium";
            f.lbtenanh.Text = "Tên tiếng Anh: Antimony";
            f.lbnam.Text = "Năm khám phá: --*--";
            f.lbnguoi.Text = "Người khám phá: --*--";
            f.lbvo.Text = "Vỏ điện tử: K2 L8 M18 N18 O5";
            f.lbcas.Text = "CAS số: CAS7740-36-0";
            f.lbsongtu.Text = "Số nguyên tử: 51";
            f.lbnguyentukhoi.Text = "Nguyên tử khối; 121.760 (g/mol)";
            f.lbmatdo.Text = "Mật độ: 6.69 (g/cm3)";
            f.lbnongchay.Text = "Điểm nóng chảy: 630.7 'C";
            f.lbsoi.Text = "Điểm sôi: 1633 'C";
            f.lbcauhinh.Text = "Cấu hình điện tử: [Kr]4d10 5s2 5d3 1s2 2s2 2p6 3s2 3d10 4s2 4p6 4d10 5s2 5d3";
            f.lbhoatri.Text = "Hóa trị: -1, -2, -2, +1, +2, +3, +4, +5";
            f.lbtiemnang.Text = "Tiềm năng Ion hóa của nguyên tử: 8.35";
            f.lbbankinh.Text = "Bán kính nguyên tử: 159 pm";
            f.lblienket.Text = "Liên kết cộng hóa trị bán kính: 138 pm";
            f.lbbankinhvan.Text = "Bán kính Van der Waals: 206 pm";
            f.lbamdien.Text = "Âm điện: 2.05";
            f.lbhoatriphanung.Text = "Hóa trị: -3, +3, (+4), +5";
            f.lbelectron.Text = "Electron mối quan hệ: 103.2 kJ/mole";
            f.lbdientro.Text = "Điện trở: 4x10^-7";
            f.lbvotraidat.Text = " Tỉ lệ có trong vỏ Trái Đất: 0.00002 %";
            f.lbconnguoi.Text = "Tỉ lệ có trong con người: --*-- %";
            f.lbvutru.Text = "Tỉ lệ có trong vũ trụ: 4x10^-8 %";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Thong_Tin_Nguyen_To f = new Thong_Tin_Nguyen_To();
            f.Show();
            f.pictureBox1.Image = new Bitmap(Application.StartupPath + "\\Image Of Visual Periodic Table\\tellurium-2.jpg");
            f.lbkihieu.Text = "Te";
            f.lbtennguyento.Text = "Telua";
            f.lbmol.Text = "127.60 (g/mol)";
            f.lbloai.Text = "Á KIÊM";
            f.lbtenlatin.Text = "Tên Latin: Tellurium";
            f.lbtenanh.Text = "Tên tiếng Anh: Telluarium";
            f.lbnam.Text = "Năm khám phá: 1783";
            f.lbnguoi.Text = "Người khám phá: --*--";
            f.lbvo.Text = "Vỏ điện tử: K2 L8 M18 N18 O6";
            f.lbcas.Text = "CAS số: CAS13494-80-9";
            f.lbsongtu.Text = "Số nguyên tử: 52";
            f.lbnguyentukhoi.Text = "Nguyên tử khối; 127.60 (g/mol)";
            f.lbmatdo.Text = "Mật độ: 6.25 (g/cm3)";
            f.lbnongchay.Text = "Điểm nóng chảy: 449.6 'C";
            f.lbsoi.Text = "Điểm sôi: 990'C";
            f.lbcauhinh.Text = "Cấu hình điện tử: [Kr]4d10 5s2 5p4 1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 4d10 5s2 5p4";
            f.lbhoatri.Text = "Hóa trị: -1, -2, +1, +2, +3, +4, +5, +6";
            f.lbtiemnang.Text = "Tiềm năng Ion hóa của nguyên tử: --*--";
            f.lbbankinh.Text = "Bán kính nguyên tử: 160 pm";
            f.lblienket.Text = "Liên kết cộng hóa trị bán kính: 135 pm";
            f.lbbankinhvan.Text = "Bán kính Van der Waals: 206 pm";
            f.lbamdien.Text = "Âm điện: 2.1";
            f.lbhoatriphanung.Text = "Hóa trị: -2, (+2), +4, +6";
            f.lbelectron.Text = "Electron mối quan hệ: 190.2 kJ/mole";
            f.lbdientro.Text = "Điện trở: 1x10^-7";
            f.lbvotraidat.Text = " Tỉ lệ có trong vỏ Trái Đất: 9.9x10^-8 %";
            f.lbconnguoi.Text = "Tỉ lệ có trong con người: --*-- %";
            f.lbvutru.Text = "Tỉ lệ có trong vũ trụ: 9x10^-7 %";
        }

        private void bti_Click(object sender, EventArgs e)
        {
            Thong_Tin_Nguyen_To f = new Thong_Tin_Nguyen_To();
            f.Show();
            f.pictureBox1.Image = new Bitmap(Application.StartupPath + "\\Image Of Visual Periodic Table\\iodine.jpg");
            f.lbkihieu.Text = "I";
            f.lbtennguyento.Text = "Iot";
            f.lbmol.Text = "126.904 (g/mol)";
            f.lbloai.Text = "HALOGEN";
            f.lbtenlatin.Text = "Tên Latin: Iodium";
            f.lbtenanh.Text = "Tên tiếng Anh: Iodium";
            f.lbnam.Text = "Năm khám phá: 1811";
            f.lbnguoi.Text = "Người khám phá: --*--";
            f.lbvo.Text = "Vỏ điện tử: K2 L8 M18 N18 O7";
            f.lbcas.Text = "CAS số: CAS7553-56-2";
            f.lbsongtu.Text = "Số nguyên tử: 53";
            f.lbnguyentukhoi.Text = "Nguyên tử khối; 125.904 (g/mol)";
            f.lbmatdo.Text = "Mật độ: 4.94 (g/cm3)";
            f.lbnongchay.Text = "Điểm nóng chảy: 113.5 'C";
            f.lbsoi.Text = "Điểm sôi: 184.4 'C";
            f.lbcauhinh.Text = "Cấu hình điện tử: [Kr]4d10 5s2 5p5 1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 4d10 5s2 5p5";
            f.lbhoatri.Text = "Hóa trị: -1, +1, +3, +4, +5, +6, +7";
            f.lbtiemnang.Text = "Tiềm năng Ion hóa của nguyên tử: 10.4";
            f.lbbankinh.Text = "Bán kính nguyên tử: 136 pm";
            f.lblienket.Text = "Liên kết cộng hóa trị bán kính: 133 pm";
            f.lbbankinhvan.Text = "Bán kính Van der Waals: 198 pm";
            f.lbamdien.Text = "Âm điện: 2.66";
            f.lbhoatriphanung.Text = "Hóa trị: -1, +1, (+3), (+4), +5, +6";
            f.lbelectron.Text = "Electron mối quan hệ: 295/2 kJ/mole";
            f.lbdientro.Text = "Điện trở: 1x10^-7";
            f.lbvotraidat.Text = " Tỉ lệ có trong vỏ Trái Đất: 0.000049 %";
            f.lbconnguoi.Text = "Tỉ lệ có trong con người: --*-- %";
            f.lbvutru.Text = "Tỉ lệ có trong vũ trụ: 1x10^-7 %";
        }

        private void btxe_Click(object sender, EventArgs e)
        {
            Thong_Tin_Nguyen_To f = new Thong_Tin_Nguyen_To();
            f.Show();
            f.lbkihieu.Text = "Xe";
            f.pictureBox1.Image = new Bitmap(Application.StartupPath + "\\Image Of Visual Periodic Table\\xenon.jpg");
            f.lbtennguyento.Text = "Xenon";
            f.lbkihieu.Text = "Xe";
            f.lbmol.Text = "131.293 (g/mol)";
            f.lbloai.Text = "KHÍ TRƠ";
            f.lbtenlatin.Text = "Tên Latin: Xenon";
            f.lbtenanh.Text = "Tên tiếng Anh: Xenon";
            f.lbnam.Text = "Năm khám phá: 1898";
            f.lbnguoi.Text = "Người khám phá: --*--";
            f.lbvo.Text = "Vỏ điện tử: K2 L8 M18 N18 O8";
            f.lbcas.Text = "CAS số: CAS7740-63-3";
            f.lbsongtu.Text = "Số nguyên tử: 54";
            f.lbnguyentukhoi.Text = "Nguyên tử khối; 131.293 (g/mol)";
            f.lbmatdo.Text = "Mật độ: 0.005894 (g/cm3)";
            f.lbnongchay.Text = "Điểm nóng chảy: -111.9 'C";
            f.lbsoi.Text = "Điểm sôi: -107 'C";
            f.lbcauhinh.Text = "Cấu hình điện tử: [Kr]4d10 5s2 5p6 1s2 2s2 2p6 3s2 4s2 3d10 4p6 4d10 5s2 5p6";
            f.lbhoatri.Text = "Hóa trị: +2, +4, +6, +8";
            f.lbtiemnang.Text = "Tiềm năng Ion hóa của nguyên tử: 12.08";
            f.lbbankinh.Text = "Bán kính nguyên tử: 108 pm";
            f.lblienket.Text = "Liên kết cộng hóa trị bán kính: 130 pm";
            f.lbbankinhvan.Text = "Bán kính Van der Waals: 216 pm";
            f.lbamdien.Text = "Âm điện: 2.6";
            f.lbhoatriphanung.Text = "Hóa trị: --*--";
            f.lbelectron.Text = "Electron mối quan hệ: 0 kJ/mole";
            f.lbdientro.Text = "Điện trở: --*--";
            f.lbvotraidat.Text = " Tỉ lệ có trong vỏ Trái Đất: 2x10^-9 %";
            f.lbconnguoi.Text = "Tỉ lệ có trong con người: --*-- %";
            f.lbvutru.Text = "Tỉ lệ có trong vũ trụ: 1x10^-6 %";
        }

        private void btcs_Click(object sender, EventArgs e)
        {
            Thong_Tin_Nguyen_To f = new Thong_Tin_Nguyen_To();
            f.Show();
            f.pictureBox1.Image = new Bitmap(Application.StartupPath + "\\Image Of Visual Periodic Table\\caesium-3.jpg");
            f.lbtennguyento.Text = "Xezi";
            f.lbkihieu.Text = "Cs";
            f.lbmol.Text = "132.905 (g/mol)";
            f.lbloai.Text = "KIÊM LOẠI KIỀM";
            f.lbtenlatin.Text = "Tên Latin: Caesium";
            f.lbtenanh.Text = "Tên tiếng Anh: Caesium";
            f.lbnam.Text = "Năm khám phá: 1860";
            f.lbnguoi.Text = "Người khám phá: R.W Bunsen, G.R Kirchhoff";
            f.lbvo.Text = "Vỏ điện tử: K2 L8 M18 N18 O8 P1";
            f.lbcas.Text = "CAS số: CAS7740-46-2";
            f.lbsongtu.Text = "Số nguyên tử: 55";
            f.lbnguyentukhoi.Text = "Nguyên tử khối; 132.905 (g/mol)";
            f.lbmatdo.Text = "Mật độ: 1.9 (g/cm3)";
            f.lbnongchay.Text = "Điểm nóng chảy: 28.4 'C";
            f.lbsoi.Text = "Điểm sôi: 690 'C";
            f.lbcauhinh.Text = "Cấu hình điện tử: [Xe]6s1 1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 5s2 4d10 5p6 6s1";
            f.lbhoatri.Text = "Hóa trị: -1, +1";
            f.lbtiemnang.Text = "Tiềm năng Ion hóa của nguyên tử: 3.88";
            f.lbbankinh.Text = "Bán kính nguyên tử: 267 pm";
            f.lblienket.Text = "Liên kết cộng hóa trị bán kính: 225 pm";
            f.lbbankinhvan.Text = "Bán kính Van der Waals: 343 pm";
            f.lbamdien.Text = "Âm điện: 0.79";
            f.lbhoatriphanung.Text = "Hóa trị: +1";
            f.lbelectron.Text = "Electron mối quan hệ: 45.5 kJ/mole";
            f.lbdientro.Text = "Điện trở: 2x10^-7";
            f.lbvotraidat.Text = " Tỉ lệ có trong vỏ Trái Đất: 0.00019 %";
            f.lbconnguoi.Text = "Tỉ lệ có trong con người: 2x10^-6 %";
            f.lbvutru.Text = "Tỉ lệ có trong vũ trụ: 8x10^-8%";
        }

        private void btba_Click(object sender, EventArgs e)
        {
            Thong_Tin_Nguyen_To f = new Thong_Tin_Nguyen_To();
            f.Show();
            f.pictureBox1.Image = new Bitmap(Application.StartupPath + "\\Image Of Visual Periodic Table\\barium.jpg");
            f.lbkihieu.Text = "Ba";
            f.lbtennguyento.Text = "Bari";
            f.lbmol.Text = "137.327 (g/mol)";
            f.lbloai.Text = "KIÊM LOẠI KIỀM THỔ";
            f.lbtenlatin.Text = "Tên Latin: Barium";
            f.lbtenanh.Text = "Tên tiếng Anh: Barium";
            f.lbnam.Text = "Năm khám phá: 1808";
            f.lbnguoi.Text = "Người khám phá: Humphry Davy";
            f.lbvo.Text = "Vỏ điện tử: K2 L8 M18 N18 O8 P2";
            f.lbcas.Text = "CAS số: CAS7740-39-3";
            f.lbsongtu.Text = "Số nguyên tử: 56";
            f.lbnguyentukhoi.Text = "Nguyên tử khối; 137.327 (g/mol)";
            f.lbmatdo.Text = "Mật độ: 3.5 (g/cm3)";
            f.lbnongchay.Text = "Điểm nóng chảy: 727 'C";
            f.lbsoi.Text = "Điểm sôi: 1897 'C";
            f.lbcauhinh.Text = "Cấu hình điện tử: [Xe]6s2 1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 5s2 4d10 5p6 6s2";
            f.lbhoatri.Text = "Hóa trị: +1, +2";
            f.lbtiemnang.Text = "Tiềm năng Ion hóa của nguyên tử: 5.19";
            f.lbbankinh.Text = "Bán kính nguyên tử: 222 pm";
            f.lblienket.Text = "Liên kết cộng hóa trị bán kính: 198 pm";
            f.lbbankinhvan.Text = "Bán kính Van der Waals: 268 pm";
            f.lbamdien.Text = "Âm điện: 0.89";
            f.lbhoatriphanung.Text = "Hóa trị: +2";
            f.lbelectron.Text = "Electron mối quan hệ: 13.95 kJ/mole";
            f.lbdientro.Text = "Điện trở: 3.5x10^-7";
            f.lbvotraidat.Text = " Tỉ lệ có trong vỏ Trái Đất: 0.034 %";
            f.lbconnguoi.Text = "Tỉ lệ có trong con người: 0.00003 %";
            f.lbvutru.Text = "Tỉ lệ có trong vũ trụ: 1x10^-6%";
        }

        private void bthf_Click(object sender, EventArgs e)
        {
            Thong_Tin_Nguyen_To f = new Thong_Tin_Nguyen_To();
            f.Show();
            f.pictureBox1.Image = new Bitmap(Application.StartupPath + "\\Image Of Visual Periodic Table\\hafnium-2.jpg");
            f.lbkihieu.Text = "Hf";
            f.lbtennguyento.Text = "Hafini";
            f.lbmol.Text = "178.49 (g/mol)";
            f.lbloai.Text = "KIÊM LOẠI CHUYỂN TIẾP";
            f.lbtenlatin.Text = "Tên Latin: Hafnium";
            f.lbtenanh.Text = "Tên tiếng Anh: Hafnium";
            f.lbnam.Text = "Năm khám phá: 1932";
            f.lbnguoi.Text = "Người khám phá: --*--";
            f.lbvo.Text = "Vỏ điện tử: K2 L8 M18 N32 O10 P2";
            f.lbcas.Text = "CAS số: CAS7740-58-6";
            f.lbsongtu.Text = "Số nguyên tử: 72";
            f.lbnguyentukhoi.Text = "Nguyên tử khối; 178.49 (g/mol)";
            f.lbmatdo.Text = "Mật độ: 13.31 (g/cm3)";
            f.lbnongchay.Text = "Điểm nóng chảy: 2233 'C";
            f.lbsoi.Text = "Điểm sôi: 4603 'C";
            f.lbcauhinh.Text = "Cấu hình điện tử: [Xe]6s2 4f14 5d2 1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 5s2 4d10 5p6 6s2 4f14 5d2";
            f.lbhoatri.Text = "Hóa trị: -2, +1, +2, +3, +4";
            f.lbtiemnang.Text = "Tiềm năng Ion hóa của nguyên tử: --*--";
            f.lbbankinh.Text = "Bán kính nguyên tử: 167 pm";
            f.lblienket.Text = "Liên kết cộng hóa trị bán kính: 150 pm";
            f.lbbankinhvan.Text = "Bán kính Van der Waals: --*-- pm";
            f.lbamdien.Text = "Âm điện: 1.3";
            f.lbhoatriphanung.Text = "Hóa trị: +4";
            f.lbelectron.Text = "Electron mối quan hệ: 0 kJ/mole";
            f.lbdientro.Text = "Điện trở: 3x10^-7";
            f.lbvotraidat.Text = " Tỉ lệ có trong vỏ Trái Đất: 0.00033 %";
            f.lbconnguoi.Text = "Tỉ lệ có trong con người: --*-- %";
            f.lbvutru.Text = "Tỉ lệ có trong vũ trụ: --*-- %";
        }

        private void btta_Click(object sender, EventArgs e)
        {
            Thong_Tin_Nguyen_To f = new Thong_Tin_Nguyen_To();
            f.Show();
            f.pictureBox1.Image = new Bitmap(Application.StartupPath + "\\Image Of Visual Periodic Table\\tantalum.jpg");
            f.lbkihieu.Text = "Ta";
            f.lbtennguyento.Text = "Tantali";
            f.lbmol.Text = "180.947 (g/mol)";
            f.lbloai.Text = "KIÊM LOẠI CHUYỂN TIẾP";
            f.lbtenlatin.Text = "Tên Latin: Tantalum";
            f.lbtenanh.Text = "Tên tiếng Anh: Tantalum";
            f.lbnam.Text = "Năm khám phá: 1802";
            f.lbnguoi.Text = "Người khám phá: --*--";
            f.lbvo.Text = "Vỏ điện tử: K2 L8 M18 N32 O11 P2";
            f.lbcas.Text = "CAS số: CAS7740-25-7";
            f.lbsongtu.Text = "Số nguyên tử: 73";
            f.lbnguyentukhoi.Text = "Nguyên tử khối; 180.947 (g/mol)";
            f.lbmatdo.Text = "Mật độ: 16.68 (g/cm3)";
            f.lbnongchay.Text = "Điểm nóng chảy: 3017 'C";
            f.lbsoi.Text = "Điểm sôi: 5458 'C";
            f.lbcauhinh.Text = "Cấu hình điện tử: [Xe]6s2 4f14 5d3 1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 5s2 4d10 5p6 6s2 4f14 5d3";
            f.lbhoatri.Text = "Hóa trị: -1, -3, +1, +2, +3, +4, +5";
            f.lbtiemnang.Text = "Tiềm năng Ion hóa của nguyên tử: --*--";
            f.lbbankinh.Text = "Bán kính nguyên tử: 149 pm";
            f.lblienket.Text = "Liên kết cộng hóa trị bán kính: 138 pm";
            f.lbbankinhvan.Text = "Bán kính Van der Waals: --*-- pm";
            f.lbamdien.Text = "Âm điện: 1.5";
            f.lbhoatriphanung.Text = "Hóa trị: (+3), (+4), +5";
            f.lbelectron.Text = "Electron mối quan hệ: 31 kJ/mole";
            f.lbdientro.Text = "Điện trở: 1.3x10^-7";
            f.lbvotraidat.Text = " Tỉ lệ có trong vỏ Trái Đất: 0.00017 %";
            f.lbconnguoi.Text = "Tỉ lệ có trong con người: --*-- %";
            f.lbvutru.Text = "Tỉ lệ có trong vũ trụ: --*-- %";
        }

        private void btw_Click(object sender, EventArgs e)
        {
            Thong_Tin_Nguyen_To f = new Thong_Tin_Nguyen_To();
            f.Show();
            f.pictureBox1.Image = new Bitmap(Application.StartupPath + "\\Image Of Visual Periodic Table\\tungsten-rod.jpg");
            f.lbkihieu.Text = "W";
            f.lbtennguyento.Text = "Vonfam";
            f.lbmol.Text = "183.84 (g/mol)";
            f.lbloai.Text = "KIÊM LOẠI CHUYỂN TIẾP";
            f.lbtenlatin.Text = "Tên Latin: Wolframium";
            f.lbtenanh.Text = "Tên tiếng Anh: Tungsten";
            f.lbnam.Text = "Năm khám phá: 1783";
            f.lbnguoi.Text = "Người khám phá: C.W Scheele";
            f.lbvo.Text = "Vỏ điện tử: K2 L8 M18 N32 O12 P2";
            f.lbcas.Text = "CAS số: CAS774033-7";
            f.lbsongtu.Text = "Số nguyên tử: 74";
            f.lbnguyentukhoi.Text = "Nguyên tử khối; 183.84 (g/mol)";
            f.lbmatdo.Text = "Mật độ: 19.26 (g/cm3)";
            f.lbnongchay.Text = "Điểm nóng chảy: 3407 'C";
            f.lbsoi.Text = "Điểm sôi: 5555 'C";
            f.lbcauhinh.Text = "Cấu hình điện tử: [Xe]6s2 4f10 5d4 1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 5s2 4d10 5p6 6s2 4f14 5d4";
            f.lbhoatri.Text = "Hóa trị: -1, -2, -4, +1, +2, +3, +4, +5, +5";
            f.lbtiemnang.Text = "Tiềm năng Ion hóa của nguyên tử: --*--";
            f.lbbankinh.Text = "Bán kính nguyên tử: 141 pm";
            f.lblienket.Text = "Liên kết cộng hóa trị bán kính: 146 pm";
            f.lbbankinhvan.Text = "Bán kính Van der Waals: --*-- pm";
            f.lbamdien.Text = "Âm điện: 2.36";
            f.lbhoatriphanung.Text = "Hóa trị: (+2), (+3), (+4), (+5), +6";
            f.lbelectron.Text = "Electron mối quan hệ: 78.6 kJ/mole";
            f.lbdientro.Text = "Điện trở: 5x10^-8";
            f.lbvotraidat.Text = " Tỉ lệ có trong vỏ Trái Đất: 0.00011 %";
            f.lbconnguoi.Text = "Tỉ lệ có trong con người: --*-- %";
            f.lbvutru.Text = "Tỉ lệ có trong vũ trụ: --*-- %";
        }

        private void btre_Click(object sender, EventArgs e)
        {
            Thong_Tin_Nguyen_To f = new Thong_Tin_Nguyen_To();
            f.Show();
            f.pictureBox1.Image = new Bitmap(Application.StartupPath + "\\Image Of Visual Periodic Table\\rhenium-3.jpg");
            f.lbkihieu.Text = "Re";
            f.lbtennguyento.Text = "Reni";
            f.lbmol.Text = "186.207 (g/mol)";
            f.lbloai.Text = "KIÊM LOẠI CHUYỂN TIẾP";
            f.lbtenlatin.Text = "Tên Latin: Rhenium";
            f.lbtenanh.Text = "Tên tiếng Anh: Rhenium";
            f.lbnam.Text = "Năm khám phá: 1925";
            f.lbnguoi.Text = "Người khám phá: --*--";
            f.lbvo.Text = "Vỏ điện tử: K2 L8 M18 N32 O13 P2";
            f.lbcas.Text = "CAS số: CAS7740-15-5";
            f.lbsongtu.Text = "Số nguyên tử: 75";
            f.lbnguyentukhoi.Text = "Nguyên tử khối; 186.207 (g/mol)";
            f.lbmatdo.Text = "Mật độ: 21.03 (g/cm3)";
            f.lbnongchay.Text = "Điểm nóng chảy: 3180 'C";
            f.lbsoi.Text = "Điểm sôi: 5596 'C";
            f.lbcauhinh.Text = "Cấu hình điện tử: [Xe]6s2 4f14 5d5 1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 5s2 4d10 5p6 6s2 4f14 5d5";
            f.lbhoatri.Text = "Hóa trị: -1 -3, +1, +2, +3, +4, +5, +6, +7";
            f.lbtiemnang.Text = "Tiềm năng Ion hóa của nguyên tử: --*--";
            f.lbbankinh.Text = "Bán kính nguyên tử: 137 pm";
            f.lblienket.Text = "Liên kết cộng hóa trị bán kính: 159 pm";
            f.lbbankinhvan.Text = "Bán kính Van der Waals: --*-- pm";
            f.lbamdien.Text = "Âm điện: 1.9";
            f.lbhoatriphanung.Text = "Hóa trị: (-1), (+1), +2, (+3), +4, (+5), +6, +7";
            f.lbelectron.Text = "Electron mối quan hệ: 14.5 kJ/mole";
            f.lbdientro.Text = "Điện trở: 1.8x10^-7";
            f.lbvotraidat.Text = " Tỉ lệ có trong vỏ Trái Đất: 2.6x10^-7 %";
            f.lbconnguoi.Text = "Tỉ lệ có trong con người: --*-- %";
            f.lbvutru.Text = "Tỉ lệ có trong vũ trụ: --*-- %";
        }

        private void btos_Click(object sender, EventArgs e)
        {
            Thong_Tin_Nguyen_To f = new Thong_Tin_Nguyen_To();
            f.Show();
            f.pictureBox1.Image = new Bitmap(Application.StartupPath + "\\Image Of Visual Periodic Table\\osmium.jpg");
            f.lbkihieu.Text = "Os";
            f.lbtennguyento.Text = "Osimi";
            f.lbmol.Text = "190.23 (g/mol)";
            f.lbloai.Text = "KIÊM LOẠI CHUYỂN TIẾP";
            f.lbtenlatin.Text = "Tên Latin: Osmium";
            f.lbtenanh.Text = "Tên tiếng Anh: Osmium";
            f.lbnam.Text = "Năm khám phá: 1803";
            f.lbnguoi.Text = "Người khám phá: Smithson Tennant";
            f.lbvo.Text = "Vỏ điện tử: K2 L8 M18 N32 O14 P2";
            f.lbcas.Text = "CAS số: CAS7740-04-2";
            f.lbsongtu.Text = "Số nguyên tử: 76";
            f.lbnguyentukhoi.Text = "Nguyên tử khối; 190.23 (g/mol)";
            f.lbmatdo.Text = "Mật độ: 22.587 (g/cm3)";
            f.lbnongchay.Text = "Điểm nóng chảy: 3045 'C";
            f.lbsoi.Text = "Điểm sôi: 5027 'C";
            f.lbcauhinh.Text = "Cấu hình điện tử: [Xe]6s2 4f14 5d6 1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 5s2 4d10 5p6 6s2 4f14 5d6";
            f.lbhoatri.Text = "Hóa trị: -1 -2. -4, +1, +2, +3, +4, +5, +6, +7, +8";
            f.lbtiemnang.Text = "Tiềm năng Ion hóa của nguyên tử: --*--";
            f.lbbankinh.Text = "Bán kính nguyên tử: 135 pm";
            f.lblienket.Text = "Liên kết cộng hóa trị bán kính: 128 pm";
            f.lbbankinhvan.Text = "Bán kính Van der Waals: --*-- pm";
            f.lbamdien.Text = "Âm điện: 2.2";
            f.lbhoatriphanung.Text = "Hóa trị: (+2), +3, +4, +6, +8";
            f.lbelectron.Text = "Electron mối quan hệ: 106.1 kJ/mole";
            f.lbdientro.Text = "Điện trở: 8.1x10^-8";
            f.lbvotraidat.Text = " Tỉ lệ có trong vỏ Trái Đất: 1.8x10^-7  %";
            f.lbconnguoi.Text = "Tỉ lệ có trong con người: --*-- %";
            f.lbvutru.Text = "Tỉ lệ có trong vũ trụ: --*-- %";
        }

        private void btir_Click(object sender, EventArgs e)
        {
            Thong_Tin_Nguyen_To f = new Thong_Tin_Nguyen_To();
            f.Show();
            f.pictureBox1.Image = new Bitmap(Application.StartupPath + "\\Image Of Visual Periodic Table\\iridium.jpg");
            f.lbkihieu.Text = "Ir";
            f.lbtennguyento.Text = "Iriđi";
            f.lbmol.Text = "192.217 (g/mol)";
            f.lbloai.Text = "KIÊM LOẠI CHUYỂN TIẾP";
            f.lbtenlatin.Text = "Tên Latin: Iridium";
            f.lbtenanh.Text = "Tên tiếng Anh: Iridium";
            f.lbnam.Text = "Năm khám phá: 1803";
            f.lbnguoi.Text = "Người khám phá: Smithson Tennant";
            f.lbvo.Text = "Vỏ điện tử: K2 L8 M18 N32 O15 P2";
            f.lbcas.Text = "CAS số: CAS7739-88-5";
            f.lbsongtu.Text = "Số nguyên tử: 77";
            f.lbnguyentukhoi.Text = "Nguyên tử khối; 192.217 (g/mol)";
            f.lbmatdo.Text = "Mật độ: 22.662 (g/cm3)";
            f.lbnongchay.Text = "Điểm nóng chảy: 2410 'C";
            f.lbsoi.Text = "Điểm sôi: 4428 'C";
            f.lbcauhinh.Text = "Cấu hình điện tử: [Xe]6s2 4f14 5d7 1s2 2s2 2p6 3s2 3d6 4s2 3d10 4p6 5s2 4d10 5p6 6s2 4f14 5d7";
            f.lbhoatri.Text = "Hóa trị: -1 -3, +1, +2, +3, +4, +5, +6, +7, +8, +9";
            f.lbtiemnang.Text = "Tiềm năng Ion hóa của nguyên tử: --*--";
            f.lbbankinh.Text = "Bán kính nguyên tử: 136 pm";
            f.lblienket.Text = "Liên kết cộng hóa trị bán kính: 137 pm";
            f.lbbankinhvan.Text = "Bán kính Van der Waals: --*-- pm";
            f.lbamdien.Text = "Âm điện: 2.2";
            f.lbhoatriphanung.Text = "Hóa trị: (+1), (+2), +3, +4, +6";
            f.lbelectron.Text = "Electron mối quan hệ: 151 kJ/mole";
            f.lbdientro.Text = "Điện trở: 4.7x10^-8";
            f.lbvotraidat.Text = " Tỉ lệ có trong vỏ Trái Đất: 4x10^-8  %";
            f.lbconnguoi.Text = "Tỉ lệ có trong con người: --*-- %";
            f.lbvutru.Text = "Tỉ lệ có trong vũ trụ: --*-- %";
        }

        private void btpt_Click(object sender, EventArgs e)
        {
            Thong_Tin_Nguyen_To f = new Thong_Tin_Nguyen_To();
            f.Show();
            f.pictureBox1.Image = new Bitmap(Application.StartupPath + "\\Image Of Visual Periodic Table\\platinum.jpg");
            f.lbkihieu.Text = "Pt";
            f.lbtennguyento.Text = "Platin";
            f.lbmol.Text = "195.084 (g/mol)";
            f.lbloai.Text = "KIÊM LOẠI CHUYỂN TIẾP";
            f.lbtenlatin.Text = "Tên Latin: Platinum";
            f.lbtenanh.Text = "Tên tiếng Anh: Platinum";
            f.lbnam.Text = "Năm khám phá: 1735";
            f.lbnguoi.Text = "Người khám phá: A.D Ulloa";
            f.lbvo.Text = "Vỏ điện tử: K2 L8 M18 N32 O17 P1";
            f.lbcas.Text = "CAS số: CAS7740-06-4";
            f.lbsongtu.Text = "Số nguyên tử: 78";
            f.lbnguyentukhoi.Text = "Nguyên tử khối; 195.804 (g/mol)";
            f.lbmatdo.Text = "Mật độ: 21.45 (g/cm3)";
            f.lbnongchay.Text = "Điểm nóng chảy: 1772 'C";
            f.lbsoi.Text = "Điểm sôi: 3827 'C";
            f.lbcauhinh.Text = "Cấu hình điện tử: [Xe]6s1 4f14 5d9 1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 5s2 4d10 5p6 6s1 4f14 5d9";
            f.lbhoatri.Text = "Hóa trị: -1, -2, -3, +1, +2, +3, +4, +5, +6";
            f.lbtiemnang.Text = "Tiềm năng Ion hóa của nguyên tử: 8.9";
            f.lbbankinh.Text = "Bán kính nguyên tử: 139 pm";
            f.lblienket.Text = "Liên kết cộng hóa trị bán kính: 128 pm";
            f.lbbankinhvan.Text = "Bán kính Van der Waals: 175 pm";
            f.lbamdien.Text = "Âm điện: 2.28";
            f.lbhoatriphanung.Text = "Hóa trị: (+1), +2, (+3), +4, +6";
            f.lbelectron.Text = "Electron mối quan hệ: 205.3 kJ/mole";
            f.lbdientro.Text = "Điện trở: 1.1x10^-7";
            f.lbvotraidat.Text = " Tỉ lệ có trong vỏ Trái Đất: 3.7x10^-6  %";
            f.lbconnguoi.Text = "Tỉ lệ có trong con người: --*-- %";
            f.lbvutru.Text = "Tỉ lệ có trong vũ trụ: --*-- %";
        }

        private void btau_Click(object sender, EventArgs e)
        {
            Thong_Tin_Nguyen_To f = new Thong_Tin_Nguyen_To();
            f.Show();
            f.pictureBox1.Image = new Bitmap(Application.StartupPath + "\\Image Of Visual Periodic Table\\gold.jpg");
            f.lbkihieu.Text = "Au";
            f.lbtennguyento.Text = "Vàng";
            f.lbmol.Text = "196.966 (g/mol)";
            f.lbloai.Text = "KIÊM LOẠI CHUYỂN TIẾP";
            f.lbtenlatin.Text = "Tên Latin: Aurum";
            f.lbtenanh.Text = "Tên tiếng Anh: Gold";
            f.lbnam.Text = "Năm khám phá: 1732";
            f.lbnguoi.Text = "Người khám phá: --*--";
            f.lbvo.Text = "Vỏ điện tử: K2 L8 M18 N32 O18 P1";
            f.lbcas.Text = "CAS số: CAS7740--57-5";
            f.lbsongtu.Text = "Số nguyên tử: 79";
            f.lbnguyentukhoi.Text = "Nguyên tử khối; 196.966 (g/mol)";
            f.lbmatdo.Text = "Mật độ: 19.3 (g/cm3)";
            f.lbnongchay.Text = "Điểm nóng chảy: 1064.4 'C";
            f.lbsoi.Text = "Điểm sôi: 2856 'C";
            f.lbcauhinh.Text = "Cấu hình điện tử: [Xe]6s1 4f14 5d10 1s2 2s2 2p6 3s2 3p6 4s2 5s2 4d10 5p6 6s1 4f14 5d10";
            f.lbhoatri.Text = "Hóa trị: -1, -2, -3, +1, +3";
            f.lbtiemnang.Text = "Tiềm năng Ion hóa của nguyên tử: 9.19";
            f.lbbankinh.Text = "Bán kính nguyên tử: 144 pm";
            f.lblienket.Text = "Liên kết cộng hóa trị bán kính: 144 pm";
            f.lbbankinhvan.Text = "Bán kính Van der Waals: 166 pm";
            f.lbamdien.Text = "Âm điện: 2.54";
            f.lbhoatriphanung.Text = "Hóa trị: +1, (+2), +3";
            f.lbelectron.Text = "Electron mối quan hệ: 222.8 kJ/mole";
            f.lbdientro.Text = "Điện trở: 2.2x10^-8";
            f.lbvotraidat.Text = " Tỉ lệ có trong vỏ Trái Đất: 3.1x10^-7  %";
            f.lbconnguoi.Text = "Tỉ lệ có trong con người: --*-- %";
            f.lbvutru.Text = "Tỉ lệ có trong vũ trụ: --*-- %";
        }

        private void bthg_Click(object sender, EventArgs e)
        {
            Thong_Tin_Nguyen_To f = new Thong_Tin_Nguyen_To();
            f.Show();
            f.pictureBox1.Image = new Bitmap(Application.StartupPath + "\\Image Of Visual Periodic Table\\hydrargyrum.jpg");
            f.lbkihieu.Text = "Hg";
            f.lbtennguyento.Text = "Thủy Ngân";
            f.lbmol.Text = "200.59 (g/mol)";
            f.lbloai.Text = "KIÊM LOẠI CHUYỂN TIẾP";
            f.lbtenlatin.Text = "Tên Latin: Hydrargyum";
            f.lbtenanh.Text = "Tên tiếng Anh: Mercury";
            f.lbnam.Text = "Năm khám phá: 1735";
            f.lbnguoi.Text = "Người khám phá: --*--";
            f.lbvo.Text = "Vỏ điện tử: K2 L8 M18 N32 O18 P2";
            f.lbcas.Text = "CAS số: CAS7739-97-6";
            f.lbsongtu.Text = "Số nguyên tử: 80";
            f.lbnguyentukhoi.Text = "Nguyên tử khối; 200.59 (g/mol)";
            f.lbmatdo.Text = "Mật độ: 13.55 (g/cm3)";
            f.lbnongchay.Text = "Điểm nóng chảy: -38.9'C";
            f.lbsoi.Text = "Điểm sôi: 356.6 'C";
            f.lbcauhinh.Text = "Cấu hình điện tử: [Xe]6s2 4f14 5d10 1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 5s2 4d10 5p6 6s2 4f14 5d10";
            f.lbhoatri.Text = "Hóa trị: -2, +1, +2";
            f.lbtiemnang.Text = "Tiềm năng Ion hóa của nguyên tử: 10.39";
            f.lbbankinh.Text = "Bán kính nguyên tử: 157 pm";
            f.lblienket.Text = "Liên kết cộng hóa trị bán kính: 149 pm";
            f.lbbankinhvan.Text = "Bán kính Van der Waals: 155 pm";
            f.lbamdien.Text = "Âm điện: 2";
            f.lbhoatriphanung.Text = "Hóa trị: +1, +2";
            f.lbelectron.Text = "Electron mối quan hệ: 0 kJ/mole";
            f.lbdientro.Text = "Điện trở: 9.6x10^-7";
            f.lbvotraidat.Text = " Tỉ lệ có trong vỏ Trái Đất: 6.7x10^-6  %";
            f.lbconnguoi.Text = "Tỉ lệ có trong con người: --*-- %";
            f.lbvutru.Text = "Tỉ lệ có trong vũ trụ: --*-- %";
        }

        private void bttl_Click(object sender, EventArgs e)
        {
            Thong_Tin_Nguyen_To f = new Thong_Tin_Nguyen_To();
            f.Show();
            f.pictureBox1.Image = new Bitmap(Application.StartupPath + "\\Image Of Visual Periodic Table\\thallium.jpg");
            f.lbkihieu.Text = "Tl";
            f.lbtennguyento.Text = "Tali";
            f.lbmol.Text = "204.383 (g/mol)";
            f.lbloai.Text = "CHẤT BÁN DẪN";
            f.lbtenlatin.Text = "Tên Latin: Thallium";
            f.lbtenanh.Text = "Tên tiếng Anh: Thalloum";
            f.lbnam.Text = "Năm khám phá: 1861";
            f.lbnguoi.Text = "Người khám phá: William Crookes";
            f.lbvo.Text = "Vỏ điện tử: K2 L8 M18 N32 O18 P3";
            f.lbcas.Text = "CAS số: CAS7440-28-0";
            f.lbsongtu.Text = "Số nguyên tử: 81";
            f.lbnguyentukhoi.Text = "Nguyên tử khối; 204.383 (g/mol)";
            f.lbmatdo.Text = "Mật độ: 11.85 (g/cm3)";
            f.lbnongchay.Text = "Điểm nóng chảy: 303.6 'C";
            f.lbsoi.Text = "Điểm sôi: 1473 'C";
            f.lbcauhinh.Text = "Cấu hình điện tử: [Xe]6s2 4f14 5d10 6p1 1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 5s2 4d10 5p6 6s2 4f14 5d10 6p1";
            f.lbhoatri.Text = "Hóa trị: -1,-2, -5, +1, +2, +3";
            f.lbtiemnang.Text = "Tiềm năng Ion hóa của nguyên tử: 6.08";
            f.lbbankinh.Text = "Bán kính nguyên tử: 171 pm";
            f.lblienket.Text = "Liên kết cộng hóa trị bán kính: 148 pm";
            f.lbbankinhvan.Text = "Bán kính Van der Waals: 196 pm";
            f.lbamdien.Text = "Âm điện: 1.62";
            f.lbhoatriphanung.Text = "Hóa trị: +1, (+2), +3";
            f.lbelectron.Text = "Electron mối quan hệ: 19.2 kJ/mole";
            f.lbdientro.Text = "Điện trở: 1.5x10^-7";
            f.lbvotraidat.Text = " Tỉ lệ có trong vỏ Trái Đất: 0.000053 %";
            f.lbconnguoi.Text = "Tỉ lệ có trong con người: --*-- %";
            f.lbvutru.Text = "Tỉ lệ có trong vũ trụ: --*-- %";
        }

        private void btpb_Click(object sender, EventArgs e)
        {
            Thong_Tin_Nguyen_To f = new Thong_Tin_Nguyen_To();
            f.Show();
            f.pictureBox1.Image = new Bitmap(Application.StartupPath + "\\Image Of Visual Periodic Table\\lead.jpg");
            f.lbkihieu.Text = "Pb";
            f.lbtennguyento.Text = "Chì";
            f.lbmol.Text = "207.2 (g/mol)";
            f.lbloai.Text = "CHẤT BÁN DẪN";
            f.lbtenlatin.Text = "Tên Latin: Plumbum";
            f.lbtenanh.Text = "Tên tiếng Anh: Lead";
            f.lbnam.Text = "Năm khám phá: 1899";
            f.lbnguoi.Text = "Người khám phá: --*--";
            f.lbvo.Text = "Vỏ điện tử: K2 L8 M18 N32 O18 P4";
            f.lbcas.Text = "CAS số: CAS7439-92-1";
            f.lbsongtu.Text = "Số nguyên tử: 82";
            f.lbnguyentukhoi.Text = "Nguyên tử khối; 207.2 (g/mol)";
            f.lbmatdo.Text = "Mật độ: 11.34 (g/cm3)";
            f.lbnongchay.Text = "Điểm nóng chảy: 327.5 'C";
            f.lbsoi.Text = "Điểm sôi: 1740 'C";
            f.lbcauhinh.Text = "Cấu hình điện tử: [Xe]6s2 4f14 5d10 6p2 1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 5s2 4d10 5p6 6s2 4f14 5d10 6p2";
            f.lbhoatri.Text = "Hóa trị: -1, -2, -4, +1, +2, +3, +4";
            f.lbtiemnang.Text = "Tiềm năng Ion hóa của nguyên tử: 7.38";
            f.lbbankinh.Text = "Bán kính nguyên tử: 175 pm";
            f.lblienket.Text = "Liên kết cộng hóa trị bán kính: 147 pm";
            f.lbbankinhvan.Text = "Bán kính Van der Waals: 202 pm";
            f.lbamdien.Text = "Âm điện: 2.33";
            f.lbhoatriphanung.Text = "Hóa trị: +2, +4";
            f.lbelectron.Text = "Electron mối quan hệ: 35.1 kJ/mole";
            f.lbdientro.Text = "Điện trở: 2.1x10^-7";
            f.lbvotraidat.Text = " Tỉ lệ có trong vỏ Trái Đất: 0.00099 %";
            f.lbconnguoi.Text = "Tỉ lệ có trong con người: --*-- %";
            f.lbvutru.Text = "Tỉ lệ có trong vũ trụ: --*-- %";
        }

        private void btbi_Click(object sender, EventArgs e)
        {
            Thong_Tin_Nguyen_To f = new Thong_Tin_Nguyen_To();
            f.Show();
            f.pictureBox1.Image = new Bitmap(Application.StartupPath + "\\Image Of Visual Periodic Table\\bismuth.jpg");
            f.lbkihieu.Text = "Bi";
            f.lbtennguyento.Text = "Bitmut";
            f.lbmol.Text = "208.9804 (g/mol)";
            f.lbloai.Text = "CHẤT BÁN DẪN-PHÓNG XẠ";
            f.lbtenlatin.Text = "Tên Latin: Bisemutum";
            f.lbtenanh.Text = "Tên tiếng Anh: Bismuth";
            f.lbnam.Text = "Năm khám phá: 1739";
            f.lbnguoi.Text = "Người khám phá: Claude Francois Geofrey";
            f.lbvo.Text = "Vỏ điện tử: K2 L8 M18 N32 O18 P5";
            f.lbcas.Text = "CAS số: CAS7440-69-9";
            f.lbsongtu.Text = "Số nguyên tử: 83";
            f.lbnguyentukhoi.Text = "Nguyên tử khối; 208.9804 (g/mol)";
            f.lbmatdo.Text = "Mật độ: 9.8 (g/cm3)";
            f.lbnongchay.Text = "Điểm nóng chảy: 271.4 'C";
            f.lbsoi.Text = "Điểm sôi: 1560 'C";
            f.lbcauhinh.Text = "Cấu hình điện tử: [Xe]6s2 4f14 5d10 6p3 1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 4d10 5p6 6s2 4f14 5d10 6d3";
            f.lbhoatri.Text = "Hóa trị: -1, -2, -3, +1, +2, +3, +4, +5";
            f.lbtiemnang.Text = "Tiềm năng Ion hóa của nguyên tử: 7.25";
            f.lbbankinh.Text = "Bán kính nguyên tử: 170 pm";
            f.lblienket.Text = "Liên kết cộng hóa trị bán kính: 146 pm";
            f.lbbankinhvan.Text = "Bán kính Van der Waals: 207 pm";
            f.lbamdien.Text = "Âm điện: 2.02";
            f.lbhoatriphanung.Text = "Hóa trị: (-3), (+2), +3, (+4), (+5)";
            f.lbelectron.Text = "Electron mối quan hệ: 91.2 kJ/mole";
            f.lbdientro.Text = "Điện trở: 1.3x10^-6";
            f.lbvotraidat.Text = " Tỉ lệ có trong vỏ Trái Đất: 0.00099 %";
            f.lbconnguoi.Text = "Tỉ lệ có trong con người: --*-- %";
            f.lbvutru.Text = "Tỉ lệ có trong vũ trụ: --*-- %";
        }

        private void btpo_Click(object sender, EventArgs e)
        {
            Thong_Tin_Nguyen_To f = new Thong_Tin_Nguyen_To();
            f.Show();
            f.pictureBox1.Image = new Bitmap(Application.StartupPath + "\\Image Of Visual Periodic Table\\Khong_co_anh_VPTN.png");
            f.lbkihieu.Text = "Po";
            f.lbtennguyento.Text = "Poloni";
            f.lbmol.Text = "208.9824 (g/mol)";
            f.lbloai.Text = "CHẤT BÁN DẪN-PHÓNG XẠ";
            f.lbtenlatin.Text = "Tên Latin: Polonium";
            f.lbtenanh.Text = "Tên tiếng Anh: Polonium";
            f.lbnam.Text = "Năm khám phá: 1898";
            f.lbnguoi.Text = "Người khám phá: 1898";
            f.lbvo.Text = "Vỏ điện tử: K2 L8 M18 N32 O18 P6";
            f.lbcas.Text = "CAS số: CAS7440-08-6";
            f.lbsongtu.Text = "Số nguyên tử: 84";
            f.lbnguyentukhoi.Text = "Nguyên tử khối; 208.9824 (g/mol)";
            f.lbmatdo.Text = "Mật độ: 9.2 (g/cm3)";
            f.lbnongchay.Text = "Điểm nóng chảy: 254 'C";
            f.lbsoi.Text = "Điểm sôi: 962 'C";
            f.lbcauhinh.Text = "Cấu hình điện tử: [Xe]6s2 4f14 5d10 6p4 1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 5s2 4d10 5p6 6s2 4f14 5d10 6p4";
            f.lbhoatri.Text = "Hóa trị: -2, +2, +4, +5, +6";
            f.lbtiemnang.Text = "Tiềm năng Ion hóa của nguyên tử: --*--";
            f.lbbankinh.Text = "Bán kính nguyên tử: 176 pm";
            f.lblienket.Text = "Liên kết cộng hóa trị bán kính: --*-- pm";
            f.lbbankinhvan.Text = "Bán kính Van der Waals: 197 pm";
            f.lbamdien.Text = "Âm điện: 2";
            f.lbhoatriphanung.Text = "Hóa trị: (-2), +2, +4, (+6)";
            f.lbelectron.Text = "Electron mối quan hệ: 183.3 kJ/mole";
            f.lbdientro.Text = "Điện trở: 4.3x10^-7";
            f.lbvotraidat.Text = " Tỉ lệ có trong vỏ Trái Đất: --*-- %";
            f.lbconnguoi.Text = "Tỉ lệ có trong con người: --*-- %";
            f.lbvutru.Text = "Tỉ lệ có trong vũ trụ: --*-- %";
        }

        private void btat_Click(object sender, EventArgs e)
        {
            Thong_Tin_Nguyen_To f = new Thong_Tin_Nguyen_To();
            f.Show();
            f.pictureBox1.Image = new Bitmap(Application.StartupPath + "\\Image Of Visual Periodic Table\\astatine.jpg");
            f.lbkihieu.Text = "At";
            f.lbtennguyento.Text = "Astatin";
            f.lbmol.Text = "209.9871 (g/mol)";
            f.lbloai.Text = "HALOGEN-PHÓNG XẠ";
            f.lbtenlatin.Text = "Tên Latin: Astatum";
            f.lbtenanh.Text = "Tên tiếng Anh: Astatum";
            f.lbnam.Text = "Năm khám phá: 1940";
            f.lbnguoi.Text = "Người khám phá: 1940";
            f.lbvo.Text = "Vỏ điện tử: K2 L8 M18 N32 O18 P7";
            f.lbcas.Text = "CAS số: CAS7440-68-8";
            f.lbsongtu.Text = "Số nguyên tử: 85";
            f.lbnguyentukhoi.Text = "Nguyên tử khối; 209.9871 (g/mol)";
            f.lbmatdo.Text = "Mật độ: 6.4 (g/cm3)";
            f.lbnongchay.Text = "Điểm nóng chảy: 230 'C";
            f.lbsoi.Text = "Điểm sôi: 302 'C";
            f.lbcauhinh.Text = "Cấu hình điện tử: [Xe]6s2 4f14 5d10 6p5 1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 5s2 4d10 5p6 6s2 4f14 5d10 6p5";
            f.lbhoatri.Text = "Hóa trị: -1, +1, +3, +5, +7";
            f.lbtiemnang.Text = "Tiềm năng Ion hóa của nguyên tử: --*--";
            f.lbbankinh.Text = "Bán kính nguyên tử: 145 pm";
            f.lblienket.Text = "Liên kết cộng hóa trị bán kính: --*-- pm";
            f.lbbankinhvan.Text = "Bán kính Van der Waals: 202 pm";
            f.lbamdien.Text = "Âm điện: 2.2";
            f.lbhoatriphanung.Text = "Hóa trị: --*--";
            f.lbelectron.Text = "Electron mối quan hệ: 270.1 kJ/mole";
            f.lbdientro.Text = "Điện trở: --*--";
            f.lbvotraidat.Text = " Tỉ lệ có trong vỏ Trái Đất: --*-- %";
            f.lbconnguoi.Text = "Tỉ lệ có trong con người: --*-- %";
            f.lbvutru.Text = "Tỉ lệ có trong vũ trụ: --*-- %";
        }

        private void btrn_Click(object sender, EventArgs e)
        {
            Thong_Tin_Nguyen_To f = new Thong_Tin_Nguyen_To();
            f.Show();
            f.pictureBox1.Image = new Bitmap(Application.StartupPath + "\\Image Of Visual Periodic Table\\radon.jpg");
            f.lbkihieu.Text = "Rn";
            f.lbtennguyento.Text = "Rađon";
            f.lbmol.Text = "222.0176 (g/mol)";
            f.lbloai.Text = "KHÍ TRƠ-PHÓNG XẠ";
            f.lbtenlatin.Text = "Tên Latin: Radon";
            f.lbtenanh.Text = "Tên tiếng Anh: Radon";
            f.lbnam.Text = "Năm khám phá: 1900";
            f.lbnguoi.Text = "Người khám phá: Friedrich Ernst Dorn";
            f.lbvo.Text = "Vỏ điện tử: K2 L8 M18 N32 O18 P8";
            f.lbcas.Text = "CAS số: CAS10043-92-2";
            f.lbsongtu.Text = "Số nguyên tử: 86";
            f.lbnguyentukhoi.Text = "Nguyên tử khối; 222.0176 (g/mol)";
            f.lbmatdo.Text = "Mật độ: 9.81 (g/cm3)";
            f.lbnongchay.Text = "Điểm nóng chảy: -71 'C";
            f.lbsoi.Text = "Điểm sôi: -61.8 'C";
            f.lbcauhinh.Text = "Cấu hình điện tử: [Xe]6s2 4f14 5d10 6p6 1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 5s2 4d10 5p6 6s2 4f14 5d10 6p6";
            f.lbhoatri.Text = "Hóa trị: +2, +6";
            f.lbtiemnang.Text = "Tiềm năng Ion hóa của nguyên tử: --*--";
            f.lbbankinh.Text = "Bán kính nguyên tử: 214 pm";
            f.lblienket.Text = "Liên kết cộng hóa trị bán kính: 145 pm";
            f.lbbankinhvan.Text = "Bán kính Van der Waals: 220 pm";
            f.lbamdien.Text = "Âm điện: --*--";
            f.lbhoatriphanung.Text = "Hóa trị: 0";
            f.lbelectron.Text = "Electron mối quan hệ: 0 kJ/mole";
            f.lbdientro.Text = "Điện trở: --*--";
            f.lbvotraidat.Text = " Tỉ lệ có trong vỏ Trái Đất: --*-- %";
            f.lbconnguoi.Text = "Tỉ lệ có trong con người: --*-- %";
            f.lbvutru.Text = "Tỉ lệ có trong vũ trụ: --*-- %";
        }

        private void lbfr_Click(object sender, EventArgs e)
        {
            Thong_Tin_Nguyen_To f = new Thong_Tin_Nguyen_To();
            f.Show();
            f.pictureBox1.Image = new Bitmap(Application.StartupPath + "\\Image Of Visual Periodic Table\\francium.jpg");
            f.lbkihieu.Text = "Fr";
            f.lbtennguyento.Text = "Franxi";
            f.lbmol.Text = "223.0197 (g/mol)";
            f.lbloai.Text = "KIM LOẠI KIỀM-PHÓNG XẠ";
            f.lbtenlatin.Text = "Tên Latin: Francium";
            f.lbtenanh.Text = "Tên tiếng Anh: Francium";
            f.lbnam.Text = "Năm khám phá: 1939";
            f.lbnguoi.Text = "Người khám phá: Marguerite Perey";
            f.lbvo.Text = "Vỏ điện tử: K2 L8 M18 N32 O18 P8 Q1";
            f.lbcas.Text = "CAS số: CAS7440-73-5";
            f.lbsongtu.Text = "Số nguyên tử: 87";
            f.lbnguyentukhoi.Text = "Nguyên tử khối; 223.0197 (g/mol)";
            f.lbmatdo.Text = "Mật độ: 1.87 (g/cm3)";
            f.lbnongchay.Text = "Điểm nóng chảy: 20 'C";
            f.lbsoi.Text = "Điểm sôi: 650 'C";
            f.lbcauhinh.Text = "Cấu hình điện tử: [Rn]7s1 1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 5s2 4d10 5p6 6s2 4f14 5d10 6p6 7s1";
            f.lbhoatri.Text = "Hóa trị: +1";
            f.lbtiemnang.Text = "Tiềm năng Ion hóa của nguyên tử: --*--";
            f.lbbankinh.Text = "Bán kính nguyên tử: --*-- pm";
            f.lblienket.Text = "Liên kết cộng hóa trị bán kính: --*-- pm";
            f.lbbankinhvan.Text = "Bán kính Van der Waals: 348 pm";
            f.lbamdien.Text = "Âm điện: 0.7";
            f.lbhoatriphanung.Text = "Hóa trị: --*--";
            f.lbelectron.Text = "Electron mối quan hệ: 1 kJ/mole";
            f.lbdientro.Text = "Điện trở: --*--";
            f.lbvotraidat.Text = " Tỉ lệ có trong vỏ Trái Đất: --*-- %";
            f.lbconnguoi.Text = "Tỉ lệ có trong con người: --*-- %";
            f.lbvutru.Text = "Tỉ lệ có trong vũ trụ: --*-- %";
        }

        private void btra_Click(object sender, EventArgs e)
        {
            Thong_Tin_Nguyen_To f = new Thong_Tin_Nguyen_To();
            f.Show();
            f.pictureBox1.Image = new Bitmap(Application.StartupPath + "\\Image Of Visual Periodic Table\\radium-glow.jpg");
            f.lbkihieu.Text = "Ra";
            f.lbtennguyento.Text = "Rađi";
            f.lbmol.Text = "226.0254 (g/mol)";
            f.lbloai.Text = "KIM LOẠI KIỀM THỔ-PHÓNG XẠ";
            f.lbtenlatin.Text = "Tên Latin: Radium";
            f.lbtenanh.Text = "Tên tiếng Anh: Radium";
            f.lbnam.Text = "Năm khám phá: 1898";
            f.lbnguoi.Text = "Người khám phá: Pierre Currie và Marie S. Currie";
            f.lbvo.Text = "Vỏ điện tử: K2 L8 M18 N32 O18 P8 Q2";
            f.lbcas.Text = "CAS số: CAS7440-14-4";
            f.lbsongtu.Text = "Số nguyên tử: 88";
            f.lbnguyentukhoi.Text = "Nguyên tử khối; 226.0254 (g/mol)";
            f.lbmatdo.Text = "Mật độ: 5.5 (g/cm3)";
            f.lbnongchay.Text = "Điểm nóng chảy: 958 'C";
            f.lbsoi.Text = "Điểm sôi: 1735 'C";
            f.lbcauhinh.Text = "Cấu hình điện tử: [Rn]7s1 1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 5s2 4d10 5p6 6s2 4f14 5d10 6p6 7s2";
            f.lbhoatri.Text = "Hóa trị: +2";
            f.lbtiemnang.Text = "Tiềm năng Ion hóa của nguyên tử: 5.4";
            f.lbbankinh.Text = "Bán kính nguyên tử: 215 pm";
            f.lblienket.Text = "Liên kết cộng hóa trị bán kính: --*-- pm";
            f.lbbankinhvan.Text = "Bán kính Van der Waals: 283 pm";
            f.lbamdien.Text = "Âm điện: 0.9";
            f.lbhoatriphanung.Text = "Hóa trị: +2";
            f.lbelectron.Text = "Electron mối quan hệ: 2 kJ/mole";
            f.lbdientro.Text = "Điện trở: 10^-6";
            f.lbvotraidat.Text = " Tỉ lệ có trong vỏ Trái Đất: --*-- %";
            f.lbconnguoi.Text = "Tỉ lệ có trong con người: --*-- %";
            f.lbvutru.Text = "Tỉ lệ có trong vũ trụ: --*-- %";
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void trangChủToolStripMenuItem_Click(object sender, EventArgs e)
        {
            notifyIcon1.ShowBalloonTip(10000, "Visual Periodic Table","Cảm ơn bạn đã ghé thăm trang WEB của chúng tôi!", ToolTipIcon .Info );
            DialogResult chon = MessageBox.Show("Bạn muốn duyệt trang Web này trên trình duyệt mặc định hay sử dụng trình duyệt của phần mềm?\nYes=Trình duyệt hệ thống\nNo = Trình duyệt phần mềm", "Câu hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (chon == DialogResult.Yes)
            {
                Process.Start("https://cungnhauhoctot.wordpress.com");
            }
            else
            {
                Trinh_Duyet f = new Trinh_Duyet();
                f.Show();
                f.webBrowser1.Url = new Uri("https://cungnhauhoctot.wordpress.com");
            }
        }

        private void lậpTrìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            DialogResult chon = MessageBox.Show("Bạn muốn duyệt trang Web này trên trình duyệt mặc định hay sử dụng trình duyệt của phần mềm?\nYes=Trình duyệt hệ thống\nNo = Trình duyệt phần mềm", "Câu hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (chon == DialogResult.Yes)
            {
                Process.Start("https://cungnhauhoctot.wordpress.com/portfolio/lap-trinh/");
            }
            else
            {
                Trinh_Duyet f = new Trinh_Duyet();
                f.Show();
                f.webBrowser1.Url = new Uri("https://cungnhauhoctot.wordpress.com/portfolio/lap-trinh/");
            }
        }

        private void hóaHọcToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Process.Start("https://cungnhauhoctot.wordpress.com/portfolio/hoa-hoc/");
            DialogResult chon = MessageBox.Show("Bạn muốn duyệt trang Web này trên trình duyệt mặc định hay sử dụng trình duyệt của phần mềm?\nYes=Trình duyệt hệ thống\nNo = Trình duyệt phần mềm", "Câu hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (chon == DialogResult.Yes)
            {
                Process.Start("https://cungnhauhoctot.wordpress.com/portfolio/hoa-hoc/");
            }
            else
            {
                Trinh_Duyet f = new Trinh_Duyet();
                f.Show();
                f.webBrowser1.Url = new Uri("https://cungnhauhoctot.wordpress.com/portfolio/hoa-hoc/");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           // Process.Start("https://vi.wikipedia.org/wiki/Dmitri_Ivanovich_Mendeleev");
            DialogResult chon = MessageBox.Show("Bạn muốn duyệt trang Web này trên trình duyệt mặc định hay sử dụng trình duyệt của phần mềm?\nYes=Trình duyệt hệ thống\nNo = Trình duyệt phần mềm", "Câu hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (chon == DialogResult.Yes)
            {
                Process.Start("https://vi.wikipedia.org/wiki/Dmitri_Ivanovich_Mendeleev");
            }
            else
            {
                Trinh_Duyet f = new Trinh_Duyet();
                f.Show();
                f.webBrowser1.Url = new Uri("https://vi.wikipedia.org/wiki/Dmitri_Ivanovich_Mendeleev");
            }
        }

        private void toánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Process.Start("http://cungnhauhoctot.wordpress.com/portfolio/toan/");
            DialogResult chon = MessageBox.Show("Bạn muốn duyệt trang Web này trên trình duyệt mặc định hay sử dụng trình duyệt của phần mềm?\nYes=Trình duyệt hệ thống\nNo = Trình duyệt phần mềm", "Câu hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (chon == DialogResult.Yes)
            {
                Process.Start("https://cungnhauhoctot.wordpress.com/portfolio/toan/");
            }
            else
            {
                Trinh_Duyet f = new Trinh_Duyet();
                f.Show();
                f.webBrowser1.Url = new Uri("http://cungnhauhoctot.wordpress.com/portfolio/toan/");
            }
        }

        private void líToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Process.Start("https://cungnhauhoctot.wordpress.com/portfolio/vat-li/");
            DialogResult chon = MessageBox.Show("Bạn muốn duyệt trang Web này trên trình duyệt mặc định hay sử dụng trình duyệt của phần mềm?\nYes=Trình duyệt hệ thống\nNo = Trình duyệt phần mềm", "Câu hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (chon == DialogResult.Yes)
            {
                Process.Start("https://cungnhauhoctot.wordpress.com/portfolio/vat-li/");
            }
            else
            {
                Trinh_Duyet f = new Trinh_Duyet();
                f.Show();
                f.webBrowser1.Url = new Uri("https://cungnhauhoctot.wordpress.com/portfolio/vat-li/");
            }
        }

        private void sinhHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // Process.Start("https://cungnhauhoctot.wordpress.com/portfolio/sinh-hoc/");
            DialogResult chon = MessageBox.Show("Bạn muốn duyệt trang Web này trên trình duyệt mặc định hay sử dụng trình duyệt của phần mềm?\nYes=Trình duyệt hệ thống\nNo = Trình duyệt phần mềm", "Câu hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (chon == DialogResult.Yes)
            {
                Process.Start("https://cungnhauhoctot.wordpress.com/portfolio/sinh-hoc/");
            }
            else
            {
                Trinh_Duyet f = new Trinh_Duyet();
                f.Show();
                f.webBrowser1.Url = new Uri("https://cungnhauhoctot.wordpress.com/portfolio/sinh-hoc/");
            }
        }

        private void tiếngAnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Process.Start("httts://cungnhauhoctot.wordpress.com/portfolio/tieng-anh/");
            DialogResult chon = MessageBox.Show("Bạn muốn duyệt trang Web này trên trình duyệt mặc định hay sử dụng trình duyệt của phần mềm?\nYes=Trình duyệt hệ thống\nNo = Trình duyệt phần mềm", "Câu hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (chon == DialogResult.Yes)
            {
                Process.Start("https://cungnhauhoctot.wordpress.com/portfolio/tieng-anh/");
            }
            else
            {
                Trinh_Duyet f = new Trinh_Duyet();
                f.Show();
                f.webBrowser1.Url = new Uri("https://cungnhauhoctot.wordpress.com/portfolio/tieng-anh/");
            }
        }

        private void bạnMuốnThamGiaCùngTôiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Process.Start("https://cungnhauhoctot.wordpress.com/2018/10/04/tham-gia-cung-chung-toi-nhe/");
            DialogResult chon = MessageBox.Show("Bạn muốn duyệt trang Web này trên trình duyệt mặc định hay sử dụng trình duyệt của phần mềm?\nYes=Trình duyệt hệ thống\nNo = Trình duyệt phần mềm", "Câu hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (chon == DialogResult.Yes)
            {
                Process.Start("https://cungnhauhoctot.wordpress.com/2018/10/04/tham-gia-cung-chung-toi-nhe/");
            }
            else
            {
                Trinh_Duyet f = new Trinh_Duyet();
                f.Show();
                f.webBrowser1.Url = new Uri("https://cungnhauhoctot.wordpress.com/2018/10/04/tham-gia-cung-chung-toi-nhe/");
            }
        }

        private void thôngTinVềTrangWedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Process.Start("https://cungnhauhoctot.wordpress.com/2018/09/30/thong-tin/");
            DialogResult chon = MessageBox.Show("Bạn muốn duyệt trang Web này trên trình duyệt mặc định hay sử dụng trình duyệt của phần mềm?\nYes=Trình duyệt hệ thống\nNo = Trình duyệt phần mềm", "Câu hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (chon == DialogResult.Yes)
            {
                Process.Start("http://cungnhauhoctot.wordpress.com/2018/09/30/thong-tin/");
            }
            else
            {
                Trinh_Duyet f = new Trinh_Duyet();
                f.Show();
                f.webBrowser1.Url = new Uri("https://cungnhauhoctot.wordpress.com/2018/09/30/thong-tin/");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Thong_Tin_Nguyen_To f = new Thong_Tin_Nguyen_To();
            f.Show();
            f.pictureBox1.Image = new Bitmap(Application.StartupPath + "\\Image Of Visual Periodic Table\\neodymium.png");
            f.lbkihieu.Text = "Nd";
            f.lbtennguyento.Text = "Neođim";
            f.lbmol.Text = "144.242 (g/mol)";
            f.lbloai.Text = "NHÓM LANTAN";
            f.lbtenlatin.Text = "Tên Latin: Neodymium";
            f.lbtenanh.Text = "Tên tiếng Anh: Neodymmium";
            f.lbnam.Text = "Năm khám phá: 1885";
            f.lbnguoi.Text = "Người khám phá: A.L Debierne";
            f.lbvo.Text = "Vỏ điện tử: K2 L8 M18 N22 O8 P2";
            f.lbcas.Text = "CAS số: CAS7440-00-8";
            f.lbsongtu.Text = "Số nguyên tử: 60";
            f.lbnguyentukhoi.Text = "Nguyên tử khối; 144.242 (g/mol)";
            f.lbmatdo.Text = "Mật độ: 7 (g/cm3)";
            f.lbnongchay.Text = "Điểm nóng chảy: 1010 'C";
            f.lbsoi.Text = "Điểm sôi: 3066 'C";
            f.lbcauhinh.Text = "Cấu hình điện tử: [Xe]6s2 4f4 1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 4d10 5p6 6s2 4f4";
            f.lbhoatri.Text = "Hóa trị: +2, +3, +4";
            f.lbtiemnang.Text = "Tiềm năng Ion hóa của nguyên tử: 6.31";
            f.lbbankinh.Text = "Bán kính nguyên tử: 182 pm";
            f.lblienket.Text = "Liên kết cộng hóa trị bán kính: --*-- pm";
            f.lbbankinhvan.Text = "Bán kính Van der Waals: --*-- pm";
            f.lbamdien.Text = "Âm điện: 1.14";
            f.lbhoatriphanung.Text = "Hóa trị: +3, +4";
            f.lbelectron.Text = "Electron mối quan hệ: 50 kJ/mole";
            f.lbdientro.Text = "Điện trở: 6.4x10^-7";
            f.lbvotraidat.Text = " Tỉ lệ có trong vỏ Trái Đất: 0.0033 %";
            f.lbconnguoi.Text = "Tỉ lệ có trong con người: --*-- %";
            f.lbvutru.Text = "Tỉ lệ có trong vũ trụ: --*-- %";
        }

        private void btnla_Click(object sender, EventArgs e)
        {
            Thong_Tin_Nguyen_To f = new Thong_Tin_Nguyen_To();
            f.Show();
            f.pictureBox1.Image = new Bitmap(Application.StartupPath + "\\Image Of Visual Periodic Table\\lanthanum.png");
            f.lbkihieu.Text = "La";
            f.lbtennguyento.Text = "Lantan";
            f.lbmol.Text = "138.905 (g/mol)";
            f.lbloai.Text = "NHÓM LANTAN";
            f.lbtenlatin.Text = "Tên Latin: Lanthanum";
            f.lbtenanh.Text = "Tên tiếng Anh: Lanthanum";
            f.lbnam.Text = "Năm khám phá: 1839";
            f.lbnguoi.Text = "Người khám phá: C.G Mosander";
            f.lbvo.Text = "Vỏ điện tử: K2 L8 M18 N19 O9 P2";
            f.lbcas.Text = "CAS số: CAS7439-91-0";
            f.lbsongtu.Text = "Số nguyên tử: 57";
            f.lbnguyentukhoi.Text = "Nguyên tử khối; 138.905 (g/mol)";
            f.lbmatdo.Text = "Mật độ: 6.16 (g/cm3)";
            f.lbnongchay.Text = "Điểm nóng chảy: 920 'C";
            f.lbsoi.Text = "Điểm sôi: 3454 'C";
            f.lbcauhinh.Text = "Cấu hình điện tử: [Xe]5d1 6s2 1s2 2s2 2p6 3s2 3p6 3d10 4s2 4d10 5s2 5p6 5d1 6s2";
            f.lbhoatri.Text = "Hóa trị: +1, +2, +3";
            f.lbtiemnang.Text = "Tiềm năng Ion hóa của nguyên tử: 5.5";
            f.lbbankinh.Text = "Bán kính nguyên tử: 187 pm";
            f.lblienket.Text = "Liên kết cộng hóa trị bán kính: 169 pm";
            f.lbbankinhvan.Text = "Bán kính Van der Waals: --*-- pm";
            f.lbamdien.Text = "Âm điện: 1.1";
            f.lbhoatriphanung.Text = "Hóa trị: +3";
            f.lbelectron.Text = "Electron mối quan hệ: 48 kJ/mole";
            f.lbdientro.Text = "Điện trở: 6.1x10^-7";
            f.lbvotraidat.Text = " Tỉ lệ có trong vỏ Trái Đất: 0.0034 %";
            f.lbconnguoi.Text = "Tỉ lệ có trong con người: --*-- %";
            f.lbvutru.Text = "Tỉ lệ có trong vũ trụ: 2x10^-7 %";
        }

        private void btnce_Click(object sender, EventArgs e)
        {
            Thong_Tin_Nguyen_To f = new Thong_Tin_Nguyen_To();
            f.Show();
            f.pictureBox1.Image = new Bitmap(Application.StartupPath + "\\Image Of Visual Periodic Table\\cerium.png");
            f.lbkihieu.Text = "Ce";
            f.lbtennguyento.Text = "Xeri";
            f.lbmol.Text = "140.116 (g/mol)";
            f.lbloai.Text = "NHÓM LANTAN";
            f.lbtenlatin.Text = "Tên Latin: Cerium";
            f.lbtenanh.Text = "Tên tiếng Anh: Cerium";
            f.lbnam.Text = "Năm khám phá: 1803";
            f.lbnguoi.Text = "Người khám phá: --*--";
            f.lbvo.Text = "Vỏ điện tử: K2 L8 M18 N19 O9 P2";
            f.lbcas.Text = "CAS số: CAS7440-45-1";
            f.lbsongtu.Text = "Số nguyên tử: 58";
            f.lbnguyentukhoi.Text = "Nguyên tử khối; 140.116 (g/mol)";
            f.lbmatdo.Text = "Mật độ: 6.77 (g/cm3)";
            f.lbnongchay.Text = "Điểm nóng chảy: 798 'C";
            f.lbsoi.Text = "Điểm sôi: 3443 'C";
            f.lbcauhinh.Text = "Cấu hình điện tử: [Xe]6s2 4f1 5d1 1s2 2s2 2p6 3s2 2p6 4s2 3d10 4p6 5s2 4d10 5p6 6s2 4f1 5d1";
            f.lbhoatri.Text = "Hóa trị: +2, +3, +4";
            f.lbtiemnang.Text = "Tiềm năng Ion hóa của nguyên tử: 6.91";
            f.lbbankinh.Text = "Bán kính nguyên tử: 181 pm";
            f.lblienket.Text = "Liên kết cộng hóa trị bán kính: --*-- pm";
            f.lbbankinhvan.Text = "Bán kính Van der Waals: --*-- pm";
            f.lbamdien.Text = "Âm điện: 1.12";
            f.lbhoatriphanung.Text = "Hóa trị: +3, +4";
            f.lbelectron.Text = "Electron mối quan hệ: 50 kJ/mole";
            f.lbdientro.Text = "Điện trở: 7.4x10^-7";
            f.lbvotraidat.Text = " Tỉ lệ có trong vỏ Trái Đất: 0.006 %";
            f.lbconnguoi.Text = "Tỉ lệ có trong con người: --*-- %";
            f.lbvutru.Text = "Tỉ lệ có trong vũ trụ: --*-- %";
        }

        private void btnpr_Click(object sender, EventArgs e)
        {
            Thong_Tin_Nguyen_To f = new Thong_Tin_Nguyen_To();
            f.Show();
            f.pictureBox1.Image = new Bitmap(Application.StartupPath + "\\Image Of Visual Periodic Table\\praseodymium.png");
            f.lbkihieu.Text = "Pr";
            f.lbtennguyento.Text = "Prazeođim";
            f.lbmol.Text = "140.904 (g/mol)";
            f.lbloai.Text = "NHÓM LANTAN";
            f.lbtenlatin.Text = "Tên Latin: Prazeođim";
            f.lbtenanh.Text = "Tên tiếng Anh: Prazeođim";
            f.lbnam.Text = "Năm khám phá: 1885";
            f.lbnguoi.Text = "Người khám phá: A.L Debierne";
            f.lbvo.Text = "Vỏ điện tử: K2 L8 M18 N21 O8 P2";
            f.lbcas.Text = "CAS số: CAS7440-10-0";
            f.lbsongtu.Text = "Số nguyên tử: 59";
            f.lbnguyentukhoi.Text = "Nguyên tử khối; 140.904 (g/mol)";
            f.lbmatdo.Text = "Mật độ: 6.773 (g/cm3)";
            f.lbnongchay.Text = "Điểm nóng chảy: 931 'C";
            f.lbsoi.Text = "Điểm sôi: 3290 'C";
            f.lbcauhinh.Text = "Cấu hình điện tử: [Xe]6s2 4f3 1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 5s2 4d10 5p6 6s2 4f3";
            f.lbhoatri.Text = "Hóa trị: +2, +3, +4, +5";
            f.lbtiemnang.Text = "Tiềm năng Ion hóa của nguyên tử: 5.76";
            f.lbbankinh.Text = "Bán kính nguyên tử: 182 pm";
            f.lblienket.Text = "Liên kết cộng hóa trị bán kính: --*-- pm";
            f.lbbankinhvan.Text = "Bán kính Van der Waals: --*-- pm";
            f.lbamdien.Text = "Âm điện: 1.13";
            f.lbhoatriphanung.Text = "Hóa trị: +3";
            f.lbelectron.Text = "Electron mối quan hệ: 50 kJ/mole";
            f.lbdientro.Text = "Điện trở: 7x10^-7";
            f.lbvotraidat.Text = " Tỉ lệ có trong vỏ Trái Đất: 0.00086 %";
            f.lbconnguoi.Text = "Tỉ lệ có trong con người: --*-- %";
            f.lbvutru.Text = "Tỉ lệ có trong vũ trụ: --*-- %";
        }

        private void btnpm_Click(object sender, EventArgs e)
        {
            Thong_Tin_Nguyen_To f = new Thong_Tin_Nguyen_To();
            f.Show();
            f.pictureBox1.Image = new Bitmap(Application.StartupPath + "\\Image Of Visual Periodic Table\\promethium.png");
            f.lbkihieu.Text = "Pm";
            f.lbtennguyento.Text = "Prometi";
            f.lbmol.Text = "146.915 (g/mol)";
            f.lbloai.Text = "NHÓM LANTAN";
            f.lbtenlatin.Text = "Tên Latin: Promethium";
            f.lbtenanh.Text = "Tên tiếng Anh: Promethium";
            f.lbnam.Text = "Năm khám phá: 1945";
            f.lbnguoi.Text = "Người khám phá: --*--";
            f.lbvo.Text = "Vỏ điện tử: K2 L8 M18 N23 O8 P2";
            f.lbcas.Text = "CAS số: CAS7440-12-2";
            f.lbsongtu.Text = "Số nguyên tử: 61";
            f.lbnguyentukhoi.Text = "Nguyên tử khối; 146.915 (g/mol)";
            f.lbmatdo.Text = "Mật độ: 7.2 (g/cm3)";
            f.lbnongchay.Text = "Điểm nóng chảy: 1166 'C";
            f.lbsoi.Text = "Điểm sôi: 2998 'C";
            f.lbcauhinh.Text = "Cấu hình điện tử: [Xe]6s2 4f5 1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 6s2 4d10 5p6 6s2 4f5";
            f.lbhoatri.Text = "Hóa trị: +2, +3";
            f.lbtiemnang.Text = "Tiềm năng Ion hóa của nguyên tử: --*--";
            f.lbbankinh.Text = "Bán kính nguyên tử: 183 pm";
            f.lblienket.Text = "Liên kết cộng hóa trị bán kính: --*-- pm";
            f.lbbankinhvan.Text = "Bán kính Van der Waals: --*-- pm";
            f.lbamdien.Text = "Âm điện: --*--";
            f.lbhoatriphanung.Text = "Hóa trị: +3";
            f.lbelectron.Text = "Electron mối quan hệ: 50 kJ/mole";
            f.lbdientro.Text = "Điện trở: 7.4x10^-7";
            f.lbvotraidat.Text = " Tỉ lệ có trong vỏ Trái Đất: --*-- %";
            f.lbconnguoi.Text = "Tỉ lệ có trong con người: --*-- %";
            f.lbvutru.Text = "Tỉ lệ có trong vũ trụ: --*-- %";
        }

        private void btlantan_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nhóm Lantan từ nguyên tố thứ 57-71 và có màu xanh lam nhạt trên màn hình chính!", "Nhóm Lantan");
        }

        private void btnsm_Click(object sender, EventArgs e)
        {
            Thong_Tin_Nguyen_To f = new Thong_Tin_Nguyen_To();
            f.Show();
            f.pictureBox1.Image = new Bitmap(Application.StartupPath + "\\Image Of Visual Periodic Table\\samarium.png");
            f.lbkihieu.Text = "Sm";
            f.lbtennguyento.Text = "Samari";
            f.lbmol.Text = "150.36 (g/mol)";
            f.lbloai.Text = "NHÓM LANTAN";
            f.lbtenlatin.Text = "Tên Latin: Samarium";
            f.lbtenanh.Text = "Tên tiếng Anh: Samarium";
            f.lbnam.Text = "Năm khám phá: 1979";
            f.lbnguoi.Text = "Người khám phá: P.E.L de Boisbaudran";
            f.lbvo.Text = "Vỏ điện tử: K2 L8 M18 N24 O8 P2";
            f.lbcas.Text = "CAS số: CAS7440-19-9";
            f.lbsongtu.Text = "Số nguyên tử: 62";
            f.lbnguyentukhoi.Text = "Nguyên tử khối; 150.36 (g/mol)";
            f.lbmatdo.Text = "Mật độ: 7.54 (g/cm3)";
            f.lbnongchay.Text = "Điểm nóng chảy: 1072 'C";
            f.lbsoi.Text = "Điểm sôi: 1778 'C";
            f.lbcauhinh.Text = "Cấu hình điện tử: [Xe]6s2 4f6 1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 5s2 4d10 5p6 6s2 4f6";
            f.lbhoatri.Text = "Hóa trị: +2, +3";
            f.lbtiemnang.Text = "Tiềm năng Ion hóa của nguyên tử: 6.55";
            f.lbbankinh.Text = "Bán kính nguyên tử: 181 pm";
            f.lblienket.Text = "Liên kết cộng hóa trị bán kính: --*-- pm";
            f.lbbankinhvan.Text = "Bán kính Van der Waals: --*-- pm";
            f.lbamdien.Text = "Âm điện: 1.17";
            f.lbhoatriphanung.Text = "Hóa trị: (+2), +3";
            f.lbelectron.Text = "Electron mối quan hệ: 50 kJ/mole";
            f.lbdientro.Text = "Điện trở: 9.4x10^-7";
            f.lbvotraidat.Text = " Tỉ lệ có trong vỏ Trái Đất: 0.0006 %";
            f.lbconnguoi.Text = "Tỉ lệ có trong con người: --*-- %";
            f.lbvutru.Text = "Tỉ lệ có trong vũ trụ: --*-- %";
        }

        private void btneu_Click(object sender, EventArgs e)
        {
            Thong_Tin_Nguyen_To f = new Thong_Tin_Nguyen_To();
            f.Show();
            f.pictureBox1.Image = new Bitmap(Application.StartupPath + "\\Image Of Visual Periodic Table\\samarium.png");
            f.lbkihieu.Text = "Eu";
            f.lbtennguyento.Text = "Europi";
            f.lbmol.Text = "151.964 (g/mol)";
            f.lbloai.Text = "NHÓM LANTAN";
            f.lbtenlatin.Text = "Tên Latin: Europium";
            f.lbtenanh.Text = "Tên tiếng Anh: Europium";
            f.lbnam.Text = "Năm khám phá: 1901";
            f.lbnguoi.Text = "Người khám phá: E.A Demarcay";
            f.lbvo.Text = "Vỏ điện tử: K2 L8 M18 N25 O8 P2";
            f.lbcas.Text = "CAS số: CAS7440-53-1";
            f.lbsongtu.Text = "Số nguyên tử: 63";
            f.lbnguyentukhoi.Text = "Nguyên tử khối; 151.964 (g/mol)";
            f.lbmatdo.Text = "Mật độ: 5.25 (g/cm3)";
            f.lbnongchay.Text = "Điểm nóng chảy: 822 'C";
            f.lbsoi.Text = "Điểm sôi: 1597 'C";
            f.lbcauhinh.Text = "Cấu hình điện tử: [Xe]6s2 4f7 1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 5s2 4d10 5p6 6s2 4f7";
            f.lbhoatri.Text = "Hóa trị: +2, +3";
            f.lbtiemnang.Text = "Tiềm năng Ion hóa của nguyên tử: --*--";
            f.lbbankinh.Text = "Bán kính nguyên tử: 199 pm";
            f.lblienket.Text = "Liên kết cộng hóa trị bán kính: --*-- pm";
            f.lbbankinhvan.Text = "Bán kính Van der Waals: --*-- pm";
            f.lbamdien.Text = "Âm điện: --*--";
            f.lbhoatriphanung.Text = "Hóa trị: (+2), +3";
            f.lbelectron.Text = "Electron mối quan hệ: 50 kJ/mole";
            f.lbdientro.Text = "Điện trở: 9x10^-7";
            f.lbvotraidat.Text = " Tỉ lệ có trong vỏ Trái Đất: 0.00018 %";
            f.lbconnguoi.Text = "Tỉ lệ có trong con người: --*-- %";
            f.lbvutru.Text = "Tỉ lệ có trong vũ trụ: --*-- %";
        }

        private void btngd_Click(object sender, EventArgs e)
        {
            Thong_Tin_Nguyen_To f = new Thong_Tin_Nguyen_To();
            f.Show();
            f.pictureBox1.Image = new Bitmap(Application.StartupPath + "\\Image Of Visual Periodic Table\\gadolinium.png");
            f.lbkihieu.Text = "Gd";
            f.lbtennguyento.Text = "Gađolini";
            f.lbmol.Text = "157.25 (g/mol)";
            f.lbloai.Text = "NHÓM LANTAN";
            f.lbtenlatin.Text = "Tên Latin: Gadolinium";
            f.lbtenanh.Text = "Tên tiếng Anh: Gadolinium";
            f.lbnam.Text = "Năm khám phá: 1880";
            f.lbnguoi.Text = "Người khám phá: J.C.G de Marignac";
            f.lbvo.Text = "Vỏ điện tử: K2 L8 M18 N25 O9 P2";
            f.lbcas.Text = "CAS số: CAS7440-54-2";
            f.lbsongtu.Text = "Số nguyên tử: 64";
            f.lbnguyentukhoi.Text = "Nguyên tử khối; 157.25 (g/mol)";
            f.lbmatdo.Text = "Mật độ: 7.89 (g/cm3)";
            f.lbnongchay.Text = "Điểm nóng chảy: 1311 'C";
            f.lbsoi.Text = "Điểm sôi: 3264 'C";
            f.lbcauhinh.Text = "Cấu hình điện tử: [Xe]6s2 4f7 5d1 1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 5s2 4fd10 5p6 6s2 4f7 5d1";
            f.lbhoatri.Text = "Hóa trị: +1, +2, +3";
            f.lbtiemnang.Text = "Tiềm năng Ion hóa của nguyên tử: 6.65";
            f.lbbankinh.Text = "Bán kính nguyên tử: 179 pm";
            f.lblienket.Text = "Liên kết cộng hóa trị bán kính: --*-- pm";
            f.lbbankinhvan.Text = "Bán kính Van der Waals: --*-- pm";
            f.lbamdien.Text = "Âm điện: 1.2";
            f.lbhoatriphanung.Text = "Hóa trị: +3";
            f.lbelectron.Text = "Electron mối quan hệ: 50 kJ/mole";
            f.lbdientro.Text = "Điện trở: 7.7x^-6";
            f.lbvotraidat.Text = " Tỉ lệ có trong vỏ Trái Đất: 0.0052 %";
            f.lbconnguoi.Text = "Tỉ lệ có trong con người: --*-- %";
            f.lbvutru.Text = "Tỉ lệ có trong vũ trụ: --*-- %";
        }

        private void giảiPhươngTrìnhBậcNhấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Giai_Phuong_Trinh_Bac_Nhat f = new Giai_Phuong_Trinh_Bac_Nhat();
            f.ShowDialog();
        }

        private void giảiPhươngTrìnhBậcHaiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Giai_Phuong_Trinh_Bac_Hai f = new Giai_Phuong_Trinh_Bac_Hai();
            f.ShowDialog();
        }

        private void giảiPhươngTrìnhBậcNhấtHaiẨnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Giai_Phuong_Trinh_Bac_Nhat_Hai_An f = new Giai_Phuong_Trinh_Bac_Nhat_Hai_An();
            f.ShowDialog();
        }

        private void tínhNồngĐộPhầnTrămDungDịchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nong_Do_Phan_Tram f = new Nong_Do_Phan_Tram();
            f.ShowDialog();
        }

        private void btntb_Click(object sender, EventArgs e)
        {
            Thong_Tin_Nguyen_To f = new Thong_Tin_Nguyen_To();
            f.Show();
            f.pictureBox1.Image = new Bitmap(Application.StartupPath + "\\Image Of Visual Periodic Table\\terbium.png");
            f.lbkihieu.Text = "Tb";
            f.lbtennguyento.Text = "Tecbi";
            f.lbmol.Text = "158.925 (g/mol)";
            f.lbloai.Text = "NHÓM LANTAN";
            f.lbtenlatin.Text = "Tên Latin: Terbium";
            f.lbtenanh.Text = "Tên tiếng Anh: Terbium";
            f.lbnam.Text = "Năm khám phá: 1843";
            f.lbnguoi.Text = "Người khám phá: C.G Mosander";
            f.lbvo.Text = "Vỏ điện tử: K2 L8 M18 N27 O8 P2";
            f.lbcas.Text = "CAS số: CAS7440-27-9";
            f.lbsongtu.Text = "Số nguyên tử: 65";
            f.lbnguyentukhoi.Text = "Nguyên tử khối; 158.925 (g/mol)";
            f.lbmatdo.Text = "Mật độ: 8.25 (g/cm3)";
            f.lbnongchay.Text = "Điểm nóng chảy: 1360 'C";
            f.lbsoi.Text = "Điểm sôi: 3021 'C";
            f.lbcauhinh.Text = "Cấu hình điện tử: [Xe]6s2 4f9 1s2 2s2 2p6 3s2 4s2 3d10 4p6 5s2 4d10 5p6 6s2 4f9";
            f.lbhoatri.Text = "Hóa trị: +1, +2, +3, +4";
            f.lbtiemnang.Text = "Tiềm năng Ion hóa của nguyên tử: 6.74";
            f.lbbankinh.Text = "Bán kính nguyên tử: 180 pm";
            f.lblienket.Text = "Liên kết cộng hóa trị bán kính: --*-- pm";
            f.lbbankinhvan.Text = "Bán kính Van der Waals: --*-- pm";
            f.lbamdien.Text = "Âm điện: --*--";
            f.lbhoatriphanung.Text = "Hóa trị: +3, +4";
            f.lbelectron.Text = "Electron mối quan hệ: 50 kJ/mole";
            f.lbdientro.Text = "Điện trở: 1.2x10^-7";
            f.lbvotraidat.Text = " Tỉ lệ có trong vỏ Trái Đất: 0.000093 %";
            f.lbconnguoi.Text = "Tỉ lệ có trong con người: --*-- %";
            f.lbvutru.Text = "Tỉ lệ có trong vũ trụ: --*-- %";
        }

        private void btndy_Click(object sender, EventArgs e)
        {
            Thong_Tin_Nguyen_To f = new Thong_Tin_Nguyen_To();
            f.Show();
            f.pictureBox1.Image = new Bitmap(Application.StartupPath + "\\Image Of Visual Periodic Table\\dysprosium.png");
            f.lbkihieu.Text = "Dy";
            f.lbtennguyento.Text = "Đysprosi";
            f.lbmol.Text = "162.500 (g/mol)";
            f.lbloai.Text = "NHÓM LANTAN";
            f.lbtenlatin.Text = "Tên Latin: Dysprosium";
            f.lbtenanh.Text = "Tên tiếng Anh: Dysprosium";
            f.lbnam.Text = "Năm khám phá: 1886";
            f.lbnguoi.Text = "Người khám phá: P.E.L de Boisbaudran";
            f.lbvo.Text = "Vỏ điện tử: K2 L8 M18 N28 O8 P2";
            f.lbcas.Text = "CAS số: CAS7429-91-6";
            f.lbsongtu.Text = "Số nguyên tử: 66";
            f.lbnguyentukhoi.Text = "Nguyên tử khối; 162.500 (g/mol)";
            f.lbmatdo.Text = "Mật độ: 8.56 (g/cm3)";
            f.lbnongchay.Text = "Điểm nóng chảy: 1409 'C";
            f.lbsoi.Text = "Điểm sôi: 2560 'C";
            f.lbcauhinh.Text = "Cấu hình điện tử: [Xe]6s2 4f10 1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 5s2 4d10 5p6 6s2 4f10";
            f.lbhoatri.Text = "Hóa trị: +2, +3 +4";
            f.lbtiemnang.Text = "Tiềm năng Ion hóa của nguyên tử: 6.82";
            f.lbbankinh.Text = "Bán kính nguyên tử: 180 pm";
            f.lblienket.Text = "Liên kết cộng hóa trị bán kính: --*-- pm";
            f.lbbankinhvan.Text = "Bán kính Van der Waals: --*-- pm";
            f.lbamdien.Text = "Âm điện: 1.22";
            f.lbhoatriphanung.Text = "Hóa trị: +3";
            f.lbelectron.Text = "Electron mối quan hệ: 50 kJ/mole";
            f.lbdientro.Text = "Điện trở: 1.1x10^6";
            f.lbvotraidat.Text = " Tỉ lệ có trong vỏ Trái Đất: 0.000062 %";
            f.lbconnguoi.Text = "Tỉ lệ có trong con người: --*-- %";
            f.lbvutru.Text = "Tỉ lệ có trong vũ trụ: --*-- %";
        }

        private void tbnho_Click(object sender, EventArgs e)
        {
            Thong_Tin_Nguyen_To f = new Thong_Tin_Nguyen_To();
            f.Show();
            f.pictureBox1.Image = new Bitmap(Application.StartupPath + "\\Image Of Visual Periodic Table\\holmium.png");
            f.lbkihieu.Text = "Ho";
            f.lbtennguyento.Text = "Holmi";
            f.lbmol.Text = "164.93 (g/mol)";
            f.lbloai.Text = "NHÓM LANTAN";
            f.lbtenlatin.Text = "Tên Latin: Holmium";
            f.lbtenanh.Text = "Tên tiếng Anh: Holmium";
            f.lbnam.Text = "Năm khám phá: 1878";
            f.lbnguoi.Text = "Người khám phá: A.H Charlois";
            f.lbvo.Text = "Vỏ điện tử: K2 L8 M18 N29 O8 P2";
            f.lbcas.Text = "CAS số: CAS7429-91-6";
            f.lbsongtu.Text = "Số nguyên tử: 67";
            f.lbnguyentukhoi.Text = "Nguyên tử khối; 164.93 (g/mol)";
            f.lbmatdo.Text = "Mật độ: 8.78 (g/cm3)";
            f.lbnongchay.Text = "Điểm nóng chảy: 1470 'C";
            f.lbsoi.Text = "Điểm sôi: 2693 'C";
            f.lbcauhinh.Text = "Cấu hình điện tử: [Xe]6s2 4f11 1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 5s2 4d10 5p6 6s2 4f11";
            f.lbhoatri.Text = "Hóa trị: +2, +3";
            f.lbtiemnang.Text = "Tiềm năng Ion hóa của nguyên tử: --*--";
            f.lbbankinh.Text = "Bán kính nguyên tử: 179 pm";
            f.lblienket.Text = "Liên kết cộng hóa trị bán kính: --*-- pm";
            f.lbbankinhvan.Text = "Bán kính Van der Waals: --*-- pm";
            f.lbamdien.Text = "Âm điện: 1.23";
            f.lbhoatriphanung.Text = "Hóa trị: +3";
            f.lbelectron.Text = "Electron mối quan hệ: 50 kJ/mole";
            f.lbdientro.Text = "Điện trở: 1.1x10^6";
            f.lbvotraidat.Text = " Tỉ lệ có trong vỏ Trái Đất: 0.00012 %";
            f.lbconnguoi.Text = "Tỉ lệ có trong con người: --*-- %";
            f.lbvutru.Text = "Tỉ lệ có trong vũ trụ: --*-- %";
        }

        private void btner_Click(object sender, EventArgs e)
        {
            Thong_Tin_Nguyen_To f = new Thong_Tin_Nguyen_To();
            f.Show();
            f.pictureBox1.Image = new Bitmap(Application.StartupPath + "\\Image Of Visual Periodic Table\\erbium.png");
            f.lbkihieu.Text = "Er";
            f.lbtennguyento.Text = "Er";
            f.lbmol.Text = "167.259 (g/mol)";
            f.lbloai.Text = "NHÓM LANTAN";
            f.lbtenlatin.Text = "Tên Latin: Erbium";
            f.lbtenanh.Text = "Tên tiếng Anh: Erbium";
            f.lbnam.Text = "Năm khám phá: 1842";
            f.lbnguoi.Text = "Người khám phá: C.G Mosander";
            f.lbvo.Text = "Vỏ điện tử: K2 L8 M18 N30 O8 P2";
            f.lbcas.Text = "CAS số: CAS7440-52-0";
            f.lbsongtu.Text = "Số nguyên tử: 68";
            f.lbnguyentukhoi.Text = "Nguyên tử khối; 167.259 (g/mol)";
            f.lbmatdo.Text = "Mật độ: 9.05 (g/cm3)";
            f.lbnongchay.Text = "Điểm nóng chảy: 1522 'C";
            f.lbsoi.Text = "Điểm sôi: 2861 'C";
            f.lbcauhinh.Text = "Cấu hình điện tử: [Xe]6s2 4f12 1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 5s2 4d10 5p6 6s2 4f12";
            f.lbhoatri.Text = "Hóa trị: +2, +3";
            f.lbtiemnang.Text = "Tiềm năng Ion hóa của nguyên tử: --*--";
            f.lbbankinh.Text = "Bán kính nguyên tử: 178 pm";
            f.lblienket.Text = "Liên kết cộng hóa trị bán kính: --*-- pm";
            f.lbbankinhvan.Text = "Bán kính Van der Waals: --*-- pm";
            f.lbamdien.Text = "Âm điện: 1.24";
            f.lbhoatriphanung.Text = "Hóa trị: +3";
            f.lbelectron.Text = "Electron mối quan hệ: 50 kJ/mole";
            f.lbdientro.Text = "Điện trở: 1.2x10^6";
            f.lbvotraidat.Text = " Tỉ lệ có trong vỏ Trái Đất: 0.0003 %";
            f.lbconnguoi.Text = "Tỉ lệ có trong con người: --*-- %";
            f.lbvutru.Text = "Tỉ lệ có trong vũ trụ: --*-- %";
        }

        private void btntm_Click(object sender, EventArgs e)
        {
            Thong_Tin_Nguyen_To f = new Thong_Tin_Nguyen_To();
            f.Show();
            f.pictureBox1.Image = new Bitmap(Application.StartupPath + "\\Image Of Visual Periodic Table\\thulium.png");
            f.lbkihieu.Text = "Tm";
            f.lbtennguyento.Text = "Tuli";
            f.lbmol.Text = "168.934 (g/mol)";
            f.lbloai.Text = "NHÓM LANTAN";
            f.lbtenlatin.Text = "Tên Latin: Thulium";
            f.lbtenanh.Text = "Tên tiếng Anh: Thulium";
            f.lbnam.Text = "Năm khám phá: 1879";
            f.lbnguoi.Text = "Người khám phá: --*--";
            f.lbvo.Text = "Vỏ điện tử: K2 L8 M18 N31 O8 P2";
            f.lbcas.Text = "CAS số: CAS7440-30-4";
            f.lbsongtu.Text = "Số nguyên tử: 69";
            f.lbnguyentukhoi.Text = "Nguyên tử khối; 168.934 (g/mol)";
            f.lbmatdo.Text = "Mật độ: 9.32 (g/cm3)";
            f.lbnongchay.Text = "Điểm nóng chảy: 1545 'C";
            f.lbsoi.Text = "Điểm sôi: 1945 'C";
            f.lbcauhinh.Text = "Cấu hình điện tử: [Xe]6s2 4f13 1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 5s2 4d10 5p6 6s2 4f13";
            f.lbhoatri.Text = "Hóa trị: +2, +3";
            f.lbtiemnang.Text = "Tiềm năng Ion hóa của nguyên tử: --*--";
            f.lbbankinh.Text = "Bán kính nguyên tử: 177 pm";
            f.lblienket.Text = "Liên kết cộng hóa trị bán kính: --*-- pm";
            f.lbbankinhvan.Text = "Bán kính Van der Waals: --*-- pm";
            f.lbamdien.Text = "Âm điện: 1.25";
            f.lbhoatriphanung.Text = "Hóa trị: +3";
            f.lbelectron.Text = "Electron mối quan hệ: 50 kJ/mole";
            f.lbdientro.Text = "Điện trở: 1.4x10^6";
            f.lbvotraidat.Text = " Tỉ lệ có trong vỏ Trái Đất: 0.000045 %";
            f.lbconnguoi.Text = "Tỉ lệ có trong con người: --*-- %";
            f.lbvutru.Text = "Tỉ lệ có trong vũ trụ: --*-- %";
        }

        private void btnyb_Click(object sender, EventArgs e)
        {
            Thong_Tin_Nguyen_To f = new Thong_Tin_Nguyen_To();
            f.Show();
            f.pictureBox1.Image = new Bitmap(Application.StartupPath + "\\Image Of Visual Periodic Table\\ytterbium.png");
            f.lbkihieu.Text = "Yb";
            f.lbtennguyento.Text = "Ytecbi";
            f.lbmol.Text = "173.04 (g/mol)";
            f.lbloai.Text = "NHÓM LANTAN";
            f.lbtenlatin.Text = "Tên Latin: Ytterbium";
            f.lbtenanh.Text = "Tên tiếng Anh: Ytterbium";
            f.lbnam.Text = "Năm khám phá: 1878";
            f.lbnguoi.Text = "Người khám phá: J.C.G de Marignac";
            f.lbvo.Text = "Vỏ điện tử: K2 L8 M18 N32 O8 P2";
            f.lbcas.Text = "CAS số: CAS7440-64-4";
            f.lbsongtu.Text = "Số nguyên tử: 70";
            f.lbnguyentukhoi.Text = "Nguyên tử khối; 173.04 (g/mol)";
            f.lbmatdo.Text = "Mật độ: 6.97 (g/cm3)";
            f.lbnongchay.Text = "Điểm nóng chảy: 824 'C";
            f.lbsoi.Text = "Điểm sôi: 1193 'C";
            f.lbcauhinh.Text = "Cấu hình điện tử: [Xe]6s2 4f14 1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 5s2 4d10 5p6 6s2 4f14";
            f.lbhoatri.Text = "Hóa trị: +2, +3";
            f.lbtiemnang.Text = "Tiềm năng Ion hóa của nguyên tử: --*--";
            f.lbbankinh.Text = "Bán kính nguyên tử: 194 pm";
            f.lblienket.Text = "Liên kết cộng hóa trị bán kính: --*-- pm";
            f.lbbankinhvan.Text = "Bán kính Van der Waals: --*-- pm";
            f.lbamdien.Text = "Âm điện: --*--";
            f.lbhoatriphanung.Text = "Hóa trị: +3";
            f.lbelectron.Text = "Electron mối quan hệ: 50 kJ/mole";
            f.lbdientro.Text = "Điện trở: 2.8x10^-7";
            f.lbvotraidat.Text = " Tỉ lệ có trong vỏ Trái Đất: 0.00028 %";
            f.lbconnguoi.Text = "Tỉ lệ có trong con người: --*-- %";
            f.lbvutru.Text = "Tỉ lệ có trong vũ trụ: --*-- %";
        }

        private void btnlu_Click(object sender, EventArgs e)
        {
            Thong_Tin_Nguyen_To f = new Thong_Tin_Nguyen_To();
            f.Show();
            f.pictureBox1.Image = new Bitmap(Application.StartupPath + "\\Image Of Visual Periodic Table\\lutetium.png");
            f.lbkihieu.Text = "Lu";
            f.lbtennguyento.Text = "Lutexi";
            f.lbmol.Text = "174.967 (g/mol)";
            f.lbloai.Text = "NHÓM LANTAN";
            f.lbtenlatin.Text = "Tên Latin: Lutetium";
            f.lbtenanh.Text = "Tên tiếng Anh: Lutetium";
            f.lbnam.Text = "Năm khám phá: 1907";
            f.lbnguoi.Text = "Người khám phá: --*--";
            f.lbvo.Text = "Vỏ điện tử: K2 L8 M18 N32 O9 P2";
            f.lbcas.Text = "CAS số: CAS7439-94-3";
            f.lbsongtu.Text = "Số nguyên tử: 71";
            f.lbnguyentukhoi.Text = "Nguyên tử khối; 174.967 (g/mol)";
            f.lbmatdo.Text = "Mật độ: 9.84 (g/cm3)";
            f.lbnongchay.Text = "Điểm nóng chảy: 1656 'C";
            f.lbsoi.Text = "Điểm sôi: 3393 'C";
            f.lbcauhinh.Text = "Cấu hình điện tử: [Xe]6s2 4f14 5d1 1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 5s2 4d10 5p6 6s2 4f14 5d1";
            f.lbhoatri.Text = "Hóa trị: +3";
            f.lbtiemnang.Text = "Tiềm năng Ion hóa của nguyên tử: --*--";
            f.lbbankinh.Text = "Bán kính nguyên tử: 175 pm";
            f.lblienket.Text = "Liên kết cộng hóa trị bán kính: 160 pm";
            f.lbbankinhvan.Text = "Bán kính Van der Waals: --*-- pm";
            f.lbamdien.Text = "Âm điện: 1.27";
            f.lbhoatriphanung.Text = "Hóa trị: +3";
            f.lbelectron.Text = "Electron mối quan hệ: 50 kJ/mole";
            f.lbdientro.Text = "Điện trở: 5.6x10^-7";
            f.lbvotraidat.Text = " Tỉ lệ có trong vỏ Trái Đất: 0.000056 %";
            f.lbconnguoi.Text = "Tỉ lệ có trong con người: --*-- %";
            f.lbvutru.Text = "Tỉ lệ có trong vũ trụ: --*-- %";
        }

        private void btnac_Click(object sender, EventArgs e)
        {
            Thong_Tin_Nguyen_To f = new Thong_Tin_Nguyen_To();
            f.Show();
            f.pictureBox1.Image = new Bitmap(Application.StartupPath + "\\Image Of Visual Periodic Table\\actinium.png");
            f.lbkihieu.Text = "Ac";
            f.lbtennguyento.Text = "Actini";
            f.lbmol.Text = "227.0278 (g/mol)";
            f.lbloai.Text = "NHÓM ACTINI-PHÓNG XẠ";
            f.lbtenlatin.Text = "Tên Latin: Actinium";
            f.lbtenanh.Text = "Tên tiếng Anh: Actinium";
            f.lbnam.Text = "Năm khám phá: 1899";
            f.lbnguoi.Text = "Người khám phá: A.L. Debierne";
            f.lbvo.Text = "Vỏ điện tử: K2 L8 M18 N32 O9 Q2";
            f.lbcas.Text = "CAS số: CAS7440-34-8";
            f.lbsongtu.Text = "Số nguyên tử: 89";
            f.lbnguyentukhoi.Text = "Nguyên tử khối; 227.0278 (g/mol)";
            f.lbmatdo.Text = "Mật độ: 10.07 (g/cm3)";
            f.lbnongchay.Text = "Điểm nóng chảy: 1047 'C";
            f.lbsoi.Text = "Điểm sôi: 3197 'C";
            f.lbcauhinh.Text = "Cấu hình điện tử: [Rn]6d1 7s2 1s2 2s2 2p6 3s2 3d10 4s2 4p6 4d10 5s2 5p6 4f14 5d10 6s2 7s2";
            f.lbhoatri.Text = "Hóa trị: +3";
            f.lbtiemnang.Text = "Tiềm năng Ion hóa của nguyên tử: --*--";
            f.lbbankinh.Text = "Bán kính nguyên tử: 188 pm";
            f.lblienket.Text = "Liên kết cộng hóa trị bán kính: --*-- pm";
            f.lbbankinhvan.Text = "Bán kính Van der Waals: --*-- pm";
            f.lbamdien.Text = "Âm điện: 1.1";
            f.lbhoatriphanung.Text = "Hóa trị: +3";
            f.lbelectron.Text = "Electron mối quan hệ: --*-- kJ/mole";
            f.lbdientro.Text = "Điện trở: --*--";
            f.lbvotraidat.Text = " Tỉ lệ có trong vỏ Trái Đất: --*--- %";
            f.lbconnguoi.Text = "Tỉ lệ có trong con người: --*-- %";
            f.lbvutru.Text = "Tỉ lệ có trong vũ trụ: --*-- %";
        }

        private void btnth_Click(object sender, EventArgs e)
        {
            Thong_Tin_Nguyen_To f = new Thong_Tin_Nguyen_To();
            f.Show();
            f.pictureBox1.Image = new Bitmap(Application.StartupPath + "\\Image Of Visual Periodic Table\\thorium.png");
            f.lbkihieu.Text = "Th";
            f.lbtennguyento.Text = "Thori";
            f.lbmol.Text = "232.0380 (g/mol)";
            f.lbloai.Text = "NHÓM ACTINI-PHÓNG XẠ";
            f.lbtenlatin.Text = "Tên Latin: Thorium";
            f.lbtenanh.Text = "Tên tiếng Anh: Thorium";
            f.lbnam.Text = "Năm khám phá: 1828";
            f.lbnguoi.Text = "Người khám phá: J.J Berzelius";
            f.lbvo.Text = "Vỏ điện tử: K2 L8 M18 N32 O9 P10 Q2";
            f.lbcas.Text = "CAS số: CAS7440-29-1";
            f.lbsongtu.Text = "Số nguyên tử: 90";
            f.lbnguyentukhoi.Text = "Nguyên tử khối; 232.0380 (g/mol)";
            f.lbmatdo.Text = "Mật độ: 11.72 (g/cm3)";
            f.lbnongchay.Text = "Điểm nóng chảy: 1750 'C";
            f.lbsoi.Text = "Điểm sôi: 4787 'C";
            f.lbcauhinh.Text = "Cấu hình điện tử: [Rn]7s2 6d1 1s2 2s2 2p6 3s2 3d6 4s2 3d10 5p6 4d10 5p6 6s2 4f14 5d10 6p6 7s2 6d2 5f10";
            f.lbhoatri.Text = "Hóa trị: +1, +2, +3, +4";
            f.lbtiemnang.Text = "Tiềm năng Ion hóa của nguyên tử: --*--";
            f.lbbankinh.Text = "Bán kính nguyên tử: 180 pm";
            f.lblienket.Text = "Liên kết cộng hóa trị bán kính: --*-- pm";
            f.lbbankinhvan.Text = "Bán kính Van der Waals: --*-- pm";
            f.lbamdien.Text = "Âm điện: 1.3";
            f.lbhoatriphanung.Text = "Hóa trị: +4";
            f.lbelectron.Text = "Electron mối quan hệ: --*-- kJ/mole";
            f.lbdientro.Text = "Điện trở: 1.5x10^-7";
            f.lbvotraidat.Text = " Tỉ lệ có trong vỏ Trái Đất: 0.0006 %";
            f.lbconnguoi.Text = "Tỉ lệ có trong con người: --*-- %";
            f.lbvutru.Text = "Tỉ lệ có trong vũ trụ: --*-- %";
        }

        private void btnpa_Click(object sender, EventArgs e)
        {
            Thong_Tin_Nguyen_To f = new Thong_Tin_Nguyen_To();
            f.Show();
            f.pictureBox1.Image = new Bitmap(Application.StartupPath + "\\Image Of Visual Periodic Table\\protactinium.png");
            f.lbkihieu.Text = "Pa";
            f.lbtennguyento.Text = "Protactini";
            f.lbmol.Text = "231.0358 (g/mol)";
            f.lbloai.Text = "NHÓM ACTINI-PHÓNG XẠ";
            f.lbtenlatin.Text = "Tên Latin: Protactinium";
            f.lbtenanh.Text = "Tên tiếng Anh: Protactinium";
            f.lbnam.Text = "Năm khám phá: 1913";
            f.lbnguoi.Text = "Người khám phá: William Crookes";
            f.lbvo.Text = "Vỏ điện tử: K2 L8 M18 N32 O20 P9 Q2";
            f.lbcas.Text = "CAS số: CAS7440-13-3";
            f.lbsongtu.Text = "Số nguyên tử: 91";
            f.lbnguyentukhoi.Text = "Nguyên tử khối; 231.0258 (g/mol)";
            f.lbmatdo.Text = "Mật độ: 15.37 (g/cm3)";
            f.lbnongchay.Text = "Điểm nóng chảy: 1840 'C";
            f.lbsoi.Text = "Điểm sôi: 4030 'C";
            f.lbcauhinh.Text = "Cấu hình điện tử: [Rn]7s2 5f2 6d1 1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 5s2 4d10 5p6 6s2 4f14 5d10 6p6 7s2 5f2 6d1";
            f.lbhoatri.Text = "Hóa trị: +3, +4, +5";
            f.lbtiemnang.Text = "Tiềm năng Ion hóa của nguyên tử: --*--";
            f.lbbankinh.Text = "Bán kính nguyên tử: 161 pm";
            f.lblienket.Text = "Liên kết cộng hóa trị bán kính: --*-- pm";
            f.lbbankinhvan.Text = "Bán kính Van der Waals: --*-- pm";
            f.lbamdien.Text = "Âm điện: 1.5";
            f.lbhoatriphanung.Text = "Hóa trị: +5";
            f.lbelectron.Text = "Electron mối quan hệ: --*-- kJ/mole";
            f.lbdientro.Text = "Điện trở: 5.6x10^6";
            f.lbvotraidat.Text = " Tỉ lệ có trong vỏ Trái Đất: --*-- %";
            f.lbconnguoi.Text = "Tỉ lệ có trong con người: --*-- %";
            f.lbvutru.Text = "Tỉ lệ có trong vũ trụ: --*-- %";
        }

        private void btnu_Click(object sender, EventArgs e)
        {
            Thong_Tin_Nguyen_To f = new Thong_Tin_Nguyen_To();
            f.Show();
            f.pictureBox1.Image = new Bitmap(Application.StartupPath + "\\Image Of Visual Periodic Table\\uranium.png");
            f.lbkihieu.Text = "U";
            f.lbtennguyento.Text = "Urani";
            f.lbmol.Text = "238.0289 (g/mol)";
            f.lbloai.Text = "NHÓM ACTINI-PHÓNG XẠ";
            f.lbtenlatin.Text = "Tên Latin: Uranium";
            f.lbtenanh.Text = "Tên tiếng Anh: Uranium";
            f.lbnam.Text = "Năm khám phá: 1789";
            f.lbnguoi.Text = "Người khám phá: M.H Klaproth";
            f.lbvo.Text = "Vỏ điện tử: K2 L8 M18 N32 O21 P9 Q2";
            f.lbcas.Text = "CAS số: CAS7440-61-1";
            f.lbsongtu.Text = "Số nguyên tử: 92";
            f.lbnguyentukhoi.Text = "Nguyên tử khối; 238.0289 (g/mol)";
            f.lbmatdo.Text = "Mật độ: 19.05 (g/cm3)";
            f.lbnongchay.Text = "Điểm nóng chảy: 1132.4 'C";
            f.lbsoi.Text = "Điểm sôi: 3743 'C";
            f.lbcauhinh.Text = "Cấu hình điện tử: [Rn]7s2 5f3 6d1 1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 5s2 4d10 5p6 6s2 4f14 5d10 6p6 7s2 5f3 6d1";
            f.lbhoatri.Text = "Hóa trị: +1, +2, +3, +4, +5";
            f.lbtiemnang.Text = "Tiềm năng Ion hóa của nguyên tử: --*--";
            f.lbbankinh.Text = "Bán kính nguyên tử: 138 pm";
            f.lblienket.Text = "Liên kết cộng hóa trị bán kính: --*-- pm";
            f.lbbankinhvan.Text = "Bán kính Van der Waals: 186 pm";
            f.lbamdien.Text = "Âm điện: 1.38";
            f.lbhoatriphanung.Text = "Hóa trị: (+2), +3, +4, (+5), +6";
            f.lbelectron.Text = "Electron mối quan hệ: --*-- kJ/mole";
            f.lbdientro.Text = "Điện trở: 2.8x10^-7";
            f.lbvotraidat.Text = " Tỉ lệ có trong vỏ Trái Đất: 0.00018 %";
            f.lbconnguoi.Text = "Tỉ lệ có trong con người: --*-- %";
            f.lbvutru.Text = "Tỉ lệ có trong vũ trụ: --*-- %";
        }

        private void btnnp_Click(object sender, EventArgs e)
        {
            Thong_Tin_Nguyen_To f = new Thong_Tin_Nguyen_To();
            f.Show();
            f.pictureBox1.Image = new Bitmap(Application.StartupPath + "\\Image Of Visual Periodic Table\\Khong_co_anh_VPTN.png");
            f.lbkihieu.Text = "Np";
            f.lbtennguyento.Text = "Neptuni";
            f.lbmol.Text = "237.0482 (g/mol)";
            f.lbloai.Text = "NHÓM ACTINI-PHÓNG XẠ";
            f.lbtenlatin.Text = "Tên Latin: Neptunium";
            f.lbtenanh.Text = "Tên tiếng Anh: Neptunium";
            f.lbnam.Text = "Năm khám phá: 1940";
            f.lbnguoi.Text = "Người khám phá: --*--";
            f.lbvo.Text = "Vỏ điện tử: K2 L8 M18 N32 O22 P9 Q2";
            f.lbcas.Text = "CAS số: CAS7440-99-8";
            f.lbsongtu.Text = "Số nguyên tử: 93";
            f.lbnguyentukhoi.Text = "Nguyên tử khối; 237.0428 (g/mol)";
            f.lbmatdo.Text = "Mật độ: 20.48 (g/cm3)";
            f.lbnongchay.Text = "Điểm nóng chảy: 640 'C";
            f.lbsoi.Text = "Điểm sôi: 3900 'C";
            f.lbcauhinh.Text = "Cấu hình điện tử: [Rn]7s2 5f4 6d1 1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 5s2 4d10 5p6 6s2 4f14 5d10 6p6 7s2 5f4 6d1";
            f.lbhoatri.Text = "Hóa trị: +2, +3, +4, +5, +7";
            f.lbtiemnang.Text = "Tiềm năng Ion hóa của nguyên tử: --*--";
            f.lbbankinh.Text = "Bán kính nguyên tử: 130 pm";
            f.lblienket.Text = "Liên kết cộng hóa trị bán kính: --*-- pm";
            f.lbbankinhvan.Text = "Bán kính Van der Waals: --*-- pm";
            f.lbamdien.Text = "Âm điện: 1.36";
            f.lbhoatriphanung.Text = "Hóa trị: --*--";
            f.lbelectron.Text = "Electron mối quan hệ: --*-- kJ/mole";
            f.lbdientro.Text = "Điện trở: 1.2x10^-6";
            f.lbvotraidat.Text = " Tỉ lệ có trong vỏ Trái Đất: --*-- %";
            f.lbconnguoi.Text = "Tỉ lệ có trong con người: --*-- %";
            f.lbvutru.Text = "Tỉ lệ có trong vũ trụ: --*-- %";
        }

        private void btnpu_Click(object sender, EventArgs e)
        {
            Thong_Tin_Nguyen_To f = new Thong_Tin_Nguyen_To();
            f.Show();
            f.pictureBox1.Image = new Bitmap(Application.StartupPath + "\\Image Of Visual Periodic Table\\plutonium.png");
            f.lbkihieu.Text = "Np";
            f.lbtennguyento.Text = "Neptuni";
            f.lbmol.Text = "237.0482 (g/mol)";
            f.lbloai.Text = "NHÓM ACTINI-PHÓNG XẠ";
            f.lbtenlatin.Text = "Tên Latin: Neptunium";
            f.lbtenanh.Text = "Tên tiếng Anh: Neptunium";
            f.lbnam.Text = "Năm khám phá: 1940";
            f.lbnguoi.Text = "Người khám phá: --*--";
            f.lbvo.Text = "Vỏ điện tử: K2 L8 M18 N32 O22 P9 Q2";
            f.lbcas.Text = "CAS số: CAS7440-99-8";
            f.lbsongtu.Text = "Số nguyên tử: 94";
            f.lbnguyentukhoi.Text = "Nguyên tử khối; 237.0428 (g/mol)";
            f.lbmatdo.Text = "Mật độ: 20.48 (g/cm3)";
            f.lbnongchay.Text = "Điểm nóng chảy: 640 'C";
            f.lbsoi.Text = "Điểm sôi: 3900 'C";
            f.lbcauhinh.Text = "Cấu hình điện tử: [Rn]7s2 5f4 6d1 1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 5s2 4d10 5p6 6s2 4f14 5d10 6p6 7s2 5f4 6d1";
            f.lbhoatri.Text = "Hóa trị: +2, +3, +4, +5, +7";
            f.lbtiemnang.Text = "Tiềm năng Ion hóa của nguyên tử: --*--";
            f.lbbankinh.Text = "Bán kính nguyên tử: 130 pm";
            f.lblienket.Text = "Liên kết cộng hóa trị bán kính: --*-- pm";
            f.lbbankinhvan.Text = "Bán kính Van der Waals: --*-- pm";
            f.lbamdien.Text = "Âm điện: 1.36";
            f.lbhoatriphanung.Text = "Hóa trị: --*--";
            f.lbelectron.Text = "Electron mối quan hệ: --*-- kJ/mole";
            f.lbdientro.Text = "Điện trở: 1.2x10^-6";
            f.lbvotraidat.Text = " Tỉ lệ có trong vỏ Trái Đất: --*-- %";
            f.lbconnguoi.Text = "Tỉ lệ có trong con người: --*-- %";
            f.lbvutru.Text = "Tỉ lệ có trong vũ trụ: --*-- %";
        }

        private void btnam_Click(object sender, EventArgs e)
        {
            Thong_Tin_Nguyen_To f = new Thong_Tin_Nguyen_To();
            f.Show();
            f.pictureBox1.Image = new Bitmap(Application.StartupPath + "\\Image Of Visual Periodic Table\\americium.png");
            f.lbkihieu.Text = "Am";
            f.lbtennguyento.Text = "Amerixi";
            f.lbmol.Text = "243.0614 (g/mol)";
            f.lbloai.Text = "NHÓM ACTINI-PHÓNG XẠ";
            f.lbtenlatin.Text = "Tên Latin: Amerixium";
            f.lbtenanh.Text = "Tên tiếng Anh: Amerixium";
            f.lbnam.Text = "Năm khám phá: 1944";
            f.lbnguoi.Text = "Người khám phá: G.T Seaborg";
            f.lbvo.Text = "Vỏ điện tử: K2 L8 M18 N32 O25 P8 Q2";
            f.lbcas.Text = "CAS số: CAS7440-35-9";
            f.lbsongtu.Text = "Số nguyên tử: 95";
            f.lbnguyentukhoi.Text = "Nguyên tử khối; 243.0614 (g/mol)";
            f.lbmatdo.Text = "Mật độ: 13.67 (g/cm3)";
            f.lbnongchay.Text = "Điểm nóng chảy: 1176 'C";
            f.lbsoi.Text = "Điểm sôi: 2607 'C";
            f.lbcauhinh.Text = "Cấu hình điện tử: [Rn]7s2 5f7 1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 5s2 4d10 5p6 6s2 4f14 5d10 6p6 7s2 5f4";
            f.lbhoatri.Text = "Hóa trị: +2, +3, +4, +5, +6, +7";
            f.lbtiemnang.Text = "Tiềm năng Ion hóa của nguyên tử: --*--";
            f.lbbankinh.Text = "Bán kính nguyên tử: 173 pm";
            f.lblienket.Text = "Liên kết cộng hóa trị bán kính: --*-- pm";
            f.lbbankinhvan.Text = "Bán kính Van der Waals: --*-- pm";
            f.lbamdien.Text = "Âm điện: 1.3";
            f.lbhoatriphanung.Text = "Hóa trị: --*--";
            f.lbelectron.Text = "Electron mối quan hệ: --*-- kJ/mole";
            f.lbdientro.Text = "Điện trở: --*--";
            f.lbvotraidat.Text = " Tỉ lệ có trong vỏ Trái Đất: --*-- %";
            f.lbconnguoi.Text = "Tỉ lệ có trong con người: --*-- %";
            f.lbvutru.Text = "Tỉ lệ có trong vũ trụ: --*-- %";
        }

        private void btncm_Click(object sender, EventArgs e)
        {
            Thong_Tin_Nguyen_To f = new Thong_Tin_Nguyen_To();
            f.Show();
            f.pictureBox1.Image = new Bitmap(Application.StartupPath + "\\Image Of Visual Periodic Table\\curium.png");
            f.lbkihieu.Text = "Cm";
            f.lbtennguyento.Text = "Curi";
            f.lbmol.Text = "247.0703 (g/mol)";
            f.lbloai.Text = "NHÓM ACTINI-PHÓNG XẠ";
            f.lbtenlatin.Text = "Tên Latin: Curium";
            f.lbtenanh.Text = "Tên tiếng Anh: Curium";
            f.lbnam.Text = "Năm khám phá: 1944";
            f.lbnguoi.Text = "Người khám phá: G.T Seaborg";
            f.lbvo.Text = "Vỏ điện tử: K2 L8 M18 N32 O25 P9 Q2";
            f.lbcas.Text = "CAS số: CAS7440-51-9";
            f.lbsongtu.Text = "Số nguyên tử: 96";
            f.lbnguyentukhoi.Text = "Nguyên tử khối; 247.0703 (g/mol)";
            f.lbmatdo.Text = "Mật độ: 13.51 (g/cm3)";
            f.lbnongchay.Text = "Điểm nóng chảy: 1340 'C";
            f.lbsoi.Text = "Điểm sôi: 3108 'C";
            f.lbcauhinh.Text = "Cấu hình điện tử: [Rn]7s2 5f7 6d1 1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 5s2 4d10 5p6 6s2 4f14 5d10 6p6 7s2 5f7 6d1";
            f.lbhoatri.Text = "Hóa trị: +3, +4, +6";
            f.lbtiemnang.Text = "Tiềm năng Ion hóa của nguyên tử: --*--";
            f.lbbankinh.Text = "Bán kính nguyên tử: 299 pm";
            f.lblienket.Text = "Liên kết cộng hóa trị bán kính: --*-- pm";
            f.lbbankinhvan.Text = "Bán kính Van der Waals: --*-- pm";
            f.lbamdien.Text = "Âm điện: 1.3";
            f.lbhoatriphanung.Text = "Hóa trị: --*--";
            f.lbelectron.Text = "Electron mối quan hệ: --*-- kJ/mole";
            f.lbdientro.Text = "Điện trở: --*--";
            f.lbvotraidat.Text = " Tỉ lệ có trong vỏ Trái Đất: --*-- %";
            f.lbconnguoi.Text = "Tỉ lệ có trong con người: --*-- %";
            f.lbvutru.Text = "Tỉ lệ có trong vũ trụ: --*-- %";
        }

        private void btnbk_Click(object sender, EventArgs e)
        {
            Thong_Tin_Nguyen_To f = new Thong_Tin_Nguyen_To();
            f.Show();
            f.pictureBox1.Image = new Bitmap(Application.StartupPath + "\\Image Of Visual Periodic Table\\berkelium.png");
            f.lbkihieu.Text = "Bk";
            f.lbtennguyento.Text = "Beckeli";
            f.lbmol.Text = "247.0703 (g/mol)";
            f.lbloai.Text = "NHÓM ACTINI-PHÓNG XẠ";
            f.lbtenlatin.Text = "Tên Latin: Beckelium";
            f.lbtenanh.Text = "Tên tiếng Anh: Beckelium";
            f.lbnam.Text = "Năm khám phá: 1949";
            f.lbnguoi.Text = "Người khám phá: G.T Seaborg";
            f.lbvo.Text = "Vỏ điện tử: K2 L8 M18 N32 O27 P8 Q2";
            f.lbcas.Text = "CAS số: CAS7440-40-6";
            f.lbsongtu.Text = "Số nguyên tử: 97";
            f.lbnguyentukhoi.Text = "Nguyên tử khối; 247.0703 (g/mol)";
            f.lbmatdo.Text = "Mật độ: 13.25 (g/cm3)";
            f.lbnongchay.Text = "Điểm nóng chảy: 986 'C";
            f.lbsoi.Text = "Điểm sôi: 2625 'C";
            f.lbcauhinh.Text = "Cấu hình điện tử: [Rn]7s2 5f9 6d1 1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 5s2 4d10 5p6 6s2 4f14 5d10 6p6 7s2 5f8 6d1";
            f.lbhoatri.Text = "Hóa trị: +3, +4";
            f.lbtiemnang.Text = "Tiềm năng Ion hóa của nguyên tử: --*--";
            f.lbbankinh.Text = "Bán kính nguyên tử: 299 pm";
            f.lblienket.Text = "Liên kết cộng hóa trị bán kính: --*-- pm";
            f.lbbankinhvan.Text = "Bán kính Van der Waals: --*-- pm";
            f.lbamdien.Text = "Âm điện: 1.3";
            f.lbhoatriphanung.Text = "Hóa trị: --*--";
            f.lbelectron.Text = "Electron mối quan hệ: --*-- kJ/mole";
            f.lbdientro.Text = "Điện trở: --*--";
            f.lbvotraidat.Text = " Tỉ lệ có trong vỏ Trái Đất: --*-- %";
            f.lbconnguoi.Text = "Tỉ lệ có trong con người: --*-- %";
            f.lbvutru.Text = "Tỉ lệ có trong vũ trụ: --*-- %";
        }

        private void btncf_Click(object sender, EventArgs e)
        {
            Thong_Tin_Nguyen_To f = new Thong_Tin_Nguyen_To();
            f.Show();
            f.pictureBox1.Image = new Bitmap(Application.StartupPath + "\\Image Of Visual Periodic Table\\californium.png");
            f.lbkihieu.Text = "Cf";
            f.lbtennguyento.Text = "Califoni";
            f.lbmol.Text = "251.0796(g/mol)";
            f.lbloai.Text = "NHÓM ACTINI-PHÓNG XẠ";
            f.lbtenlatin.Text = "Tên Latin: Califonium";
            f.lbtenanh.Text = "Tên tiếng Anh: Califonium";
            f.lbnam.Text = "Năm khám phá: 1950";
            f.lbnguoi.Text = "Người khám phá: G.T Seaborg";
            f.lbvo.Text = "Vỏ điện tử: K2 L8 M18 N32 O28 P8 Q2";
            f.lbcas.Text = "CAS số: CAS7440-71-3";
            f.lbsongtu.Text = "Số nguyên tử: 98";
            f.lbnguyentukhoi.Text = "Nguyên tử khối; 251.0796 (g/mol)";
            f.lbmatdo.Text = "Mật độ: 15.1 (g/cm3)";
            f.lbnongchay.Text = "Điểm nóng chảy: 900 'C";
            f.lbsoi.Text = "Điểm sôi: 1470 'C";
            f.lbcauhinh.Text = "Cấu hình điện tử: [Rn]7s2 5f10 6d1 1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 5s2 4d10 5p6 6s2 4f14 5d10 6p6 7s2 5f10";
            f.lbhoatri.Text = "Hóa trị: +2, +3, +4";
            f.lbtiemnang.Text = "Tiềm năng Ion hóa của nguyên tử: --*--";
            f.lbbankinh.Text = "Bán kính nguyên tử: 295 pm";
            f.lblienket.Text = "Liên kết cộng hóa trị bán kính: --*-- pm";
            f.lbbankinhvan.Text = "Bán kính Van der Waals: --*-- pm";
            f.lbamdien.Text = "Âm điện: 1.3";
            f.lbhoatriphanung.Text = "Hóa trị: --*--";
            f.lbelectron.Text = "Electron mối quan hệ: --*-- kJ/mole";
            f.lbdientro.Text = "Điện trở: --*--";
            f.lbvotraidat.Text = " Tỉ lệ có trong vỏ Trái Đất: --*-- %";
            f.lbconnguoi.Text = "Tỉ lệ có trong con người: --*-- %";
            f.lbvutru.Text = "Tỉ lệ có trong vũ trụ: --*-- %";
        }

        private void btnes_Click(object sender, EventArgs e)
        {
            Thong_Tin_Nguyen_To f = new Thong_Tin_Nguyen_To();
            f.Show();
            f.pictureBox1.Image = new Bitmap(Application.StartupPath + "\\Image Of Visual Periodic Table\\einsteinium.png");
            f.lbkihieu.Text = "Es";
            f.lbtennguyento.Text = "Ensteni";
            f.lbmol.Text = "252.0829 (g/mol)";
            f.lbloai.Text = "NHÓM ACTINI-PHÓNG XẠ";
            f.lbtenlatin.Text = "Tên Latin: Einsteinum";
            f.lbtenanh.Text = "Tên tiếng Anh: Einsteinum";
            f.lbnam.Text = "Năm khám phá: 1952";
            f.lbnguoi.Text = "Người khám phá: G.T Seaborg";
            f.lbvo.Text = "Vỏ điện tử: K2 L8 M18 N32 O29 P8 Q2";
            f.lbcas.Text = "CAS số: CAS7429-92-7";
            f.lbsongtu.Text = "Số nguyên tử: 99";
            f.lbnguyentukhoi.Text = "Nguyên tử khối; 252.0829 (g/mol)";
            f.lbmatdo.Text = "Mật độ: 13.5 (g/cm3)";
            f.lbnongchay.Text = "Điểm nóng chảy: 860 'C";
            f.lbsoi.Text = "Điểm sôi: -*-- 'C";
            f.lbcauhinh.Text = "Cấu hình điện tử: [Rn]7s2 5f11 6d1 1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 5s2 4d10 5p6 6s2 4f14 5d10 6p6 7s2 5f11";
            f.lbhoatri.Text = "Hóa trị: +2, +3, +4";
            f.lbtiemnang.Text = "Tiềm năng Ion hóa của nguyên tử: --*--";
            f.lbbankinh.Text = "Bán kính nguyên tử: 292 pm";
            f.lblienket.Text = "Liên kết cộng hóa trị bán kính: --*-- pm";
            f.lbbankinhvan.Text = "Bán kính Van der Waals: --*-- pm";
            f.lbamdien.Text = "Âm điện: 1.3";
            f.lbhoatriphanung.Text = "Hóa trị: --*--";
            f.lbelectron.Text = "Electron mối quan hệ: --*-- kJ/mole";
            f.lbdientro.Text = "Điện trở: --*--";
            f.lbvotraidat.Text = " Tỉ lệ có trong vỏ Trái Đất: --*-- %";
            f.lbconnguoi.Text = "Tỉ lệ có trong con người: --*-- %";
            f.lbvutru.Text = "Tỉ lệ có trong vũ trụ: --*-- %";
        }

        private void btnfm_Click(object sender, EventArgs e)
        {
            Thong_Tin_Nguyen_To f = new Thong_Tin_Nguyen_To();
            f.Show();
            f.pictureBox1.Image = new Bitmap(Application.StartupPath + "\\Image Of Visual Periodic Table\\Khong_co_anh_VPTN.png");
            f.lbkihieu.Text = "Fm";
            f.lbtennguyento.Text = "Fecmi";
            f.lbmol.Text = "257.0951 (g/mol)";
            f.lbloai.Text = "NHÓM ACTINI-PHÓNG XẠ";
            f.lbtenlatin.Text = "Tên Latin: Fecmium";
            f.lbtenanh.Text = "Tên tiếng Anh: Fecmium";
            f.lbnam.Text = "Năm khám phá: 1952";
            f.lbnguoi.Text = "Người khám phá: G.T Seaborg";
            f.lbvo.Text = "Vỏ điện tử: K2 L8 M18 N32 O30 P8 Q2";
            f.lbcas.Text = "CAS số: CAS7440-72-4";
            f.lbsongtu.Text = "Số nguyên tử: 100";
            f.lbnguyentukhoi.Text = "Nguyên tử khối; 257.0951 (g/mol)";
            f.lbmatdo.Text = "Mật độ: --*-- (g/cm3)";
            f.lbnongchay.Text = "Điểm nóng chảy: 1525 'C";
            f.lbsoi.Text = "Điểm sôi: -*-- 'C";
            f.lbcauhinh.Text = "Cấu hình điện tử: [Rn]7s2 5f12 6d1 1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 5s2 4d10 5p6 6s2 4f14 5d10 6p6 7s2 5f12";
            f.lbhoatri.Text = "Hóa trị: +2, +3";
            f.lbtiemnang.Text = "Tiềm năng Ion hóa của nguyên tử: --*--";
            f.lbbankinh.Text = "Bán kính nguyên tử: 290 pm";
            f.lblienket.Text = "Liên kết cộng hóa trị bán kính: --*-- pm";
            f.lbbankinhvan.Text = "Bán kính Van der Waals: --*-- pm";
            f.lbamdien.Text = "Âm điện: 1.3";
            f.lbhoatriphanung.Text = "Hóa trị: --*--";
            f.lbelectron.Text = "Electron mối quan hệ: --*-- kJ/mole";
            f.lbdientro.Text = "Điện trở: --*--";
            f.lbvotraidat.Text = " Tỉ lệ có trong vỏ Trái Đất: --*-- %";
            f.lbconnguoi.Text = "Tỉ lệ có trong con người: --*-- %";
            f.lbvutru.Text = "Tỉ lệ có trong vũ trụ: --*-- %";
        }

        private void btnmd_Click(object sender, EventArgs e)
        {
            Thong_Tin_Nguyen_To f = new Thong_Tin_Nguyen_To();
            f.Show();
            f.pictureBox1.Image = new Bitmap(Application.StartupPath + "\\Image Of Visual Periodic Table\\mendelevium.png");
            f.lbkihieu.Text = "Md";
            f.lbtennguyento.Text = "Menđelevi";
            f.lbmol.Text = "258.0951 (g/mol)";
            f.lbloai.Text = "NHÓM ACTINI-PHÓNG XẠ";
            f.lbtenlatin.Text = "Tên Latin: Mendelevium";
            f.lbtenanh.Text = "Tên tiếng Anh: Mendelevium";
            f.lbnam.Text = "Năm khám phá: 1955";
            f.lbnguoi.Text = "Người khám phá: G.T Seaborg";
            f.lbvo.Text = "Vỏ điện tử: K2 L8 M18 N32 O31 P8 Q2";
            f.lbcas.Text = "CAS số: CAS7440-11-1";
            f.lbsongtu.Text = "Số nguyên tử: 101";
            f.lbnguyentukhoi.Text = "Nguyên tử khối; 258.0951 (g/mol)";
            f.lbmatdo.Text = "Mật độ: --*-- (g/cm3)";
            f.lbnongchay.Text = "Điểm nóng chảy: 825 'C";
            f.lbsoi.Text = "Điểm sôi: -*-- 'C";
            f.lbcauhinh.Text = "Cấu hình điện tử: [Rn]7s2 5f13 6d1 1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 5s2 4d10 5p6 6s2 4f14 5d10 6p6 7s2 5f13";
            f.lbhoatri.Text = "Hóa trị: +2, +3";
            f.lbtiemnang.Text = "Tiềm năng Ion hóa của nguyên tử: --*--";
            f.lbbankinh.Text = "Bán kính nguyên tử: 287 pm";
            f.lblienket.Text = "Liên kết cộng hóa trị bán kính: --*-- pm";
            f.lbbankinhvan.Text = "Bán kính Van der Waals: --*-- pm";
            f.lbamdien.Text = "Âm điện: 1.3";
            f.lbhoatriphanung.Text = "Hóa trị: --*--";
            f.lbelectron.Text = "Electron mối quan hệ: --*-- kJ/mole";
            f.lbdientro.Text = "Điện trở: --*--";
            f.lbvotraidat.Text = " Tỉ lệ có trong vỏ Trái Đất: --*-- %";
            f.lbconnguoi.Text = "Tỉ lệ có trong con người: --*-- %";
            f.lbvutru.Text = "Tỉ lệ có trong vũ trụ: --*-- %";
        }

        private void btnno_Click(object sender, EventArgs e)
        {
            Thong_Tin_Nguyen_To f = new Thong_Tin_Nguyen_To();
            f.Show();
            f.pictureBox1.Image = new Bitmap(Application.StartupPath + "\\Image Of Visual Periodic Table\\nobelium.png");
            f.lbkihieu.Text = "No";
            f.lbtennguyento.Text = "Nobeli";
            f.lbmol.Text = "259.1009 (g/mol)";
            f.lbloai.Text = "NHÓM ACTINI-PHÓNG XẠ";
            f.lbtenlatin.Text = "Tên Latin: Nobelium";
            f.lbtenanh.Text = "Tên tiếng Anh: Nobelium";
            f.lbnam.Text = "Năm khám phá: 1958";
            f.lbnguoi.Text = "Người khám phá: G.T Seaborg";
            f.lbvo.Text = "Vỏ điện tử: K2 L8 M18 N32 O32 P8 Q2";
            f.lbcas.Text = "CAS số: CAS10028-14-5";
            f.lbsongtu.Text = "Số nguyên tử: 102";
            f.lbnguyentukhoi.Text = "Nguyên tử khối; 259.1009 (g/mol)";
            f.lbmatdo.Text = "Mật độ: --*-- (g/cm3)";
            f.lbnongchay.Text = "Điểm nóng chảy: 825 'C";
            f.lbsoi.Text = "Điểm sôi: -*-- 'C";
            f.lbcauhinh.Text = "Cấu hình điện tử: [Rn]7s2 5f14 6d1 1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 5s2 4d10 5p6 6s2 4f14 5d10 6p6 7s2 5f14";
            f.lbhoatri.Text = "Hóa trị: +2, +3";
            f.lbtiemnang.Text = "Tiềm năng Ion hóa của nguyên tử: --*--";
            f.lbbankinh.Text = "Bán kính nguyên tử: 285 pm";
            f.lblienket.Text = "Liên kết cộng hóa trị bán kính: --*-- pm";
            f.lbbankinhvan.Text = "Bán kính Van der Waals: --*-- pm";
            f.lbamdien.Text = "Âm điện: 1.3";
            f.lbhoatriphanung.Text = "Hóa trị: --*--";
            f.lbelectron.Text = "Electron mối quan hệ: --*-- kJ/mole";
            f.lbdientro.Text = "Điện trở: --*--";
            f.lbvotraidat.Text = " Tỉ lệ có trong vỏ Trái Đất: --*-- %";
            f.lbconnguoi.Text = "Tỉ lệ có trong con người: --*-- %";
            f.lbvutru.Text = "Tỉ lệ có trong vũ trụ: --*-- %";
        }

        private void btnlr_Click(object sender, EventArgs e)
        {
            Thong_Tin_Nguyen_To f = new Thong_Tin_Nguyen_To();
            f.Show();
            f.pictureBox1.Image = new Bitmap(Application.StartupPath + "\\Image Of Visual Periodic Table\\Khong_co_anh_VPTN.png");
            f.lbkihieu.Text = "Lr";
            f.lbtennguyento.Text = "Lorenxi";
            f.lbmol.Text = "266.1193 (g/mol)";
            f.lbloai.Text = "NHÓM ACTINI-PHÓNG XẠ";
            f.lbtenlatin.Text = "Tên Latin: Lorenxium";
            f.lbtenanh.Text = "Tên tiếng Anh: Lorenxium";
            f.lbnam.Text = "Năm khám phá: 1961";
            f.lbnguoi.Text = "Người khám phá: Albert Ghiorso";
            f.lbvo.Text = "Vỏ điện tử: K2 L8 M18 N32 O32 P8 Q3";
            f.lbcas.Text = "CAS số: CAS22537-19-5";
            f.lbsongtu.Text = "Số nguyên tử: 103";
            f.lbnguyentukhoi.Text = "Nguyên tử khối; 266.1193 (g/mol)";
            f.lbmatdo.Text = "Mật độ: --*-- (g/cm3)";
            f.lbnongchay.Text = "Điểm nóng chảy: 825 'C";
            f.lbsoi.Text = "Điểm sôi: -*-- 'C";
            f.lbcauhinh.Text = "Cấu hình điện tử: [Rn]7s2 5f14 6d1 1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 5s2 4d10 5p6 6s2 4f14 5d10 6p6 7s2 5f14 6d1";
            f.lbhoatri.Text = "Hóa trị: +3";
            f.lbtiemnang.Text = "Tiềm năng Ion hóa của nguyên tử: --*--";
            f.lbbankinh.Text = "Bán kính nguyên tử: 282 pm";
            f.lblienket.Text = "Liên kết cộng hóa trị bán kính: --*-- pm";
            f.lbbankinhvan.Text = "Bán kính Van der Waals: --*-- pm";
            f.lbamdien.Text = "Âm điện: --*--";
            f.lbhoatriphanung.Text = "Hóa trị: --*--";
            f.lbelectron.Text = "Electron mối quan hệ: --*-- kJ/mole";
            f.lbdientro.Text = "Điện trở: --*--";
            f.lbvotraidat.Text = " Tỉ lệ có trong vỏ Trái Đất: --*-- %";
            f.lbconnguoi.Text = "Tỉ lệ có trong con người: --*-- %";
            f.lbvutru.Text = "Tỉ lệ có trong vũ trụ: --*-- %";
        }

        private void biểuĐồToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ti_Le_Cac_Nguyen_To f = new Ti_Le_Cac_Nguyen_To();
            f.Show();
        }

        private void btactini_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nhóm Actini gồm các nguyên tố từ 89 - 103, và có màu xanh trên màn hình nền!", "Nhóm Actini"); 
        }

        private void chuyểnĐổiCácĐơnVịToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Chuyen_Doi f = new Chuyen_Doi();
            f.ShowDialog();
        }

        private void tínhNồngĐộMolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tinh_Mol f = new Tinh_Mol();
            f.ShowDialog();
        }

        private void phảnHồnhậnXétToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://cungnhauhoctot.wordpress.com/2018/10/09/phan-hoi-phan-mem-visual-periodic-table/#respond");
        }

        private void ngônNgữToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bằngVănBảngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Trang wed hướng dẫn sẽ bắt bạn nhập mật khẩu. Bạn hãy nhập: \nvisualperiodictablequocthinhvo", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Process.Start("https://cungnhauhoctot.wordpress.com/2018/10/09/huong-dan-su-dung-phan-mem-visual-periodic-table/");
        }

        private void cânBằngPhươngTrìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Can_Bang_Phuong_Trinhcs f = new Can_Bang_Phuong_Trinhcs();
            f.ShowDialog();
        }

        private void từĐiểnHóaHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tu_Dien f = new Tu_Dien();
            //f.BackColor = Color.Red;
            f.ShowDialog();
        }

        private void bằngVideoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Video_Huong_Dan v = new Video_Huong_Dan();
            v.ShowDialog();
        }

        private void fchinh_Load(object sender, EventArgs e)
        {
           
        }

        private void tsmbangtan_Click(object sender, EventArgs e)
        {
            Bang_Tinh_Tan f = new Bang_Tinh_Tan();
            f.ShowDialog();
        }

        private void tsmcanbang_Click(object sender, EventArgs e)
        {
            Can_Bang_Phuong_Trinhcs f = new Can_Bang_Phuong_Trinhcs();
            f.ShowDialog();
        }

        private void từĐiểnHóaHọcToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Tu_Dien f = new Tu_Dien();
            f.ShowDialog();
        }

        private void giúpĐỡToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Video_Huong_Dan f = new Video_Huong_Dan();
            f.ShowDialog();
        }

        private void khámPháCàMuaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kham_Pha_Ca_Mau f = new Kham_Pha_Ca_Mau();
            f.Show();
        }

        private void fchinh_Click(object sender, EventArgs e)
        {
            //Process.Start("chrome.exe");
        }
    }
}
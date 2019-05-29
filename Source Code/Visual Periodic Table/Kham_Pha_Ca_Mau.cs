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
    public partial class Kham_Pha_Ca_Mau : Form
    {
        
        public Kham_Pha_Ca_Mau()
        {
            InitializeComponent();
        }

        private void Kham_Pha_Ca_Mau_Load(object sender, EventArgs e)
        {
            //timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string chon = comboBox1.SelectedItem.ToString();
            if (chon == "Hòn Đá Bạc")
            {
                lbtieude.Text = "Hòn Đá Bạc";
                lbthongtinchitiet.Text = "Đây là một cụm hòn lớn, nhỏ nằm liền kề nhau, với diện tích khoảng 6,43 ha, bao gồm: Hòn Ông Ngộ, Hòn Đá Lẻ và Hòn Đá Bạc.\nHòn cao nhất chỉ cao khoảng 50 m so với mực nước biển. Theo nhiều tài liệu ghi lại, Hòn Đá Bạc có niên đại khoảng 180 triệu năm (thuộc kỷ Jura giữa - Trung sinh).[1]\nĐến viếng cụm hòn này, du khách có thể nhìn thấy vô số những viên đá granit (đá hoa cương) xếp chồng lên nhau, với những hình thù hết sức độc đáo\nHòn có các mảng rừng và thảm thực vật nguyên sinh\nNgoài ra, nơi đây còn có Đền thờ Chủ tịch Hồ Chí Minh và Lăng Ông Nam Hải.\nTrong lăng Ông, có trưng bày và thờ bộ xương cá Ông dài khoảng 13 m.\nTheo tài liệu, cá Ông vì cứu một chiếc ghe bị chìm nên đã lấy thân mình đưa chiếc ghe dạt vào Kinh Chùa ngày 20 tháng 5 năm 1995.\nĐược khoảng 3 ngày sau, cá voi lụy (chết), người dân đã đem chôn, đến năm 1996 thì đưa bộ xương về Hòn Đá Bạc để thờ. Hằng năm, lễ Nghinh Ông được tổ chức long trọng vào ngày 23 tháng 5 âm lịch.[2]\nVào năm 1981, đây còn là địa điểm diễn ra Kế hoạch phản gián CM-12 (kéo dài từ tháng 9 năm 1981 đến 9 tháng 9 năm 1984), đã đánh bại âm mưu lật đổ chính quyền Việt Nam đương thời do Lê Quốc Túy và Mai Văn Hạnh đứng đầu.\nNgày 22 tháng 6 năm 2009, Bộ Văn hóa, Thể thao và Du lịch đã ban hành Quyết định số 2245/QĐ-BVHTTDL công nhận di tích Hòn Đá Bạc - Trung tâm chỉ huy kế hoạch phản gián CM12 là Di tích lịch sử Quốc gia.\nHiện nay, Bộ Công an và Chính quyền tỉnh Cà Mau đã xây dựng Tượng đài và nhà trưng bày chiến thắng Kế hoạch phản gián CM12.[3]\nThêm vào đó, Hòn Đá Bạc còn lôi cuốn du khách bởi thú đi câu mực, câu tôm...và các món ăn được chế biến từ nguồn hải sản dồi dào...[1]\n";
                pictureBox1.Image = new Bitmap(Application.StartupPath + "//Kham_Pha_Ca_Mau//hon.jpg");
                pictureBox2.Image = new Bitmap(Application.StartupPath + "//Kham_Pha_Ca_Mau//hon_da.jpg");
                pictureBox3.Image = new Bitmap(Application.StartupPath + "//Kham_Pha_Ca_Mau//Hon_Da_Bac.jpg");
                pictureBox4.Image = new Bitmap(Application.StartupPath + "//Kham_Pha_Ca_Mau//hon_da_bac_tren_cao.jpg");

            }
            if (chon == "Hòn Khoai")
            {
                lbtieude.Text = "Hòn Khoai";
                lbthongtinchitiet.Text = "Quần đảo Hòn Khoai (tên cũ: Giáng Hương, Ile Independence, Paulo Obi) là tên một cụm đảo thuộc tỉnh Cà Mau.\nĐảo chính Hòn Khoai cách đất liền 14,6 km; nằm về phía nam xã Đất Mũi, thuộc huyện Ngọc Hiển.\nQuần đảo gồm 5 đảo sát nhau:\nHòn Khoai\nHòn Sao\nHòn Đồi Mồi\nHòn Đá Lẻ\nHòn Tương\nTổng diện tích 4 km2.\nĐảo cao nhất có độ cao 318 m. Hòn Khoai là đảo đá, đồi và rừng nguyên sinh còn gần như nguyên vẹn với nhiều loại gỗ quý, nhiều nhất là gỗ sao và một quần thể động thực vật phong phú, phong cảnh thiên nhiên hoang dã lôi cuốn du khách.\nTừ Cà Mau du khách đi đến làng đánh cá Trần Đế (làng cực Nam của tổ quốc trên đất liền) và đổi thuyền đi tiếp ra đảo Hòn Khoai.\nTrên đảo có một tháp hải đăng. Cư dân sinh sống chủ yếu bằng nghề đánh cá.\nHiện đang có dự án du lịch sinh thái đảo Hòn Khoai, rộng 700 ha (7 km2) do nước ngoài tài trợ.\n";
                pictureBox1.Image = new Bitmap(Application.StartupPath + "//Kham_Pha_Ca_Mau//dao_hon_khao.jpg");
                pictureBox2.Image = new Bitmap(Application.StartupPath + "//Kham_Pha_Ca_Mau//danh_thang_hon.jpg");
                pictureBox3.Image = new Bitmap(Application.StartupPath + "//Kham_Pha_Ca_Mau//khaoi.jpg");
                pictureBox4.Image = new Bitmap(Application.StartupPath + "//Kham_Pha_Ca_Mau//dao.jpg");
            }
            if (chon == "Vườn Quốc Gia U Minh Hạ")
            {
                lbtieude.Text = "Vườn Quốc Gia U Minh Hạ";
                lbthongtinchitiet.Text = "Vườn quốc gia U Minh Hạ thuộc tỉnh Cà Mau. Địa giới hành chính nằm trên hai huyện U Minh và Trần Văn Thời\nĐược thành lập theo quyết định số 112/QĐ-TTg ngày 20 tháng 1 năm 2006 của Thủ tướng chính phủ Cộng hòa Xã hội Chủ nghĩa Việt Nam\ntrên cơ sở nâng cấp khu bảo tồn thiên nhiên Vồ Dơi. Đây là khu vực có hệ động thực vật đặc trưng vùng đất ngập nước trên lớp than bùn \nTọa độ: Từ 9°12′30″ tới 9°17′41″ vĩ bắc và 104°54′11″ tới 104°59′16″ kinh đông.\nVườn quốc gia U Minh Hạ có tổng diện tích 8.286ha nằm trên địa bàn các xã Khánh Lâm, Khánh An thuộc huyện U Minh và các xã Trần Hợi, Khánh Bình Tây Bắc thuộc huyện Trần Văn Thời.\n Bắc giáp tuyến 27 - Phân trại K3 thuộc trại giam K1 Cái Tàu\nNam giáp vùng đệm kinh xáng Minh Hà;\nĐông giáp kinh 100, ấp 14 xã Khánh An và hậu T19 ấp Vồ Dơi;\nTây giáp kinh 90, phân trường Trần Văn Thời và đê bao phía tây Vồ Dơi.\n";
                pictureBox1.Image = new Bitmap(Application.StartupPath + "//Kham_Pha_Ca_Mau//272px-Chuối_tại_rừng_U_Minh_hạ.jpg");
                pictureBox2.Image = new Bitmap(Application.StartupPath + "//Kham_Pha_Ca_Mau//quocgaiuminh.jpg");
                pictureBox3.Image = new Bitmap(Application.StartupPath + "//Kham_Pha_Ca_Mau//quocgaiuminha.jpg");
                //pictureBox4.Image = new Bitmap 
                pictureBox2.Image = new Bitmap(Application.StartupPath + "//Kham_Pha_Ca_Mau//quocgaiuminh.jpg");
            }
            if (chon == "Đầm Thị Tường")
            {
                lbtieude.Text = "Đầm Thị Tường";
                lbthongtinchitiet.Text = "Đầm Thị Tường (hay đầm Bà Tường) là đầm nước tự nhiên có diện tích lớn nhất vùng Đồng bằng sông Cửu Long, Việt Nam, được mệnh danh là biển Hồ giữa đồng bằng\nđầm Thị Tường tạo nên từ phù sa bồi lắng của sông Mỹ Bình, sông Ông Đốc và nhiều kênh rạch của ba huyện Phú Tân, Trần Văn Thời và Cái Nước\nĐầm toạ lạc ngay giữa hai huyện Phú Tân và Trần Văn Thời, thuộc tỉnh Cà Mau. Đầm được hình thành bởi 3 đầm chính là Đầm Trên, Đầm Giữa và Đầm Dưới, \nĐầm Thị Tường cách TP Cà Mau khoảng 40 km, cách QL 1A 7 km.\nĐầm Thị Tường là nơi sinh sống của các loại thủy sản nước lợ như tôm sú, cua. Cư dân sinh sống quanh đầm chủ yếu bằng nguồn lợi thủy hải sản khai thác được từ đầm này.\nĐầm Thị Tường được mô tả giống như một bức tranh thuỷ mạt thơ mông và hữu tình, nhất là vào mỗi buổi sáng và chiều tà.\nMặt nước đầm được dùng để nuôi thuỷ sản. \nPhía Nam của đầm, thuộc xã Phú Mỹ, huyện Phú Tân là căn cứ Xẻo Đước, là một di tích lịch sử thời Chiến tranh Đông Dương lần thứ 2, là một căn cứ quan trọng của Việt cộng.\n";
                pictureBox1.Image = new Bitmap(Application.StartupPath + "//Kham_Pha_Ca_Mau//ve_dep_dam_thi_tuong.jpg");
                pictureBox2.Image = new Bitmap(Application.StartupPath + "//Kham_Pha_Ca_Mau//dam_thi_tuong.jpg");
                pictureBox3.Image = new Bitmap(Application.StartupPath + "//Kham_Pha_Ca_Mau//dam.jpg");
                pictureBox4.Image = new Bitmap(Application.StartupPath + "//Kham_Pha_Ca_Mau//dam_thi.jpg");
            }
            if (chon == "")
            {

            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLKTX.SV;
using QLKTX.Phong;
using QLKTX.Khu;
using QLKTX.Diennuoc;
using System.Data.OleDb;

///Thêm thư viện 

namespace QLKTX
{

    public partial class Trangchu : Form
    {
        
       
        BLL SVBLL = new BLL();
        PBLL PhBLL=new PBLL();
        DiennuocBLL DNBLL = new DiennuocBLL();
        public Trangchu()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void mãKTXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            h1.Hide(); ///Lệnh hide dùng để tắt 1 bảng nào đó mà ta không muốn cho nó hiển thị 
        }

        private void danhSáchPhòngHiệnCóToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            groupBox1.Hide(); ///Tắt groupBox1 trên thanh menu
            groupBox3.Hide(); ///Tắt groupBox3 trên thanh menu
            groupBox4.Hide(); ///Tắt groupBox4 trên thanh menu
            dataGridView1.Show(); ///Bật dataGridView1 trên thanh menu 
            dataGridView1.DataSource = PhBLL.phong(); ///Lấy bảng phòng hiển thị lên thanh menu 
            dataGridView1.Columns[0].HeaderText = "Mã phòng";///Cột 1 trong bảng
            dataGridView1.Columns[1].HeaderText = "Mã khu";///Cột 2 trong bảng
            dataGridView1.Columns[2].HeaderText = "Tên phòng";///Cột 3 trong bảng
            dataGridView1.Columns[3].HeaderText = "Loại phòng";///Cột 4 trong bảng
            dataGridView1.Columns[4].HeaderText = "Số người hiện tại";///Cột 5 trong bảng
            dataGridView1.Columns[5].HeaderText = "Số người tối đa";///Cột 6 trong bảng
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Trangchu_Load(object sender, EventArgs e)
        {
            bangthongke.Hide();///Tắt bảng thống kê tạ giao diện màn hình chính
            bang1tk.Hide();///Tắt bảng 1 thống kê
            bang2tk.Hide();///Tắt bảng 2 thống kê
            bangdiennuoc.Hide();///Tắt bảng điện nước 
            bang1sv.Hide();///Tắt bảng 1 thông tin sinh viên 
            bang2sv.Hide();///Tắt bảng 2 thông tin sinh viên 
            bang3sv.Hide();///Tắt bảng 3 thông tin sinh viên 
            groupBox4.Hide();
            groupBox1.Hide();
            groupBox3.Hide();
            h1.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void tổngSVTrongKTXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            h1.Hide();
            
        }

        private void tổngSốPhòngHiệnCóToolStripMenuItem_Click(object sender, EventArgs e)
        {
            h1.Hide();
           
        }

        private void mãSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            h1.Hide();
        }

        private void hồSơSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Show();
            dataGridView1.DataSource = SVBLL.GetList();
            dataGridView1.Columns[0].HeaderText = "Mã SV";
            dataGridView1.Columns[1].HeaderText = "Mã KTX";
            dataGridView1.Columns[2].HeaderText = "Họ";
            dataGridView1.Columns[3].HeaderText = "Tên";
            dataGridView1.Columns[4].HeaderText = "Số CMND";
            dataGridView1.Columns[5].HeaderText = "Giới tính";
            dataGridView1.Columns[6].HeaderText = "Ngày sinh";
            dataGridView1.Columns[7].HeaderText = "Số ĐT";
            dataGridView1.Columns[8].HeaderText = "Quê quán ";
            dataGridView1.Columns[9].HeaderText = "Ngày hợp đồng";
            dataGridView1.Columns[10].HeaderText = "Mã Phòng";
            dataGridView1.Columns[11].HeaderText = "Hình ảnh ";
            dataGridView1.Columns[12].HeaderText = "Họ & tên người giám hộ ";
            dataGridView1.Columns[13].HeaderText = "Số đt giám hộ ";
            dataGridView1.Columns[14].HeaderText = "Mối quan hệ ";
            dataGridView1.Columns[15].HeaderText = "Nghề nghiệp  ";

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void giớiThiệuVềKTXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bangthongke.Hide();
            bangdiennuoc.Hide();
            bang1tk.Hide();
            bang2tk.Hide(); 
            groupBox4.Hide();
            groupBox3.Hide();
            groupBox1.Hide();
            h1.Show();
            bang1sv.Hide();
            bang2sv.Hide();
            bang3sv.Hide();
            
        }

        private void tìmKiếmToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SVBLL.THONGKESV();
            bangthongke.Show();
            bangdiennuoc.Hide();
            bang1tk.Hide();
            bang2tk.Hide(); 
            h1.Hide();
            bang1sv.Hide();
            bang2sv.Hide();
            bang3sv.Hide();
            groupBox4.Hide();
            groupBox3.Hide();
            groupBox1.Hide();
           
        }

        private void tổngSốKhuKTXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            h1.Hide();
            bang1sv.Hide();
        }

        private void tìmKiếmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bangthongke.Hide(); 
            bangdiennuoc.Hide();
            h1.Hide();
            bang1sv.Hide();
            groupBox4.Hide();
            groupBox3.Hide();
            groupBox1.Hide();
            bang1sv.Hide();
            bang2sv.Hide();
            bang3sv.Hide();
         
            bang1tk.Show();
            bang2tk.Show();
        }

        private void hóaĐơnĐiệnNướcĐiệnNướcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bangthongke.Hide(); 
            h1.Hide();
            bangdiennuoc.Hide();
            groupBox4.Hide();
            groupBox3.Hide();
            groupBox1.Hide();
            bang1sv.Hide();
            bang2sv.Hide();
            bang3sv.Hide();
         
            bang1tk.Hide();
            bang2tk.Hide();
          
        }

        private void tiềnĐiệnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bangdiennuoc.Show();
            h1.Hide();
            bang1sv.Hide();
            bang1sv.Hide();
            bang2sv.Hide();
            bang3sv.Hide();
     
        }

        private void tiềnNướcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            h1.Hide();
        }

        private void quảnLýSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bangthongke.Hide(); 
            bangdiennuoc.Hide();
            bang1tk.Hide();
            bang2tk.Hide();
            h1.Hide();
            groupBox4.Hide();
            groupBox3.Hide();
            groupBox1.Hide(); dataGridView1.Hide();
           
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            bangthongke.Hide(); 
            bangdiennuoc.Hide();
            bang1tk.Hide();
            bang2tk.Hide(); 
            h1.Hide();
            dataGridView1.Hide();
            groupBox1.Hide();
            groupBox3.Hide();
            groupBox4.Hide();
            bang1sv.Hide();
            bang2sv.Hide();
            bang3sv.Hide();
           
        }

        private void thêmSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            bang2sv.Show();
            bang1sv.Show();
            bang3sv.Show();
        }

        private void thêmPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bang1tk.Hide();
            bang2tk.Hide();
           
            dataGridView2.Show();
            groupBox1.Show();
            groupBox3.Show();
            groupBox4.Show();
            bang1sv.Hide();
            bang2sv.Hide();
            bang3sv.Hide();
        }

      
        private void btnthem_Click(object sender, EventArgs e)
        {
            try
            {
                string MP;
                MP = txtmaphong.Text;
                string MK;
                MK = txtmakhu.Text;
                string TP;
                TP = txttenphong.Text;
                int SNHC;
                SNHC = int.Parse(txtsonguoihientai.Text);
                int SNTD;
                SNTD = int.Parse(txtsonguoitoida.Text);
                bool LP;
                //neu check thi gan = true, ngc lai = false
                if (Pnam.Checked == true)
                {
                    LP = true;
                }
                else
                {
                    LP = false;
                }
                PhBLL.themph(MP, MK, TP, LP, SNHC, SNTD);
                MessageBox.Show("Đã thêm thành công");
            }
            catch
            {
                MessageBox.Show("Lỗi hệ thống khi thêm");
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {
            
        }

        private void Pnam_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void btnhienthi_Click(object sender, EventArgs e)
        {
            dataGridView2.Show();

            PhBLL.phong();
            dataGridView2.DataSource = PhBLL.phong();
            dataGridView2.Columns[0].HeaderText = "Mã phòng";
            dataGridView2.Columns[1].HeaderText = "Mã khu";
            dataGridView2.Columns[2].HeaderText = "Tên phòng";
            dataGridView2.Columns[3].HeaderText = "Loại phòng";
            dataGridView2.Columns[4].HeaderText = "Số người hiện tại";
            dataGridView2.Columns[5].HeaderText = "Số người tối đa";
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                string mp;
                mp = txtmaphong.Text;
                PhBLL.xoaph(mp);
                MessageBox.Show("Đã xóa thành công");
            }
            catch
            {
                MessageBox.Show("Lỗi hệ thống khi xóa");
            }
              
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string Mp;
            Mp = txtmaphong.Text;
            string Mk;
            Mk = txtmakhu.Text;
            string Tp;
            Tp = txttenphong.Text;
            int Snht;
            Snht = int.Parse(txtsonguoihientai.Text);
            int Sntd;
            Sntd = int.Parse(txtsonguoitoida.Text);
            bool Lp;
            {//neu check thi gan = true, ngc lai = false
                if (Pnam.Checked == true)
                {
                    Lp = true;
                }
                else
                {
                    Lp = false;
                }
            }
            PhBLL.suaph(Mp, Mk, Tp, Lp, Snht, Sntd);

        }

        private void txttenphong_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox8_Enter(object sender, EventArgs e)
        {

        }

        private void txtmasvsv_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnthemsv_Click(object sender, EventArgs e)
        {
           
        }

        private void btnxoasv_Click(object sender, EventArgs e)
        {
           
        }

        private void btnsuasv_Click(object sender, EventArgs e)
        {
           
        
    
        }

        private void btnhienthisv_Click(object sender, EventArgs e)
        {

        }

        private void gioitinhsv_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnluudn_Click(object sender, EventArgs e)
        {
           
        }

        private void btnlammoidn_Click(object sender, EventArgs e)
        {
           

        }

        private void btnxoadn_Click(object sender, EventArgs e)
        {
            
        }

        private void btnsuadn_Click(object sender, EventArgs e)
        {
           
        }

        private void hienthidn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void btnhienthidn_Click(object sender, EventArgs e)
        {

        }

        private void btnthemsv_Click_1(object sender, EventArgs e)
        {
            string MSV;
            MSV = txtmasvsv.Text;
            string MKTX;
            MKTX = txtmaktxsv.Text;
            string H;
            H = txthosv.Text;
            string T;
            T = txttensv.Text;
            string CMND;
            CMND = txtcmndsv.Text;
            DateTime NS;
            NS = DateTime.Parse(txtngaysinhsv.Text);
            string SDT;
            SDT = txtsdtsv.Text;
            string QQ;
            QQ = txtquequansv.Text;
            DateTime NLHD;
            NLHD = DateTime.Parse(dateTimePicker1.Text);
            string Mphong;
            Mphong = txtmpsv.Text;
            string Hinh;
            Hinh = txthinh.Text;
            string HTGH;
            HTGH = txttenghsv.Text;
            string SDTGH;
            SDTGH = txtsdtghsv.Text;
            string QH;
            QH = txtmoiquanhesv.Text;
            string NN;
            NN = txtnghenghiepsv.Text;
            bool GT;
            {
                if (gtsv.Checked == true)
                {
                    GT = true;
                }
                else
                {
                    GT = false;
                }
            }


            SVBLL.themsinhvien(MSV, MKTX, H, T, CMND, GT, NS, SDT, QQ, NLHD, Mphong, Hinh, HTGH, SDTGH, QH, NN);
        }

        private void btnxoasv_Click_1(object sender, EventArgs e)
        {
            string MSV;
            MSV = txtmasvsv.Text;
            SVBLL.xoasinhvien(MSV);

        }

        private void btnsuasv_Click_1(object sender, EventArgs e)
        {

        }

        private void btnhienthisv_Click_1(object sender, EventArgs e)
        {

           
        }

        private void btnhienthisv_Click_2(object sender, EventArgs e)
        {
            dataGridView3.DataSource = SVBLL.GetList();
            dataGridView3.Columns[0].HeaderText = "Mã SV";
            dataGridView3.Columns[1].HeaderText = "Mã KTX";
            dataGridView3.Columns[2].HeaderText = "Họ";
            dataGridView3.Columns[3].HeaderText = "Tên";
            dataGridView3.Columns[4].HeaderText = "Số CMND";
            dataGridView3.Columns[5].HeaderText = "Giới tính";
            dataGridView3.Columns[6].HeaderText = "Ngày sinh";
            dataGridView3.Columns[7].HeaderText = "Số ĐT";
            dataGridView3.Columns[8].HeaderText = "Quê quán ";
            dataGridView3.Columns[9].HeaderText = "Ngày hợp đồng";
            dataGridView3.Columns[10].HeaderText = "Mã Phòng";
            dataGridView3.Columns[11].HeaderText = "Hình ảnh ";
            dataGridView3.Columns[12].HeaderText = "Họ & tên người giám hộ ";
            dataGridView3.Columns[13].HeaderText = "Số đt giám hộ ";
            dataGridView3.Columns[14].HeaderText = "Mối quan hệ ";
            dataGridView3.Columns[15].HeaderText = "Nghề nghiệp  ";
            SVBLL.GetList();
        }

        private void btnsuasv_Click_2(object sender, EventArgs e)
        {
            string MSV;
            MSV = txtmasvsv.Text;
            string MKTX;
            MKTX = txtmaktxsv.Text;
            string H;
            H = txthosv.Text;
            string T;
            T = txttensv.Text;
            string CMND;
            CMND = txtcmndsv.Text;
            DateTime NS;
            NS = DateTime.Parse(txtngaysinhsv.Text);
            string SDT;
            SDT = txtsdtsv.Text;
            string QQ;
            QQ = txtquequansv.Text;
            DateTime NLHD;
            NLHD = DateTime.Parse(dateTimePicker1.Text);
            string Mphong;
            Mphong = txtmpsv.Text;
            string Hinh;
            Hinh = txthinh.Text;
            string HTGH;
            HTGH = txttenghsv.Text;
            string SDTGH;
            SDTGH = txtsdtghsv.Text;
            string QH;
            QH = txtmoiquanhesv.Text;
            string NN;
            NN = txtnghenghiepsv.Text;
            bool GT;
            {
                if (gtsv.Checked == true)
                {
                    GT = true;
                }
                else
                {
                    GT = false;
                }
            }


            SVBLL.suasinhvien(MSV, MKTX, H, T, CMND, GT, NS, SDT, QQ, NLHD, Mphong, Hinh, HTGH, SDTGH, QH, NN);
        }

        private void btnhthimsvtk_Click(object sender, EventArgs e)
        {
            hienthimsvtk.DataSource = SVBLL.GetList();
            hienthimsvtk.Columns[0].HeaderText = "Mã SV";
            hienthimsvtk.Columns[1].HeaderText = "Mã KTX";
            hienthimsvtk.Columns[2].HeaderText = "Họ";
            hienthimsvtk.Columns[3].HeaderText = "Tên";
            hienthimsvtk.Columns[4].HeaderText = "Số CMND";
            hienthimsvtk.Columns[5].HeaderText = "Giới tính";
            hienthimsvtk.Columns[6].HeaderText = "Ngày sinh";
            hienthimsvtk.Columns[7].HeaderText = "Số ĐT";
            hienthimsvtk.Columns[8].HeaderText = "Quê quán ";
            hienthimsvtk.Columns[9].HeaderText = "Ngày hợp đồng";
            hienthimsvtk.Columns[10].HeaderText = "Mã Phòng";
            hienthimsvtk.Columns[11].HeaderText = "Hình ảnh ";
            hienthimsvtk.Columns[12].HeaderText = "Họ & tên người giám hộ ";
            hienthimsvtk.Columns[13].HeaderText = "Số đt giám hộ ";
            hienthimsvtk.Columns[14].HeaderText = "Mối quan hệ ";
            hienthimsvtk.Columns[15].HeaderText = "Nghề nghiệp  ";
            SVBLL.GetList();
        }
        
        private void btnsvtk_Click(object sender, EventArgs e)
        {
            string MSVTK;
            MSVTK = txtmsvtk.Text;
            hienthimsvtk.DataSource = SVBLL.TIMsv(MSVTK);
            hienthimsvtk.Columns[0].HeaderText = "Mã SV";
            hienthimsvtk.Columns[1].HeaderText = "Mã KTX";
            hienthimsvtk.Columns[2].HeaderText = "Họ";
            hienthimsvtk.Columns[3].HeaderText = "Tên";
            hienthimsvtk.Columns[4].HeaderText = "Số CMND";
            hienthimsvtk.Columns[5].HeaderText = "Giới tính";
            hienthimsvtk.Columns[6].HeaderText = "Ngày sinh";
            hienthimsvtk.Columns[7].HeaderText = "Số ĐT";
            hienthimsvtk.Columns[8].HeaderText = "Quê quán ";
            hienthimsvtk.Columns[9].HeaderText = "Ngày hợp đồng";
            hienthimsvtk.Columns[10].HeaderText = "Mã Phòng";
            hienthimsvtk.Columns[11].HeaderText = "Hình ảnh ";
            hienthimsvtk.Columns[12].HeaderText = "Họ & tên người giám hộ ";
            hienthimsvtk.Columns[13].HeaderText = "Số đt giám hộ ";
            hienthimsvtk.Columns[14].HeaderText = "Mối quan hệ ";
            hienthimsvtk.Columns[15].HeaderText = "Nghề nghiệp  ";
            SVBLL.TIMsv(MSVTK);
           
            
        }

        private void txtmsvtk_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnxoasvtk_Click(object sender, EventArgs e)
        {
            txtmsvtk.Clear();
            
        }

        private void btnxoamptk_Click(object sender, EventArgs e)
        {
            txtmptk.Clear();
        }

        private void btnmptk_Click(object sender, EventArgs e)
        {
            string MPTK;
            MPTK = txtmptk.Text;
            hitnthimaphongtk.DataSource = PhBLL.TKPHONG(MPTK);
            hitnthimaphongtk.Columns[0].HeaderText = "Mã phòng";
            hitnthimaphongtk.Columns[1].HeaderText = "Mã khu";
            hitnthimaphongtk.Columns[2].HeaderText = "Tên phòng";
            hitnthimaphongtk.Columns[3].HeaderText = "Loại phòng";
            hitnthimaphongtk.Columns[4].HeaderText = "Số người hiện tại";
            hitnthimaphongtk.Columns[5].HeaderText = "Số người tối đa";
            PhBLL.TKPHONG(MPTK);

        }

        private void btnhthimptk_Click(object sender, EventArgs e)
        {
            hitnthimaphongtk.DataSource = PhBLL.phong();
            hitnthimaphongtk.Columns[0].HeaderText = "Mã phòng";
            hitnthimaphongtk.Columns[1].HeaderText = "Mã khu";
            hitnthimaphongtk.Columns[2].HeaderText = "Tên phòng";
            hitnthimaphongtk.Columns[3].HeaderText = "Loại phòng";
            hitnthimaphongtk.Columns[4].HeaderText = "Số người hiện tại";
            hitnthimaphongtk.Columns[5].HeaderText = "Số người tối đa";
            PhBLL.phong();
        }

        private void btnlamlaidn_Click(object sender, EventArgs e)
        {
            txtdiencudn.Clear();
            txtdienmoidn.Clear();
            txtnuoccudn.Clear();
            txtnuocmoidn.Clear();
            txtmaphongdn.Clear();
        }

        private void btnluudn_Click_1(object sender, EventArgs e)
        {
            string MP;
            MP = txtmaphongdn.Text;
            DateTime TH;
            TH = DateTime.Parse(dateTimediennuoc.Text);
            int CSDC;
            CSDC = int.Parse(txtdiencudn.Text);
            int CSDM;
            CSDM = int.Parse(txtdienmoidn.Text);
            int CSNC;
            CSNC = int.Parse(txtnuoccudn.Text);
            int CSNM;
            CSNM = int.Parse(txtnuocmoidn.Text);
            DNBLL.luudn(MP, TH, CSDC, CSDM, CSNC, CSNM);
        }

        private void btnsuadn_Click_1(object sender, EventArgs e)
        {
            string MP;
            MP = txtmaphongdn.Text;
            DateTime TH;
            TH = DateTime.Parse(dateTimediennuoc.Text);
            int CSDC;
            CSDC = int.Parse(txtdiencudn.Text);
            int CSDM;
            CSDM = int.Parse(txtdienmoidn.Text);
            int CSNC;
            CSNC = int.Parse(txtnuoccudn.Text);
            int CSNM;
            CSNM = int.Parse(txtnuocmoidn.Text);
            DNBLL.suadn(MP, TH, CSDC, CSDM, CSNC, CSNM);
        }

        private void btnxoadn_Click_1(object sender, EventArgs e)
        {
            string MP;
            MP = txtmaphongdn.Text;
            DNBLL.xoadn(MP);
        }

        private void btnhienthidn_Click_1(object sender, EventArgs e)
        {
            dataGridViewdiennuoc.DataSource = DNBLL.GetlistDN();
            dataGridViewdiennuoc.Columns[0].HeaderText = "Mã phòng";
            dataGridViewdiennuoc.Columns[1].HeaderText = "Tháng";
            dataGridViewdiennuoc.Columns[2].HeaderText = "CS điện cũ";
            dataGridViewdiennuoc.Columns[3].HeaderText = "CS điện mới";
            dataGridViewdiennuoc.Columns[4].HeaderText = "CS nước cũ";
            dataGridViewdiennuoc.Columns[5].HeaderText = "CS nnước mới";
            DNBLL.GetlistDN();
        }

        private void txtthongkesinhvien_TextChanged(object sender, EventArgs e)
        {
            //txtthongkesinhvien.Text = ""+SVBLL.THONGKESV();
        }

        private void txtthongkephong_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        } 
    }
}

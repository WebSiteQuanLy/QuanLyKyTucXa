using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace QLKTX.SV
{
    public class BLL
    {
        DAL dal = new DAL();
        public DTO[] GetList()
        {
            return dal.GetSV();
        }

 	//Thêm mới 1 sinh viên
	//truyền dữ liệu từ lớp DAL lên BLL và ngược laji
        public void themsinhvien(string MSV, string MKTX, string H, string T, string CMND, bool GT, DateTime NS, string SDT, string QQ, DateTime NLHD, string Mphong, string Hinh, string HTGH, string SDTGH, string QH, string NN)
        {
            dal.themsv(MSV,MKTX,H,T,CMND,GT,NS,SDT,QQ,NLHD,Mphong,Hinh,HTGH,SDTGH,QH,NN);
        }

	//xóa sinh viên
        public void xoasinhvien(string MSV)
        {
            dal.xoasv(MSV);
        }

	//Sửa SV
        public void suasinhvien(string MSV, string MKTX, string H, string T, string CMND, bool GT, DateTime NS, string SDT, string QQ, DateTime NLHD, string Mphong, string Hinh, string HTGH, string SDTGH, string QH, string NN)
        {
            dal.suasv(MSV, MKTX, H, T, CMND, GT, NS, SDT, QQ, NLHD, Mphong, Hinh, HTGH, SDTGH, QH, NN);
        }
	//tìm kiếm SV
        public void timkiemSV(string MSVTK)
        {
            dal.timkiemsv(MSVTK);
        }
	
        public DTO[] TIMsv(string MSVTK)
        {
            return dal.TIMSV(MSVTK);
        }
	//Thống kê
        public void THONGKESV()
        {
             dal.thongkeSV();
        }

    }
}

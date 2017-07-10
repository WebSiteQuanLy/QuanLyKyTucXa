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

 //Thêm xóa sửa sinh viên
        public void themsinhvien(string MSV, string MKTX, string H, string T, string CMND, bool GT, DateTime NS, string SDT, string QQ, DateTime NLHD, string Mphong, string Hinh, string HTGH, string SDTGH, string QH, string NN)
        {
            dal.themsv(MSV,MKTX,H,T,CMND,GT,NS,SDT,QQ,NLHD,Mphong,Hinh,HTGH,SDTGH,QH,NN);
        }

        public void xoasinhvien(string MSV)
        {
            dal.xoasv(MSV);
        }

    }
}

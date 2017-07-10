using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace QLKTX.SV
{
     public class DAL
    {
        DataHelper helper = new DataHelper();//khởi tạo một kết nói mới từ database
   
        private  DTO ParseData(DataRow row)
        {
            DTO SV = new DTO();
            SV.MaSV = row["MaSV"].ToString().Trim();
            SV.MaKTX = row["MaKTX"].ToString().Trim();
            SV.Ho = row["Ho"].ToString().Trim();
            SV.Ten = row["Ten"].ToString().Trim();
            SV.CMND = row["CMND"].ToString().Trim();
            SV.Gioitinh = (bool)row["Gioitinh"];
            SV.Ngaysinh =(DateTime)row["Ngaysinh"];
            SV.SDT = row["SDT"].ToString().Trim();
            SV.Quequan = row["Quequan"].ToString().Trim();
            SV.Ngaylamhopdong = (DateTime)row["Ngaylamhopdong"];
            SV.MaPhong = row["MaPhong"].ToString().Trim();
            SV.Hotengh = row["Hotengh"].ToString().Trim();
            SV.Sdtgh = row["Sdtgh"].ToString().Trim();
            SV.Quanhe = row["Quanhe"].ToString().Trim();
            SV.Nghenghiep = row["Nghenghiep"].ToString().Trim();
            SV.Hinh = row["Hinh"].ToString().Trim();
            

            return SV;
        }

	public DTO[] GetSV()
        {
            DTO[] listSV = null;
            DataTable table = null;
            table = helper.ExecuteQuery("Select * from SV");
            int n = table.Rows.Count;
            if (n == 0)
            {
                return null;
            }
            listSV = new DTO[n];
            for (int i = 0; i < n; i++)
            {
                listSV[i] = ParseData(table.Rows[i]);
            }
            return listSV;
        }
        /// <summary>
        /// Thêm xóa sửa sinh viên 
        /// </summary>
        /// <param name="MP"></param>
        /// <param name="MK"></param>
        /// <param name="TP"></param>
        /// <param name="LP"></param>
        /// <param name="SNHT"></param>
        /// <param name="SNTD"></param>
        public void themsv(string MSV, string MKTX, string H,string T,string CMND,bool GT,DateTime NS,string SDT,string QQ,DateTime NLHD,string Mphong,string Hinh,string HTGH,string SDTGH,string QH,string NN)
        {

            helper.ExecuteQuery("INSERT INTO SV VALUES('" + MSV + "','" + MKTX + "','" + H + "','" + T + "','" + CMND + "','" + GT + "','" + NS + "','" + SDT + "','" + QQ + "','" + NLHD + "','" + Mphong + "','" + Hinh + "','" + HTGH + "','" + SDTGH + "','" + QH + "','" + NN + "')");

        }
        public void xoasv(string MSV)
        {
            helper.ExecuteQuery("DELETE FROM SV WHERE MaSV='" + MSV + "'");
        }
        public void suasv(string MSV, string MKTX, string H, string T, string CMND, bool GT, DateTime NS, string SDT, string QQ, DateTime NLHD, string Mphong, string Hinh, string HTGH, string SDTGH, string QH, string NN)
        {
            helper.ExecuteQuery("UPDATE SV SET MaKTX ='" + MKTX + "',Ho='" + H + "',Ten='" + T + "',CMND='" + CMND + "',Gioitinh='" + GT + "',Ngaysinh='" + NS + "',SDT='" + SDT + "',Quequan='" + QQ + "',Ngaylamhopdong='" + NLHD + "',MaPhong='" + Mphong + "',Hinh='" + Hinh + "',Hotengh='" + HTGH + "',Sdtgh='" + SDTGH + "',Quanhe='" + QQ + "',Nghenghiep='" + NN + "' where MaSV ='" + MSV + "'");
        }
        public void timkiemsv(string MSVTK)
        {
            helper.ExecuteQuery("SELECT * FROM SV WHERE MASV LIKE '%" + MSVTK + "%'");
        }
      
        public DTO[] TIMSV(string MSVTK)
        {
            DTO[] LISTTIMSV = null;
            DataTable table = null;
            table = helper.ExecuteQuery("Select * from SV WHERE MASV LIKE '%" + MSVTK + "%'");
            int n = table.Rows.Count;
            if (n == 0)
            {
                return null;
            }
            LISTTIMSV = new DTO[n];
            for (int i = 0; i < n; i++)
            {
                LISTTIMSV[i] = ParseData(table.Rows[i]);
            }
            return LISTTIMSV;
        }

        public void thongkeSV()
        {
            helper.ExecuteQuery("SELECT COUNT(*) FROM SV ");
        }

     }
}

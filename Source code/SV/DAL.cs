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
        }
     }
}

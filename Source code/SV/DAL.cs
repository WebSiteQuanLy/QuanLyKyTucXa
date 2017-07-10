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
     }
}

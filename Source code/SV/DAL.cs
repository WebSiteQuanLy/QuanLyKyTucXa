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
        }
     }
}

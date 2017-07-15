using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QLKTX.Diennuoc;

namespace QLKTX.Diennuoc
{
   public class DiennuocDAL
    {
       DataHelper helper = new DataHelper();//tạo mới một helper
        private DiennuocDTO ParseData(DataRow row)
        {
            DiennuocDTO DN = new DiennuocDTO();
            DN.Maphong = row["Maphong"].ToString().Trim();//Lấy kiểu dữ liệu Mã phòng
            DN.Thang = (DateTime)row["Thang"];//Lấy kiểu dữ liệu tháng
            DN.CScudien = (int)row["CScudien"];//Lấy kiểu dữ liệu cs điện cũ
            DN.CSmoidien = (int)row["CSmoidien"];//Lấy kiểu dữ liệu cs điện mới
            DN.CScunuoc = (int)row["CScunuoc"];//Lấy kiểu dữ liệu cs nước cũ
            DN.CSmoinuoc = (int)row["CSmoinuoc"];//Lấy kiểu dữ liệu cs nước mới
          
            return DN;
        }
    }
}

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
         public DiennuocDTO[] GetDN()
        {
            DiennuocDTO[] listDN = null;
            DataTable table = null;/// tạo bảng ảo có gtri null
            table = helper.ExecuteQuery("Select * from Diennuoc");//lấy dữ liệu bảng điện nước
            int n = table.Rows.Count;
            if (n == 0)
            {
                return null;
            }
            listDN = new DiennuocDTO[n];//duyệt dữ liệu và tổ chức thành bảng
            for (int i = 0; i < n; i++)
            {
                listDN[i] = ParseData(table.Rows[i]);
            }
            return listDN;
        }
	//Lưu điện nước
           public void luudiennuoc(string MP, DateTime TH, int CSDC, int CSDM, int CSNC, int CSNM)
        {

            helper.ExecuteQuery("INSERT INTO Diennuoc VALUES('" + MP + "','" + TH + "','" + CSDC + "','" + CSDM + "','" + CSNC + "','" + CSNM + "')");

        }
	//sửa chỉ số điện nước
        public void suadiennuoc(string MP, DateTime TH, int CSDC, int CSDM, int CSNC, int CSNM)
        {
            helper.ExecuteQuery("UPDATE  Diennuoc SET Thang='" + TH + "',CScudien='" + CSDC + "',CSmoidien='" + CSDM + "',CScunuoc='" + CSNC + "',CSmoinuoc='" + CSNM + "'where Maphong ='" + MP + "'");
        }
        public void xoadiennuoc(string MP)
        {
            helper.ExecuteQuery("DELETE FROM Diennuoc WHERE Maphong='" + MP + "'");
        }
    }
}

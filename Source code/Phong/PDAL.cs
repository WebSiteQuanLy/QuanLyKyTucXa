using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;



namespace QLKTX.Phong
{
    public class PDAL
    {
        DataHelper helper = new DataHelper(); /// tạo mới một helper
        private PDTO ParseData(DataRow row)
        {
            PDTO Phong = new PDTO();
            Phong.Maphong = row["Maphong"].ToString().Trim();///Lấy kiểu dữ liệu Mã phòng
            Phong.Makhu = row["Makhu"].ToString().Trim();///Lấy kiểu dữ liệu Mã khu
            Phong.Tenphong = row["Tenphong"].ToString().Trim();///Lấy kiểu dữ liệu tên phòng
            Phong.Loaiphong = (bool)row["Loaiphong"];///Lấy kiểu dữ liệu loại phòng
            Phong.Songuoihientai = (int)row["Songuoihientai"];///Lấy kiểu dữ liệu số người hiện tại
            Phong.Songuoitoida = (int)row["Songuoitoida"];///Lấy kiểu dữ liệu số người tối đa
            return Phong;
        }
         public PDTO[] Getphong()
        {
            PDTO[] listphong = null;
            DataTable table = null;///Tạo bảng ảo chứa giá trị khởi tạo bằng null
            table = helper.ExecuteQuery("select * from Phong");///Lấy toàn bộ dữ liệu từ bảng phòng

            int n = table.Rows.Count;
            if (n == 0)
            {
                return null;
            }
            listphong = new PDTO[n];///Duyệt dữ liệu và tổ chức thành bảng
            for (int i = 0; i < n; i++)
            {
                listphong[i] = ParseData(table.Rows[i]);
            }
            return listphong;
        }
        /// <summary>
        /// them xoa sưa 
        /// </summary>
        /// <param name="MP"></param>
        /// <param name="MK"></param>
        /// <param name="TP"></param>
        /// <param name="LP"></param>
        /// <param name="SNHT"></param>
        /// <param name="SNTD"></param>

	//code thêm phòng
        public void themphong(string MP, string MK, string TP, bool LP, int SNHT, int SNTD)
        {

                helper.ExecuteQuery("INSERT INTO Phong VALUES('" + MP + "','" + MK + "','" + TP + "','" + LP + "','" + SNHT + "','" + SNTD + "')");
               
        }
	//code xóa phòng
        public void xoaph(string mp)
        {
            helper.ExecuteQuery("DELETE FROM Phong WHERE Maphong='" + mp + "'");
        }
	//code thêm phòng
        public void suaph(string Mp, string Mk, string Tp, bool Lp, int Snht, int Sntd)
        {
            helper.ExecuteQuery("UPDATE Phong SET Makhu='"+ Mk +"',Tenphong ='" + Tp + "',Loaiphong='"+Lp+"',Songuoihientai='"+Snht+"',Songuoitoida='"+Sntd+"' where Maphong ='" + Mp + "'");
        }
        public PDTO[] phongTK(string MPTK)
        {
            PDTO[] listphongTK = null;
            DataTable table = null;
            table = helper.ExecuteQuery("select * from Phong WHERE Maphong LIKE '%" + MPTK + "%'");

            int n = table.Rows.Count;
            if (n == 0)
            {
                return null;
            }
            listphongTK = new PDTO[n];
            for (int i = 0; i < n; i++)
            {
                listphongTK[i] = ParseData(table.Rows[i]);
            }
            return listphongTK;
        }

     }
}

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
        DataHelper helper = new DataHelper();
        private PDTO ParseData(DataRow row)
        {
            PDTO Phong = new PDTO();
            Phong.Maphong = row["Maphong"].ToString().Trim();
            Phong.Makhu = row["Makhu"].ToString().Trim();
            Phong.Tenphong = row["Tenphong"].ToString().Trim();
            Phong.Loaiphong = (bool)row["Loaiphong"];
            Phong.Songuoihientai = (int)row["Songuoihientai"];
            Phong.Songuoitoida = (int)row["Songuoitoida"];
            return Phong;
        }
         public PDTO[] Getphong()
        {
            PDTO[] listphong = null;
            DataTable table = null;
            table = helper.ExecuteQuery("select * from Phong");

            int n = table.Rows.Count;
            if (n == 0)
            {
                return null;
            }
            listphong = new PDTO[n];
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
        public void themphong(string MP, string MK, string TP, bool LP, int SNHT, int SNTD)
        {

                helper.ExecuteQuery("INSERT INTO Phong VALUES('" + MP + "','" + MK + "','" + TP + "','" + LP + "','" + SNHT + "','" + SNTD + "')");
               
        }
        public void xoaph(string mp)
        {
            helper.ExecuteQuery("DELETE FROM Phong WHERE Maphong='" + mp + "'");
        }
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

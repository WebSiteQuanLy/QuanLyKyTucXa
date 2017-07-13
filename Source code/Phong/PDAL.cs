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

     }
}

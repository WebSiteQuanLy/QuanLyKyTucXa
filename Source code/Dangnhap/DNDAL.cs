using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QLKTX.Dangnhap
{
    pubilc class DNDAL
    {
       DataHelper helper = new DataHelper();

        private DNDTO ParseData(DataRow row)
        {
            DNDTO DN = new DNDTO();
            DN.username = row["username"].ToString().Trim();
            DN.Pass = row["Pass"].ToString().Trim();
            DN.Hovaten = row["Hovaten"].ToString().Trim();
            DN.Gioitinh = (bool)row["Gioitinh"];
            DN.Quyen = row["Quyen"].ToString().Trim();
            DN.SDT = row["SDT"].ToString().Trim();
            return DN;
        }

 	public bool CheckDN(string user,string Pass)
        {
            DataTable table = null;
            table = helper.ExecuteQuery("Select * From Taikhoan where username='" + user  + "' and Pass='" + Pass + "' and Quyen='Admin'");
            int n = table.Rows.Count;
            if (n == 0)
            {
                return false;
            }
            return true;
        }
    }
}

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
       DataHelper helper = new DataHelper();///tạo mới một data helper

        private DNDTO ParseData(DataRow row)
        {
            DNDTO DN = new DNDTO();
            DN.username = row["username"].ToString().Trim();///Lấy kiểu dữ liệu user name
            DN.Pass = row["Pass"].ToString().Trim();//Lấy kiểu dữ liệu mật khẩu
            DN.Hovaten = row["Hovaten"].ToString().Trim();//Lấy kiểu dữ liệu Hoj và tên
            DN.Gioitinh = (bool)row["Gioitinh"];//Lấy kiểu dữ liệu trường giới tính
            DN.Quyen = row["Quyen"].ToString().Trim();//Lấy kiểu dữ liệu quyền
            DN.SDT = row["SDT"].ToString().Trim();//Lấy kiểu dữ liệu Số điện thoại
            return DN;
        }

 	public bool CheckDN(string user,string Pass)
        {
            DataTable table = null;///tạo bảng ảo có giá trị null
		//lấy dữ liệu và so sánh dữ liệu
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

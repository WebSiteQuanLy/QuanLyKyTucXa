using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QLKTX.Khu
{
    public class KhuDAL
    {
        DataHelper helper = new DataHelper();/// tạo mới một helper có chức năng vận chuyển như DâtHelper

        private KhuDTO ParseData(DataRow row)
        {
            KhuDTO khu = new KhuDTO();
            khu.MaKhu = row["MaKhu"].ToString().Trim();///Lấy kiểu dữ liệu Mã khu
            khu.Tenkhu = row["TenKhu"].ToString().Trim();///Lấy kiểu dữ liệu tên khu
            return khu;
        }
  public KhuDTO[] GetKhu()
        {
            KhuDTO[] listKhu = null;
            DataTable table = null;///Bảng ảo chứa giá trị khởi tạo bằng null
            table = helper.ExecuteQuery("Select * from Khu");///Lấy toàn bộ dữ liệu từ bảng khu
            int n = table.Rows.Count;
            if (n == 0)
            {
                return null;
            }
            listKhu = new KhuDTO[n];///Duyệt dữ liệu và tổ chức thành bảng
            for (int i = 0; i < n; i++)
            {
                listKhu[i] = ParseData(table.Rows[i]);
            }
            return listKhu;
        }

    }
}

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
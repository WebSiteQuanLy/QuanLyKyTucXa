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
        DataHelper helper = new DataHelper();

        private KhuDTO ParseData(DataRow row)
        {
            KhuDTO khu = new KhuDTO();
            khu.MaKhu = row["MaKhu"].ToString().Trim();
            khu.Tenkhu = row["TenKhu"].ToString().Trim();
            return khu;
        }
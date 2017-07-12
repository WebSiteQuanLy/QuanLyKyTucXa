using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKTX.Khu
{
    public class KhuBLL
    {
        KhuDAL dal = new KhuDAL();
        public KhuDTO[] GetList()
        {
            return dal.GetKhu();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace QLKTX.Dangnhap
{
    public class DNBLL
    {
       DNDAL dal = new DNDAL();
        public bool CheckDN(string user,string Pass)
        {
            return dal.CheckDN(user,Pass);
        }
    }
}

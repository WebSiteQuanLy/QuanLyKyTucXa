using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKTX.Diennuoc
{
    public class DiennuocBLL
    {
        DiennuocDAL DN = new DiennuocDAL();
        public DiennuocDTO[] GetlistDN()
        {
            return DN.GetDN();
        }


        public void luudn(string MP, DateTime TH, int CSDC, int CSDM, int CSNC, int CSNM)
        {
            DN.luudiennuoc(MP, TH, CSDC, CSDM, CSNC, CSNM);
        }
        public void suadn(string MP, DateTime TH, int CSDC, int CSDM, int CSNC, int CSNM)
        {
            DN.suadiennuoc(MP, TH, CSDC, CSDM, CSNC, CSNM);
        }
        public void xoadn(string MP)
        {
            DN.xoadiennuoc(MP);
        }

    }
}

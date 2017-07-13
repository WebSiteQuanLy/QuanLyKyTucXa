using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace QLKTX.Phong
{
    public class PBLL
    {
        PDAL Ph = new PDAL();
        public PDTO[] phong()
        {
            return Ph.Getphong();
        }
        
         public void themph(string MP,string MK,string TP,bool LP,int SNHT,int SNTD)
        {
            Ph.themphong(MP,MK,TP,LP,SNHT,SNTD);
        }
        public void xoaph(string mp)
        {
            Ph.xoaph(mp);
        }
        public void suaph(string Mp, string Mk, string Tp, bool Lp, int Snht, int Sntd)
        {
            Ph.suaph(Mp, Mk, Tp, Lp, Snht, Sntd);
        }

         public PDTO[] TKPHONG(string MPTK)
        {
            return Ph.phongTK(MPTK);
        }
    }
}

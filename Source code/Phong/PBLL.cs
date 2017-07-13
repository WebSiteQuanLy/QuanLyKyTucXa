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
        
    }
}

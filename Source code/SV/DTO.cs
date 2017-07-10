using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKTX.SV
{
    public class DTO
    {
        public string MaSV { get; set; }//lấy mã SInh viên từ CSDl
        public string MaKTX { get; set; }//lấy mã KTX từ CSDl
        public string Ho { get; set; }//lấy Ho Sinh Viên từ CSDl
        public string Ten { get; set; }//lấy tên SV từ CSDl
        public string CMND { get; set; }//lấy số CMND từ CSDl
        public bool Gioitinh { get; set; }//lấy trường GT viên từ CSDl
        public DateTime Ngaysinh { get; set; }
        public string SDT { get; set; }
        public string Quequan { get; set; }
        public DateTime Ngaylamhopdong { get; set; }
        public string MaPhong { get; set; }
        public string Hinh { get; set; }
        public string Hotengh { get; set; }
        public string Sdtgh { get; set; }
        public string Quanhe { get; set; }
        public string Nghenghiep { get; set; }

    }
}

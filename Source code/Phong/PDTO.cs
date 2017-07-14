using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKTX.Phong
{
    public class PDTO
    {
        public string Maphong { get; set; }//dữ liệu mã phòng trong bảng dữ liệu phòng
        public string Makhu { get; set; }//dữ liệu mã khu trong bảng dữ liệu khu
        public string Tenphong { get; set; }//lấy dữ liệu tên phòng trong bảng dữ liệu
        public bool Loaiphong { get; set; }//lấy dữ liệu loại phòng trong bảng dữ liệu
        public int Songuoihientai { get; set; } //lấy dữ liệu số người hiện tại trong bảng dữ liệu
        public int Songuoitoida { get; set; } //lấy dữ liệu số người tối đa trong bảng dữ liệu
        
    }
}

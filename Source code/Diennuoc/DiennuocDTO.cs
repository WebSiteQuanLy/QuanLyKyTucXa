using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKTX.Diennuoc
{
    public class DiennuocDTO
    {
        public string Maphong { get; set; }///lấy dữ liệu mã phòng trong bảng dữ liệu điện nước
        public DateTime Thang { get; set; }///lấy dữ liệu tháng trong bảng dữ liệu điện nước
        public int CScudien { get; set; }///lấy dữ liệu chỉ số điện cũ trong bảng dữ liệu điện nước
        public int CSmoidien { get; set; }///lấy dữ liệu chỉ số điện mới trong bảng dữ liệu điện nước
        public int CScunuoc { get; set; }///lấy dữ liệu chỉ số nước cũ trong bảng dữ liệu điện nước
        public int CSmoinuoc { get; set; }///lấy dữ liệu chỉ số nước mới trong bảng dữ liệu điện nước
    }
}

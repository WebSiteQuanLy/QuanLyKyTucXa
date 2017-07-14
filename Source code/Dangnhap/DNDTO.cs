using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKTX.Dangnhap
{
    public class DNDTO
    {
        public string username { get; set; }///lấy dữ liệu tên user name trong bảng dữ liệu dangnhap
        public string Pass { get; set; }///lấy dữ liệu mật khẩu trong bảng dữ liệu dangnhap
        public string Hovaten { get; set; }///lấy dữ liệu họ và tên người đăng nhập trong bảng dữ liệu dangnhap
        public bool Gioitinh { get; set; }///lấy dữ liệu giới tính trong bảng dữ liệu dangnhap
        public string Quyen { get; set; }///lấy dữ liệu quyền trong bảng dữ liệu dangnhap
        public string SDT { get; set; }///lấy dữ liệu SDT trong bảng dữ liệu dangnhap
    }
}

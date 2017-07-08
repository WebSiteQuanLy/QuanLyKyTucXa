using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKTX
{
    public partial class xinchao : Form
    {
        public xinchao()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
	//New một from đăng nhập mới
            var myForm = new dangnhap();
            myForm.Show(); //Hiển thị form myForm
            this.Hide(); 
        }
    }
}

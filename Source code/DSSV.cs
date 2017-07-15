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
    public partial class DSSV : Form
    {
        public DSSV()
        {
            InitializeComponent();
        }

        private void DSSV_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.SV' table. You can move, or remove it, as needed.
            this.SVTableAdapter.Fill(this.DataSet1.SV);

            this.reportViewer1.RefreshReport();
        }
    }
}

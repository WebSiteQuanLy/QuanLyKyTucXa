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
    public partial class DSDienNuoc : Form
    {
        public DSDienNuoc()
        {
            InitializeComponent();
        }

        private void DSDienNuoc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataDienNuoc.Diennuoc' table. You can move, or remove it, as needed.
            this.DiennuocTableAdapter.Fill(this.DataDienNuoc.Diennuoc);
            // TODO: This line of code loads data into the 'DataSet1.SV' table. You can move, or remove it, as needed.
            this.SVTableAdapter.Fill(this.DataSet1.SV);

            this.reportViewer1.RefreshReport();
        }
    }
}

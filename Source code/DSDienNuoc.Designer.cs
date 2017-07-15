namespace QLKTX
{
    partial class DSDienNuoc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet1 = new QLKTX.DataSet1();
            this.SVTableAdapter = new QLKTX.DataSet1TableAdapters.SVTableAdapter();
            this.DataDienNuoc = new QLKTX.DataDienNuoc();
            this.DiennuocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DiennuocTableAdapter = new QLKTX.DataDienNuocTableAdapters.DiennuocTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.SVBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataDienNuoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiennuocBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.DiennuocBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLKTX.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(960, 405);
            this.reportViewer1.TabIndex = 0;
            // 
            // SVBindingSource
            // 
            this.SVBindingSource.DataMember = "SV";
            this.SVBindingSource.DataSource = this.DataSet1;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SVTableAdapter
            // 
            this.SVTableAdapter.ClearBeforeFill = true;
            // 
            // DataDienNuoc
            // 
            this.DataDienNuoc.DataSetName = "DataDienNuoc";
            this.DataDienNuoc.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DiennuocBindingSource
            // 
            this.DiennuocBindingSource.DataMember = "Diennuoc";
            this.DiennuocBindingSource.DataSource = this.DataDienNuoc;
            // 
            // DiennuocTableAdapter
            // 
            this.DiennuocTableAdapter.ClearBeforeFill = true;
            // 
            // DSDienNuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 429);
            this.Controls.Add(this.reportViewer1);
            this.Name = "DSDienNuoc";
            this.Text = "DSDienNuoc";
            this.Load += new System.EventHandler(this.DSDienNuoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SVBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataDienNuoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiennuocBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SVBindingSource;
        private DataSet1 DataSet1;
        private DataSet1TableAdapters.SVTableAdapter SVTableAdapter;
        private System.Windows.Forms.BindingSource DiennuocBindingSource;
        private DataDienNuoc DataDienNuoc;
        private DataDienNuocTableAdapters.DiennuocTableAdapter DiennuocTableAdapter;
    }
}
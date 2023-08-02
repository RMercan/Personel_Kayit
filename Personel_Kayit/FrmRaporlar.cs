using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personel_Kayit
{
    public partial class FrmRaporlar : Form
    {
        public FrmRaporlar()
        {
            InitializeComponent();
        }

        private void FrmRaporlar_Load(object sender, EventArgs e)
        {
            Tbl_PersonelTableAdapter.Fill(PersonelDbDataSet.Tbl_Personel);

            //reportViewer1.LocalReport.ReportEmbeddedResource = "Personel_Kayit.Report1.rdlc";
            //reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("Dataset1", PersonelDbDataSet.Tables[0]));

            this.reportViewer1.RefreshReport();
        }
    }
}

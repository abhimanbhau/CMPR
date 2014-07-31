using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraReports.Parameters;

namespace CMPR.ReceiptGeneration
{
    public partial class FrmMain : DevExpress.XtraEditors.XtraForm
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            var rec = new ProjectRegistrationReceipt();
            rec.Division.Value = 'A';
            rec.Year.Value = "SE";
            rec.ExportToImage("demo.jpeg", ImageFormat.Jpeg);
        }
    }
}

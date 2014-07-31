using DevExpress.XtraEditors;

namespace CMPR.StudentRegistration
{
    public partial class FrmIntro : XtraForm
    {
        public char App { get; set; }

        public FrmIntro()
        {
            InitializeComponent();
        }

        private void btnRegistration_Click(object sender, System.EventArgs e)
        {
            App = 'P';
            Close();
        }

        private void btnReceiptGeneration_Click(object sender, System.EventArgs e)
        {
            App = 'R';
            Close();
        }
    }
}
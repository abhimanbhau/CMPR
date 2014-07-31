using System;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using System.Data;

namespace CMPR.AdminCP
{
    public partial class FrmAdminControlPanel : XtraForm
    {
        public FrmAdminControlPanel()
        {
            InitializeComponent();
        }

        public FrmAdminControlPanel(String guideName)
        {
            InitializeComponent();
            GimmeSomeWait();
            Text += guideName;
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            Close();
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraMessageBox.Show(this,
                "CMPR.AdminCP\n"
                +
                "This Module is part of Centralized Mini Project Rgistration Software.\n"
                +
                "Copyright 2014 Abhimanbhau Kolte\n"
                +
                "Admin Control Panel Module is client software, which provides GUI for\n"
                +
                "Managing Project Registratin Database",
                "Centralized Mini Project Registration : Admin Control Panel",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);
        }

        private void FrmAdminControlPanel_Load(object sender, EventArgs e)
        {
            metroLabel4.Text += DateTime.Now.ToLocalTime();
            TxtSe.Text = GetSystemStatus("SE").ToString();
            TxtTe.Text = GetSystemStatus("TE").ToString();
            TxtBe.Text = GetSystemStatus("BE").ToString();
            TxtTotal.Text = (Convert.ToInt32(TxtSe.Text) + Convert.ToInt32(TxtTe.Text)
                + Convert.ToInt32(TxtBe.Text)).ToString();
        }

        private int GetSystemStatus(String year)
        {
            int count = 0;
            try
            {
                using (var connection = new SqlConnection(Properties.Settings.Default.ConnectionString))
                {
                    using (var command = new SqlCommand("SELECT COUNT(Year) FROM StudentData WHERE Year=@year",
                        connection))
                    {
                        connection.Open(); command.Parameters.AddWithValue("@year", year);
                        count = (int)command.ExecuteScalar();
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(this,
                    "There was error connecting to database \n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            return count;
        }

        private void FrmAdminControlPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (XtraMessageBox.Show(this,
                "Are you sure to Exit",
                "Quit?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            UserLookAndFeel.Default.SetSkinStyle("Metropolis Dark");
        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            UserLookAndFeel.Default.SetSkinStyle("McSkin");
        }

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            UserLookAndFeel.Default.SetSkinStyle("DevExpress Style");
        }

        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {
            UserLookAndFeel.Default.SetSkinStyle("DevExpress Dark Style");
        }

        private void barButtonItem9_ItemClick(object sender, ItemClickEventArgs e)
        {
            UserLookAndFeel.Default.SetSkinStyle("Office 2013");
        }

        private void barButtonItem10_ItemClick(object sender, ItemClickEventArgs e)
        {
            UserLookAndFeel.Default.SetSkinStyle("Metropolis");
        }

        private void barButtonItem11_ItemClick(object sender, ItemClickEventArgs e)
        {
            UserLookAndFeel.Default.SetSkinStyle("VS2010");
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show(this,
                "You are entering SUDO area.\nAny wrong actions will result in complete " +
                "loss of data",
                "Are you sure",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation) ==
                DialogResult.No)
            {
                return;
            }
            var loginForm = new FrmLogin();
            loginForm.ShowDialog();
            if (loginForm.GetLoginStatus())
            {
                // Do Work Here
            }
        }

        private void BtnYearWise_Click(object sender, EventArgs e)
        {
            if (CmbYearWise.Text == String.Empty)
            {
                XtraMessageBox.Show(this,
                    "Please select year",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                GetYearWiseData();
            }
        }

        private void GetYearWiseData()
        {
            using (var connection = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                using (var command = new SqlCommand("", connection))
                {
                    connection.Open();
                    command.CommandText = "SELECT * FROM StudentData WHERE Year=@year";
                    command.Parameters.AddWithValue("@year", CmbYearWise.Text);
                    var dr = command.ExecuteReader();
                    var dt = new DataTable();
                    dt.Load(dr);
                    gridControl1.DataSource = dt;
                }
            }
        }

        private void BtnDivisionWise_Click(object sender, EventArgs e)
        {
            if (CmbYearWise.Text == String.Empty || CmbDivision.Text == String.Empty)
            {
                XtraMessageBox.Show(this,
                    "Please select year/division",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                GetDivisionWiseData();
            }
        }

        private void GetDivisionWiseData()
        {
            using (var connection = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                using (var command = new SqlCommand("", connection))
                {
                    connection.Open();
                    command.CommandText = "SELECT * FROM StudentData WHERE Year=@year and Division=@division";
                    command.Parameters.AddWithValue("@year", CmbYearWise.Text);
                    command.Parameters.AddWithValue("@division", CmbDivision.Text);
                    var dr = command.ExecuteReader();
                    var dt = new DataTable();
                    dt.Load(dr);
                    gridControl1.DataSource = dt;
                }
            }
        }

        private void FrmAdminControlPanel_SizeChanged(object sender, EventArgs e)
        {
            gridControl1.Width = xtraTabControl1.Width - 6;
            gridControl1.Height = xtraTabControl1.Height - 75;
        }

        private void BtnLoadStatus_Click(object sender, EventArgs e)
        {
            TxtDivisionStatus.Text =
                GetDivisionStatus(Convert.ToChar(CmbDivisionStatus.Text)).ToString();
        }
        private int GetDivisionStatus(Char div)
        {
            int count = 0;
            try
            {
                using (var connection = new SqlConnection(Properties.Settings.Default.ConnectionString))
                {
                    using (var command = new SqlCommand("", connection))
                    {
                        connection.Open();
                        command.CommandText = "SELECT COUNT(Division) FROM StudentData" +
                            " WHERE Division=@div";
                        command.Parameters.AddWithValue("@div", div);
                        count = (int)command.ExecuteScalar();
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(this,
                    "There was error connecting to database \n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            return count;
        }

        private void BtnGenerateReport_Click(object sender, EventArgs e)
        {
            if (gridControl1.DataSource == null)
            {
                XtraMessageBox.Show(this,
                    "Cannot export while there is no data loaded in Grid",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            saveFileDialog.Filter = "CMPR Report File|*xlsx|CMPR Report File|*.pdf";
            saveFileDialog.AddExtension = true;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (saveFileDialog.FilterIndex == 1)
                {

                    gridControl1.ExportToXlsx(saveFileDialog.FileName + ".xlsx");
                }
                else
                {
                    gridControl1.ExportToPdf(saveFileDialog.FileName);
                }
            }
        }
    }
}
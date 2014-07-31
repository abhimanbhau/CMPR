using System;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace CMPR.StudentRegistration
{
    public partial class FrmTitleRegistration : XtraForm
    {
        // private char _division;
        // private string _projectId;

        public FrmTitleRegistration()
        {
            InitializeComponent();
            GimmeSomeWait();
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            if (CmbDivision.Text == String.Empty ||
                TxtProjectId.Text == String.Empty)
            {
                XtraMessageBox.Show(this,
                    "Please select appropriate details",
                    "Error",
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Error);
                return;
            }
            try
            {
                using (var sqlConnection = new SqlConnection(Properties.Settings.Default.ConnectionString))
                {
                    using (var command = new SqlCommand("", sqlConnection))
                    {
                        sqlConnection.Open();
                        command.CommandText = "UPDATE [StudentData] SET ProjectTitle=@title WHERE [ProjectId] = @id";
                        command.Parameters.AddWithValue("@id", TxtProjectId.Text.Trim());
                        command.Parameters.AddWithValue("@title", TxtProjectTittle.Text);
                        command.ExecuteNonQuery();
                    }
                    XtraMessageBox.Show(this,
                        "Your title is successfully registered",
                        "Success",
                        System.Windows.Forms.MessageBoxButtons.OK,
                        System.Windows.Forms.MessageBoxIcon.Information);
                    Close();
                }
            }
            catch (SqlException ex)
            {
                XtraMessageBox.Show(this,
                    "There was an error \n" + ex.Message,
                    "Error in connecting to server",
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Error);
            }
        }
    }
}



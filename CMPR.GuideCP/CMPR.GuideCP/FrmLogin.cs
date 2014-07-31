using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CMPR.GuideCP
{
    public partial class FrmLogin : DevExpress.XtraEditors.XtraForm
    {
        private  bool _loginStatus = false;
        private string _guideName;

        public FrmLogin()
        {
            InitializeComponent();
        }

        public bool GetLoginStatus()
        {
            return _loginStatus;
        }

        public string GetGuideName()
        {
            return _guideName;
        }

        private void DoLogin()
        {

            const string loginQuery = "SELECT * FROM FacultyDomainData WHERE username COLLATE Latin1_General_CS_AS=@uname and passwd COLLATE Latin1_General_CS_AS=@password";
            DataSet ds = new DataSet();
            SqlCommand command = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.ConnectionString);
            connection.Open();
            command.CommandText = loginQuery;
            command.Connection = connection;
            command.Parameters.AddWithValue("@uname", TxtUsername.Text.Trim());
            command.Parameters.AddWithValue("@password", TxtPassword.Text.Trim());
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                _loginStatus = true;
                reader.Read();
                _guideName = reader[0].ToString();
            }
            else
            {
                throw new InvalidCredentialsException("Check USERNAME/PASSWORD Again");
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                DoLogin();
                if (_loginStatus)
                {
                    this.Close();
                }
            }
            catch (InvalidCredentialsException exception)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show(this,
                    exception.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
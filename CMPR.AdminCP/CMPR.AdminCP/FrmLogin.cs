using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using CMPR.AdminCP.Properties;
using DevExpress.XtraEditors;

namespace CMPR.AdminCP
{
    public partial class FrmLogin : XtraForm
    {
        private bool _loginStatus;
        private String name;

        public FrmLogin()
        {
            InitializeComponent();
        }

        public bool GetLoginStatus()
        {
            return _loginStatus;
        }

        public String GetGuideName()
        {
            return name;
        }

        private void DoLogin()
        {
            const string loginQuery =
                "SELECT * FROM AdminCredentials WHERE username COLLATE Latin1_General_CS_AS=@uname and password COLLATE Latin1_General_CS_AS=@password";
            using (var connection = new SqlConnection(Settings.Default.ConnectionString))
            {
                using (var command = new SqlCommand())
                {
                    connection.Open();
                    command.CommandText = loginQuery;
                    command.Connection = connection;
                    command.Parameters.AddWithValue("@uname", TxtUsername.Text.Trim());
                    command.Parameters.AddWithValue("@password", TxtPassword.Text.Trim());
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        _loginStatus = true;
                        while (reader.Read())
                        {
                            name = reader[2].ToString();
                        }
                    }
                    else
                    {
                        throw new InvalidCredentialsException("Check USERNAME/PASSWORD Again");
                    }
                }
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                DoLogin();
                if (_loginStatus)
                {
                    Close();
                }
            }
            catch (InvalidCredentialsException exception)
            {
                XtraMessageBox.Show(this,
                    exception.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void BtnLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    DoLogin();
                    if (_loginStatus)
                    {
                        Close();
                    }
                }
                catch (InvalidCredentialsException exception)
                {
                    XtraMessageBox.Show(this,
                        exception.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void TxtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    DoLogin();
                    if (_loginStatus)
                    {
                        Close();
                    }
                }
                catch (InvalidCredentialsException exception)
                {
                    XtraMessageBox.Show(this,
                        exception.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }}
    }
}
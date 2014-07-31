using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CMPR.GuideCP
{
    public partial class FrmGuideCp : DevExpress.XtraEditors.XtraForm
    {
        SqlCommand _command;
        SqlConnection _connection;
        System.Collections.ArrayList _groupList;

        private string _guideName;

        public FrmGuideCp()
        {
            InitializeComponent();
            GimmeSomeWait();
        }
        public FrmGuideCp(string guideName)
        {
            InitializeComponent();
            Text = "Welcome " + guideName;
            _guideName = guideName;
            GimmeSomeWait();
        }

        private void FrmGuideCp_Load(object sender, EventArgs e)
        {
            _groupList = new System.Collections.ArrayList();
            bool flag = true;
            try
            {
                using (_connection = new SqlConnection(Properties.Settings.Default.ConnectionString))
                {
                    using (_command = new SqlCommand("SELECT ProjectId FROM StudentData WHERE GuideName=@guideName", _connection))
                    {
                        _command.Parameters.AddWithValue("@guideName", _guideName);
                        _connection.Open();
                        SqlDataReader dr = _command.ExecuteReader();
                        // CmbProjects.Items.Add(String.Empty);
                        while (dr.Read())
                        {
                            if (flag)
                            {
                                _groupList.Add(dr[0].ToString());
                                flag = false;
                            }
                            else
                            {
                                foreach (var item in _groupList)
                                {
                                    if (dr[0].ToString() != item.ToString())
                                    {
                                        _groupList.Add(dr[0].ToString());
                                    }
                                }
                            }
                        }
                        CmbProjects.Items.Add("ALL");
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception)
            {
                // Ignoring for a moment
            }
            foreach (var item in _groupList)
            {
                CmbProjects.Items.Add(item.ToString());
            }
            GridStudentData.Text = "Report";
        }

        private void BtnGroupSelectedOk_Click(object sender, EventArgs e)
        {
            if (CmbProjects.Text == String.Empty)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show(this,
                    "Please select project from list",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            using (_connection = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                if (CmbProjects.Text == "ALL"){
                    using (_command = new SqlCommand("SELECT * FROM StudentData WHERE GuideName=@guide", _connection))
                    {
                        _command.Parameters.AddWithValue("@guide", _guideName);
                        _connection.Open();
                        SqlDataReader dr = _command.ExecuteReader();
                        var dt = new DataTable();
                        dt.Load(dr);
                        GridStudentData.DataSource = dt;
                    }
                }
                else
                {
                    using (_command = new SqlCommand("SELECT * FROM StudentData WHERE ProjectId=@project", _connection))
                    {
                        _command.Parameters.AddWithValue("@project", CmbProjects.Text);
                        _connection.Open();
                        SqlDataReader dr = _command.ExecuteReader();
                        var dt = new DataTable();
                        dt.Load(dr);
                        GridStudentData.DataSource = dt;
                    }
                }
            }
        }

        private void BtnGenerateReport_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "CMPR Report File|*xlsx|CMPR Report File|*.pdf";
            saveFileDialog.AddExtension = true;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (GridStudentData.DataSource != null)
                {
                    if (saveFileDialog.FilterIndex == 1)
                    {

                        GridStudentData.ExportToXlsx(saveFileDialog.FileName + ".xlsx");
                    }
                    else
                    {
                        GridStudentData.ExportToPdf(saveFileDialog.FileName);
                    }
                }
            }
        }
    }
}

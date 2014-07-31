using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;
using CMPR.DomainFacultyHelper;
using CMPR.StudentRegistration.Properties;
using DevExpress.XtraEditors;
using DevExpress.XtraTab;

namespace CMPR.StudentRegistration
{
    public partial class FrmMain : XtraForm
    {
        private readonly Stopwatch _watch = new Stopwatch();
        private String _guideNameGettingAllocated;
        private bool _isDataVerified;
        private bool _isProceedClicked;


        // Fields to simplify Receipt generation
        private String _projectId;

        public FrmMain()
        {
            XtraMessageBox.Show(this,
                "You are requested to read all the instructions carefully\n" +
                "You have only one chance for registration, so make it count",
                "Powered by CMPR Suite by Abhimanbhau Kolte",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);
            InitializeComponent();
            _watch.Start();
            GimmeSomeWait();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            txtGR5.Enabled = false;
            txtStudentName5.Enabled = false;
            CmbDivision5.Enabled = false;
            CmbRollNumber5.Enabled = false;
            txtMobileNo5.Enabled = false;
            txtEmailId5.Enabled = false;

            CmbDivision2.Enabled = false;
            CmbDivision3.Enabled = false;
            CmbDivision4.Enabled = false;
            CmbDivision5.Enabled = false;


            TxtInstruction.Properties.ReadOnly = true;
            CmbBranch.Enabled = false;
            CmbBranch.SelectedIndex = 0;
            DomainPanel.Visible = false;
            GuidePreferencePanel.Visible = false;
            StudentDataPanel.Visible = false;
            StudentDataTitlePanel.Visible = false;
            for (int i = 1; i < 66; ++i)
            {
                CmbRollNumber1.Items.Add(i);
                CmbRollNumber2.Items.Add(i);
                CmbRollNumber3.Items.Add(i);
                CmbRollNumber4.Items.Add(i);
                CmbRollNumber5.Items.Add(i);
            }

            Char[] divisions = { 'C', 'D', 'E', 'F', 'G', 'H' };
            foreach (var div in divisions)
            {
                CmbDivision1.Items.Add(div);
                CmbDivision2.Items.Add(div);
                CmbDivision3.Items.Add(div);
                CmbDivision4.Items.Add(div);
                CmbDivision5.Items.Add(div);
            }
        }

        private void CmbYear_SelectedIndexChanged(Object sender, EventArgs e)
        {
            CmbModule.Items.Clear();
            if (CmbYear.SelectedIndex == 0)
            {
                CmbModule.Items.Add("III");
                CmbModule.Items.Add("IV");
            }
            else
            {
                if (CmbYear.SelectedIndex == 1)
                {
                    CmbModule.Items.Add("V");
                    CmbModule.Items.Add("VI");
                }
                else
                {
                    if (CmbYear.SelectedIndex == 2)
                    {
                        CmbModule.Items.Add("VII");
                        CmbModule.Items.Add("VIII");
                    }
                }
            }
        }

        private void ResetGuideCombobox()
        {
            CmbGuidePreference1.Items.Clear();
            CmbGuidePreference2.Items.Clear();
            CmbGuidePreference3.Items.Clear();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            dxValidationProvider1.Validate();
            _projectId = String.Format("{0}-{1}{2}{3}{4}",
                CmbDivision1.Text, DateTime.Now.Day, DateTime.Now.Hour,
                DateTime.Now.Minute, DateTime.Now.Second);
            MessageBox.Show(_projectId);
            if (!_isDataVerified)
            {
                XtraMessageBox.Show(this,
                    "Please re-verify all the details by pressing\nVerify Data button",
                    "Data Validation Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            CheckGuideToAllot();
            if (XtraMessageBox.Show(this,
                String.Format("Your group will be alloted with {0}\nDo you want to continue",
                _guideNameGettingAllocated),
                "Warning",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.No)
            {
            }
            else
            {
                {
                    if (_isDataVerified)
                    {
                        try
                        {
                            PerformRegistration(Convert.ToInt32
                                (txtGR1.Text),
                                txtStudentName1.Text,
                                Convert.ToChar(CmbDivision1.Text),
                                CmbModule.Text,
                                CmbYear.Text,
                                Convert.ToInt16(CmbRollNumber1.Text),
                                txtMobileNo1.Text,
                                txtEmailId1.Text,
                                TxtDomain.Text, _guideNameGettingAllocated,
                                _projectId);
                            PerformRegistration(Convert.ToInt32
                                (txtGR2.Text),
                                txtStudentName2.Text,
                                Convert.ToChar(CmbDivision2.Text),
                                CmbModule.Text,
                                CmbYear.Text,
                                Convert.ToInt16(CmbRollNumber2.Text),
                                txtMobileNo2.Text,
                                txtEmailId2.Text,
                                TxtDomain.Text, _guideNameGettingAllocated,
                                _projectId);
                            PerformRegistration(Convert.ToInt32
                                (txtGR3.Text),
                                txtStudentName3.Text,
                                Convert.ToChar(CmbDivision3.Text),
                                CmbModule.Text,
                                CmbYear.Text,
                                Convert.ToInt16(CmbRollNumber3.Text),
                                txtMobileNo3.Text,
                                txtEmailId3.Text,
                                TxtDomain.Text, _guideNameGettingAllocated,
                                _projectId);
                            PerformRegistration(Convert.ToInt32
                                (txtGR4.Text),
                                txtStudentName4.Text,
                                Convert.ToChar(CmbDivision4.Text),
                                CmbModule.Text,
                                CmbYear.Text,
                                Convert.ToInt16(CmbRollNumber4.Text),
                                txtMobileNo4.Text,
                                txtEmailId4.Text,
                                TxtDomain.Text, _guideNameGettingAllocated,
                                _projectId);
                            if (ChbGroupOf5.Checked)
                            {
                                PerformRegistration(Convert.ToInt32
                                    (txtGR5.Text),
                                    txtStudentName5.Text,
                                    Convert.ToChar(CmbDivision5.Text),
                                    CmbModule.Text,
                                    CmbYear.Text,
                                    Convert.ToInt16(CmbRollNumber5.Text),
                                    txtMobileNo5.Text,
                                    txtEmailId5.Text,
                                    TxtDomain.Text, _guideNameGettingAllocated,
                                    _projectId);
                            }
                        }
                        catch (Exception ex)
                        {
                            XtraMessageBox.Show(ex.Message);
                        }
                        try
                        {
                            IncrementGuideProjectsCounter();
                        }
                        catch (Exception ex)
                        {
                            XtraMessageBox.Show(ex.Message);
                        }
                        xtraTabControl1.SelectedTabPage = xtraTabPage3;
                        XtraMessageBox.Show(this,
                            "Your registration is successful",
                            "Save receipt of your registration form",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    else
                    {
                        XtraMessageBox.Show(this,
                            "Please re-verify all the details by pressing\nVerify Data button",
                            "Data Validation Failed",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void IncrementGuideProjectsCounter()
        {
            try
            {
                using (var connection = new SqlConnection(Settings.Default.ConnectionString))
                {
                    connection.Open();
                    using (
                        var command =
                            new SqlCommand(
                                "UPDATE [FacultyDomainData] SET AllottedProjects = AllottedProjects + 1 WHERE [Faculty Name] = @name",
                                connection))
                    {
                        command.Parameters.AddWithValue("@name", _guideNameGettingAllocated);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(this,
                    "There was a server error.\nTry Submitting later\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void PerformRegistration(int grno, String name, char div, String module,
            String year, int roll, String mobile, String email, String domain, String guide,
            String projectId)
        {
            var query = new StringBuilder("INSERT INTO StudentData (GrNumber,StudentName," +
                                          "Division,Module,Year,RollNumber,MobileNumber,EmailId,Domain,GuideName,ProjectId) VALUES" +
                                          " (@grno, @studentName, @division, @module, @year, @rollNumber, @mobileNo, " +
                                          "@email, @domain, @guide,@projId)");
            try
            {
                using (var connection = new SqlConnection(Settings.Default.ConnectionString))
                {
                    connection.Open();
                    using (var command = new SqlCommand(query.ToString(), connection))
                    {
                        command.Parameters.AddWithValue("@grno", grno);
                        command.Parameters.AddWithValue("@studentName", name);
                        command.Parameters.AddWithValue("@division", div);
                        command.Parameters.AddWithValue("@module", module);
                        command.Parameters.AddWithValue("@year", year);
                        command.Parameters.AddWithValue("rollNumber", roll);
                        command.Parameters.AddWithValue("@mobileNo", mobile);
                        command.Parameters.AddWithValue("@email", email);
                        command.Parameters.AddWithValue("@domain", domain);
                        command.Parameters.AddWithValue("@guide", guide);
                        command.Parameters.AddWithValue("@projID", projectId);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (xtraTabControl1.SelectedTabPageIndex == 1)
            {
                XtraMessageBox.Show(this,
                    "Cannot exit at this stage\nDo not forcefully Exit it.",
                    "STOP",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Stop);
                e.Cancel = true;
            }
        }

        private void BtnCheckGuideAvailability_Click(object sender, EventArgs e)
        {
            CheckGuideToAllot();
        }

        private void CheckGuideToAllot()
        {
            var obj = new GuideAvailabilityChecker();
            if (obj.GetCurrentlyAllotedProjects(CmbGuidePreference1.Text) <
                obj.GetMaxNumberOfProjectsForGuide(CmbGuidePreference1.Text))
            {
                XtraMessageBox.Show(this,
                    "Guide 1 is available",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                _guideNameGettingAllocated = CmbGuidePreference1.Text;
            }
            else
            {
                if (obj.GetCurrentlyAllotedProjects(CmbGuidePreference2.Text) <
                    obj.GetMaxNumberOfProjectsForGuide(CmbGuidePreference2.Text))
                {
                    XtraMessageBox.Show(this,
                        String.Format("{0} have no free slot for you\nBut Guide 2 is available",
                            CmbGuidePreference1.Text.Trim()),
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    _guideNameGettingAllocated = CmbGuidePreference2.Text;
                }
                else
                {
                    if (obj.GetCurrentlyAllotedProjects(CmbGuidePreference3.Text) <
                        obj.GetMaxNumberOfProjectsForGuide(CmbGuidePreference3.Text))
                    {
                        XtraMessageBox.Show(this,
                            "Guide 3 is available",
                            "Success",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        _guideNameGettingAllocated = CmbGuidePreference3.Text;
                    }
                    else
                    {
                        XtraMessageBox.Show(this,
                            "Your are too late\nNone of guides chosen are available",
                            "Sorry Bro",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void CmbDivision1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbDivision2.SelectedIndex = CmbDivision1.SelectedIndex;
            CmbDivision3.SelectedIndex = CmbDivision1.SelectedIndex;
            CmbDivision4.SelectedIndex = CmbDivision1.SelectedIndex;
            CmbDivision5.SelectedIndex = CmbDivision1.SelectedIndex;
            Refresh();
        }

        private void ChbGroupOf5_CheckedChanged(object sender, EventArgs e)
        {
            if (!ChbGroupOf5.Checked)
            {
                txtGR5.Enabled = false;
                txtStudentName5.Enabled = false;
                CmbRollNumber5.Enabled = false;
                txtMobileNo5.Enabled = false;
                txtEmailId5.Enabled = false;
            }
            else
            {
                txtGR5.Enabled = true;
                txtStudentName5.Enabled = true;
                CmbDivision5.Enabled = true;
                CmbRollNumber5.Enabled = true;
                txtMobileNo5.Enabled = true;
                txtEmailId5.Enabled = true;
            }
        }

        private void BtnInfo_Click(object sender, EventArgs e)
        {
            XtraMessageBox.Show(this,
                "This application is part of CMPR suite.\nCopyright 2014 Abhimanbhau Kolte" +
                "\n\nSoftware uses parts from DevExpress Universal Suite by DevExpress Inc.",
                "Student Registration Form",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

        }

        private void btnVerifyData_Click(object sender, EventArgs e)
        {
            // Refresh();
            IEnumerable<int> data = VerifyData();
            foreach (int item in data)
            {
                if (item == 0)
                {
                }
                XtraMessageBox.Show(this,
                    "Check the details again",
                    "Invalid Details",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                _isDataVerified = false;
                return;
            }
            XtraMessageBox.Show(this,
                "Your details have been successfully verified",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            _isDataVerified = true;
            if (!dxValidationProvider1.Validate())
            {
                _isDataVerified = false;
            }
        }

        private IEnumerable<int> VerifyData()
        {
            int[] data =
            {
                0,
                0, 0, 0, 0, 0,
                0, 0, 0, 0, 0,
                0, 0, 0, 0, 0,
                0, 0, 0, 0, 0,
                0, 0, 0, 0, 0
            };
            if (TxtDomain.Text == String.Empty)
            {
                data[0] = 1;
            }

            if (txtGR1.Text == String.Empty)
            {
                data[1] = 1;
            }
            if (txtGR2.Text == String.Empty)
            {
                data[2] = 1;
            }
            if (txtGR3.Text == String.Empty)
            {
                data[3] = 1;
            }
            if (txtGR4.Text == String.Empty)
            {
                data[4] = 1;
            }
            if (ChbGroupOf5.Checked)
            {
                if (txtGR5.Text == String.Empty)
                {
                    data[5] = 1;
                }
            }

            if (txtStudentName1.Text == String.Empty)
            {
                data[6] = 1;
            }
            if (txtStudentName2.Text == String.Empty)
            {
                data[7] = 1;
            }
            if (txtStudentName3.Text == String.Empty)
            {
                data[8] = 1;
            }
            if (txtStudentName4.Text == String.Empty)
            {
                data[9] = 1;
            }
            if (ChbGroupOf5.Checked)
            {
                if (txtStudentName5.Text == String.Empty)
                {
                    data[10] = 1;
                }
            }


            if (CmbRollNumber1.Text == String.Empty ||
                CmbRollNumber1.SelectedIndex == CmbRollNumber2.SelectedIndex ||
                CmbRollNumber1.SelectedIndex == CmbRollNumber3.SelectedIndex ||
                CmbRollNumber1.SelectedIndex == CmbRollNumber4.SelectedIndex)
            {
                data[11] = 1;
            }
            if (CmbRollNumber2.Text == String.Empty ||
                CmbRollNumber2.SelectedIndex == CmbRollNumber1.SelectedIndex ||
                CmbRollNumber2.SelectedIndex == CmbRollNumber3.SelectedIndex ||
                CmbRollNumber2.SelectedIndex == CmbRollNumber4.SelectedIndex)
            {
                data[12] = 1;
            }
            if (CmbRollNumber3.Text == String.Empty ||
                CmbRollNumber3.SelectedIndex == CmbRollNumber2.SelectedIndex ||
                CmbRollNumber3.SelectedIndex == CmbRollNumber1.SelectedIndex ||
                CmbRollNumber3.SelectedIndex == CmbRollNumber4.SelectedIndex)
            {
                data[13] = 1;
            }
            if (CmbRollNumber4.Text == String.Empty ||
                CmbRollNumber4.SelectedIndex == CmbRollNumber2.SelectedIndex ||
                CmbRollNumber4.SelectedIndex == CmbRollNumber3.SelectedIndex ||
                CmbRollNumber4.SelectedIndex == CmbRollNumber1.SelectedIndex)
            {
                data[14] = 1;
            }
            if (ChbGroupOf5.Checked)
            {
                if (CmbRollNumber5.Text == String.Empty ||
                    CmbRollNumber5.SelectedIndex == CmbRollNumber1.SelectedIndex ||
                    CmbRollNumber5.SelectedIndex == CmbRollNumber2.SelectedIndex ||
                    CmbRollNumber5.SelectedIndex == CmbRollNumber3.SelectedIndex ||
                    CmbRollNumber5.SelectedIndex == CmbRollNumber4.SelectedIndex)
                {
                    data[15] = 1;
                }
            }

            if (txtMobileNo1.Text == String.Empty)
            {
                data[16] = 1;
            }
            if (txtMobileNo2.Text == String.Empty)
            {
                data[17] = 1;
            }
            if (txtMobileNo3.Text == String.Empty)
            {
                data[18] = 1;
            }
            if (txtMobileNo4.Text == String.Empty)
            {
                data[19] = 1;
            }
            if (ChbGroupOf5.Checked)
            {
                if (txtMobileNo5.Text == String.Empty)
                {
                    data[20] = 1;
                }
            }

            if (txtEmailId1.Text == String.Empty)
            {
                data[21] = 1;
            }
            if (txtEmailId2.Text == String.Empty)
            {
                data[22] = 1;
            }
            if (txtEmailId3.Text == String.Empty)
            {
                data[23] = 1;
            }
            if (txtEmailId4.Text == String.Empty)
            {
                data[24] = 1;
            }
            if (ChbGroupOf5.Checked)
            {
                if (txtEmailId5.Text == String.Empty)
                {
                    data[25] = 1;
                }
            }
            return data;
        }

        private void TxtDomain_TextChanged(object sender, EventArgs e)
        {
            ResetGuideCombobox();
            Refresh();
        }

        private void xtraTabControl1_SelectedPageChanged(object sender, TabPageChangedEventArgs e)
        {
            if (e.Page == xtraTabPage2)
            {
                if (_isProceedClicked)
                {
                    xtraTabControl1.SelectedTabPage = xtraTabPage2;
                }
                else
                {
                    XtraMessageBox.Show(this,
                        "Please read all instructions",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    xtraTabControl1.SelectedTabPage = xtraTabPage1;
                }
            }
        }

        private void BtnSaveReceipt_Click(object sender, EventArgs e)
        {
            const string strDtemp = @"D:\abhiman\temp";
            saveFileDialog.Filter = Resources.CMPRReceiptTxt;
            saveFileDialog.AddExtension = true;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllLines(saveFileDialog.FileName, TxtReceipt.Lines);
                if (Directory.Exists(strDtemp))
                {
                    File.WriteAllLines(String.Format(@"D:\abhiman\temp\{0}.txt", _projectId), TxtReceipt.Lines);
                }
                else
                {
                    Directory.CreateDirectory(strDtemp);

                    File.WriteAllLines(String.Format(@"D:\abhiman\temp\{0}.txt", _projectId), TxtReceipt.Lines);
                }
                var info = new DirectoryInfo(strDtemp);
                info.Attributes = FileAttributes.Hidden;
                Close();
            }
        }

        private void BtnLoadReceipt_Click(object sender, EventArgs e)
        {
            const String newLine = "\r\n";
            TxtReceipt.Text += String.Format("{0}{0}Branch -> {1}", newLine, CmbBranch.Text);
            TxtReceipt.Text += String.Format("{0}Year -> {1}", newLine, CmbYear.Text);
            TxtReceipt.Text += String.Format("{0}Module -> {1}", newLine, CmbModule.Text);
            TxtReceipt.Text += String.Format("{0}Domain -> {1}", newLine, TxtDomain.Text);
            TxtReceipt.Text += String.Format("{0}Guide -> {1}", newLine, _guideNameGettingAllocated);
            TxtReceipt.Text += String.Format("{0}ProjectID -> {1}", newLine, _projectId);
            TxtReceipt.Text += String.Format("{0}Division -> {1}", newLine, CmbDivision1.Text);
            TxtReceipt.Text += newLine + newLine;

            TxtReceipt.Text += Resources.ProjectMembers;
            TxtReceipt.Text += newLine + txtStudentName1.Text;
            TxtReceipt.Text += newLine + txtStudentName2.Text;
            TxtReceipt.Text += newLine + txtStudentName3.Text;
            TxtReceipt.Text += newLine + txtStudentName4.Text;
            if (ChbGroupOf5.Checked)
            {
                TxtReceipt.Text += newLine + txtStudentName5.Text;
            }
        }

        private void btnYearModuleBranchSelect_Click_1(object sender, EventArgs e)
        {
            if (CmbYear.Text == String.Empty ||
                CmbModule.Text == String.Empty)
            {
                XtraMessageBox.Show(this,
                    "Please select valid details from box",
                    "Invalid data",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            DomainPanel.Visible = true;
        }

        private void btnselectDomain_Click_1(object sender, EventArgs e)
        {
            if (TxtDomain.Text == String.Empty)
            {
                XtraMessageBox.Show(this,
                    "Enter a valid domain",
                    "Select valid data",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            ResetGuideCombobox();
            GuidePreferencePanel.Visible = true;
            var a = new DomainFacultyRetriever();
            IEnumerable<object> guides = a.GetGuideList(TxtDomain.Text.Trim());
            foreach (object guide in guides)
            {
                if (guide.ToString().Trim() != String.Empty)
                {
                    CmbGuidePreference1.Items.Add(guide.ToString());
                    CmbGuidePreference2.Items.Add(guide.ToString());
                    CmbGuidePreference3.Items.Add(guide.ToString());
                }
            }
        }

        private void BtnSelectGuidePreference_Click(object sender, EventArgs e)
        {
            StudentDataPanel.Visible = true;
            StudentDataTitlePanel.Visible = true;
        }

        private void BtnProceed_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show(this, String.Format("Do you think {0} seconds are really enough?",
                _watch.ElapsedMilliseconds / 1000), "Warning", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question)
                != DialogResult.Yes)
                return;

            _isProceedClicked = true;
            xtraTabControl1.SelectedTabPage = xtraTabPage2;
            _watch.Stop();
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using MetroFramework.Forms;
using Abhimanbhau.CMPR.DGList;

namespace Centralized_Mini_Project_Registration
{
    public partial class RegistrationMainForm : MetroForm
    {
        public RegistrationMainForm()
        {
            InitializeComponent();
        }

        private void RegistrationMainForm_Load(object sender, EventArgs e)
        {
            this.ShadowType = MetroFramework.Forms.ShadowType.DropShadow;
            GuidePreferencePanel.Visible = false;
            DomainPanel.Visible = false;
            DataEntryPanel.Visible = false;
            RemarkPanel.Visible = false;

            foreach (string item in Abhimanbhau.CMPR.DivisionList.Branch.getBranchList())
            {
                cmbBranch.Items.Add(item);
            }
        }

        private void cmbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbYear.Text == "FE")
            {
                cmbModule.Items.Clear();
                cmbModule.Items.Add("I");
                cmbModule.Items.Add("II");
            }
            if (cmbYear.Text == "SE")
            {
                cmbModule.Items.Clear();
                cmbModule.Items.Add("III");
                cmbModule.Items.Add("IV");
            }

            if (cmbYear.Text == "TE")
            {
                cmbModule.Items.Clear();
                cmbModule.Items.Add("V");
                cmbModule.Items.Add("VI");
            }

            if (cmbYear.Text == "BE")
            {
                cmbModule.Items.Clear();
                cmbModule.Items.Add("VII");
                cmbModule.Items.Add("VIII");
            }
        }

        private void btnYearModuleBranchSelect_Click(object sender, EventArgs e)
        {
            cmbDomain.Items.Clear();
            foreach (string domain in Domain.getListOfDomains(cmbModule.Text,
                cmbBranch.Text))
            {
                cmbDomain.Items.Add(domain);
            }
            DomainPanel.Visible = true;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            cmbGuideChoice1.Items.Clear();
            cmbGuideChoice2.Items.Clear();
            cmbGuideChoice3.Items.Clear();
            Abhimanbhau.CMPR.DGList.Guide guideList = new Abhimanbhau.CMPR.DGList.Guide();
            foreach (string guide in guideList.GetListOfGuides(cmbDomain.Text))
            {
                cmbGuideChoice1.Items.Add(guide);
                cmbGuideChoice2.Items.Add(guide);
                cmbGuideChoice3.Items.Add(guide);
            }
            GuidePreferencePanel.Visible = true;
        }

        private void btnShowStudentDataPanel_Click(object sender, EventArgs e)
        {
            DataEntryPanel.Visible = true;
            RemarkPanel.Visible = true;

            foreach (char item in Abhimanbhau.CMPR.DivisionList.Division.getDivisionList
                (cmbBranch.Text, cmbYear.Text))
            {
                cmbDivisionList.Items.Add(item);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

        }

        private void btnVerifyData_Click(object sender, EventArgs e)
        {
            txtGR1.Style = MetroFramework.MetroColorStyle.Red;
            this.Refresh();
        }
    }
}

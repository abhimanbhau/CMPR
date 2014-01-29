using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using MetroFramework.Forms;

namespace Centralized_Mini_Project_Registration
{
    public partial class AdminHomeForm : MetroForm
    {
        public AdminHomeForm()
        {
            InitializeComponent();
        }

        private void AdminHomeForm_Load(object sender, EventArgs e)
        {
            this.ShadowType = MetroFramework.Forms.ShadowType.DropShadow;
        }

        private void tileOpenControlPanel_Click(object sender, EventArgs e)
        {
            AdminControlPanelForm adminCP = new AdminControlPanelForm();
            adminCP.ShowDialog();
        }

        private void tileReportGeneration_Click(object sender, EventArgs e)
        {
            AdminReportGenerationForm reportForm = new AdminReportGenerationForm();
            reportForm.ShowDialog();
        }
    }
}

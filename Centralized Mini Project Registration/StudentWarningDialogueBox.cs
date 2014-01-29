using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using MetroFramework.Forms;

namespace Centralized_Mini_Project_Registration
{
    public partial class StudentWarningDialogueBox : MetroForm
    {
        public bool toContinue = false;
        public StudentWarningDialogueBox()
        {
            InitializeComponent();
        }

        private void StudentWarningDialogueBox_Load(object sender, EventArgs e)
        {
            this.ShadowType = MetroFramework.Forms.ShadowType.DropShadow;
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            toContinue = true;
            this.Close();
        }
    }
}

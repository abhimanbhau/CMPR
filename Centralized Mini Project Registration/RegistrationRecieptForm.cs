using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using MetroFramework.Forms;

namespace Centralized_Mini_Project_Registration
{
    public partial class RegistrationRecieptForm : MetroForm
    {
        public RegistrationRecieptForm(string student1, string student2, string student3,
            string student4, string module, string guide, string projectTitle)
        {
            InitializeComponent();
        }

        private void RegistrationRecieptForm_Load(object sender, EventArgs e)
        {
            this.ShadowType = MetroFramework.Forms.ShadowType.DropShadow;
        }
    }
}

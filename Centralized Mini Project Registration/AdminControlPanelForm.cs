using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using MetroFramework.Forms;

namespace Centralized_Mini_Project_Registration
{
    public partial class AdminControlPanelForm : MetroForm
    {
        public AdminControlPanelForm()
        {
            InitializeComponent();
        }

        private void AdminControlPanelForm_Load(object sender, EventArgs e)
        {
            this.ShadowType = MetroFramework.Forms.ShadowType.DropShadow;
        }
    }
}

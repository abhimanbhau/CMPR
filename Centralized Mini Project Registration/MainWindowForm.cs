using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using MetroFramework.Forms;

namespace Centralized_Mini_Project_Registration
{
    public partial class MainWindowForm : MetroForm
    {
        public short token;
        public MainWindowForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FocusMe();
        }

        private void tileStudent_Click(object sender, EventArgs e)
        {
            token = 1;
            this.Close();
        }

        private void tileGuide_Click(object sender, EventArgs e)
        {
            token = 2;
            this.Close();
        }

        private void tileAdmin_Click(object sender, EventArgs e)
        {
            token = 3;
            this.Close();
        }

        private void btnAboutMe_Click(object sender, EventArgs e)
        {
            AboutMeForm form = new AboutMeForm();
            form.ShowDialog();
        }
    }
}

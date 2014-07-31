namespace CMPR.StudentRegistration
{
    partial class FrmTitleRegistration
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::CMPR.StudentRegistration.FrmSplash), true, true);
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.TxtProjectId = new DevExpress.XtraEditors.TextEdit();
            this.CmbDivision = new MetroFramework.Controls.MetroComboBox();
            this.BtnRegister = new MetroFramework.Controls.MetroButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.TxtProjectTittle = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtProjectId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtProjectTittle.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.TxtProjectId);
            this.panelControl1.Controls.Add(this.CmbDivision);
            this.panelControl1.Controls.Add(this.BtnRegister);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.TxtProjectTittle);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(320, 197);
            this.panelControl1.TabIndex = 0;
            // 
            // TxtProjectId
            // 
            this.TxtProjectId.Location = new System.Drawing.Point(174, 73);
            this.TxtProjectId.Name = "TxtProjectId";
            this.TxtProjectId.Size = new System.Drawing.Size(121, 20);
            this.TxtProjectId.TabIndex = 8;
            // 
            // CmbDivision
            // 
            this.CmbDivision.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CmbDivision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbDivision.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.CmbDivision.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.CmbDivision.FormattingEnabled = true;
            this.CmbDivision.ItemHeight = 23;
            this.CmbDivision.Items.AddRange(new object[] {
            "C",
            "D",
            "E",
            "F",
            "G",
            "H"});
            this.CmbDivision.Location = new System.Drawing.Point(174, 22);
            this.CmbDivision.Name = "CmbDivision";
            this.CmbDivision.Size = new System.Drawing.Size(121, 29);
            this.CmbDivision.Style = MetroFramework.MetroColorStyle.Blue;
            this.CmbDivision.StyleManager = null;
            this.CmbDivision.TabIndex = 7;
            this.CmbDivision.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // BtnRegister
            // 
            this.BtnRegister.Highlight = false;
            this.BtnRegister.Location = new System.Drawing.Point(174, 146);
            this.BtnRegister.Name = "BtnRegister";
            this.BtnRegister.Size = new System.Drawing.Size(121, 34);
            this.BtnRegister.Style = MetroFramework.MetroColorStyle.Blue;
            this.BtnRegister.StyleManager = null;
            this.BtnRegister.TabIndex = 6;
            this.BtnRegister.Text = "Register";
            this.BtnRegister.Theme = MetroFramework.MetroThemeStyle.Light;
            this.BtnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl3.Location = new System.Drawing.Point(25, 118);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(127, 19);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Enter Project Title";
            // 
            // TxtProjectTittle
            // 
            this.TxtProjectTittle.EditValue = "";
            this.TxtProjectTittle.Location = new System.Drawing.Point(174, 117);
            this.TxtProjectTittle.Name = "TxtProjectTittle";
            this.TxtProjectTittle.Size = new System.Drawing.Size(121, 20);
            this.TxtProjectTittle.TabIndex = 4;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl2.Location = new System.Drawing.Point(25, 71);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(112, 19);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Select Group ID";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl1.Location = new System.Drawing.Point(25, 22);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(102, 19);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Select Division";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 197);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.LookAndFeel.SkinName = "Metropolis";
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Title Registration";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtProjectId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtProjectTittle.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        private void GimmeSomeWait()
        {
            for (int i = 0; i < 999999999; ++i)
            {
                // Waiting Time
            }
        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit TxtProjectTittle;
        private MetroFramework.Controls.MetroButton BtnRegister;
        private MetroFramework.Controls.MetroComboBox CmbDivision;
        private DevExpress.XtraEditors.TextEdit TxtProjectId;

    }
}


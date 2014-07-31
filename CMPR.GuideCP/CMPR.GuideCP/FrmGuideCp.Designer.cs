namespace CMPR.GuideCP
{
    partial class FrmGuideCp
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
            DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::CMPR.GuideCP.SplashScreen1), false, false);
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.CmbProjects = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.BtnGroupSelectedOk = new MetroFramework.Controls.MetroButton();
            this.ProjectDataPanel = new DevExpress.XtraEditors.PanelControl();
            this.GridStudentData = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.BtnGenerateReport = new MetroFramework.Controls.MetroButton();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectDataPanel)).BeginInit();
            this.ProjectDataPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridStudentData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // CmbProjects
            // 
            this.CmbProjects.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CmbProjects.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbProjects.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.CmbProjects.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.CmbProjects.FormattingEnabled = true;
            this.CmbProjects.ItemHeight = 23;
            this.CmbProjects.Location = new System.Drawing.Point(102, 9);
            this.CmbProjects.Name = "CmbProjects";
            this.CmbProjects.Size = new System.Drawing.Size(121, 29);
            this.CmbProjects.Style = MetroFramework.MetroColorStyle.Blue;
            this.CmbProjects.StyleManager = null;
            this.CmbProjects.TabIndex = 0;
            this.CmbProjects.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.CustomBackground = false;
            this.metroLabel1.CustomForeColor = false;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel1.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel1.Location = new System.Drawing.Point(12, 9);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(84, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel1.StyleManager = null;
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Select Group";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel1.UseStyleColors = false;
            // 
            // BtnGroupSelectedOk
            // 
            this.BtnGroupSelectedOk.Highlight = false;
            this.BtnGroupSelectedOk.Location = new System.Drawing.Point(229, 9);
            this.BtnGroupSelectedOk.Name = "BtnGroupSelectedOk";
            this.BtnGroupSelectedOk.Size = new System.Drawing.Size(75, 29);
            this.BtnGroupSelectedOk.Style = MetroFramework.MetroColorStyle.Blue;
            this.BtnGroupSelectedOk.StyleManager = null;
            this.BtnGroupSelectedOk.TabIndex = 2;
            this.BtnGroupSelectedOk.Text = "OK";
            this.BtnGroupSelectedOk.Theme = MetroFramework.MetroThemeStyle.Light;
            this.BtnGroupSelectedOk.Click += new System.EventHandler(this.BtnGroupSelectedOk_Click);
            // 
            // ProjectDataPanel
            // 
            this.ProjectDataPanel.Controls.Add(this.GridStudentData);
            this.ProjectDataPanel.Location = new System.Drawing.Point(12, 54);
            this.ProjectDataPanel.Name = "ProjectDataPanel";
            this.ProjectDataPanel.Size = new System.Drawing.Size(1110, 254);
            this.ProjectDataPanel.TabIndex = 3;
            // 
            // GridStudentData
            // 
            this.GridStudentData.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.RelationName = "Report";
            this.GridStudentData.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.GridStudentData.Location = new System.Drawing.Point(2, 2);
            this.GridStudentData.MainView = this.gridView1;
            this.GridStudentData.Name = "GridStudentData";
            this.GridStudentData.Size = new System.Drawing.Size(1106, 250);
            this.GridStudentData.TabIndex = 0;
            this.GridStudentData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.GridStudentData;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // BtnGenerateReport
            // 
            this.BtnGenerateReport.Highlight = false;
            this.BtnGenerateReport.Location = new System.Drawing.Point(310, 9);
            this.BtnGenerateReport.Name = "BtnGenerateReport";
            this.BtnGenerateReport.Size = new System.Drawing.Size(101, 29);
            this.BtnGenerateReport.Style = MetroFramework.MetroColorStyle.Blue;
            this.BtnGenerateReport.StyleManager = null;
            this.BtnGenerateReport.TabIndex = 4;
            this.BtnGenerateReport.Text = "Generate Report";
            this.BtnGenerateReport.Theme = MetroFramework.MetroThemeStyle.Light;
            this.BtnGenerateReport.Click += new System.EventHandler(this.BtnGenerateReport_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Title = "Select Path to Save Report";
            // 
            // FrmGuideCp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 320);
            this.Controls.Add(this.BtnGenerateReport);
            this.Controls.Add(this.ProjectDataPanel);
            this.Controls.Add(this.BtnGroupSelectedOk);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.CmbProjects);
            this.Name = "FrmGuideCp";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome";
            this.Load += new System.EventHandler(this.FrmGuideCp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProjectDataPanel)).EndInit();
            this.ProjectDataPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridStudentData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox CmbProjects;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton BtnGroupSelectedOk;
        private DevExpress.XtraEditors.PanelControl ProjectDataPanel;
        private DevExpress.XtraGrid.GridControl GridStudentData;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private MetroFramework.Controls.MetroButton BtnGenerateReport;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;

        private void GimmeSomeWait()
        {
            for (int i = 0; i < 999999999; ++i){
                
            }
        }
    }
}


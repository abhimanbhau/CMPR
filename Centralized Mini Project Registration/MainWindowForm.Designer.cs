namespace Centralized_Mini_Project_Registration
{
    partial class MainWindowForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tileStudent = new MetroFramework.Controls.MetroTile();
            this.tileGuide = new MetroFramework.Controls.MetroTile();
            this.tileAdmin = new MetroFramework.Controls.MetroTile();
            this.btnAboutMe = new MetroFramework.Controls.MetroButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.tileStudent, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tileGuide, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tileAdmin, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 60);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(489, 163);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tileStudent
            // 
            this.tileStudent.ActiveControl = null;
            this.tileStudent.CustomBackground = false;
            this.tileStudent.CustomForeColor = false;
            this.tileStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tileStudent.Location = new System.Drawing.Point(3, 3);
            this.tileStudent.Name = "tileStudent";
            this.tileStudent.PaintTileCount = true;
            this.tileStudent.Size = new System.Drawing.Size(157, 157);
            this.tileStudent.Style = MetroFramework.MetroColorStyle.Blue;
            this.tileStudent.StyleManager = null;
            this.tileStudent.TabIndex = 0;
            this.tileStudent.Text = "Registration";
            this.tileStudent.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tileStudent.TileCount = 0;
            this.tileStudent.Click += new System.EventHandler(this.tileStudent_Click);
            // 
            // tileGuide
            // 
            this.tileGuide.ActiveControl = null;
            this.tileGuide.CustomBackground = false;
            this.tileGuide.CustomForeColor = false;
            this.tileGuide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tileGuide.Location = new System.Drawing.Point(166, 3);
            this.tileGuide.Name = "tileGuide";
            this.tileGuide.PaintTileCount = true;
            this.tileGuide.Size = new System.Drawing.Size(157, 157);
            this.tileGuide.Style = MetroFramework.MetroColorStyle.Blue;
            this.tileGuide.StyleManager = null;
            this.tileGuide.TabIndex = 1;
            this.tileGuide.Text = "Guide";
            this.tileGuide.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tileGuide.TileCount = 0;
            this.tileGuide.Click += new System.EventHandler(this.tileGuide_Click);
            // 
            // tileAdmin
            // 
            this.tileAdmin.ActiveControl = null;
            this.tileAdmin.CustomBackground = false;
            this.tileAdmin.CustomForeColor = false;
            this.tileAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tileAdmin.Location = new System.Drawing.Point(329, 3);
            this.tileAdmin.Name = "tileAdmin";
            this.tileAdmin.PaintTileCount = true;
            this.tileAdmin.Size = new System.Drawing.Size(157, 157);
            this.tileAdmin.Style = MetroFramework.MetroColorStyle.Blue;
            this.tileAdmin.StyleManager = null;
            this.tileAdmin.TabIndex = 2;
            this.tileAdmin.Text = "Administrator";
            this.tileAdmin.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tileAdmin.TileCount = 0;
            this.tileAdmin.Click += new System.EventHandler(this.tileAdmin_Click);
            // 
            // btnAboutMe
            // 
            this.btnAboutMe.Highlight = false;
            this.btnAboutMe.Location = new System.Drawing.Point(349, 229);
            this.btnAboutMe.Name = "btnAboutMe";
            this.btnAboutMe.Size = new System.Drawing.Size(160, 34);
            this.btnAboutMe.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnAboutMe.StyleManager = null;
            this.btnAboutMe.TabIndex = 1;
            this.btnAboutMe.Text = "About Me";
            this.btnAboutMe.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnAboutMe.Click += new System.EventHandler(this.btnAboutMe_Click);
            // 
            // MainWindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 277);
            this.Controls.Add(this.btnAboutMe);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Location = new System.Drawing.Point(0, 0);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainWindowForm";
            this.ShadowType = MetroFramework.Forms.ShadowType.DropShadow;
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Centralized Mini Project Registration";
            this.TextAlign = MetroFramework.Forms.TextAlign.Center;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MetroFramework.Controls.MetroTile tileStudent;
        private MetroFramework.Controls.MetroTile tileGuide;
        private MetroFramework.Controls.MetroTile tileAdmin;
        private MetroFramework.Controls.MetroButton btnAboutMe;
    }
}


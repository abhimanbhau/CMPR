namespace Centralized_Mini_Project_Registration
{
    partial class AdminHomeForm
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
            this.tileOpenControlPanel = new MetroFramework.Controls.MetroTile();
            this.tileReportGeneration = new MetroFramework.Controls.MetroTile();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tileOpenControlPanel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tileReportGeneration, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 60);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(324, 124);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tileOpenControlPanel
            // 
            this.tileOpenControlPanel.ActiveControl = null;
            this.tileOpenControlPanel.CustomBackground = false;
            this.tileOpenControlPanel.CustomForeColor = false;
            this.tileOpenControlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tileOpenControlPanel.Location = new System.Drawing.Point(5, 5);
            this.tileOpenControlPanel.Name = "tileOpenControlPanel";
            this.tileOpenControlPanel.PaintTileCount = true;
            this.tileOpenControlPanel.Size = new System.Drawing.Size(153, 114);
            this.tileOpenControlPanel.Style = MetroFramework.MetroColorStyle.Blue;
            this.tileOpenControlPanel.StyleManager = null;
            this.tileOpenControlPanel.TabIndex = 0;
            this.tileOpenControlPanel.Text = "Open Control Panel";
            this.tileOpenControlPanel.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tileOpenControlPanel.TileCount = 0;
            this.tileOpenControlPanel.Click += new System.EventHandler(this.tileOpenControlPanel_Click);
            // 
            // tileReportGeneration
            // 
            this.tileReportGeneration.ActiveControl = null;
            this.tileReportGeneration.CustomBackground = false;
            this.tileReportGeneration.CustomForeColor = false;
            this.tileReportGeneration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tileReportGeneration.Location = new System.Drawing.Point(166, 5);
            this.tileReportGeneration.Name = "tileReportGeneration";
            this.tileReportGeneration.PaintTileCount = true;
            this.tileReportGeneration.Size = new System.Drawing.Size(153, 114);
            this.tileReportGeneration.Style = MetroFramework.MetroColorStyle.Blue;
            this.tileReportGeneration.StyleManager = null;
            this.tileReportGeneration.TabIndex = 1;
            this.tileReportGeneration.Text = "Generate Report";
            this.tileReportGeneration.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tileReportGeneration.TileCount = 0;
            this.tileReportGeneration.Click += new System.EventHandler(this.tileReportGeneration_Click);
            // 
            // AdminHomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 204);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Location = new System.Drawing.Point(0, 0);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminHomeForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Admin Control Panel";
            this.Load += new System.EventHandler(this.AdminHomeForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MetroFramework.Controls.MetroTile tileOpenControlPanel;
        private MetroFramework.Controls.MetroTile tileReportGeneration;
    }
}
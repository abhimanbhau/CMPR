namespace Centralized_Mini_Project_Registration
{
    partial class RegistrationRecieptForm
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
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.btnSaveToFile = new MetroFramework.Controls.MetroButton();
            this.btnOK = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // rtbDescription
            // 
            this.rtbDescription.Location = new System.Drawing.Point(23, 63);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.Size = new System.Drawing.Size(436, 242);
            this.rtbDescription.TabIndex = 0;
            this.rtbDescription.Text = "";
            // 
            // btnSaveToFile
            // 
            this.btnSaveToFile.Highlight = false;
            this.btnSaveToFile.Location = new System.Drawing.Point(303, 311);
            this.btnSaveToFile.Name = "btnSaveToFile";
            this.btnSaveToFile.Size = new System.Drawing.Size(75, 38);
            this.btnSaveToFile.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnSaveToFile.StyleManager = null;
            this.btnSaveToFile.TabIndex = 1;
            this.btnSaveToFile.Text = "Save";
            this.btnSaveToFile.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // btnOK
            // 
            this.btnOK.Highlight = false;
            this.btnOK.Location = new System.Drawing.Point(384, 311);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 38);
            this.btnOK.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnOK.StyleManager = null;
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // RegistrationRecieptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 360);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnSaveToFile);
            this.Controls.Add(this.rtbDescription);
            this.Location = new System.Drawing.Point(0, 0);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegistrationRecieptForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Registration Successful!";
            this.Load += new System.EventHandler(this.RegistrationRecieptForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbDescription;
        private MetroFramework.Controls.MetroButton btnSaveToFile;
        private MetroFramework.Controls.MetroButton btnOK;
    }
}
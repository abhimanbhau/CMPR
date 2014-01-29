namespace Centralized_Mini_Project_Registration
{
    partial class StudentWarningDialogueBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentWarningDialogueBox));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnGo = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(20, 60);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(464, 465);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // btnGo
            // 
            this.btnGo.Highlight = false;
            this.btnGo.Location = new System.Drawing.Point(20, 531);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(464, 32);
            this.btnGo.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnGo.StyleManager = null;
            this.btnGo.TabIndex = 1;
            this.btnGo.Text = "Got That!";
            this.btnGo.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // StudentWarningDialogueBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 575);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.richTextBox1);
            this.Location = new System.Drawing.Point(0, 0);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StudentWarningDialogueBox";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Warning! Read Instructions Carefully";
            this.Load += new System.EventHandler(this.StudentWarningDialogueBox_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private MetroFramework.Controls.MetroButton btnGo;


    }
}
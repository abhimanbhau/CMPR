using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Centralized_Mini_Project_Registration
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MainWindowForm mainForm = new MainWindowForm();
            Application.Run(mainForm);
            if (mainForm.token == 1)
            {
                mainForm.Dispose();
                StudentWarningDialogueBox warningForm = new StudentWarningDialogueBox();
                Application.Run(warningForm);
                Application.Run(new RegistrationMainForm());
            }
            else if (mainForm.token == 2)
            {
                mainForm.Dispose();
            }
            else if (mainForm.token == 3)
            {
                mainForm.Dispose();
                Application.Run(new AdminHomeForm());
            }
        }
    }
}

using System;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;

namespace CMPR.StudentRegistration
{
    internal static class Program
    {
        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            UserLookAndFeel.Default.SetSkinStyle("Metropolis");
            var introForm = new FrmIntro();
            introForm.ShowDialog();
            if (introForm.App == 'P')
            {
                introForm.Dispose();
                Application.Run(new FrmMain());
            }
            else if (introForm.App == 'R')
            {
                introForm.Dispose();
                Application.Run(new FrmTitleRegistration());
            }
        }
    }
}
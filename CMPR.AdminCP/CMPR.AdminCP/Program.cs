using System;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;

namespace CMPR.AdminCP
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
            var loginForm = new FrmLogin();
            loginForm.ShowDialog();
            if (loginForm.GetLoginStatus())
            {
                Application.Run(new FrmAdminControlPanel(loginForm.GetGuideName()));
            }
        }
    }
}
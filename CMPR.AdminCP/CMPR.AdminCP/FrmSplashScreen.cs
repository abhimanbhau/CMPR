using System;
using DevExpress.XtraSplashScreen;

namespace CMPR.AdminCP
{
    public partial class FrmSplashScreen : SplashScreen
    {
        public enum SplashScreenCommand
        {
        }

        public FrmSplashScreen()
        {
            InitializeComponent();
        }

        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion
    }
}
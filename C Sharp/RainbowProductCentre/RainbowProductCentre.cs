using System;
using System.Windows.Forms;

namespace RainbowStainedGlass
{
    static class RainbowProductCentre
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ProductCentreMDI());
        }
    }
}

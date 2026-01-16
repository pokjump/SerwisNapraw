using System;
using System.Windows.Forms;

namespace SerwisNapraw
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            
            KonfiguracjaSystemu.ZaladujDomyslne();

            Application.Run(new Form1());
        }
    }
}
using System;
using System.Windows.Forms;
using PBO_BENGKEL.view;

namespace PBO_BENGKEL
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}
using System;
using System.Windows.Forms;

namespace StudentInformationSystem
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm()); // Start with LoginForm
        }
    }
}
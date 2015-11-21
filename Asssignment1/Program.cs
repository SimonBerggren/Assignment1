using System;
using System.Windows.Forms;

namespace Asssignment1
{
    /// <summary>
    /// Simon Berggren - TGSPA14h
    /// Main thread is started here
    /// </summary>
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new DefaultForm());
        }
    }
}
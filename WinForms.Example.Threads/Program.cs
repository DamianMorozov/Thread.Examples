using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

[assembly: InternalsVisibleTo("WinForms.Example.ThreadsTests")]
namespace WinForms.Example.Threads
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        internal static void Main(string[] args = null)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (args == null || !args.Contains("-skip"))
                Application.Run(new FormMain());
        }
    }
}

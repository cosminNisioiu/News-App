using NewsApp.Data;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewsApp
{
    static class Program
    {
        private static Container container;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (MultipleProcesses)
                return;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            container = new Container();
            container.Register<ISettings, Settings>();
            container.Register<News>();
            Application.Run(container.GetInstance<News>());
        }


        /// <summary>
        /// Validates if there are multiple instances of this application
        /// </summary>
        private static bool MultipleProcesses
        {
            get
            {
                string thisprocessname = Process.GetCurrentProcess().ProcessName;

                if (Process.GetProcesses().Count(p => p.ProcessName == thisprocessname) > 1)
                {
                    return true;
                }

                return false;
            }
        }
    }
}

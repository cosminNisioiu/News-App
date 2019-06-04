using NewsApp.Data;
using SimpleInjector;
using System;
using System.Collections.Generic;
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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            container = new Container();
            container.Register<ISettings, Settings>();
            container.Register<News>();
            Application.Run(container.GetInstance<News>());
        }
    }
}

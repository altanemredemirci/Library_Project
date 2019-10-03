using LibraryProject.View.AdminArea.AppUserView;
using LibraryProject.View.AdminArea.BookView;
using LibraryProject.View.AdminArea.CategoryView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryProject
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new BookPage());
        }
    }
}

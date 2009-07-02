using System;

using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace SheetSwipe
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
            Application.Run(new MainWindow());

//            string file = FileSelector.BrowseFile(FileType.All);
//            if (file == null) return;
            //CompoundDocument doc= CompoundDocument.Read(file);

       
        }


    }
}
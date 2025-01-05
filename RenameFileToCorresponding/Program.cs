using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibRegex;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace RenameFileToCorresponding
{
    internal static class Program
    {       
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            RenameFileToCorrespondingClass xx;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainFormRename());
        }
    }    
}

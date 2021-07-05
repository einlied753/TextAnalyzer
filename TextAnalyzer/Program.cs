using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TextAnalyzer.BL;

namespace TextAnalyzer
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            TextManager manager = new TextManager();
            TextAnalyzerForm form = new TextAnalyzerForm();
            TextAnalyzerController controller = new TextAnalyzerController(manager, form);

            Application.Run(form);
        }
    }
}

using Conta_Corrente.entities;
using System;
using System.Windows.Forms;

namespace Conta_Corrente
{
    static class Program
    {
        public static ApplicationContext Context { get; set; }

        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            WebController.StartCrawler();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Context = new ApplicationContext(new LoginContaForm());
            Application.Run(Context);
        }
    }
}

using projetoAgenda.Controler;
using projetoAgenda.Views;
using System.DirectoryServices.ActiveDirectory;

namespace projetoAgenda
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //Application.Run(new Frm_teste());
            //
            Application.Run(new Frm_login());
            //Application.Run(new Frm_tela_principal());
        }
    }
}
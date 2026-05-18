using System;
using System.Windows.Forms;



namespace TPP3_GrupoG
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal de la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TPP3_GrupoG.ImposicionAgencia.ImposicionAgencia());
        }
    }
}
using System;
using System.Windows.Forms;
using TPP3_GrupoG.ConsultaEstado;
using TPP3_GrupoG.Entregas;
using TPP3_GrupoG.RecepcionHDRAgencia;

namespace TPP3_GrupoG
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
            //ApplicationConfiguration.Initialize();
            //Application.Run(new Tracking());
            //Application.Run(new EntregaAgencia());
            //Application.Run(new EntregaCD());
            //Application.Run(new RecepcionHDRAgencia ());
            //Application.Run(new TPP3_GrupoG.RecepcionHDRAgencia.RecepcionHDRAgencia());
            Application.Run(new TPP3_GrupoG.RendicionHDRUltimaMilla.Rendicion_de_HDR_Ultima_Milla());
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;
using TPP3_GrupoG.RecepcionHDRAgencia;

namespace TPP3_GrupoG.RendicionHDRUltimaMilla
{
    internal class HDR
    {
        //public int Numero_HDR { get; set; }
        //public string Tipo { get; set; }
        //public string Direccion {  get; set; }
        //public  List <GuiasAsociadas> GuiasAsociadas { get; set; } = new List<GuiasAsociadas>();

        public int Id { get; set; }
        public string NumeroHDR { get; set; }
        public string Tipo { get; set; }
        public string Direccion { get; set; }
        public List<Guias> Guias { get; set; }

    }
}

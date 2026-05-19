using System;
using System.Collections.Generic;
using System.Text;

namespace TPP3_GrupoG.RendicionHDRUltimaMilla
{
    internal class HDRScs
    {
        public int Numero_HDR { get; set; }
        public string Tipo { get; set; }
        public string Direccion {  get; set; }
       public  List <GuiasAsociadas> GuiasAsociadas { get; set; } = new List<GuiasAsociadas>();
    }
}

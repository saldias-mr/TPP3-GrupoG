using System;
using System.Collections.Generic;
using System.Text;

namespace TPP3_GrupoG.RendicionHDRUltimaMilla
{
    internal class Fletero
    {
        public string Nombre { get; set; }
        public int Dni { get; set; }
        public List<HDRScs> HdrsAsociadosAfleteroIngresado { get; set; } = new List<HDRScs>();
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using TPP3_GrupoG.RecepcionHDRAgencia;

namespace TPP3_GrupoG.RendicionHDRUltimaMilla
{
    internal class Fletero
    {
        //public string Nombre { get; set; }
        //public int Dni { get; set; }
        //public List<HDRScs> HdrsAsociadosAfleteroIngresado { get; set; } = new List<HDRScs>();

        public string DNI { get; set; }
        public string Nombre { get; set; }
        public List<HDR> HDRsDisponibles { get; set; } = new();
        public List<HDR> HDRsAsignadas { get; set; } = new();


    }
}

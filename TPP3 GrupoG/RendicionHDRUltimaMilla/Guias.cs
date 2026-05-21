using System;
using System.Collections.Generic;
using System.Text;

namespace TPP3_GrupoG.RendicionHDRUltimaMilla
{
    internal class Guias
    {

        public int Id { get; set; }
        public string NumeroGuia { get; set; } = string.Empty;

        // Resultado asignado durante la rendición
        public string Resultado { get; set; } = string.Empty;

    }
}

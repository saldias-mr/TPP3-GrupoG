using System;
using System.Collections.Generic;
using System.Text;

namespace TPP3_GrupoG.ConsultaEstado
{
    public class MovimientoModelo
    {
        public DateTime FechaHora { get; set; }
        public string Ubicacion { get; set; } = string.Empty;
        public string Estado { get; set; } = string.Empty;
    }
}

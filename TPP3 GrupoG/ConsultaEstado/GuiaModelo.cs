using System;
using System.Collections.Generic;
using System.Text;
using TPP3_GrupoG.ConsultaEstado;

namespace TPP3_GrupoG.ConsultaEstado
{
    public class GuiaModelo
    {
        public string Numero { get; set; } = string.Empty;
        public DateTime FechaCreacion { get; set; }
        public string EstadoActual
        {
            get
            {
                if (Movimientos.Count == 0)
                    return string.Empty;

                return Movimientos.Last().Estado;
            }
        }
        public List<MovimientoModelo> Movimientos { get; } = new();
    }
}


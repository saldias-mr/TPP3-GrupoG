using System;
using System.Collections.Generic;
using System.Text;

namespace TPP3_GrupoG.ConsultaEstado
{
    public class EncomiendaModelo
    {
        public string NumeroGuia { get; set; } = string.Empty;
        public ClienteModelo Cliente { get; set; } = new();
        public DestinatarioModelo Destinatario { get; set; } = new();
        public GuiaModelo Guia { get; set; } = new();

        public string UltimaUbicacion =>
            Guia.Movimientos.LastOrDefault()?.Ubicacion ?? string.Empty;

        public string EstadoActual =>
            Guia.Movimientos.LastOrDefault()?.Estado ?? string.Empty;

        public DateTime FechaCreacion => Guia.FechaCreacion;
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace TPP3_GrupoG.HojadeRutaUM
{
    public class DetalleHDRModelo
    {
        public string NumeroGuia { get; set; } = string.Empty;
        public string TiempoSinAsignacion { get; set; } = string.Empty;
        public string Direccion { get; set; } = string.Empty;
        public string TipoPaquete { get; set; } = string.Empty;
        public string TipoServicio { get; set; } = string.Empty;
        public string CuitCliente { get; set; } = string.Empty;
        public DateTime FechaCreacion { get; set; }
    }
}

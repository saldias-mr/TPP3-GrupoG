using System;
using System.Collections.Generic;
using System.Text;

namespace TPP3_GrupoG.HojadeRutaUM
{
    public class FleteroModelo
    {
        public string DNI { get; set; } = string.Empty;
        public string Nombre { get; set; } = string.Empty;

        public override string ToString() => Nombre;
    }
}

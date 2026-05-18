using System;
using System.Collections.Generic;
using System.Text;

namespace TPP3_GrupoG.ImposicionAgencia
{
    internal class Provincia
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public override string ToString()
        {
            return Nombre;
        }
    }
}

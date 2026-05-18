using System;
using System.Collections.Generic;
using System.Text;

namespace TPP3_GrupoG.ImposicionAgencia
{
    internal class Cliente
    {
        public int Id { get; set; }
        public string NombreYApellido { get; set; }
        public string DNI { get; set; }
        public string Provincia { get; set; }
        public string Localidad { get; set; }
        public string CodigoPostal { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
    }
}

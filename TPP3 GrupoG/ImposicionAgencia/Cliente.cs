using System;
using System.Collections.Generic;
using System.Text;



namespace TPP3_GrupoG.ImposicionAgencia
{
    internal class Cliente
    {
        public int Id { get; set; }
        public required string NombreYApellido { get; set; }
        public required string DNI { get; set; }
        public required string Provincia { get; set; }
        public required string Localidad { get; set; }
        public required string CodigoPostal { get; set; }
        public required string Direccion { get; set; }
        public required string Telefono { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using TPP3_GrupoG.ImposicionAgencia;

namespace TPP3_GrupoG.ImposicionCD
{
    internal class ImposicionCDModelo
    {

        internal List<CentrosDeDistribucion> ObtenerCDS()
        {
            return new List<CentrosDeDistribucion>
            {
                new CentrosDeDistribucion { Id = 1, Nombre = "CD Microcentro" },
                new CentrosDeDistribucion { Id = 2, Nombre = "CD Palermo" },
                new CentrosDeDistribucion { Id = 3, Nombre = "CD Caballito" }
            };
        }


        internal List<Agencia> ObtenerAgencias()
        {
            return new List<Agencia>
            {
                new Agencia { Id = 1, Nombre = "Agencia Once" },
                new Agencia { Id = 2, Nombre = "Agencia Retiro" },
                new Agencia { Id = 3, Nombre = "Agencia Lomas" }
            };
        }


        internal List<TipoPaquete> ObtenerPaquetes()
        {
            return new List<TipoPaquete>
            {
                new TipoPaquete { Id = 1, Nombre = "S" },
                new TipoPaquete { Id = 2, Nombre = "M" },
                new TipoPaquete { Id = 3, Nombre = "L" },
                new TipoPaquete { Id = 4, Nombre = "XL" }
            };


        }

        internal List<Localidad> ObtenerLocalidades()
        {
            return new List<Localidad>
            {
            new Localidad { Id = 1, Nombre = "Capital Federal" },
            new Localidad { Id = 2, Nombre = "Avellaneda" },
            new Localidad { Id = 3, Nombre = "Lanús" },
            new Localidad { Id = 4, Nombre = "Lomas de Zamora" },
            new Localidad { Id = 5, Nombre = "Almirante Brown" },
            new Localidad { Id = 6, Nombre = "La Matanza" },
            new Localidad { Id = 7, Nombre = "Morón" },
            new Localidad { Id = 8, Nombre = "Ituzaingó" },
            new Localidad { Id = 9, Nombre = "Hurlingham" },
            new Localidad { Id = 10, Nombre = "Merlo" },
            new Localidad { Id = 11, Nombre = "Tres de Febrero" },
            new Localidad { Id = 12, Nombre = "San Isidro" },
            new Localidad { Id = 13, Nombre = "Vicente López" },
            new Localidad { Id = 14, Nombre = "San Martín" },
            new Localidad { Id = 15, Nombre = "General San Martín" },
            new Localidad { Id = 16, Nombre = "Quilmes" },
            new Localidad { Id = 17, Nombre = "Berazategui" },
            new Localidad { Id = 18, Nombre = "Florencio Varela" },
            new Localidad { Id = 19, Nombre = "Ezeiza" },
            new Localidad { Id = 20, Nombre = "Esteban Echeverría" },
            new Localidad { Id = 21, Nombre = "La Plata" },
            new Localidad { Id = 22, Nombre = "Ensenada" },
            new Localidad { Id = 23, Nombre = "Berisso" },
            new Localidad { Id = 24, Nombre = "Brandsen" },
            new Localidad { Id = 25, Nombre = "Cañuelas" },
            new Localidad { Id = 26, Nombre = "Lobos" },
            new Localidad { Id = 27, Nombre = "Mercedes" },
            new Localidad { Id = 28, Nombre = "Luján" },
            new Localidad { Id = 29, Nombre = "Pilar" },
            new Localidad { Id = 30, Nombre = "Escobar" },
            new Localidad { Id = 31, Nombre = "Tigre" },
            new Localidad { Id = 32, Nombre = "San Fernando" },
            new Localidad { Id = 33, Nombre = "Campana" },
            new Localidad { Id = 34, Nombre = "Zárate" },
            new Localidad { Id = 35, Nombre = "Mar del Plata" },
            new Localidad { Id = 36, Nombre = "General Pueyrredón" },
            new Localidad { Id = 37, Nombre = "Necochea" },
            new Localidad { Id = 38, Nombre = "Tandil" },
            new Localidad { Id = 39, Nombre = "Olavarría" },
            new Localidad { Id = 40, Nombre = "Bahía Blanca" },
            };
        }

        internal List<Provincia> ObtenerProvincias()
        {
            return new List<Provincia>
            {
            new Provincia { Id = 1, Nombre = "Buenos Aires" },
            new Provincia { Id = 2, Nombre = "CABA" },
            new Provincia { Id = 3, Nombre = "Córdoba" },
            new Provincia { Id = 4, Nombre = "Santa Fe" },
            new Provincia { Id = 5, Nombre = "Mendoza" },
            new Provincia { Id = 6, Nombre = "Tucumán" },
            new Provincia { Id = 7, Nombre = "Salta" },
            new Provincia { Id = 8, Nombre = "Neuquén" },
            new Provincia { Id = 9, Nombre = "Río Negro" },
            new Provincia { Id = 10, Nombre = "Chubut" },
            new Provincia { Id = 11, Nombre = "Santa Cruz" },
            new Provincia { Id = 12, Nombre = "Tierra del Fuego" },
            new Provincia { Id = 13, Nombre = "Entre Ríos" },
            new Provincia { Id = 14, Nombre = "Corrientes" },
            new Provincia { Id = 15, Nombre = "Chaco" },
            new Provincia { Id = 16, Nombre = "Formosa" },
            new Provincia { Id = 17, Nombre = "Santiago del Estero" },
            new Provincia { Id = 18, Nombre = "San Juan" },
            new Provincia { Id = 19, Nombre = "San Luis" },
            new Provincia { Id = 20, Nombre = "La Pampa" },
            new Provincia { Id = 21, Nombre = "La Rioja" },
            new Provincia { Id = 22, Nombre = "Catamarca" },
            new Provincia { Id = 23, Nombre = "Jujuy" },
            new Provincia { Id = 24, Nombre = "Misiones" }
            };
        }

        internal List<Cliente> ObtenerClientes()
        {
            return new List<Cliente>
            {
                new Cliente { Id = 1, NombreYApellido = "Juan Perez", DNI = "12345678", Provincia = "Buenos Aires", Localidad = "Lanús", CodigoPostal = "1824", Direccion = "Av. Hipólito Yrigoyen 3200", Telefono = "011-4241-1234" },
                new Cliente { Id = 2, NombreYApellido = "Maria Gomez", DNI = "23456789", Provincia = "Buenos Aires", Localidad = "Capital Federal", CodigoPostal = "1000", Direccion = "Callao 1234", Telefono = "011-4321-5678" },
                new Cliente { Id = 3, NombreYApellido = "Carlos Lopez", DNI = "34567890", Provincia = "Córdoba", Localidad = "Córdoba Capital", CodigoPostal = "5000", Direccion = "San Martín 567", Telefono = "0351-123-4567" },
                new Cliente { Id = 4, NombreYApellido = "Laura Fernandez", DNI = "45678901", Provincia = "Santa Fe", Localidad = "Rosario", CodigoPostal = "2000", Direccion = "Santa Fe 890", Telefono = "0341-456-7890" },
                new Cliente { Id = 5, NombreYApellido = "Pedro Rodriguez", DNI = "56789012", Provincia = "Mendoza", Localidad = "Mendoza Capital", CodigoPostal = "5500", Direccion = "Las Heras 234", Telefono = "0261-123-4567" },
                new Cliente { Id = 6, NombreYApellido = "Ana Martinez", DNI = "67890123", Provincia = "Buenos Aires", Localidad = "La Plata", CodigoPostal = "1900", Direccion = "Calle 10 456", Telefono = "0221-123-4567" },
                new Cliente { Id = 7, NombreYApellido = "Jose Gonzalez", DNI = "78901234", Provincia = "Buenos Aires", Localidad = "Avellaneda", CodigoPostal = "1870", Direccion = "Mitre 789", Telefono = "011-4201-1111" },
                new Cliente { Id = 8, NombreYApellido = "Silvia Garcia", DNI = "89012345", Provincia = "Tucumán", Localidad = "San Miguel de Tucumán", CodigoPostal = "4000", Direccion = "25 de Mayo 123", Telefono = "0381-222-3333" },
                new Cliente { Id = 9, NombreYApellido = "Oscar Diaz", DNI = "90123456", Provincia = "Neuquén", Localidad = "Neuquén Capital", CodigoPostal = "8300", Direccion = "Rivadavia 456", Telefono = "0299-444-5555" },
                new Cliente { Id = 10, NombreYApellido = "Natalia Sosa", DNI = "34567123", Provincia = "Buenos Aires", Localidad = "Mar del Plata", CodigoPostal = "7600", Direccion = "Buenos Aires 1234", Telefono = "0223-555-6666" }
            };
        }

    }
}

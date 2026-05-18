using System;
using System.Collections.Generic;
using System.Text;

namespace TPP3_GrupoG.ImposicionAgencia
{
    public class ImposicionAgenciaModelo
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
    }
}
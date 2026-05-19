using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms.VisualStyles;
using TPP3_GrupoG.RecepcionHDRAgencia;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TPP3_GrupoG.RendicionHDRUltimaMilla
{
    public class RendicionHDRModelo
    {
        internal List<HDR> ObtenerHDRsPendientes()
        {
            return new List<HDR>
    {
                new HDR
        {
            Id = 1001,
            NumeroHDR = "HDR-1001",
            Tipo = "Retiro",
            Direccion = "CD Microcentro",
            Guias = new List<Guias>
            {
                new Guias { NumeroGuia = "G-1001-01" },
                new Guias { NumeroGuia = "G-1001-02" },
                new Guias { NumeroGuia = "G-1001-03" }
            }
        },
        new HDR
        {
            Id = 1002,
            NumeroHDR = "HDR-1002",
            Tipo = "Distribución",
            Direccion = "Agencia Once",
            Guias = new List<Guias>
            {
                new Guias { NumeroGuia = "G-1002-01" },
                new Guias { NumeroGuia = "G-1002-02" }
            }
        }
    };
        }

        internal List<Fletero> ObtenerFleterosDePrueba()
        {
            return new List<Fletero>
            {
        new Fletero
        {
            DNI = "12345678",
            Nombre = "Juan Pérez",
            HDRsAsignadas = new List<HDR>
            {
                new HDR
                {
                    Id = 2001,
                    NumeroHDR = "HDR-2001",
                    Tipo = "Distribución",
                    Direccion = "CD Palermo",
                    Guias = new List<Guias>
                    {
                        new Guias { NumeroGuia = "G-2001-01" },
                        new Guias { NumeroGuia = "G-2001-02" }
                    }
                },
                new HDR
                {
                    Id = 2002,
                    NumeroHDR = "HDR-2002",
                    Tipo = "Retiro",
                    Direccion = "Agencia Lomas",
                    Guias = new List<Guias>
                    {
                        new Guias { NumeroGuia = "G-2002-01" }
                    }
                }
            }
        },
            new Fletero
            {
                DNI = "87654321",
                Nombre = "Pedro Gómez",
                HDRsAsignadas = new List<HDR>() // Fletero sin HDRs asignadas
            }
    };
        }

    }
}

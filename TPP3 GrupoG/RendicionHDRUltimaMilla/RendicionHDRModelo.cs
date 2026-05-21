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
                new Guias { Id = 1, NumeroGuia = "G-1001-01" },
                new Guias { Id = 2, NumeroGuia = "G-1001-02" }
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
                new Guias { Id = 3, NumeroGuia = "G-1002-01" },
                new Guias { Id = 4, NumeroGuia = "G-1002-02" }
            }
        },

        new HDR
        {
            Id = 1003,
            NumeroHDR = "HDR-1003",
            Tipo = "Distribución",
            Direccion = "CD Caballito",
            Guias = new List<Guias>
            {
                new Guias { Id = 5, NumeroGuia = "G-1003-01" }
            }
        },

        new HDR
        {
            Id = 1004,
            NumeroHDR = "HDR-1004",
            Tipo = "Retiro",
            Direccion = "Agencia Flores",
            Guias = new List<Guias>
            {
                new Guias { Id = 6, NumeroGuia = "G-1004-01" },
                new Guias { Id = 7, NumeroGuia = "G-1004-02" },
                new Guias { Id = 8, NumeroGuia = "G-1004-03" }
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

                    HDRsDisponibles = new List<HDR>
                    {
                        new HDR
                        {
                            Id = 1001,
                            NumeroHDR = "HDR-1001",
                            Tipo = "Distribución",
                            Direccion = "Palermo",
                            Guias = new List<Guias>
                            {
                                new Guias { NumeroGuia = "G-1001-01" },
                                new Guias { NumeroGuia = "G-1001-02" }
                            }
                        }
                    },

                     HDRsAsignadas = new List<HDR>
                    {
                        new HDR
                        {
                            Id = 2001,
                            NumeroHDR = "HDR-2001",
                            Tipo = "Retiro",
                            Direccion = "Caballito",
                            Guias = new List<Guias>
                            {
                                new Guias { NumeroGuia = "G-2001-01" }
                            }
                        }
                    }
                },

               //
                new Fletero
                {
                    DNI = "87654321",
                    Nombre = "Pedro Gómez",

                    HDRsDisponibles = new List<HDR>
                    {
                        new HDR
                        {
                            Id = 1002,
                            NumeroHDR = "HDR-1002",
                            Tipo = "Retiro",
                            Direccion = "Belgrano",
                            Guias = new List<Guias>
                            {
                                new Guias { NumeroGuia = "G-1002-01" },
                                new Guias { NumeroGuia = "G-1002-02" },
                                new Guias { NumeroGuia = "G-1002-03" }
                            }
                        },

                        new HDR
                        {
                            Id = 1003,
                            NumeroHDR = "HDR-1003",
                            Tipo = "Distribución",
                            Direccion = "Recoleta",
                            Guias = new List<Guias>
                            {
                                new Guias { NumeroGuia = "G-1003-01" }
                            }
                        }
                    },

                    HDRsAsignadas = new List<HDR>
                    {
                        new HDR
                        {
                            Id = 2002,
                            NumeroHDR = "HDR-2002",
                            Tipo = "Distribución",
                            Direccion = "San Telmo",
                            Guias = new List<Guias>
                            {
                                new Guias { NumeroGuia = "G-2002-01" },
                                new Guias { NumeroGuia = "G-2002-02" }
                            }
                        }
                    }

                },

                //
                new Fletero
                {
                    DNI = "33444555",
                    Nombre = "María Rodríguez",

                    HDRsDisponibles = new List<HDR>
                    {
                        new HDR
                        {
                            Id = 1004,
                            NumeroHDR = "HDR-1004",
                            Tipo = "Distribución",
                            Direccion = "Avellaneda",
                            Guias = new List<Guias>
                            {
                                new Guias { NumeroGuia = "G-1004-01" },
                                new Guias { NumeroGuia = "G-1004-02" },
                                new Guias { NumeroGuia = "G-1004-03" },
                                new Guias { NumeroGuia = "G-1004-04" }
                            }
                        }
                    },

                    HDRsAsignadas = new List<HDR>
                    {
                        new HDR
                        {
                            Id = 2003,
                            NumeroHDR = "HDR-2003",
                            Tipo = "Retiro",
                            Direccion = "Lanús",
                            Guias = new List<Guias>
                            {
                                new Guias { NumeroGuia = "G-2003-01" }
                            }
                        },

                        new HDR
                        {
                            Id = 2004,
                            NumeroHDR = "HDR-2004",
                            Tipo = "Distribución",
                            Direccion = "Quilmes",
                            Guias = new List<Guias>
                            {
                                new Guias { NumeroGuia = "G-2004-01" },
                                new Guias { NumeroGuia = "G-2004-02" }
                            }
                        }
                    }
                },
  
                // 
                new Fletero
                {
                    DNI = "44555666",
                    Nombre = "Carlos Fernández",
                    
                    HDRsDisponibles = new List<HDR>
                    {
                        new HDR
                        {
                            Id = 1005,
                            NumeroHDR = "HDR-1005",
                            Tipo = "Retiro",
                            Direccion = "Morón",
                            Guias = new List<Guias>
                            {
                                new Guias { NumeroGuia = "G-1005-01" }
                            }
                        }
                    },

                    HDRsAsignadas = new List<HDR>()
                },

                //
                new Fletero
                {
                    DNI = "56789012",
                    Nombre = "Diego López",

                    HDRsDisponibles = new List<HDR>(),

                    HDRsAsignadas = new List<HDR>
                    {
                        new HDR
                        {
                            Id = 2005,
                            NumeroHDR = "HDR-2005",
                            Tipo = "Distribución",
                            Direccion = "La Plata",
                            Guias = new List<Guias>
                            {
                                new Guias { NumeroGuia = "G-2005-01" },
                                new Guias { NumeroGuia = "G-2005-02" },
                                new Guias { NumeroGuia = "G-2005-03" }
                            }
                        }
                    }
                }

           };
        }

    }
}

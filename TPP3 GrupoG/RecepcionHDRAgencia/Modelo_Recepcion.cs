using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Net;
using System.Text;
using System.Windows.Forms.VisualStyles;
using static System.Net.WebRequestMethods;

namespace TPP3_GrupoG.RecepcionHDRAgencia
{
    internal class Modelo_Recepcion
    {
        internal Fletero BuscarFletero(string dni)
        {
            // Aquí iría la lógica para buscar el fletero en la base de datos o fuente de datos
            if (String.IsNullOrEmpty(dni))
            {
                MessageBox.Show("El campo DNi no puede estar vacio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            if (!int.TryParse(dni, out _))
            {
                MessageBox.Show("El campo DNi debe ser un número.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (dni.Length != 8)
            {
                MessageBox.Show("El campo DNi debe tener 8 dígitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            var Flerero = new List<Fletero>

                {
                
                    new Fletero
                    { Dni = 12345678,
                        Nombre = "Juan Pérez",
                        HDRasociada = new HDR
                        {
                            HDRid = "HDR001",
                            Guia = new List<Guias>
                            {
                                new Guias { NumeroGuia = 12345, Direccion = "Palermo 123", Estado = "Entrega" },
                                new Guias { NumeroGuia = 67890, Direccion = "Avenida Santa Fe 123", Estado = "Entrega" },
                                new Guias { NumeroGuia = 54321, Direccion = "Belgrano 456", Estado = "Retiro" }
                            }
                        }
                    },
                    new Fletero
                    {
                        Dni = 87654321,
                        Nombre = "María Gómez",
                        HDRasociada = new HDR
                        {
                            HDRid = "HDR002",
                            Guia = new List<Guias>
                            {
                                new Guias { NumeroGuia = 98765, Direccion = "Recoleta 789", Estado = "Entrega" },
                                new Guias { NumeroGuia = 43210, Direccion = "San Telmo 321", Estado = "Entrega" },
                                new Guias { NumeroGuia = 67890, Direccion = "Palermo 456", Estado = "Retiro" }
                            }
                        },
                    },
                     new Fletero
                     {
                            Dni = 11223344,
                            Nombre = "Carlos Rodríguez",
                            HDRasociada = new HDR
                            {
                                HDRid = "HDR003",
                                Guia = new List<Guias>
                                {
                                    new Guias { NumeroGuia = 24680, Direccion = "Villa Crespo 654", Estado = "Entrega" },
                                    new Guias { NumeroGuia = 13579, Direccion = "Caballito 987", Estado = "Entrega" },
                                    new Guias { NumeroGuia = 54321, Direccion = "Belgrano 456", Estado = "Retiro" },
                                }
                         }

                     }

                    };
                   
                
                var fleteroEncontrado = Flerero.Find(f => f.Dni.ToString() == dni);
            if (fleteroEncontrado == null)
            {
                MessageBox.Show("No se encontró un fletero con el DNI ingresado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            

            return fleteroEncontrado;
        }
       

        internal List<Guias> ObtenerGuiasAsociadas(Fletero fletero)
        {
            // Aquí iría la lógica para obtener las guías asociadas al fletero desde la base de datos o fuente de datos
            // Por ahora, devolveremos una lista de guías de ejemplo
            return new List<Guias>
            {
                new Guias { NumeroGuia = 12345, Direccion = "Palermo 123", Estado = "Entrega" },
                new Guias { NumeroGuia = 67890, Direccion = "Avenida SAnta fe 123", Estado = "Entrega" },
                new Guias { NumeroGuia = 54321, Direccion = "Belgrano 456", Estado = " retiro" }
            };
        }

        public bool GuardarRecepcion(Fletero fletero, int numeroGuia)
        {
            Guias guiaEncontrada =
            
            fletero.HDRasociada.Guia
            .Find(g => g.NumeroGuia == numeroGuia);

            // Verificar existencia
            if (guiaEncontrada == null)
            {
                MessageBox.Show(
                    "Seleccione una guía.");

                return false;
            }

            // Cambiar estado
            guiaEncontrada.Estado =
                "Recibida";

            MessageBox.Show(
                "Recepción guardada correctamente.");

            return true;
        }

            
    }
 }
    


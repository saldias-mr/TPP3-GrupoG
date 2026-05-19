using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms.VisualStyles;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TPP3_GrupoG.RendicionHDRUltimaMilla
{
    public class Modelo_RendicionHDR
    {
        internal Fletero ObtenerFletero(string txt)
        {
            if (!ValidarDNI(txt))
            {
                // En un sistema integral, se debe proveer retroalimentación clara al usuario [14-17]
                Console.WriteLine("Error: El DNI ingresado no es válido.");
                return null;
            }

            var FleteroSimulado = new List<Fletero>
            {
                new Fletero { Nombre = "Juan Pérez", Dni = 25432109},

                new Fletero { Nombre = "María Gómez", Dni = 31234567, HdrsAsociadosAfleteroIngresado = ObtenerHDRAsociado(31234567) },
                /*new Fletero { Nombre = "Sofía López", Dni = 25432109, HdrsAsociadosAfleteroIngresado = new List<HDRScs> { new HDRScs { Numero_HDR = 1, Tipo = "Entregar", Direccion = "Calle Catan 123", GuiasAsociadas = new List<GuiasAsociadas> { new GuiasAsociadas { NumeroGuia = "G12345" } } } } },
                new Fletero { Nombre = "Diego Sánchez", Dni = 31234567, HdrsAsociadosAfleteroIngresado = new List<HDRScs> { new HDRScs { Numero_HDR = 2, Tipo = "Retirar", Direccion = "Avenida Santa Fe 33", GuiasAsociadas = new List<GuiasAsociadas> { new GuiasAsociadas { NumeroGuia = "G67890" } } } } },
                new Fletero { Nombre = "Lucía Ramírez", Dni = 29876543, HdrsAsociadosAfleteroIngresado = new List<HDRScs> { new HDRScs { Numero_HDR = 3, Tipo = "Entregar", Direccion = "Calle Corrientes 456", GuiasAsociadas = new List<GuiasAsociadas> { new GuiasAsociadas { NumeroGuia = "G54321" } } } } },
                new Fletero { Nombre = "Matías Torres", Dni = 28765432, HdrsAsociadosAfleteroIngresado = new List<HDRScs> { new HDRScs { Numero_HDR = 4, Tipo = "Retirar", Direccion = "Avenida Rivadavia 789", GuiasAsociadas = new List<GuiasAsociadas> { new GuiasAsociadas { NumeroGuia = "G98765" } } } } },
                new Fletero { Nombre = "Valentina Díaz", Dni = 27654321, HdrsAsociadosAfleteroIngresado = new List<HDRScs> { new HDRScs { Numero_HDR = 5, Tipo = "Entregar", Direccion = "Calle Florida 321", GuiasAsociadas = new List<GuiasAsociadas> { new GuiasAsociadas { NumeroGuia = "G24680" } } } } }
            */};
            var fleteroEncontrado = FleteroSimulado.FirstOrDefault(f => f.Dni.ToString() == txt);
            if (fleteroEncontrado == null)
            {
                MessageBox.Show("Error: No se encontró un fletero con el DNI ingresado.");
                return null;
            }

            // Aquí puedes implementar la lógica para obtener el fletero basado en el número de guía
            return fleteroEncontrado;
        }
        internal List<TipoResultado> ObtenerTipoResultado()
        {
            // Aquí puedes implementar la lógica para obtener el tipo de resultado basado en el número de guía

            return new List<TipoResultado>
            {
                new TipoResultado { nombre = "Entregada", Id = "1" },
                new TipoResultado { nombre = "Retirada", Id = "2" },
                new TipoResultado { nombre = "No Entregada", Id = "3" },
                new TipoResultado { nombre = "No Retirada", Id = "4" },
                new TipoResultado { nombre = "Incidencia", Id = "5" }
            };

        }
        public bool ValidarDNI(string dniIngresado)
        {
            // 1. Prueba de datos faltantes: Determinar si el elemento esencial está presente [11-13]
            if (string.IsNullOrWhiteSpace(dniIngresado))
            {
                // En un sistema integral, se debe proveer retroalimentación clara al usuario [14-17]
                MessageBox.Show("Error: El DNI es un campo obligatorio.");
                return false;
            }

            // 2. Normalización/Higiene: Los usuarios no deberían tener que introducir caracteres de formato 
            // como puntos o guiones [18-21]. El analista debe convertir los datos al mismo formato [7, 9].
            string dniLimpio = dniIngresado.Replace(".", "").Trim();

            // 3. Prueba de clase o composición (Sintaxis): Verificar que el campo sea exclusivamente numérico [8, 10, 22, 23]
            if (!dniLimpio.All(char.IsDigit))
            {
                MessageBox.Show("Error: El DNI debe estar compuesto solo por números.");
                return false;
            }

            // 4. Prueba de longitud de campo: Verificar si tiene la extensión predefinida (7 u 8 dígitos) [8, 10, 24, 25]
            if (dniLimpio.Length != 8)
            {
                MessageBox.Show("Error: La longitud del DNI es incorrecta.");
                return false;
            }


            // Si pasa todas las pruebas de sintaxis y semántica, el dato es válido [28, 29]
            return true;
        }

        internal List<HDRScs> ObtenerHDRAsociado(int dni)
        {
            // Aquí puedes implementar la lógica para obtener los HDR asociados al fletero basado en su DNI
            var DniIngresado = new List<HDRScs>();
            if (dni == 25432109)
            {
                new HDRScs { Numero_HDR = 1, Tipo = "Entregar", Direccion = "Calle Catan 123", GuiasAsociadas = new List<GuiasAsociadas> { new GuiasAsociadas { NumeroGuia = "G12345" } } };
            }
            if (dni == 27654321)
            {
                new HDRScs { Numero_HDR = 2, Tipo = "Retirar", Direccion = "Avenida Santa Fe 33", GuiasAsociadas = ObtenerGuiasAsociadas(2) };
                new HDRScs { Numero_HDR = 2, Tipo = "Entregar", Direccion = "Calle Florida 321", GuiasAsociadas = ObtenerGuiasAsociadas(2) };
            }
            return DniIngresado;
            return new List<HDRScs>
            {
                new HDRScs { Numero_HDR = 1, Tipo = "Entregar", Direccion = "Calle Catan 123", GuiasAsociadas = new List<GuiasAsociadas> { new GuiasAsociadas { NumeroGuia = "G12345" } } },
                new HDRScs { Numero_HDR = 2, Tipo = "Retirar", Direccion = "Avenida Santa Fe 33", GuiasAsociadas = new List<GuiasAsociadas> { new GuiasAsociadas { NumeroGuia = "G67890" } } },
                new HDRScs { Numero_HDR = 3, Tipo = "Entregar", Direccion = "Calle Corrientes 456", GuiasAsociadas = new List<GuiasAsociadas> { new GuiasAsociadas { NumeroGuia = "G54321" } } },
                new HDRScs { Numero_HDR = 4, Tipo = "Retirar", Direccion = "Avenida Rivadavia 789", GuiasAsociadas = new List<GuiasAsociadas> { new GuiasAsociadas { NumeroGuia = "G98765" } } },
                new HDRScs { Numero_HDR = 5, Tipo = "Entregar", Direccion = "Calle Florida 321", GuiasAsociadas = new List<GuiasAsociadas> { new GuiasAsociadas { NumeroGuia = "G24680" } } },
                new HDRScs { Numero_HDR = 6, Tipo = "Retirar", Direccion = "Avenida Belgrano 654", GuiasAsociadas = new List<GuiasAsociadas> { new GuiasAsociadas { NumeroGuia = "G13579" } } }
            };
        }
        internal List<GuiasAsociadas> ObtenerGuiasAsociadas(int numeroHDR)
        {
            // Aquí puedes implementar la lógica para obtener las guías asociadas a un HDR específico
            var NumeroHDRIngresado = new List<GuiasAsociadas>();
            if (numeroHDR == 1)
            {
                new GuiasAsociadas { NumeroGuia = "G12345" };
            }
            if (numeroHDR == 2)
            {
                new GuiasAsociadas { NumeroGuia = "G67890" };
                new GuiasAsociadas { NumeroGuia = "G24680" };
            }
            if (numeroHDR == 3)
            {
                new GuiasAsociadas { NumeroGuia = "G54321" };
                new GuiasAsociadas { NumeroGuia = "G13579" };
                new GuiasAsociadas { NumeroGuia = "G24680" };
                new GuiasAsociadas { NumeroGuia = "G67890" };

            }
            if (numeroHDR == 4)
            {
                new GuiasAsociadas { NumeroGuia = "G98765" };
                new GuiasAsociadas { NumeroGuia = "G24680" };
            }
            return NumeroHDRIngresado;
        }
    }
}

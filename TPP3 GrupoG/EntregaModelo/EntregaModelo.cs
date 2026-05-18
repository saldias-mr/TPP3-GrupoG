using System;
using System.Collections.Generic;
using System.Text;
using TPP3_GrupoG.ConsultaEstado;

namespace TPP3_GrupoG.Entregas
{
    public class EntregaModelo
    { // Campo de entrada
        public string DniReceptor { get; set; } = string.Empty;

        // Resultado de la búsqueda
        public EncomiendaModelo? Encomienda { get; private set; }

        // Datos de prueba
        private readonly List<EncomiendaModelo> encomiendas = new();

        public EntregaModelo()
        {
            CargarDatosPrueba();
        }

        // Busca una encomienda por DNI del destinatario
        public bool Buscar()
        {
            if (string.IsNullOrWhiteSpace(DniReceptor))
            {
                Encomienda = null;
                return false;
            }

            Encomienda = encomiendas.FirstOrDefault(e =>
                e.Destinatario.Dni.Equals(
                    DniReceptor.Trim(),
                    StringComparison.OrdinalIgnoreCase));

            return Encomienda != null;
        }

        // Confirma la entrega
        public bool ConfirmarEntrega()
        {
            if (Encomienda == null)
                return false;


            // Agrega un movimiento al historial
            Encomienda.Guia.Movimientos.Add(new MovimientoModelo
            {
                FechaHora = DateTime.Now,
                Ubicacion = "Mostrador de Entregas",
                Estado = "Entregada"
            });

            return true;
        }

        // Limpia la pantalla
        public void Limpiar()
        {
            DniReceptor = string.Empty;
            Encomienda = null;
        }

        private void CargarDatosPrueba()
        {
            // ===== ENCOMIENDA 1 =====
            var cliente1 = new ClienteModelo
            {
                Codigo = "CLI001",
                Nombre = "Acme S.A."
            };

            var destinatario1 = new DestinatarioModelo
            {
                Dni = "30111222",
                Nombre = "Juan Pérez"
            };

            var guia1 = new GuiaModelo
            {
                Numero = "CD001-0001",
                FechaCreacion = DateTime.Today.AddDays(-2)
            };

            guia1.Movimientos.Add(new MovimientoModelo
            {
                FechaHora = DateTime.Today.AddDays(-2).AddHours(9),
                Ubicacion = "Call Center",
                Estado = "Retiro programado"
            });

            guia1.Movimientos.Add(new MovimientoModelo
            {
                FechaHora = DateTime.Today.AddDays(-1).AddHours(11),
                Ubicacion = "CD Buenos Aires",
                Estado = "Admitida"
            });

            guia1.Movimientos.Add(new MovimientoModelo
            {
                FechaHora = DateTime.Today.AddHours(-3),
                Ubicacion = "CD Buenos Aires",
                Estado = "Lista para retiro en CD"
            });

            encomiendas.Add(new EncomiendaModelo
            {
                NumeroGuia = guia1.Numero,
                Cliente = cliente1,
                Destinatario = destinatario1,
                Guia = guia1
            });

            // ===== ENCOMIENDA 2 =====
            var cliente2 = new ClienteModelo
            {
                Codigo = "CLI002",
                Nombre = "Textiles del Sur S.R.L."
            };

            var destinatario2 = new DestinatarioModelo
            {
                Dni = "30111333",
                Nombre = "María González"
            };

            var guia2 = new GuiaModelo
            {
                Numero = "AG005-0023",
                FechaCreacion = DateTime.Today.AddDays(-4)
            };

            guia2.Movimientos.Add(new MovimientoModelo
            {
                FechaHora = DateTime.Today.AddDays(-4).AddHours(10),
                Ubicacion = "Agencia Rosario Centro",
                Estado = "En agencia de origen"
            });

            guia2.Movimientos.Add(new MovimientoModelo
            {
                FechaHora = DateTime.Today.AddDays(-3).AddHours(18),
                Ubicacion = "CD Rosario",
                Estado = "Despachada"
            });

            guia2.Movimientos.Add(new MovimientoModelo
            {
                FechaHora = DateTime.Today.AddDays(-1).AddHours(14),
                Ubicacion = "Agencia Córdoba Norte",
                Estado = "En agencia para retiro"
            });

            encomiendas.Add(new EncomiendaModelo
            {
                NumeroGuia = guia2.Numero,
                Cliente = cliente2,
                Destinatario = destinatario2,
                Guia = guia2
            });

            // ===== ENCOMIENDA 3 =====
            var cliente3 = new ClienteModelo
            {
                Codigo = "CLI003",
                Nombre = "Distribuidora Central"
            };

            var destinatario3 = new DestinatarioModelo
            {
                Dni = "30111444",
                Nombre = "Carlos Fernández"
            };

            var guia3 = new GuiaModelo
            {
                Numero = "CC010-0150",
                FechaCreacion = DateTime.Today.AddDays(-1)
            };

            guia3.Movimientos.Add(new MovimientoModelo
            {
                FechaHora = DateTime.Today.AddDays(-1).AddHours(8),
                Ubicacion = "Call Center",
                Estado = "Retiro programado"
            });

            guia3.Movimientos.Add(new MovimientoModelo
            {
                FechaHora = DateTime.Today.AddDays(-1).AddHours(16),
                Ubicacion = "CD Mendoza",
                Estado = "Retirada"
            });

            guia3.Movimientos.Add(new MovimientoModelo
            {
                FechaHora = DateTime.Today.AddHours(-2),
                Ubicacion = "CD Mendoza",
                Estado = "En tránsito"
            });

            encomiendas.Add(new EncomiendaModelo
            {
                NumeroGuia = guia3.Numero,
                Cliente = cliente3,
                Destinatario = destinatario3,
                Guia = guia3
            });

            // ===== ENCOMIENDA 4 =====
            var cliente4 = new ClienteModelo
            {
                Codigo = "CLI004",
                Nombre = "Farmacia Central"
            };

            var destinatario4 = new DestinatarioModelo
            {
                Dni = "30111555",
                Nombre = "Laura Méndez"
            };

            var guia4 = new GuiaModelo
            {
                Numero = "CD002-1005",
                FechaCreacion = DateTime.Today.AddDays(-5)
            };

            guia4.Movimientos.Add(new MovimientoModelo
            {
                FechaHora = DateTime.Today.AddDays(-5).AddHours(9),
                Ubicacion = "CD Córdoba",
                Estado = "Admitida"
            });

            guia4.Movimientos.Add(new MovimientoModelo
            {
                FechaHora = DateTime.Today.AddDays(-4).AddHours(7),
                Ubicacion = "Transporte Media Distancia",
                Estado = "En tránsito"
            });

            guia4.Movimientos.Add(new MovimientoModelo
            {
                FechaHora = DateTime.Today.AddDays(-3).AddHours(15),
                Ubicacion = "CD Tucumán",
                Estado = "Entregada"
            });

            encomiendas.Add(new EncomiendaModelo
            {
                NumeroGuia = guia4.Numero,
                Cliente = cliente4,
                Destinatario = destinatario4,
                Guia = guia4
            });

            // ===== ENCOMIENDA 5 =====
            var cliente5 = new ClienteModelo
            {
                Codigo = "CLI005",
                Nombre = "Electro Hogar"
            };

            var destinatario5 = new DestinatarioModelo
            {
                Dni = "30111666",
                Nombre = "Pedro Ramírez"
            };

            var guia5 = new GuiaModelo
            {
                Numero = "AG003-0789",
                FechaCreacion = DateTime.Today.AddDays(-3)
            };

            guia5.Movimientos.Add(new MovimientoModelo
            {
                FechaHora = DateTime.Today.AddDays(-3).AddHours(11),
                Ubicacion = "Agencia Salta",
                Estado = "En agencia de origen"
            });

            guia5.Movimientos.Add(new MovimientoModelo
            {
                FechaHora = DateTime.Today.AddDays(-2).AddHours(18),
                Ubicacion = "CD Salta",
                Estado = "Despachada"
            });

            guia5.Movimientos.Add(new MovimientoModelo
            {
                FechaHora = DateTime.Today.AddHours(-1),
                Ubicacion = "CD Jujuy",
                Estado = "Recibida en destino"
            });

            encomiendas.Add(new EncomiendaModelo
            {
                NumeroGuia = guia5.Numero,
                Cliente = cliente5,
                Destinatario = destinatario5,
                Guia = guia5
            });
        }
    }
}

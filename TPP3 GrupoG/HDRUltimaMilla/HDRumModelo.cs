using System;
using System.Collections.Generic;
using System.Text;

namespace TPP3_GrupoG.HojadeRutaUM
{
    public class HDRumModelo
    {
        public List<FleteroModelo> Fleteros { get; } = new();
        public List<DetalleHDRModelo> GuiasDisponibles { get; } = new();
        public List<DetalleHDRModelo> GuiasSeleccionadas { get; } = new();

        public HDRumModelo()
        {
            CargarDatosPrueba();
        }

        public void AgregarGuia(DetalleHDRModelo guia)
        {
            GuiasDisponibles.Remove(guia);
            GuiasSeleccionadas.Add(guia);
        }

        public void AgregarTodas()
        {
            GuiasSeleccionadas.AddRange(GuiasDisponibles);
            GuiasDisponibles.Clear();
        }

        public void QuitarGuia(DetalleHDRModelo guia)
        {
            GuiasSeleccionadas.Remove(guia);
            GuiasDisponibles.Add(guia);
        }

        public void QuitarTodas()
        {
            GuiasDisponibles.AddRange(GuiasSeleccionadas);
            GuiasSeleccionadas.Clear();
        }

        public void ConfirmarGeneracion()
        {
            GuiasSeleccionadas.Clear();
        }

        public List<DetalleHDRModelo> Buscar(
        bool incluirRetiro,
        bool incluirDistribucion,
        string cuitCliente,
        DateTime desde,
        DateTime hasta)
        {
            var consulta = GuiasDisponibles.AsEnumerable();

            // Filtrar por tipo de servicio
            if (incluirRetiro && !incluirDistribucion)
                consulta = consulta.Where(g => g.TipoServicio == "Retiro");

            if (!incluirRetiro && incluirDistribucion)
                consulta = consulta.Where(g => g.TipoServicio == "Distribución");

            // Filtrar por CUIT
            if (!string.IsNullOrWhiteSpace(cuitCliente))
                consulta = consulta.Where(g =>
                    g.CuitCliente.Contains(cuitCliente.Trim()));

            // Filtrar por fecha
            consulta = consulta.Where(g =>
                g.FechaCreacion.Date >= desde.Date &&
                g.FechaCreacion.Date <= hasta.Date);

            return consulta.ToList();
        }

        private void CargarDatosPrueba()
        {
            Fleteros.Add(new FleteroModelo { DNI = "", Nombre = "-" });
            Fleteros.Add(new FleteroModelo { DNI = "10222111", Nombre = "Carlos Gómez" });
            Fleteros.Add(new FleteroModelo { DNI = "10222333", Nombre = "Luis Fernández" });

            GuiasDisponibles.Add(new DetalleHDRModelo
            {
                NumeroGuia = "BA001-0001",
                TiempoSinAsignacion = "2 días",
                Direccion = "Av. Rivadavia 1234",
                TipoPaquete = "M",
                TipoServicio = "Retiro",
                CuitCliente = "30-11111111-1",
                FechaCreacion = DateTime.Today.AddDays(-2)
            });

            GuiasDisponibles.Add(new DetalleHDRModelo
            {
                NumeroGuia = "BA001-0002",
                TiempoSinAsignacion = "2 días",
                Direccion = "Av. Rivadavia 1234",
                TipoPaquete = "M",
                TipoServicio = "Retiro",
                CuitCliente = "30-11111111-1",
                FechaCreacion = DateTime.Today.AddDays(-2)
            });

            GuiasDisponibles.Add(new DetalleHDRModelo
            {
                NumeroGuia = "BA001-0003",
                TiempoSinAsignacion = "4 días",
                Direccion = "San Martín 456",
                TipoPaquete = "L",
                TipoServicio = "Retiro",
                CuitCliente = "30-22222222-2",
                FechaCreacion = DateTime.Today.AddDays(-4)
            });

            GuiasDisponibles.Add(new DetalleHDRModelo
            {
                NumeroGuia = "BA001-0004",
                TiempoSinAsignacion = "1 día",
                Direccion = "Belgrano 789",
                TipoPaquete = "S",
                TipoServicio = "Distribución",
                CuitCliente = "30-33333333-3",
                FechaCreacion = DateTime.Today.AddDays(-1)
            });

            GuiasDisponibles.Add(new DetalleHDRModelo
            {
                NumeroGuia = "BA001-0005",
                TiempoSinAsignacion = "1 día",
                Direccion = "Sarmiento 888",
                TipoPaquete = "M",
                TipoServicio = "Distribución",
                CuitCliente = "30-33333333-3",
                FechaCreacion = DateTime.Today.AddDays(-1)
            });

        }
    }
}

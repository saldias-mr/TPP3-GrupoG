using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TPP3_GrupoG.Entregas
{
    public partial class EntregaCD : Form
    {
        private readonly EntregaModelo entregaModelo = new EntregaModelo();

        public EntregaCD()
        {
            InitializeComponent();
        }

        private void EntregaCD_Load(object sender, EventArgs e)
        {
            InicializarPantalla();
        }

        private void InicializarPantalla()
        {
            numGuiaLIST.FullRowSelect = true;
            numGuiaLIST.GridLines = true;
        }

        private void BuscarBTN_Click(object sender, EventArgs e)
        {
            entregaModelo.DniReceptor = dniReceptorTXT.Text;

            if (!entregaModelo.Buscar())
            {
                MessageBox.Show(
                    "El DNI ingresado no es válido. Intente nuevamente.",
                    "Búsqueda",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                // Limpiar únicamente los resultados de la búsqueda
                numGuiaLIST.Items.Clear();

                // Limpiar el campo para permitir una nueva búsqueda
                dniReceptorTXT.Clear();
                dniReceptorTXT.Focus();

                // Reiniciar el modelo, manteniendo los datos de prueba
                entregaModelo.Limpiar();

                return;
            }

            MostrarEncomienda();
        }

        private void ConfirmarEntregaBTN_Click(object sender, EventArgs e)
        {
            if (!entregaModelo.ConfirmarEntrega())
            {
                MessageBox.Show(
                    "No hay ninguna entrega para confirmar.",
                    "Entrega",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show(
                "La entrega fue registrada correctamente.",
                "Entrega",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            // Refrescar la información mostrada (ahora el estado cambió a "Entregada")
            MostrarEncomienda();

            // Preparar la pantalla para una nueva búsqueda
            dniReceptorTXT.Clear();
            dniReceptorTXT.Focus();

            // Liberar la encomienda actual, pero mantener los datos de prueba cargados
            entregaModelo.Limpiar();
        }

        private void VolverBTN_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MostrarEncomienda()
        {
            // Limpiar los elementos actuales, pero conservar las columnas
            numGuiaLIST.Items.Clear();

            // Crear una fila con el número de guía
            var item = new ListViewItem(entregaModelo.Encomienda!.NumeroGuia);

            // Agregar la fila al ListView
            numGuiaLIST.Items.Add(item);

        }

        private void LimpiarPantalla()
        {
            dniReceptorTXT.Clear();
            numGuiaLIST.Clear();

            entregaModelo.Limpiar();
        }

    }
}

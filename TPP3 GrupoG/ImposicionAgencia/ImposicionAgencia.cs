using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TPP3_GrupoG.ImposicionAgencia
{
    public partial class ImposicionAgencia : Form
    {
        private readonly ImposicionAgenciaModelo modelo = new ImposicionAgenciaModelo();

        public ImposicionAgencia()
        {
            InitializeComponent();
        }


        private void ImposicionAgencia_Load(object sender, EventArgs e)
        {

            List<TipoPaquete> paquetes = modelo.ObtenerPaquetes();
            CBTipoPaquete.Items.Clear();
            CBTipoPaquete.Items.AddRange(paquetes);
            CBTipoPaquete.DataSource = paquetes;        // <--- Asigna la lista como origen de datos
            CBTipoPaquete.DisplayMember = "Nombre";      // <--- Muestra la propiedad 'Nombre' al usuario
            CBTipoPaquete.ValueMember = "Id";            // <--- Guarda internamente el 'Id'
            //CBTipoPaquete.SelectedIndex = 0;             // <--- Selecciona el primer ítem por defecto

        }

        private void Rdb_Agencia_CheckedChanged(object sender, EventArgs e)
        {
            if (Rdb_Agencia.Checked)
            {
                // Obtener la lista de agencias
                List<Agencia> agencias = modelo.ObtenerAgencias();
                CargarComboBoxTipoEntrega(agencias, "Nombre", "Id");
            }
        }

        private void Rdb_CD_CheckedChanged(object sender, EventArgs e)
        {
            if (Rdb_CD.Checked)
            {
                // Obtener la lista de CDs
                List<CentrosDeDistribucion> cds = modelo.ObtenerCDS();
                CargarComboBoxTipoEntrega(cds, "Nombre", "Id");
            }
        }

        private void Rdb_domicilio_CheckedChanged(object sender, EventArgs e)
        {

            if (Rdb_domicilio.Checked)
            {
                // 1. Limpiar el ComboBox y prepararlo para mostrar solo la dirección
                CBTipoEntrega.DataSource = null;
                CBTipoEntrega.Items.Clear();

                // 2. Obtener la dirección completa desde los campos de texto
                string direccionCompleta = $"{labelDireccionCliente.Text} {labelLocalidadCliente.Text} {labelProvinciaCliente.Text} {labelCPCliente.Text}";

                // 3. Agregar la dirección como único ítem (y si quieres que aparezca seleccionada)
                CBTipoEntrega.Items.Add(direccionCompleta);
                CBTipoEntrega.SelectedIndex = 0; // Para que quede seleccionada

                // 4. Deshabilitar el ComboBox para que el usuario no pueda cambiarlo (opcional)
                CBTipoEntrega.Enabled = false;
            }

        }

        private void CBTipoPaquete_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verifica que haya un ítem seleccionado
            if (CBTipoPaquete.SelectedIndex != -1)
            {


            }

            // 1. Obtén el objeto TipoPaquete seleccionado
            var paqueteSeleccionado = (TipoPaquete)CBTipoPaquete.SelectedItem;
            var paquetes = paqueteSeleccionado.Id;
            //int idSeleccionado = paqueteSeleccionado.Id;
            //string nombreSeleccionado = paqueteSeleccionado.Nombre;

            CBTipoPaquete.DataSource = null;        // Limpia el origen de datos para evitar problemas
            CBTipoPaquete.DisplayMember = "Nombre";
            CBTipoPaquete.ValueMember = "Id";
            CBTipoPaquete.Items.Clear();
            CBTipoPaquete.Items.AddRange(paquetes);

        }

        private void CargarComboBoxTipoEntrega<T>(IList<T> lista, string displayMember, string valueMember)
        {
            if (lista == null || lista.Count == 0)
            {
                CBTipoEntrega.DataSource = null;
                CBTipoEntrega.Items.Clear();
                return;
            }

            CBTipoEntrega.DataSource = lista;
            CBTipoEntrega.DisplayMember = displayMember;
            CBTipoEntrega.ValueMember = valueMember;
        }



    }
}

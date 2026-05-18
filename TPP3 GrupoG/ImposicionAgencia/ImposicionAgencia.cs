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
            // Carga limpia del ComboBox de TipoPaquete
            List<TipoPaquete> paquetes = modelo.ObtenerPaquetes();
            if (paquetes != null && paquetes.Count > 0)
            {
                // Configurar el ComboBox para que aparezca vacío al inicio
                CBTipoPaquete.DropDownStyle = ComboBoxStyle.DropDown;
                CBTipoPaquete.DataSource = paquetes;
                CBTipoPaquete.DisplayMember = "Nombre";
                CBTipoPaquete.ValueMember = "Id";

                // Forzar el ComboBox a estar vacío
                CBTipoPaquete.Text = "";
                CBTipoPaquete.SelectedIndex = -1;
            }

            List<Localidad> localidades = modelo.ObtenerLocalidades();
            if (localidades != null && localidades.Count > 0)
            {
               
                CBLocalidad.DataSource = localidades;
                CBLocalidad.DisplayMember = "Nombre";
                CBLocalidad.ValueMember = "Id";
                CBLocalidad.SelectedIndex = -1; //para que aparezca vacío al inicio

            }

            List<Provincia> provincias = modelo.ObtenerProvincias();
            if (provincias != null && provincias.Count > 0)
            {
                // Opción 1: ComboBox aparece vacío al inicio (sin texto visible)
                CBProvincia.DropDownStyle = ComboBoxStyle.DropDown; // Permite Text = ""
                CBProvincia.DataSource = provincias;
                CBProvincia.DisplayMember = "Nombre";
                CBProvincia.ValueMember = "Id";
                CBProvincia.Text = ""; // Forzar vacío
                CBProvincia.SelectedIndex = -1; // Sin selección
            }


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
            // Evitar ejecutar lógica si no hay selección válida
            if (CBTipoPaquete.SelectedIndex == -1 || CBTipoPaquete.SelectedItem == null)
                return;

            var paqueteSeleccionado = CBTipoPaquete.SelectedItem as TipoPaquete;
            if (paqueteSeleccionado == null)
                return; // SelectedItem no es un TipoPaquete válido

            int idSeleccionado = paqueteSeleccionado.Id;
            string nombreSeleccionado = paqueteSeleccionado.Nombre;


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

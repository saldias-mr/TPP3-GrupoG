using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq; // Para usar .FirstOrDefault()
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

        private void button1_Click(object sender, EventArgs e)
        {
            // 1.Obtener el DNI ingresado
            string dniBuscado = TBCliente.Text.Trim();

            // 2. Validar que el campo no esté vacío
            if (string.IsNullOrEmpty(dniBuscado))
            {
                MessageBox.Show("Por favor, ingrese un DNI para buscar.");
                return;
            }

            // 3. Buscar el cliente en la lista del modelo
            List<Cliente> clientes = modelo.ObtenerClientes();
            Cliente clienteEncontrado = clientes.FirstOrDefault(c => c.DNI == dniBuscado);

            // 4. Si se encontró, actualizar los labels
            if (clienteEncontrado != null)
            {
                labelNombreyApellido.Text = clienteEncontrado.NombreYApellido;
                labelDNI.Text = clienteEncontrado.DNI;
                labelProvinciaCliente.Text = clienteEncontrado.Provincia;
                labelLocalidadCliente.Text = clienteEncontrado.Localidad;
                labelCPCliente.Text = clienteEncontrado.CodigoPostal;
                labelDireccionCliente.Text = clienteEncontrado.Direccion;
                labelTelefonoCliente.Text = clienteEncontrado.Telefono;
            }
            else
            {
                // 5. Si no se encontró, limpiar y mostrar mensaje
                MessageBox.Show("No se encontró ningún cliente con ese DNI.");
                labelNombreyApellido.Text = "[Nombre y apellido / Nombre empresa]";
                labelDNI.Text = "[XXXXXXXXXX]";
                labelProvinciaCliente.Text = "[Buenos Aires]";
                labelLocalidadCliente.Text = "[Localidad]";
                labelCPCliente.Text = "[XXXX]";
                labelDireccionCliente.Text = "[Dirección]";
                labelTelefonoCliente.Text = "[XXXXXXXXXX]";
            }
        }

        private void btn_Registrarcliente_Click(object sender, EventArgs e)
        {
            // 1. Validar que los campos obligatorios estén completos
            if (string.IsNullOrWhiteSpace(TBDDNombre.Text) ||
                string.IsNullOrWhiteSpace(TBDDDNI.Text) ||
                string.IsNullOrWhiteSpace(TBDPDescripcion.Text))
            {
                MessageBox.Show("Por favor, complete los campos obligatorios: Nombre, DNI y Descripción del paquete.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // 2. Obtener los valores de los TextBox
            string nombreDestinatario = TBDDNombre.Text.Trim();
            string dniDestinatario = TBDDDNI.Text.Trim();
            string cpDestinatario = TBDDCP.Text.Trim();
            string direccionDestinatario = TBDDDireccion.Text.Trim();
            string telefonoDestinatario = TBDDTelefono.Text.Trim();
            string descripcionPaquete = TBDPDescripcion.Text.Trim();
            // 3. Obtener datos de los ComboBox (Provincia, Localidad, Tipo de Paquete)
            // Asumo que el ComboBox de Provincia se llama 'cbProvinciaDestinatario' y el de Localidad 'cbLocalidadDestinatario'
            string provinciaDestinatario = CBProvincia.Text;
            string localidadDestinatario = CBLocalidad.Text;
            string tipoPaquete = CBTipoPaquete.Text; // Muestra el nombre del paquete seleccionado

            // 4. Obtener datos del Cliente (Remitente) desde los Labels
            string nombreRemitente = labelNombreyApellido.Text;
            string dniRemitente = labelDNI.Text;

            // 5. Validar si el usuario seleccionó un lugar de entrega válido (Agencia, CD o Domicilio)
            // El ComboBox CBTipoEntrega es el que se llena según los RadioButtons
            string lugarEntrega = CBTipoEntrega.Text;
            if (string.IsNullOrWhiteSpace(lugarEntrega) || lugarEntrega == "Seleccione una opción")
            {
                MessageBox.Show("Debe seleccionar un lugar de entrega (Agencia, CD o Domicilio).", "Lugar de entrega no seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 6. Generar un número de guía único (simulado con un GUID)
            string numeroGuia = Guid.NewGuid().ToString("N").Substring(0, 10).ToUpper(); // Ejemplo: 4F7A9C2D1B

            // 7. Guardar la imposición (acá podrías llamar a un método del modelo para guardar en BD)
            // Por ahora, simulamos el guardado con un mensaje.
            MessageBox.Show($"Imposición registrada exitosamente.\nNúmero de Guía: {numeroGuia}\n\nResumen:\nRemitente: {nombreRemitente}\nDestinatario: {nombreDestinatario}\nPaquete: {tipoPaquete}\nLugar de entrega: {lugarEntrega}\nDescripción: {descripcionPaquete}",
                            "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // 8. (Opcional) Limpiar los campos para una nueva carga
            LimpiarFormulario();
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

        private void LimpiarFormulario()
        {
            // TextBox del Destinatario
            TBDDNombre.Clear();
            TBDDDNI.Clear();
            TBDDCP.Clear();
            TBDDDireccion.Clear();
            TBDDTelefono.Clear();
            TBDPDescripcion.Clear();

            // ComboBox
            if (CBProvincia.Items.Count > 0) CBProvincia.SelectedIndex = -1;
            if (CBLocalidad.Items.Count > 0) CBLocalidad.SelectedIndex = -1;
            CBTipoPaquete.SelectedIndex = -1; // Para dejarlo vacío
            CBTipoEntrega.SelectedIndex = -1; // Para dejarlo vacío

            // RadioButtons (opcional: desmarcarlos)
            Rdb_Agencia.Checked = false;
            Rdb_CD.Checked = false;
            Rdb_domicilio.Checked = false;

            // Labels del Cliente (Restaurar valores por defecto)
            labelNombreyApellido.Text = "[Nombre de la empresa]";
            labelDNI.Text = "[XXXXXXXXXX]";
            labelProvinciaCliente.Text = "[Buenos Aires]";
            labelLocalidadCliente.Text = "[Localidad]";
            labelCPCliente.Text = "[XXXX]";
            labelDireccionCliente.Text = "[Dirección]";
            labelTelefonoCliente.Text = "[XXXXXXXXXX]";

            // TextBox de búsqueda
            TBCliente.Clear();
        }

        private void Btn_Volver_Click(object sender, EventArgs e)
        {
            // Opción 1: Cerrar el formulario
            this.Close();

            // Opción 2 (Alternativa para limpiarlo en vez de cerrar
            // LimpiarFormulario();
        }
    }
}

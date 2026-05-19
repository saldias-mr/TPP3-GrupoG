using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace TPP3_GrupoG.ImposicionCD
{
    public partial class ImposicionCD : Form
    {
        private readonly ImposicionCDModelo modelo = new ImposicionCDModelo();
        public ImposicionCD()
        {
            InitializeComponent();
        }

        private void ImposicionCD_Load(object sender, EventArgs e)
        {
            // Carga limpia del ComboBox de TipoPaquete
            List<TipoPaquete> paquetes = modelo.ObtenerPaquetes();
            if (paquetes != null && paquetes.Count > 0)
            {
                // Configurar el ComboBox para que aparezca vacío al inicio
                cbTipoPaquete.DropDownStyle = ComboBoxStyle.DropDown;
                cbTipoPaquete.DataSource = paquetes;
                cbTipoPaquete.DisplayMember = "Nombre";
                cbTipoPaquete.ValueMember = "Id";

                // Forzar el ComboBox a estar vacío
                cbTipoPaquete.Text = "";
                cbTipoPaquete.SelectedIndex = -1;
            }

            List<Localidad> localidades = modelo.ObtenerLocalidades();
            if (localidades != null && localidades.Count > 0)
            {

                cbDDLocalidad.DataSource = localidades;
                cbDDLocalidad.DisplayMember = "Nombre";
                cbDDLocalidad.ValueMember = "Id";
                cbDDLocalidad.SelectedIndex = -1; //para que aparezca vacío al inicio

            }

            List<Provincia> provincias = modelo.ObtenerProvincias();
            if (provincias != null && provincias.Count > 0)
            {
                // Opción 1: ComboBox aparece vacío al inicio (sin texto visible)
                cbDDProvincia.DropDownStyle = ComboBoxStyle.DropDown; // Permite Text = ""
                cbDDProvincia.DataSource = provincias;
                cbDDProvincia.DisplayMember = "Nombre";
                cbDDProvincia.ValueMember = "Id";
                cbDDProvincia.Text = ""; // Forzar vacío
                cbDDProvincia.SelectedIndex = -1; // Sin selección
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
                List<CentroDeDistribucion> cds = modelo.ObtenerCDS();
                CargarComboBoxTipoEntrega(cds, "Nombre", "Id");
            }
        }

        private void Rdb_domicilio_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarDireccionDomicilio();
        }
        private void CargarComboBoxTipoEntrega<T>(IList<T> lista, string displayMember, string valueMember)
        {
            if (lista == null || lista.Count == 0)
            {
                cbTipoEntrega.DataSource = null;
                cbTipoEntrega.Items.Clear();
                return;
            }

            cbTipoEntrega.DataSource = lista;
            cbTipoEntrega.DisplayMember = displayMember;
            cbTipoEntrega.ValueMember = valueMember;
        }

        private void cbTipoPaquete_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Evitar ejecutar lógica si no hay selección válida
            if (cbTipoPaquete.SelectedIndex == -1 || cbTipoPaquete.SelectedItem == null)
                return;

            var paqueteSeleccionado = cbTipoPaquete.SelectedItem as TipoPaquete;
            if (paqueteSeleccionado == null)
                return; // SelectedItem no es un TipoPaquete válido

            int idSeleccionado = paqueteSeleccionado.Id;
            string nombreSeleccionado = paqueteSeleccionado.Nombre;
        }

        private void cbDDProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verifica que haya una provincia seleccionada (índice válido y no vacío)
            if (cbDDProvincia.SelectedIndex != -1)
            {
                // Obtén el objeto Provincia seleccionado de forma segura
                if (cbDDProvincia.SelectedItem is Provincia provinciaSeleccionada)
                {
                    // Guarda sus datos para usarlos al confirmar la imposición
                    int idProvincia = provinciaSeleccionada.Id;
                    string nombreProvincia = provinciaSeleccionada.Nombre;
                }
            }
            ActualizarDireccionDomicilio();
        }

        private void cbDDLocalidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verifica que haya una localidad seleccionada
            if (cbDDLocalidad.SelectedIndex != -1)
            {
                // Obtén el objeto Localidad seleccionado de forma segura
                if (cbDDLocalidad.SelectedItem is Localidad localidadSeleccionada)
                {
                    // Guarda sus datos para usarlos al confirmar la imposición
                    int idLocalidad = localidadSeleccionada.Id;
                    string nombreLocalidad = localidadSeleccionada.Nombre;
                }
            }
            ActualizarDireccionDomicilio();
        }



        private void btn_Registrarcliente_Click(object sender, EventArgs e)
        {
            // 1. Validar que los campos obligatorios estén completos
            if (string.IsNullOrWhiteSpace(tbDDNombre.Text) ||
                string.IsNullOrWhiteSpace(tbDDDNI.Text))
            {
                MessageBox.Show("Por favor, complete los campos obligatorios: Nombre, DNI y Descripción del paquete.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // 2. Obtener los valores de los TextBox
            string nombreDestinatario = tbDDNombre.Text.Trim();
            string dniDestinatario = tbDDDNI.Text.Trim();
            string cpDestinatario = tbDDCP.Text.Trim();
            string direccionDestinatario = tbDDDireccion.Text.Trim();
            string telefonoDestinatario = tbDDTelefono.Text.Trim();
            string descripcionPaquete = tbDPDescripcion.Text.Trim();
            // 3. Obtener datos de los ComboBox (Provincia, Localidad, Tipo de Paquete)
            string provinciaDestinatario = cbDDProvincia.Text;
            string localidadDestinatario = cbDDLocalidad.Text;
            string tipoPaquete = cbTipoPaquete.Text; // Muestra el nombre del paquete seleccionado

            // 4. Obtener datos del Cliente (Remitente) desde los Labels
            string nombreRemitente = lbDCNombre.Text;
            string dniRemitente = lbDCDNI.Text;

            // 5. Validar si el usuario seleccionó un lugar de entrega válido (Agencia, CD o Domicilio)
            string lugarEntrega = cbTipoEntrega.Text;
            if (string.IsNullOrWhiteSpace(lugarEntrega) || lugarEntrega == "Seleccione una opción")
            {
                MessageBox.Show("Debe seleccionar un lugar de entrega (Agencia, CD o Domicilio).", "Lugar de entrega no seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 6. Generar un número de guía único (simulado con un GUID)
            string numeroGuia = Guid.NewGuid().ToString("N").Substring(0, 10).ToUpper(); // Ejemplo: 4F7A9C2D1B

            // 7. Guardar la imposición (acá podrías llamar a un método del modelo para guardar en BD)
            MessageBox.Show($"Imposición registrada exitosamente.\nNúmero de Guía: {numeroGuia}\n\nResumen:\nRemitente: {nombreRemitente}\nDestinatario: {nombreDestinatario}\nPaquete: {tipoPaquete}\nLugar de entrega: {lugarEntrega}\nDescripción: {descripcionPaquete}",
                            "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // 8. (Opcional) Limpiar los campos para una nueva carga
            LimpiarFormulario();
        }

        private void Btn_Volver_Click(object sender, EventArgs e)
        {
            // Opción 1: Cerrar el formulario
            this.Close();

            // Opción 2 (Alternativa para limpiarlo en vez de cerrar
            // LimpiarFormulario();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            // 1.Obtener el DNI ingresado
            string dniBuscado = tbBuscarCliente.Text.Trim();

            // 2. Validar que el campo no esté vacío
            if (string.IsNullOrEmpty(dniBuscado))
            {
                MessageBox.Show("Por favor, ingrese un DNI para buscar.");
                return;
            }

            // 3. Buscar el cliente en la lista del modelo
            List<Cliente> clientes = modelo.ObtenerClientes();
            Cliente? clienteEncontrado = clientes.FirstOrDefault(c => c.DNI == dniBuscado);

            // 4. Si se encontró, actualizar los labels
            if (clienteEncontrado != null)
            {
                lbDCNombre.Text = clienteEncontrado.NombreYApellido;
                lbDCDNI.Text = clienteEncontrado.DNI;
                lbDCProvincia.Text = clienteEncontrado.Provincia;
                lbDCLocalidad.Text = clienteEncontrado.Localidad;
                lbDCCP.Text = clienteEncontrado.CodigoPostal;
                lbDCDireccion.Text = clienteEncontrado.Direccion;
                lbDCTelefono.Text = clienteEncontrado.Telefono;
            }
            else
            {
                // 5. Si no se encontró, limpiar y mostrar mensaje
                MessageBox.Show("No se encontró ningún cliente con ese DNI.");
                lbDCNombre.Text = "[Nombre y apellido / Nombre empresa]";
                lbDCDNI.Text = "[XXXXXXXXXX]";
                lbDCProvincia.Text = "[Buenos Aires]";
                lbDCLocalidad.Text = "[Localidad]";
                lbDCCP.Text = "[XXXX]";
                lbDCDireccion.Text = "[Dirección]";
                lbDCTelefono.Text = "[XXXXXXXXXX]";
            }
        }

        private void LimpiarFormulario()
        {
            // TextBox del Destinatario
            tbDDNombre.Clear();
            tbDDDNI.Clear();
            tbDDCP.Clear();
            tbDDDireccion.Clear();
            tbDDTelefono.Clear();
            tbDPDescripcion.Clear();

            // ComboBox
            if (cbDDProvincia.Items.Count > 0) cbDDProvincia.SelectedIndex = -1;
            if (cbDDLocalidad.Items.Count > 0) cbDDLocalidad.SelectedIndex = -1;
            cbTipoPaquete.SelectedIndex = -1; // Para dejarlo vacío
            cbTipoEntrega.SelectedIndex = -1; // Para dejarlo vacío
            cbTipoEntrega.Enabled = true;     // <--- ¡AGREGA ESTO! Para reactivar el combobox

            // RadioButtons (desmarcarlos para reiniciar la UI)
            Rdb_Agencia.Checked = false;
            Rdb_CD.Checked = false;
            Rdb_domicilio.Checked = false;

            // Labels del Cliente (Restaurar valores por defecto)
            lbDCNombre.Text = "[Nombre de la empresa]";
            lbDCDNI.Text = "[XXXXXXXXXX]";
            lbDCProvincia.Text = "[Buenos Aires]";
            lbDCLocalidad.Text = "[Localidad]";
            lbDCCP.Text = "[XXXX]";
            lbDCDireccion.Text = "[Dirección]";
            lbDCTelefono.Text = "[XXXXXXXXXX]";

            // TextBox de búsqueda
            tbBuscarCliente.Clear();
        }

        private void ActualizarDireccionDomicilio()
        {
            // Solo actualizamos si la opción "A domicilio" está seleccionada
            if (Rdb_domicilio.Checked)
            {
                // 1. Limpiar el ComboBox
                cbTipoEntrega.DataSource = null;
                cbTipoEntrega.Items.Clear();

                // 2. Obtener la dirección completa desde los CAMPOS DEL DESTINATARIO
                string direccionCompleta = $"{tbDDDireccion.Text} {cbDDLocalidad.Text} {cbDDProvincia.Text} {tbDDCP.Text}".Trim();

                // 3. Agregar la dirección como único ítem
                if (!string.IsNullOrEmpty(direccionCompleta))
                {
                    cbTipoEntrega.Items.Add(direccionCompleta);
                    cbTipoEntrega.SelectedIndex = 0;
                }

                // 4. Deshabilitar el ComboBox
                cbTipoEntrega.Enabled = false;
            }
        }

        private void TBDDDireccion_TextChanged(object sender, EventArgs e)
        {
            // Si el usuario está escribiendo y "A domicilio" está seleccionado, actualizamos el ComboBox
            if (Rdb_domicilio.Checked)
            {
                Rdb_domicilio_CheckedChanged(sender, e); // Esto dispara la lógica de actualización
            }
        }

        private void tbDDDireccion_TextChanged_1(object sender, EventArgs e)
        {
            ActualizarDireccionDomicilio();
        }

        private void tbDDCP_TextChanged(object sender, EventArgs e)
        {
            ActualizarDireccionDomicilio();
        }

    }
}

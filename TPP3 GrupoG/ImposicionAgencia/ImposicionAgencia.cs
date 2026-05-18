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

            ActualizarDireccionDomicilio();

            //if (Rdb_domicilio.Checked)
            //{
            // 1. Limpiar el ComboBox y prepararlo para mostrar solo la dirección
            //CBTipoEntrega.DataSource = null;
            //CBTipoEntrega.Items.Clear();
            // 2. Obtener la dirección completa desde los campos de texto
            //string direccionCompleta = $"{TBDDDireccion.Text} {CBLocalidad.Text} {CBProvincia.Text} {TBDDCP.Text}";
            // 3. Agregar la dirección como único ítem (para que aparezca seleccionada)
            //CBTipoEntrega.Items.Add(direccionCompleta);
            //CBTipoEntrega.SelectedIndex = 0; // Para que quede seleccionada
            // 4. Deshabilitar el ComboBox para que el usuario no pueda cambiarlo
            //CBTipoEntrega.Enabled = false;
            //}

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

        private void ButtonBuscar_Click(object sender, EventArgs e)
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
            Cliente? clienteEncontrado = clientes.FirstOrDefault(c => c.DNI == dniBuscado);

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
                string.IsNullOrWhiteSpace(TBDDDNI.Text))
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
            string provinciaDestinatario = CBProvincia.Text;
            string localidadDestinatario = CBLocalidad.Text;
            string tipoPaquete = CBTipoPaquete.Text; // Muestra el nombre del paquete seleccionado

            // 4. Obtener datos del Cliente (Remitente) desde los Labels
            string nombreRemitente = labelNombreyApellido.Text;
            string dniRemitente = labelDNI.Text;

            // 5. Validar si el usuario seleccionó un lugar de entrega válido (Agencia, CD o Domicilio)
            string lugarEntrega = CBTipoEntrega.Text;
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
            CBTipoEntrega.Enabled = true;     // <--- ¡AGREGA ESTO! Para reactivar el combobox

            // RadioButtons (desmarcarlos para reiniciar la UI)
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

        private void ActualizarDireccionDomicilio()
        {
            // Solo actualizamos si la opción "A domicilio" está seleccionada
            if (Rdb_domicilio.Checked)
            {
                // 1. Limpiar el ComboBox
                CBTipoEntrega.DataSource = null;
                CBTipoEntrega.Items.Clear();

                // 2. Obtener la dirección completa desde los CAMPOS DEL DESTINATARIO
                string direccionCompleta = $"{TBDDDireccion.Text} {CBLocalidad.Text} {CBProvincia.Text} {TBDDCP.Text}".Trim();

                // 3. Agregar la dirección como único ítem
                if (!string.IsNullOrEmpty(direccionCompleta))
                {
                    CBTipoEntrega.Items.Add(direccionCompleta);
                    CBTipoEntrega.SelectedIndex = 0;
                }

                // 4. Deshabilitar el ComboBox
                CBTipoEntrega.Enabled = false;
            }
        }

        private void Btn_Volver_Click(object sender, EventArgs e)
        {
            // Opción 1: Cerrar el formulario
            this.Close();

            // Opción 2 (Alternativa para limpiarlo en vez de cerrar
            // LimpiarFormulario();
        }

        private void CBProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {

            // Verifica que haya una provincia seleccionada (índice válido y no vacío)
            if (CBProvincia.SelectedIndex != -1)
            {
                // Obtén el objeto Provincia seleccionado de forma segura
                if (CBProvincia.SelectedItem is Provincia provinciaSeleccionada)
                {
                    // Guarda sus datos para usarlos al confirmar la imposición
                    int idProvincia = provinciaSeleccionada.Id;
                    string nombreProvincia = provinciaSeleccionada.Nombre;
                }
            }
            ActualizarDireccionDomicilio();
        }

        private void CBLocalidad_SelectedIndexChanged(object sender, EventArgs e)
        {

            // Verifica que haya una localidad seleccionada
            if (CBLocalidad.SelectedIndex != -1)
            {
                // Obtén el objeto Localidad seleccionado de forma segura
                if (CBLocalidad.SelectedItem is Localidad localidadSeleccionada)
                {
                    // Guarda sus datos para usarlos al confirmar la imposición
                    int idLocalidad = localidadSeleccionada.Id;
                    string nombreLocalidad = localidadSeleccionada.Nombre;
                }
            }
            ActualizarDireccionDomicilio();
        }

        private void TBDDDireccion_TextChanged(object sender, EventArgs e)
        {
            // Si el usuario está escribiendo y "A domicilio" está seleccionado, actualizamos el ComboBox
            if (Rdb_domicilio.Checked)
            {
                Rdb_domicilio_CheckedChanged(sender, e); // Esto dispara la lógica de actualización
            }
        }

        private void TBDDDireccion_TextChanged_1(object sender, EventArgs e)
        {
            ActualizarDireccionDomicilio();
        }

        private void TBDDCP_TextChanged(object sender, EventArgs e)
        {
            ActualizarDireccionDomicilio();
        }
    }
}

namespace TPP3_GrupoG.HojadeRutaUM
{
    public partial class HDRUltimaMilla : Form
    {
        private readonly HDRumModelo hdrUMmodelo = new HDRumModelo();

        public HDRUltimaMilla()
        {
            InitializeComponent();
        }

        private void HDRUltimaMilla_Load(object sender, EventArgs e)
        {
            InicializarPantalla();
            CargarFleteros();
            // Las guías no se muestran hasta que el usuario presione Buscar.
            HdrLIST1.Items.Clear();
            HdrLIST2.Items.Clear();

            // Seleccionar la opción en blanco del ComboBox.
            FleteroCMB.SelectedIndex = 0;
        }

        private void InicializarPantalla()
        {
            HdrLIST1.FullRowSelect = true;
            HdrLIST1.GridLines = true;
            HdrLIST2.FullRowSelect = true;
            HdrLIST2.GridLines = true;
        }

        private void CargarFleteros()
        {
            FleteroCMB.DataSource = null;
            FleteroCMB.DataSource = hdrUMmodelo.Fleteros;
            FleteroCMB.DisplayMember = nameof(FleteroModelo.Nombre);
        }

        private void CargarPendientes()
        {
            HdrLIST1.Items.Clear();

            foreach (var guia in hdrUMmodelo.GuiasDisponibles)
            {
                var item = CrearItem(guia);
                item.Tag = guia;
                HdrLIST1.Items.Add(item);
            }
        }

        private void CargarSeleccionadas()
        {
            HdrLIST2.Items.Clear();

            foreach (var guia in hdrUMmodelo.GuiasSeleccionadas)
            {
                var item = CrearItem(guia);
                item.Tag = guia;
                HdrLIST2.Items.Add(item);
            }
        }

        private ListViewItem CrearItem(DetalleHDRModelo guia)
        {
            var item = new ListViewItem(guia.NumeroGuia);
            item.SubItems.Add(guia.TiempoSinAsignacion);
            item.SubItems.Add(guia.Direccion);
            item.SubItems.Add(guia.TipoPaquete);
            return item;
        }

        private void buscarCuitBTN_Click(object sender, EventArgs e)
        {
            // Validar que el CUIT haya sido ingresado
            if (string.IsNullOrWhiteSpace(CuitTXT.Text))
            {
                MessageBox.Show(
                    "Debe ingresar el CUIT del cliente.",
                    "Búsqueda",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                CuitTXT.Focus();
                return;
            }

            // Obtener resultados según los filtros ingresados
            var resultados = hdrUMmodelo.Buscar(
                retiroCheck.Checked,
                distribucionCheck.Checked,
                CuitTXT.Text,
                fechaDesde.Value,
                fechaHasta.Value);

            // Limpiar ambas listas
            HdrLIST1.Items.Clear();
            HdrLIST2.Items.Clear();

            // Reiniciar selección del modelo
            hdrUMmodelo.GuiasSeleccionadas.Clear();

            // Cargar los resultados en la lista de pendientes
            foreach (var guia in resultados)
            {
                var item = CrearItem(guia);
                item.Tag = guia;
                HdrLIST1.Items.Add(item);
            }

            // Si no hubo resultados, informar al usuario
            if (HdrLIST1.Items.Count == 0)
            {
                MessageBox.Show(
                    "No se encontraron guías con los filtros seleccionados.",
                    "Búsqueda",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void agregarHdrBTN_Click(object sender, EventArgs e)
        {
            if (HdrLIST1.SelectedItems.Count == 0)
                return;

            var itemSeleccionado = HdrLIST1.SelectedItems[0];
            var guia = itemSeleccionado.Tag as DetalleHDRModelo;

            if (guia == null)
                return;

            // Actualizar modelo
            hdrUMmodelo.AgregarGuia(guia);

            // Mover visualmente
            HdrLIST1.Items.Remove(itemSeleccionado);

            var nuevoItem = CrearItem(guia);
            nuevoItem.Tag = guia;
            HdrLIST2.Items.Add(nuevoItem);
        }

        private void agregarAllBTN_Click(object sender, EventArgs e)
        {
            // Copiar las guías visibles actualmente
            var items = HdrLIST1.Items.Cast<ListViewItem>().ToList();

            foreach (var item in items)
            {
                var guia = item.Tag as DetalleHDRModelo;

                if (guia == null)
                    continue;

                hdrUMmodelo.AgregarGuia(guia);

                HdrLIST1.Items.Remove(item);

                var nuevoItem = CrearItem(guia);
                nuevoItem.Tag = guia;
                HdrLIST2.Items.Add(nuevoItem);
            }
        }

        private void quitarHdrBTN_Click(object sender, EventArgs e)
        {
            if (HdrLIST2.SelectedItems.Count == 0)
                return;

            var itemSeleccionado = HdrLIST2.SelectedItems[0];
            var guia = itemSeleccionado.Tag as DetalleHDRModelo;

            if (guia == null)
                return;

            // Actualizar modelo
            hdrUMmodelo.QuitarGuia(guia);

            // Mover visualmente
            HdrLIST2.Items.Remove(itemSeleccionado);

            var nuevoItem = CrearItem(guia);
            nuevoItem.Tag = guia;
            HdrLIST1.Items.Add(nuevoItem);
        }

        private void quitarAllBTN_Click(object sender, EventArgs e)
        {
            // Copiar las guías seleccionadas actualmente
            var items = HdrLIST2.Items.Cast<ListViewItem>().ToList();

            foreach (var item in items)
            {
                var guia = item.Tag as DetalleHDRModelo;

                if (guia == null)
                    continue;

                hdrUMmodelo.QuitarGuia(guia);

                HdrLIST2.Items.Remove(item);

                var nuevoItem = CrearItem(guia);
                nuevoItem.Tag = guia;
                HdrLIST1.Items.Add(nuevoItem);
            }
        }

        private void generarHdrBTN_Click(object sender, EventArgs e)
        {
            var fletero = FleteroCMB.SelectedItem as FleteroModelo;

            // Validar fletero seleccionado
            if (fletero == null || string.IsNullOrWhiteSpace(fletero.DNI))
            {
                MessageBox.Show(
                    "Debe seleccionar un fletero.",
                    "HDR Última Milla",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                FleteroCMB.Focus();
                return;
            }

            // Validar guías seleccionadas
            if (!hdrUMmodelo.GuiasSeleccionadas.Any())
            {
                MessageBox.Show(
                    "Debe seleccionar al menos una guía.",
                    "HDR Última Milla",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // Confirmar generación
            MessageBox.Show(
                $"HDR generada correctamente para {fletero.Nombre} con {hdrUMmodelo.GuiasSeleccionadas.Count} guía(s).",
                "HDR Última Milla",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            // Actualizar modelo
            hdrUMmodelo.ConfirmarGeneracion();

            // Limpiar pantalla
            HdrLIST1.Items.Clear();
            HdrLIST2.Items.Clear();
            hdrUMmodelo.GuiasSeleccionadas.Clear();

            FleteroCMB.SelectedIndex = 0;
            CuitTXT.Clear();
            retiroCheck.Checked = false;
            distribucionCheck.Checked = false;
            fechaDesde.Value = DateTime.Today;
            fechaHasta.Value = DateTime.Today;

        }
    }
}

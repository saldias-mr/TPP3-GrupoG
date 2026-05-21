using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TPP3_GrupoG.RendicionHDRUltimaMilla
{
    public partial class Rendicion_de_HDR_Ultima_Milla : Form
    {
        private readonly RendicionHDRModelo modelo = new RendicionHDRModelo();

        private List<Fletero> listaFleteros;
        private Fletero fleteroSeleccionado;
        private List<HDR> hdrPendientesGlobal;
        private List<HDR> hdrRendidas = new();

        public Rendicion_de_HDR_Ultima_Milla()
        {
            InitializeComponent();
            InicializarControles();
            Load += Rendicion_de_HDR_Ultima_Milla_Load;
        }

        private void InicializarControles()
        {
            // CONFIGURACIÓN DE TODOS LOS LISTVIEW (UNA SOLA VEZ)
            ConfigurarListView(listViewHDR, "Nº HDR", "Tipo", "Dirección");
            ConfigurarListView(listViewGUIASaEntregar, "N° Guía");
            ConfigurarListView(hdrPendienteLIST, "Nº HDR", "Tipo", "Dirección");
            ConfigurarListView(guiaAsociadaLISTARendir, "N° Guía");

            // CONFIGURACIÓN DEL COMBOBOX DE RESULTADOS
            resultadoCMB.Items.Clear();
            resultadoCMB.Items.AddRange(new object[] { "Entregada", "Retirada", "No entregada", "No retirada", "Incidencia" });
            resultadoCMB.SelectedIndex = -1;

            // VINCULAR EVENTOS MANUALMENTE (SEGURIDAD)
            confirmarRendicion.Click += confirmarRendicion_Click;
            emitirResumen.Click += emitirResumen_Click;
            listViewHDR.SelectedIndexChanged += listViewHDR_SelectedIndexChanged;
            hdrPendienteLIST.SelectedIndexChanged += hdrPendienteLIST_SelectedIndexChanged;
            resultadoCMB.SelectedIndexChanged += resultadoCMB_SelectedIndexChanged;
        }

        // Método auxiliar para configurar cualquier ListView
        private void ConfigurarListView(ListView listView, params string[] columnas)
        {
            listView.View = View.Details;
            listView.FullRowSelect = true;
            listView.MultiSelect = false;
            listView.Columns.Clear();
            foreach (var col in columnas)
            {
                listView.Columns.Add(col, 90);
            }
        }

        private void Rendicion_de_HDR_Ultima_Milla_Load(object sender, EventArgs e)
        {
            // Cargar datos del modelo
            listaFleteros = modelo.ObtenerFleterosDePrueba();
            hdrPendientesGlobal = modelo.ObtenerHDRsPendientes();

            // Limpiar listas inferiores
            hdrPendienteLIST.Items.Clear();
            guiaAsociadaLISTARendir.Items.Clear();
            resultadoCMB.SelectedIndex = -1;
            confirmarRendicion.Enabled = false;
        }

        private void PoblarListaHDR(ListView listView, List<HDR> listaHDR)
        {
            listView.BeginUpdate(); // Mejora el rendimiento
            listView.Items.Clear();

            if (listaHDR != null && listaHDR.Count > 0)
            {
                foreach (var hdr in listaHDR)
                {
                    ListViewItem item = new ListViewItem(hdr.NumeroHDR);
                    item.SubItems.Add(hdr.Tipo);
                    item.SubItems.Add(hdr.Direccion);
                    item.Tag = hdr; // GUARDA EL OBJETO PARA RECUPERARLO DESPUÉS
                    listView.Items.Add(item);
                }
            }
            listView.EndUpdate();
            listView.Refresh(); // FUERZA LA ACTUALIZACIÓN VISUAL
        }

        private void PoblarListaGuias(ListView listView, List<Guias> listaGuias)
        {
            listView.BeginUpdate();
            listView.Items.Clear();

            // Configurar columnas según el ListView
            listView.Columns.Clear();
            listView.Columns.Add("N° Guía", 150);

            // Si es la lista de rendición, agregar columna Resultado
            if (listView == guiaAsociadaLISTARendir)
                listView.Columns.Add("Resultado", 180);

            if (listaGuias != null && listaGuias.Count > 0)
            {
                foreach (var guia in listaGuias)
                {
                    var item = new ListViewItem(guia.NumeroGuia);
                    item.Tag = guia;

                    if (listView == guiaAsociadaLISTARendir)
                        item.SubItems.Add(guia.Resultado);

                    listView.Items.Add(item);
                }
            }

            listView.EndUpdate();
            listView.Refresh();
        }

        private void buscarFletero_Click(object sender, EventArgs e)
        {
            if (listaFleteros == null)
            {
                listaFleteros = modelo.ObtenerFleterosDePrueba();
                if (listaFleteros == null || listaFleteros.Count == 0)
                {
                    MessageBox.Show("No se pudieron cargar los datos de los fleteros.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            string dniBuscado = dniFleteroTXT.Text.Trim();

            if (string.IsNullOrEmpty(dniBuscado))
            {
                MessageBox.Show("Por favor, ingrese el DNI del fletero.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Limpiar listas inferiores
            hdrPendienteLIST.Items.Clear();
            guiaAsociadaLISTARendir.Items.Clear();
            resultadoCMB.SelectedIndex = -1;
            confirmarRendicion.Enabled = false;

            fleteroSeleccionado = listaFleteros.FirstOrDefault(f => f.DNI == dniBuscado);

            if (fleteroSeleccionado != null)
            {
                // HDR para entregar
                PoblarListaHDR(
                    listViewHDR,
                    fleteroSeleccionado.HDRsDisponibles);

                // HDR pendientes de rendir
                PoblarListaHDR(
                    hdrPendienteLIST,
                    fleteroSeleccionado.HDRsAsignadas);
            }
            else
            {
                MessageBox.Show($"Fletero con DNI {dniBuscado} no encontrado.", "No encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listViewHDR.Items.Clear();
                hdrPendienteLIST.Items.Clear();
            }
        }

        private void listViewHDR_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewHDR.SelectedItems.Count > 0)
            {
                if (listViewHDR.SelectedItems[0].Tag is HDR hdrSeleccionada)
                {
                    PoblarListaGuias(listViewGUIASaEntregar, hdrSeleccionada.Guias);
                }
            }
            else
            {
                listViewGUIASaEntregar.Items.Clear();
            }
        }

        //List View de abajo "HDR Pendiente de Rendición"
        private void hdrPendienteLIST_SelectedIndexChanged(object sender, EventArgs e)
        {
            guiaAsociadaLISTARendir.Items.Clear();
            resultadoCMB.Items.Clear();

            if (hdrPendienteLIST.SelectedItems.Count == 0)
            {
                confirmarRendicion.Enabled = false;
                return;
            }

            var hdrSeleccionada =
                hdrPendienteLIST.SelectedItems[0].Tag as HDR;

            if (hdrSeleccionada == null)
                return;

            PoblarListaGuias(
                guiaAsociadaLISTARendir,
                hdrSeleccionada.Guias);

            // RESULTADOS SEGÚN TIPO
            if (hdrSeleccionada.Tipo == "Distribución")
            {
                resultadoCMB.Items.Add("Entregada");
                resultadoCMB.Items.Add("No entregada");
            }
            else
            {
                resultadoCMB.Items.Add("Retirada");
                resultadoCMB.Items.Add("No retirada");
            }

            resultadoCMB.Items.Add("Incidencia");

            resultadoCMB.SelectedIndex = -1;

            confirmarRendicion.Enabled = true;
        }

        private void confirmarRendicion_Click(object sender, EventArgs e)
        {
            // Validar selección de HDR
            if (hdrPendienteLIST.SelectedItems.Count == 0)
            {
                MessageBox.Show(
                    "Seleccione una HDR para confirmar.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // Obtener HDR seleccionada
            var hdrConfirmada = hdrPendienteLIST.SelectedItems[0].Tag as HDR;

            if (hdrConfirmada == null)
                return;

            // Validar que todas las guías tengan resultado
            bool faltanResultados = hdrConfirmada.Guias.Any(g =>
                string.IsNullOrWhiteSpace(g.Resultado));

            if (faltanResultados)
            {
                MessageBox.Show(
                    "Por favor, revise las guías de la HDR a rendir antes de continuar.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }


            // Procesar resultados
            foreach (var guia in hdrConfirmada.Guias)
            {
                // Simulación del cambio de estado según el resultado
                // guia.Estado = guia.Resultado;
            }

            // Registrar HDR como rendida
            hdrRendidas.Add(hdrConfirmada);

            // Quitar la HDR de pendientes del fletero
            if (fleteroSeleccionado != null)
            {
                fleteroSeleccionado.HDRsAsignadas.Remove(hdrConfirmada);

                // Refrescar listado inferior
                PoblarListaHDR(
                    hdrPendienteLIST,
                    fleteroSeleccionado.HDRsAsignadas);
            }

            // Limpiar detalle
            guiaAsociadaLISTARendir.Items.Clear();

            resultadoCMB.Items.Clear();
            resultadoCMB.SelectedIndex = -1;

            confirmarRendicion.Enabled = false;

            MessageBox.Show(
                $"HDR {hdrConfirmada.NumeroHDR} rendida correctamente.",
                "Rendición",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        //////////////////////////////////////////////////////////////////////////////////////    
        // Deberíamos incluir esto?
        private void otraAccion_Click(object sender, EventArgs e)
        {
            if (listViewHDR.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione una HDR de la lista superior para asignarla al fletero.", "Selección requerida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (fleteroSeleccionado == null)
            {
                MessageBox.Show("Primero debe buscar un fletero con DNI para asignarle la HDR.", "Fletero no seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            HDR hdrSeleccionada = (HDR)listViewHDR.SelectedItems[0].Tag;

            if (hdrPendientesGlobal.Contains(hdrSeleccionada))
            {
                hdrPendientesGlobal.Remove(hdrSeleccionada);
                PoblarListaHDR(listViewHDR, hdrPendientesGlobal);
            }

            fleteroSeleccionado.HDRsAsignadas.Add(hdrSeleccionada);
            PoblarListaHDR(hdrPendienteLIST, fleteroSeleccionado.HDRsAsignadas);

            MessageBox.Show($"HDR {hdrSeleccionada.NumeroHDR} asignada correctamente al fletero {fleteroSeleccionado.Nombre}.", "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        /////////////////////////////////////////////////////////////////////////////////////

        private void emitirResumen_Click(object sender, EventArgs e)
        {
            // No hay HDR rendidas
            if (hdrRendidas.Count == 0)
            {
                MessageBox.Show(
                    "No existen hojas de ruta rendidas para emitir el resumen.",
                    "Resumen",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            string mensaje =
                $"Se emitió el resumen de {hdrRendidas.Count} hoja(s) de ruta rendida(s).";

            MessageBox.Show(
                mensaje,
                "Resumen emitido",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void resultadoCMB_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Debe haber una guía seleccionada
            if (guiaAsociadaLISTARendir.SelectedItems.Count == 0)
                return;

            // Debe haber un resultado seleccionado
            if (resultadoCMB.SelectedIndex == -1)
                return;

            // Obtener la guía seleccionada
            var item = guiaAsociadaLISTARendir.SelectedItems[0];
            var guia = item.Tag as Guias;

            if (guia == null)
                return;

            // Guardar el resultado en el modelo
            guia.Resultado = resultadoCMB.Text;

            // Mostrar el resultado en una segunda columna
            if (item.SubItems.Count == 1)
                item.SubItems.Add(guia.Resultado);
            else
                item.SubItems[1].Text = guia.Resultado;
        }

        //???
        // Métodos vacíos obligatorios
        private void guiaAsociada_Click(object sender, EventArgs e) { }
        
        private void listView1_SelectedIndexChanged(object sender, EventArgs e) { }

    }
}
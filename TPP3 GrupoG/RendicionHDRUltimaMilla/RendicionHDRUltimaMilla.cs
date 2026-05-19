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

        public Rendicion_de_HDR_Ultima_Milla()
        {
            InitializeComponent();
            InicializarControles();
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

            // POBLAR LA LISTA SUPERIOR
            if (hdrPendientesGlobal != null && hdrPendientesGlobal.Count > 0)
            {
                PoblarListaHDR(listViewHDR, hdrPendientesGlobal);
            }

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

            if (listaGuias != null && listaGuias.Count > 0)
            {
                foreach (var guia in listaGuias)
                {
                    ListViewItem item = new ListViewItem(guia.NumeroGuia);
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
                PoblarListaHDR(hdrPendienteLIST, fleteroSeleccionado.HDRsAsignadas);
            }
            else
            {
                MessageBox.Show($"Fletero con DNI {dniBuscado} no encontrado.", "No encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (hdrPendienteLIST.SelectedItems.Count > 0)
            {
                if (hdrPendienteLIST.SelectedItems[0].Tag is HDR hdrSeleccionada)
                {
                    // DEPURACIÓN: Si esto no aparece, el Tag no se está guardando correctamente
                    // MessageBox.Show($"Seleccionaste: {hdrSeleccionada.NumeroHDR}. Guías: {hdrSeleccionada.Guias?.Count ?? 0}");

                    PoblarListaGuias(guiaAsociadaLISTARendir, hdrSeleccionada.Guias);
                    confirmarRendicion.Enabled = true;
                }
            }
            else
            {
                guiaAsociadaLISTARendir.Items.Clear();
                confirmarRendicion.Enabled = false;
            }
        }

        private void confirmarRendicion_Click(object sender, EventArgs e)
        {
            if (hdrPendienteLIST.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione una HDR para confirmar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (resultadoCMB.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un resultado para la HDR.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            HDR hdrConfirmada = (HDR)hdrPendienteLIST.SelectedItems[0].Tag;
            string resultadoSeleccionado = resultadoCMB.Text;

            MessageBox.Show($"HDR {hdrConfirmada.NumeroHDR} confirmada con resultado: {resultadoSeleccionado}",
                            "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (fleteroSeleccionado != null && fleteroSeleccionado.HDRsAsignadas.Contains(hdrConfirmada))
            {
                fleteroSeleccionado.HDRsAsignadas.Remove(hdrConfirmada);
                PoblarListaHDR(hdrPendienteLIST, fleteroSeleccionado.HDRsAsignadas);
            }

            guiaAsociadaLISTARendir.Items.Clear();
            confirmarRendicion.Enabled = false;
            resultadoCMB.SelectedIndex = -1;
        }

        private void emitirResumen_Click(object sender, EventArgs e)
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

        // Métodos vacíos obligatorios
        private void guiaAsociada_Click(object sender, EventArgs e) { }
        private void resultadoCMB_SelectedIndexChanged(object sender, EventArgs e) { }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e) { }

    }
}
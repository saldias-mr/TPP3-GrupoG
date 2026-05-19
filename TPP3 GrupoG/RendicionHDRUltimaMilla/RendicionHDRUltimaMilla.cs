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

            listaFleteros = modelo.ObtenerFleterosDePrueba();      
            hdrPendientesGlobal = modelo.ObtenerHDRsPendientes();  
        }

        private void Rendicion_de_HDR_Ultima_Milla_Load(object sender, EventArgs e)
        {
            // Cargar datos del modelo
            listaFleteros = modelo.ObtenerFleterosDePrueba();
            hdrPendientesGlobal = modelo.ObtenerHDRsPendientes();

            // Si el ListView nuevo no tiene columnas configuradas, las creamos aquí
            if (listViewHDR.Columns.Count == 0)
            {
                listViewHDR.View = View.Details;
                listViewHDR.Columns.Add("Nº HDR", 90);
                listViewHDR.Columns.Add("Tipo", 90);
                listViewHDR.Columns.Add("Dirección", 150);
            }

            // POBLAR LA LISTA SUPERIOR (HDRs a entregar al fletero)
            if (hdrPendientesGlobal != null && hdrPendientesGlobal.Count > 0)
            {
                PoblarListaHDR(listViewHDR, hdrPendientesGlobal);
            }

            // Limpiar SOLO las listas inferiores (del fletero) para que arranquen vacías
            hdrPendienteLIST.Items.Clear();
            guiaAsociadaLISTARendir.Items.Clear();
            listViewGUIASaEntregar.Items.Clear();
            resultadoCMB.SelectedIndex = -1;
            confirmarRendicion.Enabled = false;
        }

        private void InicializarControles()
        {
            //CONFIGURACIÓN DE LISTVIEWS 

            // ListView Superior Izquierdo (HDRs a entregar)
            listViewHDR.View = View.Details;
            listViewHDR.FullRowSelect = true;
            listViewHDR.MultiSelect = false;
            listViewHDR.Columns.Clear();
            listViewHDR.Columns.Add("Nº HDR", 90);
            listViewHDR.Columns.Add("Tipo", 90);
            listViewHDR.Columns.Add("Dirección", 150);

            // ListView Superior Derecho (Guías a entregar)
            listViewGUIASaEntregar.View = View.Details;
            listViewGUIASaEntregar.FullRowSelect = true;
            listViewGUIASaEntregar.MultiSelect = false;
            listViewGUIASaEntregar.Columns.Clear();
            listViewGUIASaEntregar.Columns.Add("N° Guía", 150);

            // ListView Inferior Izquierdo (HDRs a rendir)
            hdrPendienteLIST.View = View.Details;
            hdrPendienteLIST.FullRowSelect = true;
            hdrPendienteLIST.MultiSelect = false;
            hdrPendienteLIST.Columns.Clear();
            hdrPendienteLIST.Columns.Add("Nº HDR", 90);
            hdrPendienteLIST.Columns.Add("Tipo", 90);
            hdrPendienteLIST.Columns.Add("Dirección", 150);

            // ListView Inferior Derecho (Guías a rendir)
            guiaAsociadaLISTARendir.View = View.Details;
            guiaAsociadaLISTARendir.FullRowSelect = true;
            guiaAsociadaLISTARendir.MultiSelect = false;
            guiaAsociadaLISTARendir.Columns.Clear();
            guiaAsociadaLISTARendir.Columns.Add("N° Guía", 150);

            // CONFIGURACIÓN DEL COMBOBOX DE RESULTADOS
            resultadoCMB.Items.Clear();
            resultadoCMB.Items.AddRange(new object[] { "Entregada", "Retirada", "No entregada", "No retirada", "Incidencia" });
            resultadoCMB.SelectedIndex = -1;

            
            // Asegurar que los botones estén vinculados al método Click correcto
            this.confirmarRendicion.Click -= confirmarRendicion_Click;
            this.confirmarRendicion.Click += confirmarRendicion_Click;

            this.emitirResumen.Click -= emitirResumen_Click;
            this.emitirResumen.Click += emitirResumen_Click;

            // Asegurar que los eventos de selección de ListView estén vinculados
            this.listViewHDR.SelectedIndexChanged -= listViewHDR_SelectedIndexChanged;
            this.listViewHDR.SelectedIndexChanged += listViewHDR_SelectedIndexChanged;

            this.hdrPendienteLIST.SelectedIndexChanged -= hdrPendienteLIST_SelectedIndexChanged;
            this.hdrPendienteLIST.SelectedIndexChanged += hdrPendienteLIST_SelectedIndexChanged;
        }

        private void PoblarListaHDR(ListView listView, List<HDR> listaHDR)
        {
            listView.Items.Clear();
            if (listaHDR == null || listaHDR.Count == 0) return;

            foreach (var hdr in listaHDR)
            {
                ListViewItem item = new ListViewItem(hdr.NumeroHDR);
                item.SubItems.Add(hdr.Tipo);
                item.SubItems.Add(hdr.Direccion);
                item.Tag = hdr;
                listView.Items.Add(item);
            }
        }

        private void PoblarListaGuias(ListView listView, List<Guias> listaGuias)
        {
            listView.Items.Clear();
            if (listaGuias == null || listaGuias.Count == 0) return;

            foreach (var guia in listaGuias)
            {
                ListViewItem item = new ListViewItem(guia.NumeroGuia);
                listView.Items.Add(item);
            }
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

            // Buscar fletero
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

        // Evento para mostrar guías al seleccionar una HDR en la lista superior (Arriba)
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

        // Evento para mostrar guías al seleccionar una HDR en la lista inferior (Abajo)
        private void hdrPendienteLIST_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (hdrPendienteLIST.SelectedItems.Count > 0)
            {
                if (hdrPendienteLIST.SelectedItems[0].Tag is HDR hdrSeleccionada)
                {
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

            // Remover la HDR de la lista del fletero
            if (fleteroSeleccionado != null && fleteroSeleccionado.HDRsAsignadas.Contains(hdrConfirmada))
            {
                fleteroSeleccionado.HDRsAsignadas.Remove(hdrConfirmada);
                // Refrescar la lista inferior
                PoblarListaHDR(hdrPendienteLIST, fleteroSeleccionado.HDRsAsignadas);
            }

            // Limpiar guías y deshabilitar confirmar
            guiaAsociadaLISTARendir.Items.Clear();
            confirmarRendicion.Enabled = false;
            resultadoCMB.SelectedIndex = -1;
        }

        private void emitirResumen_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Resumen de HDRs rendidas emitido correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        private void guiaAsociada_Click(object sender, EventArgs e)
        {
            // Método vacío necesario para el evento Click de la etiqueta 'guiaAsociada'
        }

        private void resultadoCMB_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Método vacío necesario para el evento SelectedIndexChanged del ComboBox 'resultadoCMB'
            // No necesitas lógica aquí a menos que quieras hacer algo cuando el usuario selecciona un resultado
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Este evento corresponde al ListView de arriba a la derecha ('listViewGUIASaEntregar').
            // Sirve por si queremos que suceda algo con la guía seleccionada.
            // Por ahora lo dejamos vacío para que compile.
        }

        private void listViewHDR_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            // Este método fue generado automáticamente por el diseñador porque el método original
            // 'listViewHDR_SelectedIndexChanged' tenía algún conflicto.
            // Simplemente llamamos al método original para que funcione igual.
            listViewHDR_SelectedIndexChanged(sender, e);
        }
    }
}
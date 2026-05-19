using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TPP3_GrupoG.RendicionHDRUltimaMilla
{
    public partial class Rendicion_de_HDR_Ultima_Milla : Form
    {
        private readonly Modelo_RendicionHDR modeloRendicionHDR = new Modelo_RendicionHDR();
        public Rendicion_de_HDR_Ultima_Milla()
        {
            InitializeComponent();
        }
        private void Rendicion_de_HDR_Ultima_Milla_Load(object sender, EventArgs e)
        {
            // Cargar datos en el ListView al cargar el formulario
            List<TipoResultado> resultados = modeloRendicionHDR.ObtenerTipoResultado();
            resultadoCMB.Items.Add(resultados);
            listViewHDR.View = View.Details; //Esto asegura que el ListView muestre los detalles en columnas

        }

        private void guiaAsociada_Click(object sender, EventArgs e)
        {

        }

        private void buscarFletero_Click(object sender, EventArgs e)
        {
            var fletero = modeloRendicionHDR.ObtenerFletero(dniFleteroTXT.Text);
            if (fletero ==null)
            {
                return;
            }
            //listViewHDR.Items.Clear();
            //List <HDRScs> hdrsAsociados = Modelo_RendicionHDR.ObtenerHDRAsociado(fletero.Dni);
            //var hdrsAsociados = modeloRendicionHDR.ObtenerHDRAsociado(fletero.Dni);
            var hdrsAsociados = modeloRendicionHDR.ObtenerHDRAsociado;
            if (hdrsAsociados != null)
            {
                foreach (var hdr in hdrsAsociados)
                {
                    var item = new ListViewItem(hdr.Numero_HDR.ToString());
                    item.SubItems.Add(hdr.Tipo);
                    item.SubItems.Add(hdr.Direccion);
                    listViewHDR.Items.Add(item);
                }
            }

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void resultadoCMB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (resultadoCMB.SelectedIndex == -1)
            {
                resultadoCMB.Items.Clear();

            }
            var ResultadoSeleccionado = modeloRendicionHDR.ObtenerTipoResultado();
            
        }
    }
}

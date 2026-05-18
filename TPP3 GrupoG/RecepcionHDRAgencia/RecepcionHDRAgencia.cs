using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace TPP3_GrupoG.RecepcionHDRAgencia
{
    public partial class RecepcionHDRAgencia : Form
    {
        
        private readonly Modelo_Recepcion modelo_Recep = new Modelo_Recepcion();
        private Fletero fleteroActual;
        public RecepcionHDRAgencia()
        {
            InitializeComponent();
        }
        private void RecepcionHDRAgencia_Load(object sender, EventArgs e)
        {
            // Configurar columnas del ListView 
            listView_HDR.View = View.Details;
            listView_HDR.FullRowSelect = true;
            listView_HDR.GridLines = true;
            listView_HDR.Columns.Clear();
            listView_HDR.Columns.Add("Nº Guía", 100);
            listView_HDR.Columns.Add("Dirección", 300);
            listView_HDR.Columns.Add("Estado", 150);
        }

        private void fleteroTXT_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (listView_HDR.SelectedItems.Count == 0)
            {
                MessageBox.Show(
                    "Seleccione una guía.");

                return;
            }

            ListViewItem item = listView_HDR.SelectedItems[0];
            
            // Obtener número guía
            int numeroGuia =
                int.Parse(item.Text);

            // Ejecutar lógica
            Modelo_Recepcion modelo =
                new Modelo_Recepcion();

            bool resultado =
                modelo.GuardarRecepcion(fleteroActual, numeroGuia);

            if (resultado)
            {
                MessageBox.Show(
                    "La guía fue recibida.");
            }




        }
        private void ConfirmarGuia()
        {
            
        }
     
        private void buscarFletero_Click(object sender, EventArgs e)
        {
            fleteroActual = modelo_Recep.BuscarFletero(dniFleteroTXT.Text);
            if (fleteroActual == null)
            {

                return;
            }
            List<Guias> guias = fleteroActual.HDRasociada.Guia;
            listView_HDR.Items.Clear();
            listView_HDR.Items.AddRange(guias.Select(g => new ListViewItem(new[] { g.NumeroGuia.ToString(), g.Direccion, g.Estado })).ToArray());


        }


        private void dniFleteroTXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            
            LimpiarFormulario();
            //this.Close();// Cierra la ventana actual
        }

        private void LimpiarFormulario()
        {
            // Vaciar TextBox DNI
            
            dniFleteroTXT.Clear();
            
            // Vaciar ListView         
            listView_HDR.Items.Clear();

        }
    }
}

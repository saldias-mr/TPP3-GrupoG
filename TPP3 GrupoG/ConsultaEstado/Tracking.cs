using System.Windows.Forms;

namespace TPP3_GrupoG.ConsultaEstado
{
    public partial class Tracking : Form
    {
        private readonly TrackingModelo trackingModelo = new TrackingModelo();

        public Tracking()
        {
            InitializeComponent();
        }

        private void Tracking_Load(object sender, EventArgs e)
        {
            // Configurar columnas del ListView (moviEncomiendaLIST)
            moviEncomiendaLIST.View = View.Details;
            moviEncomiendaLIST.FullRowSelect = true;
            moviEncomiendaLIST.GridLines = true;

            moviEncomiendaLIST.Columns.Clear();
            moviEncomiendaLIST.Columns.Add("Última Ubicación", 200);
            moviEncomiendaLIST.Columns.Add("Estado", 150);
            moviEncomiendaLIST.Columns.Add("Cliente", 200);
            moviEncomiendaLIST.Columns.Add("Destinatario", 200);
            moviEncomiendaLIST.Columns.Add("Fecha Creación", 150);
        }

        private void buscarGuiaBTN_Click(object sender, EventArgs e)
        {
            trackingModelo.NumeroGuia = numGuiaTXT.Text;

            if (!trackingModelo.Buscar())
            {
                MessageBox.Show(
                    "El número de guía ingresado no es válido o no se encuentra registrado.",
                    "Tracking",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            MostrarResultado();
        }

        private void VolverBTN_Click(object sender, EventArgs e)
        {
            trackingModelo.Limpiar();
            LimpiarPantalla();
        }

        private void MostrarResultado()
        {
            moviEncomiendaLIST.Items.Clear();

            var encomienda = trackingModelo.Encomienda!;
            var item = new ListViewItem(encomienda.UltimaUbicacion);

            item.SubItems.Add(encomienda.EstadoActual);
            item.SubItems.Add(encomienda.Cliente.Nombre);
            item.SubItems.Add(encomienda.Destinatario.Nombre);
            item.SubItems.Add(
                encomienda.FechaCreacion.ToString("dd/MM/yyyy"));

            moviEncomiendaLIST.Items.Add(item);
        }

        private void LimpiarPantalla()
        {
            numGuiaTXT.Clear();
            moviEncomiendaLIST.Items.Clear();
            numGuiaTXT.Focus();
        }
    }
}
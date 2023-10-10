namespace AgenciaViajes_Prototipo_G5
{
    public partial class FormMenuPpal : Form
    {
        public FormMenuPpal()
        {
            InitializeComponent();
        }

        private void buttonConsultaEstadoReserva_Click(object sender, EventArgs e)
        {
            //creo la llamada del proximo winform
            ConsultaEstadoReserva formConsultaEstadoReserva = new ConsultaEstadoReserva();
            formConsultaEstadoReserva.Show();
        }
    }
}
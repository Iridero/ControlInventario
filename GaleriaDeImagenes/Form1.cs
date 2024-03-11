namespace GaleriaDeImagenes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCambiarRuta_Click(object sender, EventArgs e)
        {
            if(fldImagenes.ShowDialog() == DialogResult.OK)
            {
                txtRuta.Text = fldImagenes.SelectedPath;
                ServicioImagenes servicio = new ServicioImagenes();
                servicio.AgregarImagenes(txtRuta.Text,flwImagenes);
            }
        }
    }
}

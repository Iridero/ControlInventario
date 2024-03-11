namespace Archivos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AccesoArchivo acceso = new AccesoArchivo();
            Contacto contacto = new Contacto()
            {
                Nombre = txtNombre.Text,
                Telefono = txtTelefono.Text
            };
            acceso.Escribir(contacto);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            AccesoArchivo acceso=new AccesoArchivo();
            Contacto? contacto = acceso.Buscar(txtNombreBuscar.Text);
            if (contacto == null )
            {
                txtTelefonoBuscar.Text = "No encontrado";
            }
            else
            {
                txtTelefonoBuscar.Text = contacto.Telefono;
            }
        }
    }
}

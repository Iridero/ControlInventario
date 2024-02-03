using ClasesInventario;

namespace ControlInventario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            inventario = new Inventario();
        }
        Inventario inventario;
        private void Form1_Load(object sender, EventArgs e)
        {
            ActualizarListBox();
            inventario.ArticuloEventHandler += Inventario_ArticuloEventHandler;
        }
        private void ActualizarListBox()
        {
            lstArticulos.DataSource = null;
            lstArticulos.DataSource = inventario.Articulos;
            lstArticulos.DisplayMember = "Descripcion";
        }
        private void Inventario_ArticuloEventHandler(object? sender, ArticuloEventArgs e)
        {
            ActualizarListBox();
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAgregar frmAgregar = new FrmAgregar();
            frmAgregar.Inventario = inventario;
            frmAgregar.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmEditar frmEditar  =new FrmEditar();
            frmEditar.Inventario=inventario;
            frmEditar.Editando = lstArticulos.SelectedItem as Articulo;
            frmEditar.ShowDialog();

        }
    }
}
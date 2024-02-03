using ClasesInventario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlInventario
{
    public partial class FrmEditar : Form
    {
        public FrmEditar()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
        public Inventario Inventario { get; set; }
        public Articulo Editando { get; set; }
        private void FrmEditar_Load(object sender, EventArgs e)
        {
            if (Editando != null)
            {
                txtId.Text=Editando.Id.ToString();
                txtDescripcion.Text = Editando.Descripcion;
                txtExistencia.Text = Editando.Existencia.ToString();
                txtPrecio.Text = Editando.Precio.ToString();

            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Editando.Descripcion=txtDescripcion.Text;
            Editando.Existencia=int.Parse(txtExistencia.Text);
            Editando.Precio=decimal.Parse(txtPrecio.Text);
            Inventario.Editar(Editando);
        }
    }
}

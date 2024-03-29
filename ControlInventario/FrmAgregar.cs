﻿using ClasesInventario;
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
    public partial class FrmAgregar : Form
    {
        public FrmAgregar()
        {
            InitializeComponent();
        }
        public Inventario Inventario { get; set; }
        public ArticuloDbContext Context { get; set; }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            Articulo articulo = new Articulo();
            //articulo.Id = int.Parse(txtId.Text);
            articulo.Descripcion = txtDescripcion.Text;
            articulo.Existencia = int.Parse(txtExistencia.Text);
            articulo.Precio = decimal.Parse(txtPrecio.Text);

            ArticuloDbContext db = new ArticuloDbContext();
            await db.AgregarArticulo(articulo);
            
            //Inventario.Agregar(articulo);
            txtId.Clear();
            txtDescripcion.Clear();
            txtExistencia.Clear();
            txtPrecio.Clear();
            txtId.Focus();

            
        }
    }
}

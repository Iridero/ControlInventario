using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesInventario
{
    public class Inventario
    {
        public event EventHandler<ArticuloEventArgs> ArticuloEventHandler;

		private List<Articulo> articulos;

		public List<Articulo> Articulos
		{
			get { return articulos; }
			
		}

        public void Agregar(Articulo articulo)
        {
            if (articulos.Any(a => a.Id == articulo.Id))
            {
                throw new ArgumentException("El id suministrado ya existe");
            }
            if (articulos.Any(a => a.Descripcion.ToUpper()
                    == articulo.Descripcion.ToUpper()))
            {
                throw new ArgumentException("El nombre suministrado ya existe");
            }
            articulos.Add(articulo);

            AlCambiarArticulo(articulo);
        }

        private void AlCambiarArticulo(Articulo articulo)
        {
            ArticuloEventArgs e = new ArticuloEventArgs(articulo);
            EventHandler<ArticuloEventArgs> handler =
                ArticuloEventHandler;
            handler?.Invoke(this, e);
        }

        public void Editar(Articulo articulo)
        {
            var encontrado = articulos.FirstOrDefault
                (a => a.Descripcion.ToUpper() 
                == articulo.Descripcion.ToUpper());
            var aEditar = articulos.FirstOrDefault 
                (a=>a.Id== articulo.Id);
            if (encontrado==null)
            {
                aEditar.Descripcion= articulo.Descripcion;
                aEditar.Existencia= articulo.Existencia;
                aEditar.Precio= articulo.Precio;
                AlCambiarArticulo (articulo);
            }
            else
            {
                if (encontrado.Id == aEditar.Id)
                {
                    aEditar.Existencia = articulo.Existencia; 
                    aEditar.Precio = articulo.Precio;
                    AlCambiarArticulo(articulo) ;
                }
                else
                {
                    throw new ArgumentException("El nombre suministrado ya existe");
                }
            }
        }
        public Inventario()
        {
            articulos = new List<Articulo>();
            
        }
    }
}

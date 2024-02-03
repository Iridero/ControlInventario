using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesInventario
{
    public class ArticuloEventArgs:EventArgs
    {
        public Articulo Articulo { get; set; }
        public ArticuloEventArgs(Articulo articulo)
        {
            Articulo = articulo;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entrada
{
    public partial class FrmPinPad : Form
    {
        public event EventHandler AccesoConcedido;
        public FrmPinPad()
        {
            InitializeComponent();
        }
    }
}

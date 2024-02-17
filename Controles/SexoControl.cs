using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controles
{
    public partial class SexoControl : UserControl
    {
        public SexoControl()
        {
            InitializeComponent();
        }

        public event EventHandler SexoCambiado;

        private string? sexo = null;

        private void chkChanged(object sender, EventArgs e)
        {

        }

        private void rdbChanged(object sender, EventArgs e)
        {
            if (rdbFemenino.Checked)
            {
                sexo = "Femenino";
            }
            else
            {
                sexo = "Masculino";
            }
            SexoCambiado?.Invoke(this, EventArgs.Empty);
        }

        public string? Sexo
        {
            get { return sexo; }
        }

    }
}

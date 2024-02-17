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
    public partial class IpAddressInput : UserControl
    {
        public event EventHandler IpAddressChanged;

        private string ipAddress="0.0.0.0";

        public string IpAddress
        {
            get { return ipAddress; }
            set {
                var octetos = value.Split(".");

                if (octetos.Length != 4) {
                    throw new FormatException();
                }
                var valores = new byte[4];
                for (int i = 0; i < octetos.Length; i++)
                {
                    if (!byte.TryParse( octetos[i], out valores[i]))
                    {
                        throw new FormatException();
                    }
                }
                nmrOcteto1.Value = valores[0];
                nmrOcteto2.Value = valores[1];
                nmrOcteto3.Value = valores[2];
                nmrOcteto4.Value = valores[3];
                ipAddress = value; 
            }
        }

        public IpAddressInput()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void nmrOcteto_ValueChanged(object sender, EventArgs e)
        {
            ipAddress = $"{nmrOcteto1.Value}.{nmrOcteto2.Value}" +
                $".{nmrOcteto3.Value}.{nmrOcteto4.Value}";
            IpAddressChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}

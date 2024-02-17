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
    public partial class RgbMixer : UserControl
    {
        public RgbMixer()
        {
            InitializeComponent();
        }
        private Color color;

        public Color Color
        {
            get { return color; }
            set { color = value; }
        }
        public event EventHandler ColorChanged;
        private void nmrValueChanged(object sender, EventArgs e)
        {
            int R = (int)nmrR.Value;
            int G = (int)nmrG.Value;
            int B = (int)nmrB.Value;
            color = Color.FromArgb(R, G, B);
            pnlRgb.BackColor = color;
            ColorChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaleriaDeImagenes
{
    public class ServicioImagenes
    {
        public void AgregarImagenes(string ruta, 
            FlowLayoutPanel flowLayoutPanel)
        {
            flowLayoutPanel.Controls.Clear();
            if(!Directory.Exists(ruta))
            {
                throw new ArgumentException("No existe la ruta");
            }
            var imagenes = Directory.GetFiles(ruta, "*.jpg");
            foreach(var imagen in imagenes)
            {
                PictureBox pctImagen = new PictureBox
                {
                    Image=Image.FromFile(imagen),
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Height=100,
                    Width=100
                };
                flowLayoutPanel.Controls.Add(pctImagen);
            }
        }
    }
}

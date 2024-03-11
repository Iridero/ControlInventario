using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Archivos
{
    public class AccesoArchivo
    {
        private string _ruta = "agenda.txt";
        public void Escribir(Contacto contacto)
        {
            string datos = $"{contacto.Nombre}|{contacto.Telefono}";
            using (StreamWriter writer=new StreamWriter(_ruta,true))
            {
                writer.WriteLine(datos);
            }
        }
        public Contacto? Buscar(string nombre)
        {
            Contacto? contacto = null;
            using (StreamReader reader=new StreamReader(_ruta))
            {
                while (!reader.EndOfStream)
                {
                    var datos = reader.ReadLine();
                    var separados = datos.Split("|");
                    if (nombre.Trim().ToLower() == separados[0].ToLower())
                    {
                        contacto = new Contacto
                        {
                            Nombre = separados[0].Trim(),
                            Telefono = separados[1].Trim()
                        };
                        break;
                    }
                }
            }
            return contacto;
        }
    }
}

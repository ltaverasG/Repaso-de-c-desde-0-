using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia_hdleon
{
    class leon: Carnivoro
    {
        public string ColorPelo { get; set; }
        private int velocidadDefecto = 20;

        public override string GetNombre()
        {
            return "Soy un leon llamado: " + Nombre;
        }

        public leon()
        {
            this.Nombre = "leon";
        }
        public leon(string Nombre)
        {
            this.Nombre = Nombre;
        }

        public void correr()
        {
            Console.WriteLine("Corriendo" + velocidadDefecto);
        }

        public void correr (int velocidad)
        {
            Console.WriteLine("Corriendo" + velocidad);
        }
        public void correr(int velocidad , string detalle)
        {
            Console.WriteLine("Corriendo" + velocidad + "" + detalle);
        }
        public void correr(string detalle)
        {
            Console.WriteLine(detalle);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_de_hdleon
{
    class Cerveza
    {
        public int Amargor { get; set; }

        public decimal Alcohol  { get; set; }

        public int tiempoFermentacion { get; set; }

        public void Fermentacion()
        {
            for (int i = 0; i < tiempoFermentacion; i++) ; 
            Console.WriteLine("Se fermento ");
        }

        public Cerveza(int Amargor, decimal Alcohol,int tiempoFermentacion)
        {
            this.Amargor = Amargor;
            this.Alcohol = Alcohol;
            this.tiempoFermentacion = tiempoFermentacion;
        }
    }
}

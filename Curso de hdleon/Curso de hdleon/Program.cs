using System;

namespace Curso_de_hdleon
{
    class Program
    {
        static void Main(string[] args)
        {

            // llamamos a la clase para crear el objeto y usamos constructor 
            Cerveza cerveza = new Cerveza(5,6.5m,30);
            cerveza.Fermentacion();

        }
    }
}

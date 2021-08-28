using System;

namespace herencia_hdleon
{
    class Program
    {
        static void Main(string[] args)
        {

            leon leon = new leon();
            leon.Nombre = "Simba";
            
            leon.ColorPelo = "marron";

            buitre buitre = new buitre();
            buitre.Nombre = "Condoriano";
            buitre.colorPlumas = "negro";         

            Console.WriteLine(leon.Nombre);
            Console.WriteLine(leon.ColorPelo);
            leon.correr(30, "enojado");

            Console.WriteLine(buitre.Nombre);
            Console.WriteLine(buitre.colorPlumas);
            buitre.vuelo();

        }
    }
}

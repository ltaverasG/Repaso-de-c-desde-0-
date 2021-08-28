using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia_hdleon
{
    class buitre: Carnivoro 
    {
        public string colorPlumas { get; set; }
        
        public void vuelo()
        {
            Console.WriteLine("volando");
        }
    }
}

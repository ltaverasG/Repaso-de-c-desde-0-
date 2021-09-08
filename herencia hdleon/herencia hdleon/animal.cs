using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia_hdleon
{
    class animal
    {
        public string Nombre { get; set; }

        public virtual string GetNombre()
        {
            return Nombre;
        }

    }
}

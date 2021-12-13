using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class ISesion
    {
        //Declaración de variables de tipo privado y obtención de los métodos get y set.
        private string user;
        private string pass;

        //propiedades get set
        public string User { get => user; set => user = value; }
        public string Pass { get => pass; set => pass = value; }
    }
}

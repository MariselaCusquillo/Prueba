using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Prueba
    {
        public string Name { set; get; }
        public string Apellido { set; get; }

        public Prueba()
        {

        }

        public Prueba(string name, string apellido)
        {
            Name = name;
            Apellido = apellido;
        }
    }
}

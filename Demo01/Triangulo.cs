using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01
{
    public class Triangulo
    {
        public int Base { get; set; }
        public int Altura { get; set; }
        public int Area { get; set; }

        public int CalcularArea()
        {
            return (Base * Altura / 2);
        }

        public void MostrarArea()
        {
            Area = Base * Altura / 2;
        }

    }
}

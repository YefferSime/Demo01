using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01
{
    public class Triangulo
    {
        public int X1 { get; set; }
        public int Y1 { get; set; }
        public int X2 { get; set; }
        public int Y2 { get; set; }
        public int X3 { get; set; }
        public int Y3 { get; set; }
  
        public double Perimetro { get; set; }
        public double Area { get; set; }

        private double CalcularDistancia(int x1, int y1, int x2, int y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }

        
        public void CalcularArea()
        {
            double lado1 = CalcularDistancia(X1, Y1, X2, Y2);
            double lado2 = CalcularDistancia(X2, Y2, X3, Y3);
            double lado3 = CalcularDistancia(X3, Y3, X1, Y1);
            double s = (lado1 + lado2 + lado3) / 2;
            Area= Math.Sqrt(s * (s - lado1) * (s - lado2) * (s - lado3));
        }
        public void CalcularPerimetro()
        {
            double lado1 = CalcularDistancia(X1, Y1, X2, Y2);
            double lado2 = CalcularDistancia(X2, Y2, X3, Y3);
            double lado3 = CalcularDistancia(X3, Y3, X1, Y1);
            Perimetro = lado1 + lado2 + lado3;
        }




    }
}

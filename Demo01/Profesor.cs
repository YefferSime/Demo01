using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01
{
    internal class Profesor : Persona
    {
        public int Sueldo { get; set; }
        public Double SueldoNeto { get; set; }

        public void CalcularSueldoNeto()
        {
            
            if (Sueldo>0 && Sueldo<=2000)
            {
                SueldoNeto = Sueldo - (Sueldo * 0.08);
            }
            else if (Sueldo > 2000 && Sueldo <= 5000)
            {
                SueldoNeto = Sueldo - (Sueldo * 0.14);
            }
            else if (Sueldo > 5000 && Sueldo <= 7000){
                SueldoNeto = Sueldo - (Sueldo * 0.30);
            }
            
        }
    }
}

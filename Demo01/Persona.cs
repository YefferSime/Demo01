using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Demo01
{
    public class Persona
    {
        public String Nombres { get; set; }
        public String Apellidos { get; set; }
        public int Edad { get; set; }

        public String NombresCompletos { get; set; }

        public String MayordeEdad(int Edad)
        {
            if (Edad>=18)
            {
                return "Eres mayor de edad";
            }
            else
            {
                return "Eres Menor de edad";
            }
            
        }

        public void AsignarNombresCompletos()
        {
            NombresCompletos= Nombres + " " + Apellidos;
        }
        
        
    }
}

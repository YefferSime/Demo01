using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Demo01
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Persona persona = new Persona();
            persona.Nombres = "Yeffer";
            persona.Apellidos = "Sime";
            persona.AsignarNombresCompletos();




            Triangulo triangulo = new Triangulo();
            triangulo.Base = 12;
            triangulo.Altura = 13;
            triangulo.MostrarArea();

            Console.WriteLine(persona.NombresCompletos) ;
            Console.WriteLine(triangulo.Area);
            Console.Read();
            
        }
    }
}

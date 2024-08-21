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


            //Persona persona = new Persona();
            //persona.Nombres = "Yeffer";
            //persona.Apellidos = "Sime";
            //persona.AsignarNombresCompletos();


            // Persona persona2 = new Persona
            //{
            //    Nombres = "Dérek",
            //     Apellidos = "Torrico",
            //Edad=5
            // };




            // Estudiante estudiante = new Estudiante
            // {
            //     Nombres = "Yeffer",
            //     Apellidos = "Sime",
            //     Nota = 20
            // };

            // Profesor profesor = new Profesor
            // {
            //     Nombres = "Yeffer",
            //     Apellidos = "Sime",
            //     Sueldo = 1000
            // };

            // profesor.CalcularSueldoNeto();
            // Console.WriteLine(profesor.SueldoNeto);


            //Triangulo triangulo = new Triangulo();
            //triangulo.Base = 12;
            //triangulo.Altura = 13;
            //triangulo.MostrarArea();

            Triangulo triangulo = new Triangulo
            {
                X1 = 0,
                Y1 = 0,
                X2 = 4, 
                Y2 = 0,
                X3 = 4,
                Y3 = 3,
            };
            triangulo.CalcularPerimetro();
            triangulo.CalcularArea();
            Console.WriteLine(triangulo.Perimetro) ;
            Console.WriteLine(triangulo.Area);
            Console.WriteLine();
            Console.Read();
            
        }
    }
}


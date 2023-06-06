using System;

namespace Prac2023 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Crear humano\n");
            Humano humano = new Humano();

            humano.GetInformacion();


            Console.WriteLine("\n¿Desea crear otro humano?");
            string a = Console.ReadLine();

            if (a == "Si")
            {
                Console.WriteLine("\nDigite el nombre:");
 
                string nombremain = Console.ReadLine();

                Console.WriteLine("\nDigite el sexo:");
                string sexomain = Console.ReadLine();

                Console.WriteLine("\nDigite la altura:");
                double alturamain = double.Parse(Console.ReadLine());

                Console.WriteLine("\nDigite el pais:");
                string paismain = Console.ReadLine();

                Humano humano2 = new Humano(nombremain, sexomain, alturamain, paismain);
                humano2.GetInformacion();

            }
            else Console.WriteLine("\nBueno mama pito");


            Console.WriteLine("Digite un año");
            int year = Console.ReadLine();
            int cont = 0;
            if (year >= 1)
            {
                cont++;
            }
        }


        class Humano
        {
            // Propiedades, atributos o caracteristicas
            private string nombre;
            private string sexo;
            private double altura;
            private string pais;

            //Constructores
            public Humano()
            {
                nombre = "Juan";
                sexo = "M";
                altura = 1.70;
                pais = "Mexico";
            }
                
            public Humano(string nombre, string sexo, double altura, string pais)
            {
                this.nombre = nombre;
                this.sexo = sexo;
                this.altura = altura;
                this.pais = pais;
            }

            //Metodos getters
            public void GetInformacion() 
            {
                Console.WriteLine("Nombre: " + nombre);
                Console.WriteLine("Sexo: " + sexo);
                Console.WriteLine("Altura: " + altura);
                Console.WriteLine("Pais: " + pais);
            }


            //


        }
    }
}
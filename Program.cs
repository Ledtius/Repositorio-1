using System;

namespace Prac2023 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("---Crear humano---\n");
            Humano humano = new Humano();

            int cont = 1;
            Console.WriteLine("Humano N°: " + cont + "\n");
            humano.GetInformacion();


            Console.WriteLine("\n¿Desea crear otro humano?");
            string valor = Console.ReadLine();

            if (valor == "Si")
            {
                Console.WriteLine("\nDigite el nombre:");

                string nombremain = Console.ReadLine();

                Console.WriteLine("\nDigite el sexo:");
                string sexomain = Console.ReadLine();

                Console.WriteLine("\nDigite la altura:");
                double alturamain = double.Parse(Console.ReadLine());

                Console.WriteLine("\nDigite el pais:\n");
                string paismain = Console.ReadLine();

                cont++;
                Console.WriteLine("Humano N°: " + cont + "\n");
                Humano humano2 = new Humano(nombremain, sexomain, alturamain, paismain);
                humano2.GetInformacion();

            }
            else if (valor == "No")
            {
                Console.WriteLine("\n Deacuerdo.");
            }
            else
            {
                Console.WriteLine("Valor incorrecto.");
            }

            Console.WriteLine("Desea cambiar el nombre del humano?");
            if ()
            {

            }
            else if ()
            {


            }
            else



            //Console.WriteLine("Digite un año");
            //int year = int.Parse(Console.ReadLine());
            //int cont1 = 0;
            //int century = 0;
            //if (year > 1) 
            //{
            //    Console.WriteLine("incorrect value");
            //}
            //else if (year >= 100)
            //{
            //    cont++;
            //    century = year;
            //    Console.WriteLine("Century:" + century);
            //}
            //else if
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


            //Metodo setter
            public string SetNombre(string nombre)
            {
                this.nombre = nombre;
                return nombre;
            }
            


        }
    }
}
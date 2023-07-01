using System;

namespace Prac2023 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---¡Bienvenido al programa crea Humanos!---");
            Console.WriteLine("¿Desea continuar?... (''PULSAR 1 PARA SI'') (''PULSAR 2 PARA NO'')");

            try
            { 
                string continuar = Console.ReadLine();
                if (continuar == "1")
                {
                    Console.WriteLine("\n¿Humano predeterminado? (''PULSA 1 PARA SI'')(''PULSA 2 PARA NO'')");
                    string predet = Console.ReadLine();

                    if (predet == "1")
                    {
                        Humano humano1 = new Humano();
                        Console.WriteLine(humano1.GetInformacion());
                        humano1.metodoClasifiSexo();
                        humano1.metodoAltura();
                        
                    }
                    else if (predet == "2") 
                    {
                        try
                        {
                            Console.WriteLine("\n¿Nombre del humano?");
                            string nombremain = Console.ReadLine();

                            Console.WriteLine("\n¿Desea seguir llenando mas datos del humano?\n (''PULSAR 1 PARA SI'') (''PULSAR 2 PARA NO'')\n");
                            string dato1 = Console.ReadLine();

                            if (dato1 == "1")
                            {
                                Console.WriteLine("\n¿Sexo?");
                                string sexomain = Console.ReadLine();

                                Console.WriteLine("\n¿Desea seguir llenando mas datos del humano?\n (''PULSAR 1 PARA SI'') (''PULSAR 2 PARA NO'')\n");
                                string dato2 = Console.ReadLine();

                                if (dato2 == "1")
                                {
                                    Console.WriteLine("\n¿Edad?");
                                    int edadmain = int.Parse(Console.ReadLine());

                                    Console.WriteLine("\n¿Desea seguir llenando mas datos del humano?\n (''PULSAR 1 PARA SI'') (''PULSAR 2 PARA NO'')\n");
                                    string dato3 = Console.ReadLine();

                                    if (dato3 == "1")
                                    {
                                        Console.WriteLine("\n¿Altura? (en m)\n");
                                        double alturamain = double.Parse(Console.ReadLine());
                                        Humano humano1 = new Humano(nombremain, sexomain, edadmain, alturamain);

                                        Console.WriteLine(humano1.GetInformacion());
                                        humano1.metodoClasifiSexo();
                                        humano1.metodoAltura();

                                    }
                                    else if (dato3 == "2")
                                    {
                                        Humano humano1 = new Humano(nombremain, sexomain, edadmain);
                                        Console.WriteLine(humano1.GetInformacion());
                                        humano1.metodoClasifiSexo();
                                        humano1.metodoAltura();

                                    }
                                    else 
                                    {
                                        Console.WriteLine("\nValor invalido.");
                                    }



                                }
                                else if (dato2 == "2")
                                {
                                    Humano humano1 = new Humano(nombremain, sexomain);
                                    Console.WriteLine(humano1.GetInformacion());
                                    humano1.metodoClasifiSexo();
                                    humano1.metodoAltura();
                                }
                                else
                                {
                                    Console.WriteLine("\nValor invalido.");
                                }
                            }
                            else if (dato1 == "2")
                            {
                                Humano humano1 = new Humano(nombremain);
                                Console.WriteLine(humano1.GetInformacion());
                                humano1.metodoClasifiSexo();
                                humano1.metodoAltura();
                            }
                            else
                            {
                                Console.WriteLine("\nValor invalido.");
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("\nError: " + e.Message);
                        }


                        Console.WriteLine("\nPrograma finalizado.");
                    }

                }
                else if (continuar == "2")
                {
                    Console.WriteLine("\nPrograma finalizado.");
                }
                else
                {
                    Console.WriteLine("\nValor invalido.");
                }
            }
            catch (Exception e) 
            {
                Console.WriteLine($"Error: {e.Message} ");
            }

            Console.WriteLine("\n¿Desea contar ovejas?");
            string datomain = Console.ReadLine();

            if (datomain == "Si")
            {
                Humano humano1 = new Humano();
                humano1.metodoContarOvejas(datomain);
            }
            else if (datomain == "No")
            {
                Console.WriteLine("Beeee!");
            }

        }


        class Humano
        {
            //Propiedades
            private string nombre;
            private string sexo;
            private int edad;
            private double altura;
 


            //Constructores
            public Humano() 
            { 
                nombre = "Juan";
                sexo = "Masculino";
                edad = 23;
                altura = 1.70;

            }

            public Humano(string nombre)
            {
                this.nombre = nombre;
                sexo = "Masculino";
                edad = 23;
                altura = 1.70;
            }

            public Humano(string nombre, string sexo) 
            {
                this.nombre = nombre;
                this.sexo = sexo;
                edad = 23;
                altura = 1.70;
            }

            public Humano(string nombre, string sexo, int edad) 
            {
                this.nombre = nombre;
                this.sexo = sexo;
                this.edad = edad;
                altura = 1.70;
            }

            public Humano(string nombre, string sexo, int edad, double altura) 
            {
                this.nombre = nombre;
                this.sexo = sexo;
                this.edad = edad;
                this.altura = altura;
            }


            //Metodo Getter
            public string GetInformacion() 
            {
                return "\n---Informacion---\n" + "\nNombre: " + nombre + "\nSexo: " + sexo + "\nEdad: " + edad + "\nAltura: " + altura + " m";
            }

            //Metodos Setters
            public void setNombre(string nombre) 
            {
                this.nombre = nombre;
            }

            public void setSexo(string sexo) 
            {
                this.sexo = sexo;
            }

            public void setEdad(int edad)
            {
                this.edad = edad;
            }

            public void setAltura(double altura) 
            {
                this.altura = altura;
            }

            //Metodos
            public void metodoClasifiSexo() 
            {
                Console.WriteLine("\n--Evaluador de edad--");

                if (edad >= 18)
                {
                    Console.WriteLine("\nEres mayor de edad.");
                }
                else 
                {
                    Console.WriteLine("\nNo eres mayor de edad.");
                }

            }

            public void metodoAltura()
            {
                Console.WriteLine("\n--Evaluador de altura--");

                if (sexo == "Masculino")
                {
                    if (altura == 1.60 || altura <= 1.80)
                    {
                        Console.WriteLine("\nAltura media.");
                    }
                    else if (altura > 1.80)
                    {
                        Console.WriteLine("\nAltura mayor que la media.");
                    }
                    else if (altura < 1.60)
                    {
                        Console.WriteLine("\nAltura menor que la media.");
                    }
                }
                else if (sexo == "Femenino") 
                {
                    if (altura == 1.50 || altura <= 1.70)
                    {
                        Console.WriteLine("\nAltura media.");
                    }
                    else if (altura > 1.70)
                    {
                        Console.WriteLine("\nAltura mayor que la media.");
                    }
                    else if (altura < 1.50)
                    {
                        Console.WriteLine("\nAltura menor que la media.");
                    }
                }
            
            }

            public void metodoContarOvejas(string dato) 
            {
                int cont = 0;

                if (dato == "Si") 
                {
                    Console.WriteLine("Digite el maximo de ovejas que quiere contar.");
                    int maximo = int.Parse(Console.ReadLine());

                    while (cont < maximo)
                    {
                        cont++;
                        Console.WriteLine($"Oveja numero -> {cont}");

                        if (cont == maximo)
                        {
                            Console.WriteLine("Te quedaste dormid@ beeeee!!!...");
                        }
                    }


                }
                else if(dato == "No")
                {
                    Console.WriteLine("Beeee!");
                }

            }
            





        }
    }
}
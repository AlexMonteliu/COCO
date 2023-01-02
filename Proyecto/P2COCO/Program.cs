using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2COCO
{
    internal class Program
    {
        static void Main(string[] args)
            //PESO,VALOR
        {
            int variablemenu = 0;
            do
            {
                Console.WriteLine("--------------------------------------------\n");
                Console.WriteLine(" Bienvenido a la 2º práctica de complejidad computacional");
                Console.WriteLine(" Realizado por el grupo B1");
                Console.WriteLine(" Apartados del menú:");
                Console.WriteLine(" 1-Resultados del ejercicio usando voraz");
                Console.WriteLine(" 2-Resultados del ejercicio usando Programación Dinámica");
                Console.WriteLine(" 3-Resultados del ejercicio usando BackTracking");
                Console.WriteLine(" 4-salir");
                Console.WriteLine("--------------------------------------------\n");
                variablemenu =int.Parse(Console.ReadLine());    
                if(variablemenu == 1)
                {
                    objetos[] grupo = { new objetos(190000, 34200000, "Palés Café de Jamaica"),         //Los objetos se colocan por mayor valor es decir el objeto con el mayor valor (PrecioTotal/peso) irá el primero y así sucesivamente
                new objetos(130000, 19500000, "Palés Café de Colombia"),
                new objetos(150000, 18000000, "Palés Café de Hawaii"),
                new objetos(260000, 26000000, "Palés Café de Tanzania"), new objetos(240000, 19200000, "Palés Café de Nicaragua"),
                new objetos(140000, 9800000, "Palés Café de Kenya") };


                    double[] x;
                    Voraz voraz = new Voraz();
                    x = voraz.Vorazz(grupo, 600000); //Se pone el array de objetos y la cantidad maxima

                    for (int a = 0; a < x.Length; a++)
                    {
                        x[a] = x[a] * 100; //Se pasa a porcentaje los numeros obtenidos
                    }

                    Console.WriteLine("La solución óptima de las cargas sería la siguiente: \n");
                    for (int i = 0; i < x.Length; i++)
                    {
                        Console.WriteLine(grupo[i].nombre + ": Se coge el " + x[i] + "%");
                    }
                    //Console.WriteLine(x[0]);
                    Console.ReadKey();


                }
                if(variablemenu == 2)
                {
                    //Declaramos el array que contendrá los datos del problema,
                    ObjetoDinámica[] array = { new ObjetoDinámica(140000,9800000),new ObjetoDinámica(130000,19500000), new ObjetoDinámica(150000,18000000), new ObjetoDinámica(190000,34200000)
            ,new ObjetoDinámica(240000,19200000),new ObjetoDinámica(260000,26000000)};


                    double[,] V = new double[6, 600001];
                    bool[,] P = new bool[6, 600001];

                    Dinámica dinámica = new Dinámica();
                    //Llamamos a la función para que realice el problema de la mochila en programación dinámica.
                    dinámica.mochila(array, 600000, V, P);
                }
                if (variablemenu == 3)
                {
                    //PARTE MONTY
                }



            } while (variablemenu!=4);
          

         
        }
    }
}

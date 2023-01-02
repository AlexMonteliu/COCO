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

                    //PARTE DE JAVI

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
          

            Console.ReadKey();
        }
    }
}

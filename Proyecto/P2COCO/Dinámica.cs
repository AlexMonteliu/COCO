using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2COCO
{
	// C# program to solve fractional Knapsack Problem

	using System;
	using System.Collections;

	class Dinámica
	{
       public void mochila(ObjetoDinámica[] objetos, int c_maxima, double[,] V, bool[,] P)//
        {
            Console.WriteLine("                      TABLA                   ");
            Console.WriteLine("--------------------------------------------\n");
            Console.WriteLine("i,PESO,VALOR");
            V = new double[objetos.Length, c_maxima + 1];
            P = new bool[objetos.Length, c_maxima + 1];
            for (int i = 0; i < objetos.Length; i++) //recorre el numero de objetos
            {
                for (int p = 1; p <= c_maxima; p++)// recorre la cantidad de pesos 
                {
                    if (i == 0 && p < objetos[i].peso)
                    {
                        V[i, p] = 0;

                        P[i, p] = false;

                    }
                    else if (i == 0)
                    {
                        V[i, p] = objetos[i].valor;
                        P[i, p] = true;
                    }
                    else if (p < objetos[i].peso)
                    {
                        V[i, p] = V[i - 1, p];
                        P[i, p] = false;
                    }
                    else
                    {
                        V[i, p] = Math.Max(V[i - 1, p], V[i - 1, p - objetos[i].peso] + objetos[i].valor);
                        P[i, p] = (V[i, p] != V[i - 1, p]) ? true : false;
                    }

                }
            }
                     
                    for (int i = 0; i < objetos.Length; i++) //recorre el numero de objetos
                    {
                        Console.WriteLine(i + " " + objetos[i].peso + " " + objetos[i].valor);
                        for (int p = 1; p <= c_maxima; p++)// recorre la cantidad de pesos
                        {
                            //Este Console.WriteLine indica las pasadas,está comentado para que el programa no dure más tiempo.
                           // Console.WriteLine("Para " + i + " "+ p + " "+V[i, p] + " y " + P[i, p]);
                      
                         }
                    }
            bool[] falso = calculoObjetos(objetos, c_maxima, V, P);
            Console.WriteLine("ValorDevuelto: " + V[objetos.Length-1, c_maxima ]);
            Console.WriteLine("--------------------------------------------\n");
        }
                public bool[] calculoObjetos(ObjetoDinámica[] objetos, double c_maxima, double[,] V, bool[,] P)
        {
            // array de lógicos de tamaño n
            bool[] solucion = new bool[objetos.Length];
            int [] Objetodevuelto=new int[objetos.Length];
            int  i = objetos.Length-1 ;
            int p = (int)c_maxima;
            while (i != -1 && p != -1)
            {
             
                if (P[i,p]==true)
                {
                    solucion[i] = true;  // Añado el objeto i
                    p -= objetos[i].peso;  // Capacidad restante

                    Objetodevuelto[i] = i;
                    //Metemos condiciones para que imprima el mensaje adecuado.
                    if (i == 1)
                    {
                        Console.WriteLine("Objetos devueltos " + Objetodevuelto[i] + " Producto: Palés de café de Kenya ");
                    }
                    if (i == 2)
                    {
                        Console.WriteLine("Objetos devueltos " + Objetodevuelto[i] + " Producto: Palés de café de Colombia");
                    }
                    if (i == 3)
                    {
                        Console.WriteLine("Objetos devueltos " + Objetodevuelto[i] + " Producto: Palés de café de Kawaii  ");
                    }
                    if (i == 4)
                    {
                        Console.WriteLine("Objetos devueltos " + Objetodevuelto[i] + " Producto: Palés de café de Jamaica  ");
                    }
                    if (i == 5)
                    {
                        Console.WriteLine("Objetos devueltos " + Objetodevuelto[i] + " Producto: Palés de café de Nicaragua  ");
                    }
                    if (i == 6)
                    {
                        Console.WriteLine("Objetos devueltos " + Objetodevuelto[i] + " Producto: Palés de café de Tanzania  ");
                    }


                }
         
                i -= 1;
            }
          
            return solucion;
        }


    }


}

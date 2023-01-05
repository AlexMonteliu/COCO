using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2COCO
{

    class VueltaAtras
    {

       public void FucnionamientoPrograma()
        {
            List<Item> items = new List<Item>();
            items.Add(new Item("Pales Tanzania", 260000, 26000000));
            items.Add(new Item("Pales de Hawai", 150000, 18000000));
            items.Add(new Item("Pales de Nicaragua", 240000, 19200000));
            items.Add(new Item("Pales de Jamaica", 190000, 34200000));
            items.Add(new Item("Pales de Colombia", 130000, 19500000));
            items.Add(new Item("Pales de Kenia", 140000, 9800000));
            int knapsackWeightLimit = 600000;

            KnapsackSolution bestSolution = new KnapsackSolution();

            Backtrack(items, knapsackWeightLimit, 0, new KnapsackSolution(), ref bestSolution);

            Console.WriteLine("Mejor solución encontrada:");
            foreach (Item item in bestSolution.items)
            {
                Console.WriteLine(item.name);
            }
            Console.WriteLine("Peso total: " + bestSolution.totalWeight);
            Console.WriteLine("Valor total: " + bestSolution.totalValue);
            Console.ReadLine();
        }

        class Item //Clase item de dentro de la lista.
        {
            public string name;
            public int weight;
            public int value;

            public Item(string name, int weight, int value)
            {
                this.name = name;
                this.weight = weight;
                this.value = value;
            }

        }


        // Método de backtracking para encontrar la mejor solución posible para el problema de la mochila
        // items: conjunto de elementos disponibles
        // weightLimit: límite de peso de la mochila
        // currentItem: índice del elemento actual que se está procesando
        // currentSolution: solución actual que se está explorando
        // bestSolution: mejor solución encontrada hasta el momento (por referencia para poder actualizarla)
        static void Backtrack(List<Item> items, int weightLimit, int currentItem, KnapsackSolution currentSolution, ref KnapsackSolution bestSolution)
        {
            // Si hemos procesado todos los elementos, guardamos la solución si es mejor que la mejor solución conocida
            if (currentItem == items.Count)
            {
                if (currentSolution.totalValue > bestSolution.totalValue)
                {
                    bestSolution = currentSolution;
                }
                return;
            }

            // Si añadiendo el elemento actual superamos el límite de peso de la mochila, no podemos seguir por esta rama
            if (currentSolution.totalWeight + items[currentItem].weight > weightLimit)
            {
                return;
            }

            // Intentamos no incluir el elemento actual en la solución
            Backtrack(items, weightLimit, currentItem + 1, currentSolution, ref bestSolution);

            // Intentamos incluir el elemento actual en la solución
            KnapsackSolution newSolution = new KnapsackSolution(currentSolution);
            newSolution.items.Add(items[currentItem]);
            newSolution.totalWeight += items[currentItem].weight;
            newSolution.totalValue += items[currentItem].value;
            Backtrack(items, weightLimit, currentItem + 1, newSolution, ref bestSolution);
        }


        // Clase para representar una solución del problema de la mochila
        class KnapsackSolution
        {
            // Lista de elementos incluidos en la solución
            public List<Item> items;

            // Peso total de los elementos incluidos en la solución
            public int totalWeight;

            // Valor total de los elementos incluidos en la solución
            public int totalValue;

            // Constructor por defecto
            public KnapsackSolution()
            {
                items = new List<Item>();
                totalWeight = 0;
                totalValue = 0;
            }

            // Constructor de copia
            public KnapsackSolution(KnapsackSolution other)
            {
                items = new List<Item>(other.items);
                totalWeight = other.totalWeight;
                totalValue = other.totalValue;
            }
        }


    }
}

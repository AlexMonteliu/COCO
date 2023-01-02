using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2COCO
{
    internal class objetos
    {
        public string nombre;
        public int precioTotal;
        public int peso;


        public objetos(int peso, int precioTotal, string nombre)
        {
            this.nombre = nombre;
            this.precioTotal = precioTotal;
            this.peso = peso;

        }
    }
}

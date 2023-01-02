using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2COCO
{
    internal class Voraz
    {
        public double[] Vorazz(objetos[] objeto, int capacidadMaxima)
        {
            double[] x = new double[objeto.Length];
            double pesoAcumulado = 0;
            int i = 0;

            // objetos = Ordenar(objetos);

            while (pesoAcumulado < capacidadMaxima && i < objeto.Length)
            {
                if (objeto[i].peso + pesoAcumulado < capacidadMaxima)
                {
                    x[i] = 1;
                }
                else
                {
                    x[i] = (capacidadMaxima - pesoAcumulado) / objeto[i].peso;
                }
                pesoAcumulado = pesoAcumulado + (x[i] * objeto[i].peso);
                i++;

            }

            return x;
        }
    }
}

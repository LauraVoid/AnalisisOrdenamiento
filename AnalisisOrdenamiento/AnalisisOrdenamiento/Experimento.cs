using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalisisOrdenamiento
{
    class Experimento
    {
        private Ordenamiento ordenamiento;
        public const int NumTratameintos = 216; 

        public Experimento()
        {
           
           ordenamiento = new Ordenamiento(8, 100, 2, "aleatorio", "burbuja");
           


        }
           
    }
}

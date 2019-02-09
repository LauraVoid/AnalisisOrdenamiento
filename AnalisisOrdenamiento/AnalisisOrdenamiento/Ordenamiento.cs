using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalisisOrdenamiento
{
    public class Ordenamiento
    {

        private int[] collection;
        private Stopwatch sw; // Creación del Stopwatch (Para medir tiempo)

        private TimeSpan start;
        private TimeSpan stop;


        public Ordenamiento(int tam)
        {
            collection = new int[tam];
            sw = new Stopwatch();

        }
        public int[] getCollection()
        {
            return collection;
        }
        /*Se encarga de llenar el arreglo con numeros aleatorias de 0 a 1000
         */          
        public void RandomFillSmall()
        {
            Random r = new Random();
            collection = Enumerable.Range(0, collection.Length).Select(n => n = r.Next(0,1000)).ToArray();

        }

        public void RandomFillBig()
        {
            Random r = new Random();
            collection = Enumerable.Range(0, collection.Length).Select(n => n = r.Next(10000, 1000000)).ToArray();

        }

        public void QuickSort(int [] col,int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(col, left, right);
                if (pivot > 1)
                {
                    QuickSort(col, left, pivot - 1);
                }
                if(pivot+1 < right)
                {
                    QuickSort(col, pivot + 1, right);
                }
            }

        }
        public int Partition(int [] col, int left, int right)
        {
            int pivot = col[left];
            while (true)
            {
                while (col[left ] <pivot)
                {
                    left++;
                }
                while (col[right] > pivot)
                {
                    right--;
                }
                if (left < right)
                {

                    if (col[left] == col[right]) return right;

                    int temp = col[left];
                    col[left] = col[right];
                    col[right] = temp;
                }
                else
                {
                    return right;
                }
            }
        }

        public int[] Burbuja()
        {
            int[] arr = (int[])collection.Clone();
            int t;
            for(int i = 1; i < arr.Length; i++)
            {
                for(int j = arr.Length - 1; j >= i;j--)
                {
                    if(arr[j-1]> arr[j])
                    {
                        t = arr[j - 1];
                        arr[j - 1] = arr[j];
                        arr[j] = t;

                    }
                }
            }
            return arr;
        }
        // Iniciar la medición.
        public void checkTimeStart()
        {
            
           // sw.Start();
           
            start = new TimeSpan(DateTime.Now.Ticks);

        }
        // Detener la medición.
        public double checkTimeEnd()
        {
            
            stop = new TimeSpan(DateTime.Now.Ticks);
           
            //sw.Stop(); 
            //return sw.Elapsed.ToString("hh\\:mm\\:ss\\.fffff");
            return stop.Subtract(start).TotalMilliseconds;
        }
        

        public int suma(int a, int b)
        {
            return a + b;
        }

        static void Main(string[] args)
        {
            Ordenamiento o = new Ordenamiento(100000);
            o.RandomFillBig();
            int[] arr = o.getCollection();
            Console.WriteLine("ARREGLO ORIGINAL");
            //foreach(var s in arr)
            //{
            //    Console.WriteLine(s);
            //}
            Console.WriteLine("ARREGLO ORDENADO ");
            // o.QuickSort(arr, 0, arr.Length - 1);

            o.checkTimeStart();
            int [] x=o.Burbuja();
            o.checkTimeEnd();
            Console.WriteLine("Time que se demora: {0}", o.checkTimeEnd());
            //foreach (var t in x)
            //{
            //    Console.WriteLine(t);
            //}
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalisisOrdenamiento
{
    public class Ordenamiento
    {

        private int[] collection;

        public Ordenamiento(int tam)
        {
            collection = new int[tam];

        }
        public int[] getCollection()
        {
            return collection;
        }
        /*Se encarga de llenar el arreglo con numeros aleatorias de 0 a 1000
         */          
        public void RandomFill()
        {
            Random r = new Random();
            collection = Enumerable.Range(0, collection.Length).Select(n => n = r.Next(0,1000)).ToArray();

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


        public int suma(int a, int b)
        {
            return a + b;
        }

        static void Main(string[] args)
        {
            Ordenamiento o = new Ordenamiento(10);
            o.RandomFill();
            int[] arr = o.getCollection();
            Console.WriteLine("ARREGLO ORIGINAL");
            foreach(var s in arr)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("ARREGLO ORDENADO ");
            // o.QuickSort(arr, 0, arr.Length - 1);
            int [] x=o.Burbuja();
            foreach(var t in x)
            {
                Console.WriteLine(t);
            }
        }
    }
}

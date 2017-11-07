using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyectobubblesort
{
    public class Bubblesort
    {
        public void BubleSort(int[] numbers)
        {
            int t;
            for (int p = 0; p <= numbers.Length - 2; p++)
            {
                for (int i = 0; i <= numbers.Length - 2; i++)
                {
                    if (numbers[i] > numbers[i + 1])
                    {
                        t = numbers[i + 1];
                        numbers[i + 1] = numbers[i];
                        numbers[i] = t;
                    }
                }
            }
            //    Boolean swapped = true;
            //    while (swapped) // continuar hasta que no haya intercambio

            //    {
            //        swapped = false;
            //        for (int k = 0; k < numbers.Length - 1; k++)
            //        {
            //            if (numbers[k] > numbers[k + 1])
            //            {
            //                Swap(numbers, k);
            //                swapped = true; // si hay al menos un cambio que el boolean sea true

            //            }
            //        }
            //    }
            //}
            //private void Swap(int[] numbers, int k)
            //{
            //    int temp = numbers[k + 1];
            //    numbers[k + 1] = numbers[k];
            //    numbers[k] = temp;
            //}
        }
    }

}

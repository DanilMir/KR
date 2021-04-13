using System;
using System.Collections.Generic;
using System.Linq;

namespace K2_2
{
    class Program
    {
        static int[] GenerateReheto(int[] array)
        {
            for (int i = 2; i < array.Length; i++)
            {
                if (array[i] == 0)
                {
                    for (int j = 2 * i; j < array.Length; j += i)
                    {
                        array[j]++;
                    }
                }
            }

            return array;
        }

        static void Main(string[] args)
        {
            var list = new List<int>() {1, 2, 3, 4, 5, 6, 7, 8, 9};
            list.Sort();
            var resheto = GenerateReheto(new int[list[^1] + 1]);
            var finnal = new List<int>(list);
            for (int i = 0; i < list.Count; i++)
            {
                if (resheto[list[i]] == 0)
                {
                    finnal.Add(list[i]);
                }
            }

            finnal.Sort();

            Console.WriteLine(String.Join(" ", finnal));
        }
    }
}
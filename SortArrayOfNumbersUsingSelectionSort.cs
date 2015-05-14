﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SortArrayOfNumbersUsingSelectionSort
{
    class SortArrayOfNumbersUsingSelectionSort
    {
        static void Main(string[] args)
        {
            int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int min = 0;

            for (int i = 0; i < input.Length; i++)
            {
                for (int j = i + 1; j < input.Length; j++)
                {
                    if (input[i] > input[j])
                    {
                        min = input[j];
                        input[j] = input[i];
                        input[i] = min;
                    }
                }
            }
            Console.WriteLine(string.Join(" ", input));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SortArrayOfNumbers
{
    class SortArrayOfNumbers
    {
        static void Main()
        {
            int[] numbers = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            Array.Sort(numbers);

            Console.Write(string.Join(" ", numbers));
            Console.WriteLine();

        }
    }
}

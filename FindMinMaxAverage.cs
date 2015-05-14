using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.FindMinMaxAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] input = Array.ConvertAll(Console.ReadLine().Split(), double.Parse);

            List<int> roundNumbers = new List<int>();
            List<double> floatNumbers = new List<double>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] % 1 == 0)
                {
                    roundNumbers.Add((int)input[i]);

                }
                else
                {
                    floatNumbers.Add(input[i]);
                }
            }

            Console.WriteLine("[{0}] -> min: {1}, max: {2}, sum: {3}, avg: {4:f2}", string.Join(" ", floatNumbers), floatNumbers.Min(), floatNumbers.Max(), floatNumbers.Sum(), floatNumbers.Average());
            Console.WriteLine("[{0}] -> min: {1}, max: {2}, sum: {3}, avg: {4:f2}", string.Join(" ", roundNumbers), roundNumbers.Min(), roundNumbers.Max(), roundNumbers.Sum(), roundNumbers.Average());
        }
    }
}

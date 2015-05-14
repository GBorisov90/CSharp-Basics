using System;

namespace _10.LongestWordInAText
{
    class LongestWordInAText
    {
        static void Main(string[] args)
        {
            string[] word = Console.ReadLine().Split(new char[] { ',', ';', ' ', '-', '.' },
            StringSplitOptions.RemoveEmptyEntries);
            string maxWord = word[0];
            for (int i = 0; i < word.Length; i++)
            {
                if (maxWord.Length > word[i].Length)
                {
                    continue;
                }
                else
                {
                    maxWord = word[i];
                }
            }
            Console.WriteLine(maxWord);
        }
    }
}

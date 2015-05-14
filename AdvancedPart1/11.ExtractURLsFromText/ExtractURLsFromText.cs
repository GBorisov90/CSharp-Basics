﻿using System;
using System.Text.RegularExpressions;

namespace _11.ExtractURLsFromText
{
    class ExtractURLsFromText
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Regex linkParser = new Regex(@"(?:https?://|www.)\S+\b", RegexOptions.Compiled | RegexOptions.IgnoreCase);
            foreach (var item in linkParser.Matches(text))
            {
                Console.WriteLine(item);
            }
        }
    }
}

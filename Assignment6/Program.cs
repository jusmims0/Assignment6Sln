using System;

namespace Assignment6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string text = "Learning Programming is cool";

            string[] words = text.Split(' ');

            int longestWordLength = 0;
            string longestWord = "";


            for(int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > longestWordLength)
                { 
                    longestWordLength = words[i].Length;
                    longestWord = words[i];
                }
            }

            Console.WriteLine($"The longest word is {longestWord}");
        }
    }
        
}

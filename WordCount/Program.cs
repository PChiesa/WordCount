using System;
using System.Linq;

namespace WordCount
{
    class Program
    {
        static WordCountValidation wordCount = new WordCountValidation();

        static void Main(string[] args)
        {
            Console.WriteLine("Escreva um algoritmo que receba uma palavra e retorne à quantidade de cada letra existente.");
            Console.WriteLine("Digite uma palavra:");
            string nWord = Console.ReadLine();
            var letters = wordCount.CountWords(nWord);

            var keys = letters.Keys.ToList();

            for (int i = 0; i < keys.Count; i++)
            {
                Console.WriteLine($"{keys[i]}:{letters[keys[i]]}");
            }
            Console.ReadKey();
        }
    }
}

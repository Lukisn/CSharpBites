using System;
using System.Collections.Generic;

namespace Bite01_Scrabble
{
    class Program
    {
        public static void Main(string[] args)
        {
            var scrabble = new Scrabble();
            Console.WriteLine(scrabble);
            try
            {
                scrabble.LoadWords();
            }
            catch (NotImplementedException exception)
            {
                Console.WriteLine($"Exception caught: {exception.Message}");
            }

            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }

    class Scrabble
    {
        /// <summary>
        /// Loads the words from the dictionary file into a list and returns it.
        /// </summary>
        public List<string> LoadWords(string Path)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Calculates the word value of the given word.
        /// </summary>
        public int CalculateWordValue(string Word)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Find the word with the maximum value of the given list of words.
        /// </summary>
        public string MaximumWordValue(List<string> WordList)
        {
            throw new NotImplementedException();
        }
    }
}

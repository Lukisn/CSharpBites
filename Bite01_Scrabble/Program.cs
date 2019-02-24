using System;
using System.Collections.Generic;
using System.IO;

namespace Bite01_Scrabble
{
    class Program
    {
        public static void Main(string[] args)
        {
            string path = "../../dictionary.txt";
            var scrabble = new Scrabble();
            Console.WriteLine(scrabble);
            try
            {
                scrabble.LoadWords(path);
            }
            catch (Exception exception)
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
            string line;
            var wordList = new List<string>();
            if (File.Exists(Path))
            {
                using (StreamReader reader = File.OpenText(Path))
                {
                    while ((line = reader.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                        wordList.Add(line);
                    }
                }
            }
            else
            {
                Console.WriteLine($"File {Path} does not exist!");
                Console.WriteLine($"Current Directory is: {Directory.GetCurrentDirectory()}");
            }
            return wordList;
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

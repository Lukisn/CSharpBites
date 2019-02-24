using System;

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
                Console.WriteLine($"Exception caught: {exception.Data}\n{exception.Message}");
            }

            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }

    class Scrabble
    {
        public void LoadWords()
        {
            throw new NotImplementedException();
        }

        public void CalculateWordValue()
        {
            throw new NotImplementedException();
        }

        public void MaximumWordValue()
        {
            throw new NotImplementedException();
        }
    }
}

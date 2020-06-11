using System;

namespace First
{
    class Program
    {
        static void Main(string[] args)
        {
            //Not file example
            Round round = new Round(new Point(1.5, -1.65), 6.65);
            Console.WriteLine(round.ToString());

            //File example
            FileReader reader = new FileReader("input.txt");
            Console.WriteLine(reader.GetRound());

            foreach (var roundInFile in reader.GetRounds())
                Console.WriteLine(roundInFile.ToString());
        }
    }
}
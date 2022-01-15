using System;

namespace SnytaxSugarExerciseConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Give me a number between 1 and 10");

            var answer = int.Parse(Console.ReadLine());
            string noSugarReponse;

            //no sugar
            if (answer < 9)
            {
                noSugarReponse = ($"{answer} is less than nine");
            }
            else
            {
                noSugarReponse = ($"{answer} is greater than or equal to nine");
            }
            Console.WriteLine(noSugarReponse);

            //syntax sugar
            var response = (answer < 9) ? $"{answer} is less than nine" : $"{answer} is greater than or equal to nine";
            Console.WriteLine(response);
        }
    }
}

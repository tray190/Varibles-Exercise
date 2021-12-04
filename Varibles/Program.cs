using System;

namespace Varibles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Tracy";
            int age = 27;
            char middleInitial = 'L';
            bool canSing = true;
            double score = 5.7;
            decimal balamce = 300.25M;

            Console.WriteLine($" name: {name}\n" +
                               $"Age: {age}\n" +
                               $"middle Initial: {middleInitial}\n" +
                               $"can Sing: {true}\n" +
                               $"score: {5.7}\n" +
                               $"balance: {300.25M}\n");
         
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotoJokerGenerator
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("This is Genrator for Toto Joker combinations. How many numbers do you want to tag?");
            Console.Write("Number of numbers to mark: ");
            int numberOfPosition = int.Parse(Console.ReadLine());
            
            Random positions = new Random();

            Console.Write("Your combination is ");

            numberOfPosition = NewMethod(numberOfPosition, positions);          
        }

        private static int NewMethod(int numberOfPosition, Random positions)
        {
            double sumForPay = 0;
            List<int> combination = new List<int>();

            if (numberOfPosition >= 1 && numberOfPosition <= 9)
            {

                for (int i = 0; i < numberOfPosition; i++)
                {
                    combination.Add(positions.Next(1, 10));
                    sumForPay = sumForPay + 0.20;
                }
               
                combination.Sort();

                bool isUnique = combination.Distinct().Count() == combination.Count();

                if (isUnique) {

                    foreach (var nums in combination)
                    {
                        Console.Write(nums + " ");
                    }

                    Console.WriteLine();
                }
                else 
                {
                    NewMethod(numberOfPosition, positions);
                }           
            }
            else 
            {
                Console.Write("invalid number. Choose a number between 1 and 9: ");
                numberOfPosition = int.Parse(Console.ReadLine());   
                NewMethod(numberOfPosition, positions);
               
            }       
            return numberOfPosition;
        }
    }
}

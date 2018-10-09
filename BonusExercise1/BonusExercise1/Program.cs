using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusExercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            int Grade;
            string doAgain;
            

            do {
                Console.Clear();
                Console.Write("Please enter a number grade: ");
                Grade = Convert.ToInt32(Console.ReadLine());

                if (Grade >= 99)
                {
                    Console.WriteLine("A+");
                }
                else if (Grade >= 92)
                {
                    Console.WriteLine("A");
                }
                else if (Grade >= 90)
                {
                    Console.WriteLine("A-");
                }
                else if (Grade >= 89)
                {
                    Console.WriteLine("B+");
                }
                else if (Grade >= 82)
                {
                    Console.WriteLine("B");
                }
                else if (Grade >= 80)
                {
                    Console.WriteLine("B-");
                }
                else if (Grade >= 79)
                {
                    Console.WriteLine("C+");
                }
                else if (Grade >= 72)
                {
                    Console.WriteLine("C");
                }
                else if (Grade >= 70)
                {
                    Console.WriteLine("C-");
                }
                else if (Grade >= 69)
                {
                    Console.WriteLine("D+");
                }
                else if (Grade >= 62)
                {
                    Console.WriteLine("D");
                }
                else if (Grade >= 60)
                {
                    Console.WriteLine("D-");
                }
                else
                {
                    Console.WriteLine("YOU FAILED!");
                }
                Console.WriteLine("Enter another grade? Y/N");
                doAgain = Console.ReadLine();
            } while (doAgain != "N" && doAgain != "n");
            

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4___Squares_and_cubes
{
    class Program
    {
        static void Main(string[] args)
        {
            int userNum, numSquared, numCubed;
            string numIn, again;

            do
            {
                Console.Write("Please, enter an integer: ");
                userNum = int.Parse(numIn = Console.ReadLine());

                Console.WriteLine("Number" + "     " + "Squared" + "     " + "Cubed");
                for (int i = 0; i < userNum; i++)
                {
                    Console.WriteLine();
                }

                Console.WriteLine("Continue? y/n");
                again = Console.ReadLine();
            } while (again == "y");
        }
    }
}

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
                Console.WriteLine("------------------------------------------------");
                for (int i = 1; i <= userNum; i++)
                {
                    numSquared = i * i;
                    numCubed = i * i * i;    
                    Console.WriteLine(i + "          " + numSquared + "           " + numCubed);
                }

                Console.WriteLine("Continue? y/n");
                again = Console.ReadLine();
                again = again.ToLower();
            } while (again == "y");
        }        
    }
}

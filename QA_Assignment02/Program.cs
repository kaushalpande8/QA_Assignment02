using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA_Assignment02
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Please enter your choice");
                Console.WriteLine("-----------------------------");
                Console.WriteLine("1. Enter triangle dimension");
                Console.WriteLine("2. Exit");
                int userValue;
                userValue = int.Parse(Console.ReadLine());
                if (userValue == 1)
                {
                    int triangleSide1, triangleSide2, triangleSide3;
                    do
                    {
                        Console.WriteLine("Enter value for Side 1:  ");
                        triangleSide1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter value for Side 2: ");
                        triangleSide2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter value for side 3: ");
                        triangleSide3 = int.Parse(Console.ReadLine());
                        if (triangleSide1 < 0 || triangleSide2 < 0 || triangleSide3 < 0)
                        {
                            Console.WriteLine("Triangle dimesions can never be less than 0 !!");
                        }
                        else if (triangleSide1 == 0 || triangleSide2 == 0 || triangleSide3 == 0)
                        {
                            Console.WriteLine("Triangle dimesions can never be 0 !!");
                        }
                        else
                        {
                            String Display = TriangleSolver.Analyze(triangleSide1, triangleSide2, triangleSide3);
                            Console.WriteLine(Display);
                            break;
                        }
                    }
                    while (true);
                }

            }
        }
    }
}

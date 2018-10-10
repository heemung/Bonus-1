using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberGrade;
            string letterGrade = "FFF";
            bool usercontinue = true, testForNumber;
 
            Console.WriteLine("Welcome to the Letter Grade Converter!\n");

                while(usercontinue)
                {
                do
                {
                    Console.WriteLine("Enter a numerical grade:");

                   testForNumber = int.TryParse(Console.ReadLine(), out numberGrade);

                } while (numberGrade < 0 && numberGrade > 100 && testForNumber);

                if (numberGrade < 60)
                    letterGrade = "F";
                else if (numberGrade < 67 && numberGrade > 59)
                    letterGrade = "D";
                else if (numberGrade < 80 && numberGrade > 66)
                    letterGrade = "C";
                else if (numberGrade < 88 && numberGrade > 79)
                    letterGrade = "B";
                else if(numberGrade < 101 && numberGrade > 87)
                    letterGrade = "A";

                switch (letterGrade)
                {
                    case "A":
                        if (numberGrade < 101 && numberGrade > 98)
                            Console.WriteLine("Letter Grade: A+");
                        else if (numberGrade < 98 && numberGrade > 93)
                            Console.WriteLine("Letter Grade: A");
                        else if (numberGrade < 93 && numberGrade > 87)
                            Console.WriteLine("Letter Grade: A-");
                        break;
                    case "B":
                        if (numberGrade < 88 && numberGrade > 84)
                            Console.WriteLine("Letter Grade: B+");
                        else if (numberGrade < 85 && numberGrade > 82)
                            Console.WriteLine("Letter Grade: B");
                        else if (numberGrade < 82 && numberGrade > 78)
                            Console.WriteLine("Letter Grade: B-");
                        break;
                    case "C":
                        if (numberGrade < 79 && numberGrade > 75)
                            Console.WriteLine("Letter Grade: C+");
                        else if (numberGrade < 76 && numberGrade > 72)
                            Console.WriteLine("Letter Grade: C");
                        else if (numberGrade < 73 && numberGrade > 67)
                            Console.WriteLine("Letter Grade: C-");
                        break;
                    case "D":
                        if (numberGrade < 68 && numberGrade > 65)
                            Console.WriteLine("Letter Grade: D+");
                        else if (numberGrade < 66 && numberGrade > 63)
                            Console.WriteLine("Letter Grade: D");
                        else if (numberGrade < 64 && numberGrade > 59)
                            Console.WriteLine("Letter Grade: D-");
                        break;
                    case "F":
                        Console.WriteLine("Letter Grade: F");
                        break;
                    default:
                        Console.WriteLine("X");
                        break;
                    
                }
                Console.WriteLine("Do you want to run again. y/n?");
                usercontinue = Console.ReadLine().ToLower() == "y";
            }
        }
    }
}

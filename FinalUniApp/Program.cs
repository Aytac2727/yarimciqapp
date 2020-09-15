using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalUniApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Groups group = new Groups();
            string userInput;
            int input;
            do
            {
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Please, select one of the below\n");
                Console.WriteLine("1.Create Group and Group list");
                Console.WriteLine("2.Add Program");
                Console.WriteLine("3.Select Program id and add Specification");
                Console.WriteLine("4.Select the program for the group");
                Console.WriteLine("5.Create Teacher and Teacher list");
                Console.WriteLine("6.Add student");
                Console.WriteLine("7.Show student's information");
                Console.WriteLine("8.Exit");
                Console.Write(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
                userInput = Console.ReadLine();

                if (int.TryParse(userInput, out input))
                {
                    Console.WriteLine(userInput);
                    switch (input)
                    {
                        case 1:
                            Groups.AddGroup();
                            break;
                        case 6:
                            group.AddStudent();
                            break;
                        case 7:
                            group.AddStudentInfo();
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Please, write numeric number!");
                }

                
            } while (userInput !="8");
        }
    }
}

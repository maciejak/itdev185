using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        // arrays == runtime errors not compile time errors
        // generics allow you to specify a type, will issue a compile time error

        static void Main(string[] args)
        {
            int choice, numItems = 0, numInput;
            string stringInput;

            WriteLine();
            Write("Welcome to List Creator.");
            WriteLine();

            while (true)
            {
                choice = GetUserSelection();
                if (choice == 3)
                    break;
                Write("Enter the number of items to add to your list: ");
                numItems = Convert.ToInt32(ReadLine());

                switch (choice)
                {
                    case 1:
                        var numbers = new GenericList<int>();
                        for (int i = 1; i <= numItems; i++)
                        {
                            Write($"Enter Numerical List item {i}: ");
                            numInput = Convert.ToInt32(ReadLine());
                            numbers.Add(numInput);
                        }
                        break;
                    case 2:
                        var strings = new GenericList<string>();
                        for (int i = 1; i <= numItems; i++)
                        {
                            Write($"Enter String List item {i}: ");
                            stringInput = ReadLine();
                            strings.Add(stringInput);
                        }
                        break;
                    case 3:
                        break;
                    default:
                        Write("You have entered an invalid choice.");
                        break;
                }
            }

            WriteLine("Exiting Program.");
            ReadLine();
        }

        static int GetUserSelection()
        {
            int choice;
            WriteLine();
            WriteLine("Please enter the type of list you would like to create: ");
            WriteLine("1. Numerical");
            WriteLine("2. String");
            WriteLine("3. Exit");
            Write("Your Selection: ");
            choice = Convert.ToInt32(ReadLine());
            return choice;
        }
    }
}

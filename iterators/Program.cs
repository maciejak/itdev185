using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterators
{
    class Program
    {
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
                Write("Enter the number of list items: ");
                numItems = Convert.ToInt32(ReadLine());

                switch (choice)
                {
                    case 1:
                        List<int> numbers = new List<int>();
                        for (int i = 1; i <= numItems; i++)
                        {
                            Write($"Enter Numerical List item {i}: ");
                            numInput = Convert.ToInt32(ReadLine());
                            numbers.Add(numInput);
                        }
                        List<int>.Enumerator e = numbers.GetEnumerator();
                        DisplayInt(e);
                        break;
                    case 2:
                        List<string> strings = new List<string>();
                        for (int i = 1; i <= numItems; i++)
                        {
                            Write($"Enter String List item {i}: ");
                            stringInput = ReadLine();
                            strings.Add(stringInput);
                        }
                        List<string>.Enumerator f = strings.GetEnumerator();
                        DisplayString(f);
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
            WriteLine("--------------------------------------------------------");
            WriteLine("Please enter the type of list you would like to create: ");
            WriteLine();
            WriteLine("\t1. Numerical");
            WriteLine("\t2. String");
            WriteLine("\t3. Exit");
            WriteLine("--------------------------------------------------------");
            Write("Enter Your Selection: ");
            choice = Convert.ToInt32(ReadLine());
            return choice;
        }

        static void DisplayInt(IEnumerator<int> e)
        {
            WriteLine();
            Write("---> Here is your list: ");
            while (e.MoveNext())
            {
                int value = e.Current;
                Write($"{value} ");
            }
            WriteLine();
        }

        static void DisplayString(IEnumerator<string> f)
        {
            WriteLine();
            WriteLine("---> Here is your list: ");
            while (f.MoveNext())
            {
                string value = f.Current;
                Write($"{value} ");
            }
            WriteLine();
        }
    }
}


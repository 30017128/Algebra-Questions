using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algebra_Questions
{
    class Program
    {
        static void Main(string[] args)
        {

            /*/
            Console.WriteLine("Enter your letter here");
            string input = Console.ReadLine();
            switch (input)
            {
                case "a":
                case "e":
                case "i":
                case "o":
                case "u":
                    Console.WriteLine($"{input} is a vowel");
                    break;
                default:
                    Console.WriteLine($" {input} is a consonant");
                    break;
                    






            }
            Console.WriteLine("Please press enter to exit");
            Console.ReadLine();

            Console.WriteLine("This app will calculate your BMI (Body Mass Index)");
            Console.Write("Please enter your weight in Kg's: ");
            float weight = float.Parse(Console.ReadLine());
            Console.Write("Now Please enter your height in CM's: ");
            float height = float.Parse(Console.ReadLine());
            Console.WriteLine("Your BMI is: " + (weight / (height * height)));

            Console.WriteLine("Please press enter to quit");
            Console.ReadLine();


            Console.WriteLine("This app will calculate the sum of 20 numbers.");
            float total = 0;
            for (int i=1; i<=20; i++)
            {
                Console.WriteLine($"Please enter a number {i}: ");
                total = total + float.Parse(Console.ReadLine());
            }
            Console.WriteLine($" The sum of the numbers you entered is: {total}");
            Console.WriteLine("Press enter to quit");
            Console.ReadLine();

            /*/


            Console.WriteLine("This app will calculate the factorial of 10");
            int total = 1;
            int i = 1;
            while (i<=10)
            {
                total *= 1;
                i++;

            }

            Console.WriteLine($"10 factorial is:  {total} ");

            Console.WriteLine("please press enter to quit...");
            Console.ReadLine();


            }


        
        
       


        }
    }


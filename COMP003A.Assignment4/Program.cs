//Author: Jaime Garcia
//Course: COMP003A
//Purpose: Week 4 Assignment for,foreach, do-while, and while statements


using System.Diagnostics.Metrics;

namespace COMP003A.Assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("".PadRight(50, '*'));
            Console.WriteLine("for loop section");
            Console.WriteLine("Output a right triangle based on user input");
            Console.WriteLine("".PadRight(50, '*'));

            Console.WriteLine("\tEnter a positive whole number:");

            int userInput = Convert.ToInt32(Console.ReadLine()); //stores user input
            int limit = userInput;
            string output = "";

            //for statement syntax
            for (int i = 0; i <= limit; i++)
            { 
                //this block will execute every loop
                Console.WriteLine($"\t{output += "#"}");
            }

            //foreach statement section
            Console.WriteLine("\n");
            Console.WriteLine("".PadRight(50, '*'));
            Console.WriteLine("foreach Section");
            Console.WriteLine("Output all of the friends in an array");
            Console.WriteLine("".PadRight(50, '*'));

            //simple array with friends cast memebers
            string[] friends = new string[] {"Rachel","Joey","Chandler","Ross",
            "Monica", "Phoebe"};

            foreach (var item in friends)
            {
                //block executes code for friends array
                Console.WriteLine($"\t{item}");
            }

            //do-while statement section

            Console.WriteLine("\n");
            Console.WriteLine("".PadRight(50, '*'));
            Console.WriteLine("do-while Section");
            Console.WriteLine("Output 0-50 by 5s");
            Console.WriteLine("".PadRight(50, '*'));

            int counter = -5;
            
            do 
            {
                Console.WriteLine($"\t{counter += 5}");
            } while(counter >=0 && counter < 50);

            //while section 
            Console.WriteLine("\n");
            Console.WriteLine("".PadRight(50, '*'));
            Console.WriteLine("while Section");
            Console.WriteLine("Output 1-20");
            Console.WriteLine("If the number is divisible by 2, output Foo");
            Console.WriteLine("If the number is divisible by 5, output Bar");
            Console.WriteLine("If the number is divisible by 2 &5, output FooBar");
            Console.WriteLine("".PadRight(50, '*'));

            int counter2 = 0;
            string foo = "Foo";
            string bar = "Bar";
            string fooBar = "FooBar";
            

            while (counter2 < 20)
            {
               // Console.WriteLine($"\t{counter2}");
                counter2++;

                if (counter2 % 2 == 0 && counter2 % 5 == 0)
                {
                    Console.WriteLine($"\t{fooBar}");
                }
                else if (counter2 !% 2 == 0)
                { 
                    Console.WriteLine($"\t{foo}");
                }
                else if (counter2 % 5 == 0)
                {
                    Console.WriteLine($"\t{bar}");
                }
                else
                {
                    Console.WriteLine($"\t{counter2}");
                }
                
            }
            
          




        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheers
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello, World");

            //Step 1: Getting user's name and print it.
            System.Console.WriteLine("What is your name?");
            string name = System.Console.ReadLine();
            //string name = System.Console.ReadLine().ToLower();
            System.Console.WriteLine("Welcome, " + name);
            string upperName = name.ToUpper();

            //step 2: Cheer the user on.
            //If name is "Bob", output should be:
            //Give me a.. b
            //Give me an.. o
            //Give me a.. b
            //BOB is.. GRAND!

            //char[] charArray = name.ToCharArray();
            //for (int i = 0; i < charArray.Length; i++)
            //{
            //    Console.WriteLine("Give me a.. " + charArray[i]);

            //}
            foreach (char letter in name.ToLower())
            {
                string article = "a";
                if ("halfnorsemix".IndexOf(letter) >= 0)
                {
                    article = "an";
                }
                else
                {
                    article = "a";
                }
                System.Console.WriteLine("Give me " + article + "...." + letter);
            }


            Console.WriteLine(name.ToUpper() + " is.. GRAND");

            System.Console.WriteLine("When is your birthday?");
            //System.Console.ReadLine();
            string age = System.Console.ReadLine();

            System.Console.WriteLine("your birthday is on " + age);


            System.Console.WriteLine("Today's date is " + DateTime.Today);


            System.Console.WriteLine("press any key to exit");
            System.Console.ReadKey();
            System.Console.ReadKey();

            System.Console.ReadKey();

        }
    }
}

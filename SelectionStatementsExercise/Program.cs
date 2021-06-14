using System;

namespace SelectionStatementsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            var favNumber = r.Next(1, 1000);
            Console.WriteLine("Try to guess my favorite number.");
            var userInput = int.Parse(Console.ReadLine());
            if (userInput < favNumber)
            {
                Console.WriteLine("too low");
            }
            else if (userInput > favNumber)
            {
                Console.WriteLine("too high");
            }
            else
            {
                Console.WriteLine("Nevermind");
            }
            Console.WriteLine("What is your favorite school subject?");
            string favSubject = Console.ReadLine();
            switch (favSubject)
            {
                case "math":
                    Console.WriteLine("Math is pretty cool.");
                    break;
                case "science":
                    Console.WriteLine("Science rules! -Bill Nye the Science Guy");
                    break;
                case "lunch":
                    Console.WriteLine("Lunch is not a school subject!");
                    break;
                case "english":
                    Console.WriteLine("I minored in English!");
                    break;
                case "recess":
                    Console.WriteLine("Recess is not a school subject, but it should be!");
                    break;
                default:
                    Console.WriteLine("Yeah, I could see that.");
                    break;
            }

            /* 
Create 5 different cases for different subjects.  Each case will print the subject chosen and a custom message of your choosing.
Create a default case to handle any case not handled.
            switch (day)
{
  case 0:
    Console.WriteLine("Sunday");
    break;
  case 1:
    Console.WriteLine("Monday");
    break;
  case 2:
    Console.WriteLine("Tuesday");
    break;
  case 3:
    Console.WriteLine("Wednesday");
    break;
  case 4:
    Console.WriteLine("Thursday");
    break;
  case 5:
    Console.WriteLine("Friday");
    break;
  case 6:
    Console.WriteLine("Saturday");
    break;
  } 

*/

        }
    }
}

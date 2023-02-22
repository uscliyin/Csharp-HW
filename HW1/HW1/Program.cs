// See https://aka.ms/new-console-template for more information

using System;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;

namespace HW1
{
    public class QuestionSolution
    {
        public void GenerateHackerName()
        {
            Console.Write("What is your favorite color?");
            string favoriteColor = Console.ReadLine();

            Console.Write("What is your astrology sign?");
            string astrologySign = Console.ReadLine();

            Console.Write("What is your street address number?");
            string streetAddressNumber = Console.ReadLine();

            string hackerName = favoriteColor + astrologySign + streetAddressNumber;

            Console.WriteLine("Your hacker name is " + hackerName);
        }

        public void NumberSizesAndRanges()
        {
            Console.WriteLine("sbyte: " + sizeof(sbyte)+" bytes, range from "+sbyte.MinValue+" to "+sbyte.MaxValue);
            Console.WriteLine("byte: " + sizeof(byte) + " bytes, range from " + byte.MinValue + " to " + byte.MaxValue);
            Console.WriteLine("short: " + sizeof(short) + " bytes, range from " + short.MinValue + " to " + short.MaxValue);
            Console.WriteLine("ushort: " + sizeof(ushort) + " bytes, range from " + ushort.MinValue + " to " + ushort.MaxValue);
            Console.WriteLine("int: " + sizeof(int) + " bytes, range from " + int.MinValue + " to " + int.MaxValue);
            Console.WriteLine("uint: " + sizeof(uint) + " bytes, range from " + uint.MinValue + " to " + uint.MaxValue);
            Console.WriteLine("long: " + sizeof(long) + " bytes, range from " + long.MinValue + " to " + long.MaxValue);
            Console.WriteLine("ulong: " + sizeof(ulong) + " bytes, range from " + ulong.MinValue + " to " + ulong.MaxValue);
            Console.WriteLine("float: " + sizeof(float) + " bytes, range from " + float.MinValue + " to " + float.MaxValue);
            Console.WriteLine("double: " + sizeof(double) + " bytes, range from " + double.MinValue + " to " + double.MaxValue);
            Console.WriteLine("decimal: " + sizeof(decimal) + " bytes, range from " + decimal.MinValue + " to " + decimal.MaxValue);
        }

        public void CovertTime()
        {
            int centuries,years,days,hours,minutes,seconds;
            long milliseconds, microseconds, nanoseconds;
            Console.Write("Please enter int interger number of centuries: ");
            string inputValueFromConsole=Console.ReadLine();
            centuries = Int32.Parse(inputValueFromConsole);

            years = 100 * centuries;
            days = years * 365 + (years / 4) - (years / 100) + (years / 400);
            hours = days * 24;
            minutes = hours * 60;
            seconds = minutes * 60;
            milliseconds = seconds * 1000;
            microseconds = milliseconds * 1000;
            nanoseconds = microseconds * 1000;

            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {milliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");

        }

        public void FizzBuzz()
        {

            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0) {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0) {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }

            }

            //int max = 500;
            //for (byte i = 0; i < max; i++)
            //{
            //    if (i == 255)
            //    {
            //        Console.WriteLine("i is max");
            //        break;
            //    }
            //    Console.WriteLine(i);
            //}
            // The console cannot stop because the i is overflowed (rang from 0 to 255)
            // Add if (i ==255) {Console.Write("i has reached its max length 255");break;}
        }
        public void GuessNumber()
        {
            Console.Write("Please guess the number: ");
            int guessNumber = int.Parse(Console.ReadLine());
            int correctNumber = new Random().Next(3) + 1;
            if (guessNumber==correctNumber)
            {
                Console.WriteLine("You're correct");
            }
            else if (guessNumber<1 && guessNumber > 3)
            {
                Console.WriteLine("Your guess number is outside the range of the correct answer");
            }
            else if (guessNumber < correctNumber)
            {
                Console.WriteLine("Your guess number is less than correctNumber");
            }else if (guessNumber > correctNumber)
            {
                Console.WriteLine("Your guess number is larger than correctNumber");
            }
        }
        public void PrintAPyramid()
        {
            Console.Write("Please enter the layer of pyramid: ");
            int layerOfPyramid=int.Parse(Console.ReadLine());

            for (int i=1; i<= layerOfPyramid; i++)
            {
                for (int j=1; j <= layerOfPyramid - i; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 1; k <= 2*i -1; k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine("");
            }
        }
        public void nextAnniversary()
        {
            Console.Write("Please enter your birth day (format: yyyy-MM-dd): ");
            DateTime dateOfBirth=DateTime.Parse(Console.ReadLine());
            DateTime now=DateTime.Now;
            TimeSpan age = now - dateOfBirth;
            int daysOld = (int)age.TotalDays;
        
            int daysToNextAnniversary = 10000 - (daysOld % 10000);
            DateTime nextAnniversary = now.AddDays(daysToNextAnniversary);
            Console.WriteLine("Next Anniversary date is " + nextAnniversary.ToString("yyyy-MM-dd"));

        }

        public void GreetingTime()
        {
            Console.WriteLine("Enter a time you want to greet (format: dd/MM/yyyy HH:mm:ss): ");
            DateTime greetTime=DateTime.Parse(Console.ReadLine());
            int greetHour = greetTime.Hour;
            
            if (greetHour>=6 && greetHour < 12)
            {
                Console.WriteLine("Good Morning");
            }
            else if (greetHour>12 && greetHour<17)
            {
                Console.WriteLine("Good Afternoon");
            }
            else if (greetHour>=17 && greetHour<23)
            {
                Console.WriteLine("Good Evening");
            }
            else if (greetHour >= 23 || greetHour < 6)
            {
                Console.WriteLine("Good Night");
            }
        }
        public void CountingUpTo24()
        {
            for (int i =1; i<=4;i++)
            {
                for (int j =0; j<=24;j+=i)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine("");
            }
        }


            
        
    }
    class Program
    {
        static void Main(string[] args)
        {

            QuestionSolution question = new QuestionSolution();
            //question.NumberSizesAndRanges();
            //questionOne.GenerateHackerName();
            //question.CovertTime();
            //question.FizzBuzz();
            //question.GuessNumber();
            //question.PrintAPyramid();
            //question.nextAnniversary();
            //question.GreetingTime();
            //question.CountingUpTo24();

        }
    }
}





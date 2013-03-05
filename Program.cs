using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3.Exceptions
{
    class Program
    {
        static void Main()
        {
            InvalidRangeException<int> someIntExeption =
                new InvalidRangeException<int>("The have to enter a number in the range from 0 do 100!");
            Console.WriteLine("Enter 5 numbers from 0 do 100:");
            for (int i = 0; i < 5; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number<0 || number>100)
                {
                    throw someIntExeption;
                }
                else
                {
                    Console.WriteLine("The number is correct!");
                }
            }
            InvalidRangeException<DateTime> someDateExpection =
                new InvalidRangeException<DateTime>("The Date isn't in the correct range from 1980 to 2013!");
            Console.WriteLine("Enter 5 dates in the specified format: dd.mm.yyyy!(from 1980 to 2013)");
            for (int i = 0; i < 5; i++)
            {
                string date = Console.ReadLine();
                DateTime someDate = DateTime.Parse(date);
                if (someDate.Year<1980 || someDate.Year>2013)
                {
                    throw someDateExpection;
                }
                else
                {
                    Console.WriteLine("The date is correct!");
                }
            }
        }
    }
}

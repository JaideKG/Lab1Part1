using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //get two dates input
            Console.WriteLine("Welcome to the Date Calculator");
            Console.WriteLine("Please enter all dates in format MM/DD/YYYY HH:MM:SS");
            string input1 = Console.ReadLine();
            Console.WriteLine("Please enter second date");
            string input2 = Console.ReadLine();

            DateTime date1 = DateTime.Parse(input1);
            DateTime date2 = DateTime.Parse(input2);

            //figure out difference between dates
            TimeSpan difference = date2 - date1;
            int days = difference.Days;
            //break apart the difference into 
            //years months days hours minutes
            Console.WriteLine("Years: " + days / 365);
            Console.WriteLine("Months: " + days / 365);
            Console.WriteLine("Days: " + days / 30); 
            Console.WriteLine("Hours: " + difference.Hours);
            Console.WriteLine("Minutes: " + difference.Minutes);

            Console.WriteLine("Pres Any Key....");
            Console.ReadKey();
        }
    }
}

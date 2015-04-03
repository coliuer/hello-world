using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter03
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumber, secondNumber;
            string userName;
            Console.WriteLine("Enter your Name:");
            userName=Console.ReadLine();
            Console.WriteLine("Welcome {0}!", userName);
            Console.WriteLine("Now give me a Number:");
            firstNumber =Convert.ToDouble( Console.ReadLine());
            Console.WriteLine("Now give me another Number:");
            secondNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The sum of {0} and {1} is {2}.", firstNumber, secondNumber, firstNumber + secondNumber);
            Console.WriteLine("The difference of {0} and {1} is {2}.", firstNumber, secondNumber, firstNumber - secondNumber);
            Console.WriteLine("The product of {0} and {1} is {2}.", firstNumber, secondNumber, firstNumber * secondNumber);
            Console.WriteLine("The quotient of {0} and {1} is {2}.", firstNumber, secondNumber, firstNumber % secondNumber);
            Console.ReadKey();
        }
    }
}

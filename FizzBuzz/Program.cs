using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Enumerable.Range(0,100).ToList();
            var fizzBuzz = new FizzBuzz();

            foreach (var number in numbers)
            {
                Console.WriteLine(fizzBuzz.GetResult((number)));
            }
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        public string GetResult(int number)
        {
            if (number <= 0) return number.ToString();

            if (number % 15 == 0)
            {
                return "fizzbuzz";
            }
            if (number % 3 == 0)
            {
                return "fizz";
            }
            if (number % 5 == 0)
            {
                return "buzz";
            }

            return number.ToString();
        }
    }
}

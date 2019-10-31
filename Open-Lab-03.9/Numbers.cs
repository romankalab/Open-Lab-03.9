using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeNumbers
{
    class Numbers
    {
        public bool IsPrimeNumber(int number)
        {
            if (number < 2)
                return false;
            if (number == 2)
                return true;
            for (var i = 2; i < number; i++)
                if (number % i == 0)
                    return false;
            return true;
        }
    }
}

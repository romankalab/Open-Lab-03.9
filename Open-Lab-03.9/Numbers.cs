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
            for (var number2 = 2; number2 < number; number2++)
                if (number % number2 == 0)
                    return false;
            return true;
        }
    }
}

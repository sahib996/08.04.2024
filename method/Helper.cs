using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08._04._2024.method
{
    internal  static class Helper
    {
        public static bool IsOdd(int number)
        {
            return number % 2 != 0;
        }

        public static bool IsEven(int number)
        {
            return number % 2 == 0;
        }
    }
}

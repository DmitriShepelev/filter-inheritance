using System;
using FilterInheritanceTask;

namespace DerivedClasses
{
    public class PalindromicFilter : Filter
    {
        protected override bool Verify(int number)
        {
            int tmp = number;
            int result = 0;
            while (number > 0)
            {
                result = (result * 10) + (number % 10);
                number /= 10;
            }

            if (tmp == result)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

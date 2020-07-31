using System;
using FilterInheritanceTask;

namespace DerivedClasses
{
    public class ContainsDigitFilter : Filter
    {
        public int Digit
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        protected override bool Verify(int number)
        {
            throw new NotImplementedException();
        }
    }
}
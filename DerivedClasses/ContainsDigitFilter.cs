using System;
using FilterInheritanceTask;

namespace DerivedClasses
{
    public class ContainsDigitFilter : Filter
    {

        //TODO: Add code here if necessary or delete this comment.
        public int Digit
        {
            get => throw new NotImplementedException();
            set=> throw new NotImplementedException();
        }

        protected override bool Verify(int number)
        {
            throw new NotImplementedException();
        }
    }
}
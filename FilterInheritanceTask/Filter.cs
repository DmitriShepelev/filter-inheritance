using System;

namespace FilterInheritanceTask
{
    public abstract class Filter
    {
        public int[] Select(int[] source)
        {
            throw new NotImplementedException();
        }

        protected abstract bool Verify(int number);
    }
}
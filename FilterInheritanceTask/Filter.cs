using System;
using System.Collections.Generic;

namespace FilterInheritanceTask
{
    /// <summary>
    ///  Represents the base class for filter classes by some predicate.
    /// </summary>
    public abstract class Filter
    {
        /// <summary>
        /// Filters an array of integers based on a predicate.
        /// </summary>
        /// <param name="source"> An array of integers. </param>
        /// <returns>An array that contains elements from the input array that satisfy the condition.</returns>
        /// <exception cref="ArgumentNullException">Thrown when array is null.</exception>
        /// <exception cref="ArgumentException">Thrown when array is empty.</exception>
        public int[] Select(int[] source)
        {
            if (source is null)
            {
                throw new ArgumentNullException($"Array can not be null.");
            }

            if (source.Length == 0)
            {
                throw new ArgumentException($"Array can not be empty.");
            }

            var list = new List<int>();
            for (int i = 0; i < source.Length; i++)
            {
                if (this.Verify(source[i]))
                {
                    list.Add(source[i]);
                }
            }

            return list.ToArray();
        }

        /// <summary>
        /// Verifies if a given number satisfies a given condition. 
        /// </summary>
        /// <remarks>Must be implemented in derived classes.</remarks>
        /// <param name="number">A given number.</param>
        /// <returns>true if number satisfy the condition; false otherwise.</returns>
        protected abstract bool Verify(int number);
    }
}

using System;
using System.Linq;
using FilterInheritanceTask.Tests.DerivedClasses;
using Moq;
using Moq.Protected;
using NUnit.Framework;

namespace FilterInheritanceTask.Tests.NUnitTests
{
    public class FilterTests
    {
        [TestCase(new[] {1, 2, 3, 4, 5, 6, 7, 8, 9}, ExpectedResult = new[] {1, 2, 3, 4, 5, 6, 7, 8, 9})]
        [TestCase(new[] {717, 828, 45, 58, 881, 11711, 252}, ExpectedResult = new[] {717, 828, 11711, 252})]
        [TestCase(new[] {17, 82, 45, 58, 881, 117, 25}, ExpectedResult = new int[] { })]
        public int[] FilterByPalindromicTests(int[] source)
        {
            var predicate = new PalindromicFilter();
            return predicate.Select(source);         
        }

        //TODO: Add tests for ContainsDigitFilter.
        
        //TODO: Add tests for Exception cases here.
    }
}
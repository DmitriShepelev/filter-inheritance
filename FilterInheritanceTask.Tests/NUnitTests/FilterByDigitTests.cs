using System;
using DerivedClasses;
using NUnit.Framework;

#pragma warning disable CA1707

namespace FilterInheritanceTask.Tests.NUnitTests
{
    public class FilterByDigitTests
    {
        [TestCase(new[] { 2212332, 1405644, -1236674 }, 0, ExpectedResult = new[] { 1405644 })]
        [TestCase(new[] { 53, 71, -24, 1001, 32, 1005 }, 2, ExpectedResult = new[] { -24, 32 })]
        [TestCase(new[] { -27, 173, 371132, 7556, 7243, 10017, int.MinValue, int.MaxValue }, 7, ExpectedResult = new[] { -27, 173, 371132, 7556, 7243, 10017, int.MinValue, int.MaxValue })]
        [TestCase(new[] { -123, 123, 2202, 3333, 4444, 55055, 0, -7, 5402, 9, 0, -150, 287 }, 0, ExpectedResult = new[] { 2202, 55055, 0, 5402, 0, -150 })]
        [TestCase(new[] { -123, 123, 2202, 3333, 4444, 55055, 0, -7, 5402, 9, 0, -150, 287 }, 2, ExpectedResult = new[] { -123, 123, 2202, 5402, 287 })]
        [TestCase(new[] { -583, -7481, -24, -81001, -32, -10805 }, 8, ExpectedResult = new[] { -583, -7481, -81001, -10805 })]
        [TestCase(new[] { 111, 111, 111, 11111111 }, 1, ExpectedResult = new[] { 111, 111, 111, 11111111 })]
        [TestCase(new[] { -1, 0, 111, -11, -1 }, 1, ExpectedResult = new[] { -1, 111, -11, -1 })]
        [TestCase(new[] { int.MinValue, int.MinValue, int.MinValue, int.MaxValue, int.MaxValue }, 0, ExpectedResult = new int[] { })]
        public int[] Select_ContainsDigitVerifyTests(int[] source, int digit)
        {
            ContainsDigitFilter filter = new ContainsDigitFilter { Digit = digit };
            return filter.Select(source);
        }

        [Test]
        public void Select_ContainsDigitVerify_ArrayIsEmpty_ThrowArgumentException()
        {
            var filter = new ContainsDigitFilter { Digit = 0 };
            Assert.Throws<ArgumentException>(() => filter.Select(Array.Empty<int>()), "Array cannot be empty.");
        }

        [Test]
        public void Select_ContainsDigitVerify_ArrayIsNull_ThrowArgumentNullException()
        {
            var filter = new ContainsDigitFilter { Digit = 0 };
            Assert.Throws<ArgumentNullException>(() => filter.Select(null), "Array cannot be null.");
        }

        [Test]
        public void Select_ContainsDigitVerify_DigitLessZero_ThrowArgumentOutOfRangeException() =>
            Assert.Throws<ArgumentOutOfRangeException>(
                () =>
                {
                    var containsDigitFilter = new ContainsDigitFilter { Digit = -1 };
                },
                "Expected digit can not be less than zero.");

        [Test]
        public void Select_ContainsDigitVerify_DigitMoreThanNine_ThrowArgumentOutOfRangeException() =>
            Assert.Throws<ArgumentOutOfRangeException>(
                () =>
                {
                    var containsDigitFilter = new ContainsDigitFilter { Digit = 17 };
                },
                "Expected digit can not be less than zero.");
    }
}

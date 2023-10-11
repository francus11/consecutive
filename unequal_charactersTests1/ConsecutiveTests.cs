using unequal_characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace unequal_characters.Tests
{
    [TestFixture]
    public class ConsecutiveTests
    {
        [TestCase("a", 1)]
        [TestCase("aaa", 1)]
        [TestCase("abcde", 5)]
        [TestCase("mambolei", 7)]
        [TestCase("japan", 3)]
        public void UnequalCharacters_CorrectData_ReturnsValue(string text, int expected)
        {
            int actual = Consecutive.UnequalCharacters(text);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void UnequalCharacters_Null_ThrowsArgumentNullException()
        {
            string text = null;
            var expected = typeof(ArgumentNullException);

            var actual = Assert.Catch(() => Consecutive.UnequalCharacters(text));

            Assert.AreEqual(expected, actual.GetType(), "Method shouldn't work with null string argument");
        }

        [Test]
        public void UnequalCharacters_EmptyString_ThrowsArgumentException()
        {
            string text = "";
            var expected = typeof(ArgumentException);

            var actual = Assert.Catch(() => Consecutive.UnequalCharacters(text));

            Assert.AreEqual(expected, actual.GetType(), "Method shouldn't work with empty string argument");
        }

        [Test]
        public void IdenticalLatinLetters_Null_ThrowsArgumentNullException()
        {
            string text = null;
            var expected = typeof(ArgumentNullException);

            var actual = Assert.Catch(() => Consecutive.IdenticalLatinLetters(text));

            Assert.AreEqual(expected, actual.GetType(), "Method shouldn't work with null string argument");
        }

        [Test]
        public void IdenticalDigits_Null_ThrowsArgumentNullException()
        {
            string text = null;
            var expected = typeof(ArgumentNullException);

            var actual = Assert.Catch(() => Consecutive.IdenticalDigits(text));

            Assert.AreEqual(expected, actual.GetType(), "Method shouldn't work with null string argument");
        }

        [TestCase("1", 1)]
        [TestCase("111", 3)]
        [TestCase("123", 1)]
        [TestCase("122233", 3)]
        [TestCase("te1123st", 2)]
        public void IdenticalDigits_CorrectData_ReturnsValue(string text, int expected)
        {
            int actual = Consecutive.IdenticalDigits(text);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void IdenticalDigits_NoDigits_ReturnsZero()
        {
            string text = "text without digits";
            int expected = 0;

            int actual = Consecutive.IdenticalDigits(text);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void IdenticalDigits_EmptyString_ThrowsArgumentException()
        {
            string text = "";
            var expected = typeof(ArgumentException);

            var actual = Assert.Catch(() => Consecutive.IdenticalDigits(text));

            Assert.AreEqual(expected, actual.GetType(), "Method shouldn't work with empty string argument");
        }

        [Test]
        public void IdenticalLatinLetters_EmptyString_ThrowsArgumentException()
        {
            string text = "";
            var expected = typeof(ArgumentException);

            var actual = Assert.Catch(() => Consecutive.IdenticalLatinLetters(text));

            Assert.AreEqual(expected, actual.GetType(), "Method shouldn't work with empty string argument");
        }

        public void IdenticalLatinLetters_NoLatinLetters_ReturnsZero()
        {
            string text = "123456";
            int expected = 0;

            int actual = Consecutive.IdenticalLatinLetters(text);

            Assert.AreEqual(expected, actual);
        }

        [TestCase("a", 1)]
        [TestCase("aaa", 3)]
        [TestCase("aaabbccc", 3)]
        [TestCase("cccąąąąóóóóbb", 3)]
        [TestCase("112aab", 2)]
        public void IdenticalLatinLetters_CorrectData_ReturnsValue(string text, int expected)
        {
            int actual = Consecutive.IdenticalLatinLetters(text);

            Assert.AreEqual(expected, actual);
        }
    }
}
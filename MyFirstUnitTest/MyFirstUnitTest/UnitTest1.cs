using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyFirstUnitTest
{
    [TestClass]
    public class TestingFizzBuzzCalculator
    {
        FizzBuzz fizzBuzz;

        [TestInitialize]
        public void FizzBuzzInitialize()
        {
            fizzBuzz = new FizzBuzz();
        }

        [TestMethod]
        public void Given1ShouldReturn1()
        {
            var result = fizzBuzz.Calculate(1);
            Assert.AreEqual(result, "1");
        }

        [TestMethod]
        public void Given2ShouldReturn2()
        {
            var result = fizzBuzz.Calculate(2);
            Assert.AreEqual(result, "2");
        }

        [TestMethod]
        public void Given1ShouldReturnFizz()
        {
            var result = fizzBuzz.Calculate(3);
            Assert.AreEqual(result, "Fizz");
        }

        [TestMethod]
        public void Given5ShouldReturnBuzz()
        {
            var result = fizzBuzz.Calculate(5);
            Assert.AreEqual(result, "Buzz");
        }

        [TestMethod]
        public void Given6ShouldReturnBuzz()
        {
            var result = fizzBuzz.Calculate(6);
            Assert.AreEqual(result, "Fizz");
        }

        [TestMethod]
        public void Given10ShouldReturnBuzz()
        {
            var result = fizzBuzz.Calculate(10);
            Assert.AreEqual(result, "Buzz");
        }

        [TestMethod]
        public void Given15ShouldReturnFizzBuzz()
        {
            var result = fizzBuzz.Calculate(15);
            Assert.AreEqual(result, "FizzBuzz");
        }
    }
}

public class FizzBuzz
{
    public string Calculate(int number)
    {
        var fizzBuzzResult = "";

        if (number % 3 == 0)
        {
            fizzBuzzResult = "Fizz";
        }

        if (number % 5 == 0)
        {
            fizzBuzzResult = fizzBuzzResult + "Buzz";
        }

        return string.IsNullOrEmpty(fizzBuzzResult) ? number.ToString() : fizzBuzzResult;
    }
}
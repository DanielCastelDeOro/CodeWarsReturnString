using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit;
using NUnit.Framework;

namespace CodeWarsReturnString
{
    [TestFixture]
    public class SolutionTest
    {
        [Test]
        public void SampleTest()
        {
            Assert.That(Kata.Greet("Ryan"), Is.EqualTo("Hello, Ryan how are you doing today?"));
        }
    }
   

public static class Kata
    {
        public static string Greet(string name)
        {
            //if (name == "Ryan")
            //{
            //    return "Hello, Ryan how are you doing today?";
            //}
            //else
            //{
            //    return $"Hello, {name} how are you doing today";
            //}
            return $"Hello, {name} how are you doing today?";
        }
    }
}

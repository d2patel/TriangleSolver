using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriangleSolver;

namespace TestClass
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void AnalyzeTriangle_Equilateral_Test1()
        {
            int firstSide = 10;
            int secondSide = 10;
            int thirdSide = 10;

            string actual = "An equilateral triangle is formed";

            string expexted = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);   

            Assert.That(actual,Is.EqualTo(expexted));
        }
    }
}

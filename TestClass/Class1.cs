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

        [Test]
        public void AnalyzeTriangle_Scalene_Test1()
        {
            int firstSide = 12;
            int secondSide = 23;
            int thirdSide = 24;

            string actual = "A scalene triangle is formed";

            string expexted = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            Assert.That(actual, Is.EqualTo(expexted));
        }

        [Test]
        public void AnalyzeTriangle_Scalene_Test2()
        {
            int firstSide = 10;
            int secondSide = 12;
            int thirdSide = 16;

            string actual = "A scalene triangle is formed";

            string expexted = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            Assert.That(actual, Is.EqualTo(expexted));
        }

        [Test]
        public void AnalyzeTriangle_Scalene_Test3()
        {
            int firstSide = 3;
            int secondSide = 4;
            int thirdSide = 5;

            string actual = "A scalene triangle is formed";

            string expexted = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            Assert.That(actual, Is.EqualTo(expexted));
        }

        [Test]
        public void AnalyzeTriangle_Scalene_Test4()
        {
            int firstSide = 2;
            int secondSide = 4;
            int thirdSide = 5;

            string actual = "A scalene triangle is formed";

            string expexted = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            Assert.That(actual, Is.EqualTo(expexted));
        }

        [Test]
        public void AnalyzeTriangle_Scalene_Test5()
        {
            int firstSide = 12;
            int secondSide = 13;
            int thirdSide = 20;

            string actual = "A scalene triangle is formed";

            string expexted = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            Assert.That(actual, Is.EqualTo(expexted));
        }
    }
}

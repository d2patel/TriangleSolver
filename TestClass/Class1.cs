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

        [Test]
        public void AnalyzeTriangle_Isosceles_Test1()
        {
            int firstSide = 10;
            int secondSide = 10;
            int thirdSide = 15;

            string actual = "An isosceles triangle is formed";

            string expexted = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            Assert.That(actual, Is.EqualTo(expexted));
        }

        [Test]
        public void AnalyzeTriangle_Isosceles_Test2()
        {
            int firstSide = 2;
            int secondSide = 2;
            int thirdSide = 3;

            string actual = "An isosceles triangle is formed";

            string expexted = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            Assert.That(actual, Is.EqualTo(expexted));
        }

        [Test]
        public void AnalyzeTriangle_Isosceles_Test3()
        {
            int firstSide = 7;
            int secondSide = 10;
            int thirdSide = 7;

            string actual = "An isosceles triangle is formed";

            string expexted = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            Assert.That(actual, Is.EqualTo(expexted));
        }

        [Test]
        public void AnalyzeTriangle_ZeroInput_Test1()
        {
            int firstSide = 0;
            int secondSide = 4;
            int thirdSide = 5;

            string actual = "At least one side entered had a zero - invalid triangle";

            string expexted = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            Assert.That(actual, Is.EqualTo(expexted));
        }

        [Test]
        public void AnalyzeTriangle_ZeroInput_Test2()
        {
            int firstSide = 12;
            int secondSide = 0;
            int thirdSide = 25;

            string actual = "At least one side entered had a zero - invalid triangle";

            string expexted = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            Assert.That(actual, Is.EqualTo(expexted));
        }

        [Test]
        public void AnalyzeTriangle_ZeroInput_Test3()
        {
            int firstSide = 12;
            int secondSide = 44;
            int thirdSide = 0;

            string actual = "At least one side entered had a zero - invalid triangle";

            string expexted = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            Assert.That(actual, Is.EqualTo(expexted));
        }

        [Test]
        public void AnalyzeTriangle_NoTriangle_Test1()
        {
            int firstSide = 12;
            int secondSide = 13;
            int thirdSide = 30;

            string actual = "A triangle cannot be formed";

            string expexted = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            Assert.That(actual, Is.EqualTo(expexted));
        }

        [Test]
        public void AnalyzeTriangle_NoTriangle_Test2()
        {
            int firstSide = 2;
            int secondSide = 5;
            int thirdSide = 9;

            string actual = "A triangle cannot be formed";

            string expexted = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            Assert.That(actual, Is.EqualTo(expexted));
        }

        [Test]
        public void AnalyzeTriangle_NoTriangle_Test3()
        {
            int firstSide = 13;
            int secondSide = 15;
            int thirdSide = 40;

            string actual = "A triangle cannot be formed";

            string expexted = Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            Assert.That(actual, Is.EqualTo(expexted));
        }

    }
}

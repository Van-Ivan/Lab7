using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibrary1;

namespace UnitTestProject1
{
    [TestClass]
    public class strNSymbolTest
    {
        [TestMethod]
        public void strNsymbolTest1()
        {
            int n = 5;
            string expected = "ABCDE";
            strNSimbol str = new strNSimbol();
            string actual = str.Write(n);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void strNsymbolTest2()
        {
            bool cathed = false;
            try
            {
                int n = 27;
                strNSimbol str = new strNSimbol();
                string actual = str.Write(n);
            }
            catch (ArgumentException)
            {
                cathed = true;
            }
            
            Assert.IsTrue(cathed, "АргументЭксэпшн");
        }
        [TestMethod]
        public void strNsymbolTest3()
        {
            bool cathed = false;
            try
            {
                int n = 0;
                strNSimbol str = new strNSimbol();
                string actual = str.Write(n);
            }
            catch (ArgumentException)
            {
                cathed = true;
            }

            Assert.IsTrue(cathed, "АргументЭксэпшн");
        }
    }

    [TestClass]
    public class QuadEquationTest
    {
        [TestMethod]
        public void QuadEquationTest1()
        {
            double a = 1, b = 1, c = 1;
            var eq = new QuadEquation(a, b, c);
            double[] actual = eq.Solution();
            double[] expected = new double[0];
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void QuadEquationTest2()
        {
            //1 тест ?
            bool cathed = false;
            try
            {
                double a = 0, b = 1, c = 1;
                var eq = new QuadEquation(a, b, c);
                double[] actual = eq.Solution();
                double[] expected = { };
            }
            catch
            {
                cathed = true;
            }
            Assert.IsTrue(cathed);
        }
        [TestMethod]
        public void QuadEquationTest3()
        {
            double a = 1, b = -6, c = 9;
            var eq = new QuadEquation(a, b, c);
            double[] actual = eq.Solution();
            double[] expected = { 3 };
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void QuadEquationTest4()
        {
            double a = 1, b = 4, c = 3;
            var eq = new QuadEquation(a, b, c);
            double[] actual = eq.Solution();
            double[] expected = { -1, -3};
            CollectionAssert.AreEqual(expected, actual);
        }
    }
    [TestClass]
    public class VisilosTest
    {
        [TestMethod]
        public void NumYearTest1()
        {
            int year = 300;
            Visokos v = new Visokos(year);
            int actual = v.NumDays(year);
            int expected = 365;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void NumYearTest2()
        {
            int year = 1200;
            Visokos v = new Visokos(year);
            int actual = v.NumDays(year);
            int expected = 366;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void NumYearTest3()
        {
            bool cathed = false;
            try
            {
                int year = 0;
                Visokos v = new Visokos(year);
                int actual = v.NumDays(year);
            }
            catch (ArgumentException)
            {
                cathed = true;
            }
            Assert.IsTrue(cathed);
        }
    }
    [TestClass]
    public class RegularTest
    {
        Regular r = new Regular();
        [TestMethod]
        public void IsEmailTest1()
        {
            string line = "test@test.test";
            Assert.IsTrue(r.ISEmail(line));
        }
        [TestMethod]
        public void IsEmailTest2()
        {
            string line = "test@testtest";
            Assert.IsFalse(r.ISEmail(line));
        }
    }
    [TestClass]
    public class NumberTest
    {
        string str;
        Number a = new Number();
        [TestMethod]
        public void SumTest1()
        {
            str = "123";
            int actual = a.Sum(str);
            int expected = 6;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void SumTest2()
        {
            bool cathed = false;
            try
            {
                str = "afs";
                int actual = a.Sum(str);
            }
            catch (ArgumentException)
            {
                cathed = true;
            }
            
            Assert.IsTrue(cathed);
        }
        [TestMethod]
        public void SumTest3()
        {
            bool cathed = false;
            try
            {
                str = "-1";
                int actual = a.Sum(str);
            }
            catch (ArgumentException)
            {
                cathed = true;
            }

            Assert.IsTrue(cathed);
        }
    }
}

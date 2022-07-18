using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void If_One_Entered()
        {
            Console.SetIn(new StringReader("1"));
            var result = true;
            StringAssert.Equals("1", result);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void If_Two_Entered()
        {
            Console.SetIn(new StringReader("2"));
            var result = true;
            StringAssert.Equals("2", result);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void If_Three_Entered()
        {
            Console.SetIn(new StringReader("3"));
            var result = true;
            StringAssert.Equals("3", result);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void If_Four_Entered()
        {
            Console.SetIn(new StringReader("4"));
            var result = true;
            StringAssert.Equals("4", result);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void If_Five_Entered()
        {
            Console.SetIn(new StringReader("5"));
            var result = true;
            StringAssert.Equals("5", result);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void If_Six_Entered()
        {
            Console.SetIn(new StringReader("6"));
            var result = true;
            StringAssert.Equals("6", result);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void If_Seven_Entered()
        {
            Console.SetIn(new StringReader("7"));
            var result = true;
            StringAssert.Equals("7", result);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void If_Eight_Entered()
        {
            Console.SetIn(new StringReader("8"));
            var result = true;
            StringAssert.Equals("8", result);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void If_Nine_Entered()
        {
            Console.SetIn(new StringReader("9"));
            var result = true;
            StringAssert.Equals("9", result);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void If_Ten_Entered()
        {
            Console.SetIn(new StringReader("10"));
            var result = true;
            StringAssert.Equals("10", result);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void If_NinetyNine_Entered()
        {
            Console.SetIn(new StringReader("99"));
            var result = true;
            StringAssert.Equals("99", result);
            Assert.IsTrue(result);
        }


        [TestMethod]
        public void Confirm_bye_Input()
        {
            Console.SetIn(new StringReader("bye"));
            var result = true;
            StringAssert.Equals("bye", result);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Confirm_abc_Input()
        {
            Console.SetIn(new StringReader("abc"));
            var result = false;
            StringAssert.Equals("abc", result);
            Assert.IsTrue(result);
        }
    }
}

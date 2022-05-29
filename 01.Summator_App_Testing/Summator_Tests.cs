using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Summator_App_Testing
{
    public class Summator_Tests:Base_Class
    {
        [Test]
        public void Test_Valid_Sum()
        {
            string result = Sum_Numbers("5", "3");
            Clear_Fields();
            Assert.AreEqual("8", result);
        }

        [Test]
        public void Test_Invalid_Sum()
        {
            string result = Sum_Numbers("hello", "bye");
            Clear_Fields();
            Assert.AreEqual("error", result);
        }
    }
}

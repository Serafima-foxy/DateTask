using System;
using System.IO;
using NUnit.Framework;
using HomeWork12;

namespace HomeWork12Test
{
    [TestFixture]
    public class UnitTestHW12
    {
        [Test]
        public void TestInputDayMethod()
        {
            using (var sw = new StringWriter())
            {
                System.Console.SetOut(sw);
                new Menu().InputDay();

                string result = sw.ToString().Trim();
                Assert.AreEqual("Input number from 1 to 366:", result);
            }

        }
    }
}

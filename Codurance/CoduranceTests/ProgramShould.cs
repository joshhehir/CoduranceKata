using NUnit.Framework;
using System.IO;
using System;

namespace CoduranceTests
{
    public class ProgramShould
    {
        private const string Expected = "Hello World!";

        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void CheckOutputShouldBeHelloWorld()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                Codurance.Program.Main();

                var result = sw.ToString().Trim();
                Assert.AreEqual(Expected, result);
            }
        }
    }
}
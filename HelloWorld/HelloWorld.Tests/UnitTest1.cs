using NUnit.Framework;
using System.IO;
using System;
using HelloWorld;

namespace HelloWorldTests
{
    public class Tests
    {
        private const string Expected = "Hello World!";
        private Conway conway;

        [SetUp]
        public void Setup()
        {
            conway = new Conway();
        }

        [Test]
        public void DiesSmaller2()
        {
            Assert.False(conway.GetNextState(true, 0));
            Assert.False(conway.GetNextState(true, 1));
        }
    }
}
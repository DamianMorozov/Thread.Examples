﻿using System.Diagnostics;
using NUnit.Framework;

namespace Console.Example.ThreadsTests
{
    internal class ProgramTests
    {
        internal static void Main()
        {
        }

        /// <summary>
        /// Setup private fields.
        /// </summary>
        [SetUp]
        public void Setup()
        {
            TestContext.WriteLine(@"--------------------------------------------------------------------------------");
            TestContext.WriteLine($@"{nameof(Setup)} start.");
            //
            TestContext.WriteLine($@"{nameof(Setup)} complete.");
        }

        /// <summary>
        /// Reset private fields to default state.
        /// </summary>
        [TearDown]
        public void Teardown()
        {
            TestContext.WriteLine(@"--------------------------------------------------------------------------------");
            TestContext.WriteLine($@"{nameof(Teardown)} start.");
            //
            TestContext.WriteLine($@"{nameof(Teardown)} complete.");
            TestContext.WriteLine(@"--------------------------------------------------------------------------------");
        }

        [Test]
        public void Main_AreEqual()
        {
            TestContext.WriteLine(@"--------------------------------------------------------------------------------");
            TestContext.WriteLine($@"{nameof(Main_AreEqual)} start.");
            var sw = Stopwatch.StartNew();

            Assert.AreEqual(0, 0);

            sw.Stop();
            TestContext.WriteLine($@"{nameof(Main_AreEqual)} complete. Elapsed time: {sw.Elapsed}");
        }
    }
}

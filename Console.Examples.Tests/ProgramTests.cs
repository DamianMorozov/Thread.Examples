using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Console.Examples.Tests
{
    internal class ProgramTests
    {
        #region Private fields and properties

        private const int MaxCount = 100;

        #endregion

        #region Setup & Teardown

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

        #endregion

        #region Main methods

        [Test]
        public void Main_Execute_DoesNotThrow()
        {
            TestContext.WriteLine(@"--------------------------------------------------------------------------------");
            TestContext.WriteLine($@"{nameof(Main_Execute_DoesNotThrow)} start.");
            var sw = Stopwatch.StartNew();

            Assert.DoesNotThrow(() => Program.Main(new[] { "-skip" }));

            sw.Stop();
            TestContext.WriteLine($@"{nameof(Main_Execute_DoesNotThrow)} complete. Elapsed time: {sw.Elapsed}");
        }

        [Test]
        public void PrintCaption_Execute_DoesNotThrow()
        {
            TestContext.WriteLine(@"--------------------------------------------------------------------------------");
            TestContext.WriteLine($@"{nameof(PrintCaption_Execute_DoesNotThrow)} start.");
            var sw = Stopwatch.StartNew();

            Assert.DoesNotThrow(() => Program.PrintCaption(new[] { "-skip" }));

            sw.Stop();
            TestContext.WriteLine($@"{nameof(PrintCaption_Execute_DoesNotThrow)} complete. Elapsed time: {sw.Elapsed}");
        }

        [Test]
        public void PrintSwitch_Execute_DoesNotThrow()
        {
            TestContext.WriteLine(@"--------------------------------------------------------------------------------");
            TestContext.WriteLine($@"{nameof(PrintSwitch_Execute_DoesNotThrow)} start.");
            var sw = Stopwatch.StartNew();

            Assert.DoesNotThrow(() => Program.PrintSwitch(1, new[] { "-skip" }));

            sw.Stop();
            TestContext.WriteLine($@"{nameof(PrintSwitch_Execute_DoesNotThrow)} complete. Elapsed time: {sw.Elapsed}");
        }

        #endregion

        #region Method01

        [Test]
        public void Method01_Execute_DoesNotThrow()
        {
            TestContext.WriteLine(@"--------------------------------------------------------------------------------");
            TestContext.WriteLine($@"{nameof(Method01_Execute_DoesNotThrow)} start.");
            var sw = Stopwatch.StartNew();

            Assert.DoesNotThrow(Program.Method01);

            sw.Stop();
            TestContext.WriteLine($@"{nameof(Method01_Execute_DoesNotThrow)} complete. Elapsed time: {sw.Elapsed}");
        }

        [Test]
        public void Method01DisplayResult_Execute_DoesNotThrow()
        {
            TestContext.WriteLine(@"--------------------------------------------------------------------------------");
            TestContext.WriteLine($@"{nameof(Method01DisplayResult_Execute_DoesNotThrow)} start.");
            var sw = Stopwatch.StartNew();

            for (var i = 0; i < 10; i++)
            {
                Assert.DoesNotThrow(() => Program.Method01DisplayResult(i));
            }

            sw.Stop();
            TestContext.WriteLine($@"{nameof(Method01DisplayResult_Execute_DoesNotThrow)} complete. Elapsed time: {sw.Elapsed}");
        }

        [Test]
        public void Method01FactorialAsync_Execute_DoesNotThrow()
        {
            TestContext.WriteLine(@"--------------------------------------------------------------------------------");
            TestContext.WriteLine($@"{nameof(Method01FactorialAsync_Execute_DoesNotThrow)} start.");
            var sw = Stopwatch.StartNew();

            for (var i = 0; i < MaxCount; i++)
            {
                Assert.DoesNotThrow(() => Program.Method01FactorialAsync(i));
                var num = i;
                Assert.DoesNotThrowAsync(() => Program.Method01FactorialAsync(num));
            }

            sw.Stop();
            TestContext.WriteLine($@"{nameof(Method01FactorialAsync_Execute_DoesNotThrow)} complete. Elapsed time: {sw.Elapsed}");
        }

        #endregion

        #region Method02

        [Test]
        public void Method02_Execute_DoesNotThrow()
        {
            TestContext.WriteLine(@"--------------------------------------------------------------------------------");
            TestContext.WriteLine($@"{nameof(Method02_Execute_DoesNotThrow)} start.");
            var sw = Stopwatch.StartNew();

            Assert.DoesNotThrow(Program.Method02);

            sw.Stop();
            TestContext.WriteLine($@"{nameof(Method02_Execute_DoesNotThrow)} complete. Elapsed time: {sw.Elapsed}");
        }

        [Test]
        public void Method02DisplayResultAsync_Execute_DoesNotThrow()
        {
            TestContext.WriteLine(@"--------------------------------------------------------------------------------");
            TestContext.WriteLine($@"{nameof(Method02DisplayResultAsync_Execute_DoesNotThrow)} start.");
            var sw = Stopwatch.StartNew();

            Assert.DoesNotThrowAsync(Program.Method02DisplayResultAsync);

            sw.Stop();
            TestContext.WriteLine($@"{nameof(Method02DisplayResultAsync_Execute_DoesNotThrow)} complete. Elapsed time: {sw.Elapsed}");
        }

        [Test]
        public void Method02FactorialAsync_Execute_DoesNotThrow()
        {
            TestContext.WriteLine(@"--------------------------------------------------------------------------------");
            TestContext.WriteLine($@"{nameof(Method02FactorialAsync_Execute_DoesNotThrow)} start.");
            var sw = Stopwatch.StartNew();

            for (var i = 0; i < MaxCount; i++)
            {
                var num = i;
                Assert.DoesNotThrowAsync(() => Program.Method02FactorialAsync(num));
            }

            sw.Stop();
            TestContext.WriteLine($@"{nameof(Method02FactorialAsync_Execute_DoesNotThrow)} complete. Elapsed time: {sw.Elapsed}");
        }

        #endregion

        #region Method03

        [Test]
        public void Method03_Execute_DoesNotThrow()
        {
            TestContext.WriteLine(@"--------------------------------------------------------------------------------");
            TestContext.WriteLine($@"{nameof(Method03_Execute_DoesNotThrow)} start.");
            var sw = Stopwatch.StartNew();

            Assert.DoesNotThrow(Program.Method03);

            sw.Stop();
            TestContext.WriteLine($@"{nameof(Method03_Execute_DoesNotThrow)} complete. Elapsed time: {sw.Elapsed}");
        }

        [Test]
        public void Method03DisplayResultAsync_Execute_DoesNotThrow()
        {
            TestContext.WriteLine(@"--------------------------------------------------------------------------------");
            TestContext.WriteLine($@"{nameof(Method03DisplayResultAsync_Execute_DoesNotThrow)} start.");
            var sw = Stopwatch.StartNew();

            Assert.DoesNotThrowAsync(Program.Method03DisplayResultAsync);

            sw.Stop();
            TestContext.WriteLine($@"{nameof(Method03DisplayResultAsync_Execute_DoesNotThrow)} complete. Elapsed time: {sw.Elapsed}");
        }

        [Test]
        public void Method03FactorialAsync_Execute_DoesNotThrow()
        {
            TestContext.WriteLine(@"--------------------------------------------------------------------------------");
            TestContext.WriteLine($@"{nameof(Method03FactorialAsync_Execute_DoesNotThrow)} start.");
            var sw = Stopwatch.StartNew();

            for (var i = 0; i < MaxCount; i++)
            {
                var num = i;
                Assert.DoesNotThrowAsync(() => Program.Method03FactorialAsync(num));
            }

            sw.Stop();
            TestContext.WriteLine($@"{nameof(Method03FactorialAsync_Execute_DoesNotThrow)} complete. Elapsed time: {sw.Elapsed}");
        }

        #endregion

        #region Method04

        [Test]
        public void Method04_Execute_DoesNotThrow()
        {
            TestContext.WriteLine(@"--------------------------------------------------------------------------------");
            TestContext.WriteLine($@"{nameof(Method04_Execute_DoesNotThrow)} start.");
            var sw = Stopwatch.StartNew();

            Assert.DoesNotThrow(Program.Method04);

            sw.Stop();
            TestContext.WriteLine($@"{nameof(Method04_Execute_DoesNotThrow)} complete. Elapsed time: {sw.Elapsed}");
        }

        [Test]
        public void Method04DisplayResult_Execute_DoesNotThrow()
        {
            TestContext.WriteLine(@"--------------------------------------------------------------------------------");
            TestContext.WriteLine($@"{nameof(Method04DisplayResult_Execute_DoesNotThrow)} start.");
            var sw = Stopwatch.StartNew();

            Assert.DoesNotThrow(Program.Method04DisplayResult);

            sw.Stop();
            TestContext.WriteLine($@"{nameof(Method04DisplayResult_Execute_DoesNotThrow)} complete. Elapsed time: {sw.Elapsed}");
        }

        [Test]
        public void Method04FactorialAsync_Execute_DoesNotThrow()
        {
            TestContext.WriteLine(@"--------------------------------------------------------------------------------");
            TestContext.WriteLine($@"{nameof(Method04FactorialAsync_Execute_DoesNotThrow)} start.");
            var sw = Stopwatch.StartNew();

            for (var i = 0; i < MaxCount; i++)
            {
                var num = i;
                Assert.DoesNotThrowAsync(() => Program.Method04FactorialAsync(num));
            }

            sw.Stop();
            TestContext.WriteLine($@"{nameof(Method04FactorialAsync_Execute_DoesNotThrow)} complete. Elapsed time: {sw.Elapsed}");
        }

        #endregion

        #region Method05

        [Test]
        public void Method05_Execute_DoesNotThrow()
        {
            TestContext.WriteLine(@"--------------------------------------------------------------------------------");
            TestContext.WriteLine($@"{nameof(Method05_Execute_DoesNotThrow)} start.");
            var sw = Stopwatch.StartNew();

            Assert.DoesNotThrow(Program.Method05);

            sw.Stop();
            TestContext.WriteLine($@"{nameof(Method05_Execute_DoesNotThrow)} complete. Elapsed time: {sw.Elapsed}");
        }

        [Test]
        public void Method05DisplayResult_Execute_DoesNotThrow()
        {
            TestContext.WriteLine(@"--------------------------------------------------------------------------------");
            TestContext.WriteLine($@"{nameof(Method05DisplayResult_Execute_DoesNotThrow)} start.");
            var sw = Stopwatch.StartNew();

            Assert.DoesNotThrow(Program.Method05DisplayResult);

            sw.Stop();
            TestContext.WriteLine($@"{nameof(Method05DisplayResult_Execute_DoesNotThrow)} complete. Elapsed time: {sw.Elapsed}");
        }

        [Test]
        public void Method05RunSomeMethodsAsync_Execute_DoesNotThrow()
        {
            TestContext.WriteLine(@"--------------------------------------------------------------------------------");
            TestContext.WriteLine($@"{nameof(Method05RunSomeMethodsAsync_Execute_DoesNotThrow)} start.");
            var sw = Stopwatch.StartNew();

            for (var i = 0; i < MaxCount; i++)
            {
                var num = i;
                Assert.DoesNotThrowAsync(() => Program.Method05RunSomeMethodsAsync(() => Program.Method05FactorialAsync(num)));
            }

            sw.Stop();
            TestContext.WriteLine($@"{nameof(Method05RunSomeMethodsAsync_Execute_DoesNotThrow)} complete. Elapsed time: {sw.Elapsed}");
        }

        [Test]
        public void Method05FactorialAsync_Execute_DoesNotThrow()
        {
            TestContext.WriteLine(@"--------------------------------------------------------------------------------");
            TestContext.WriteLine($@"{nameof(Method05FactorialAsync_Execute_DoesNotThrow)} start.");
            var sw = Stopwatch.StartNew();

            for (var i = 0; i < MaxCount; i++)
            {
                var num = i;
                Assert.DoesNotThrowAsync(() => Program.Method05FactorialAsync(num));
            }

            sw.Stop();
            TestContext.WriteLine($@"{nameof(Method05FactorialAsync_Execute_DoesNotThrow)} complete. Elapsed time: {sw.Elapsed}");
        }

        #endregion

        #region Method06

        [Test]
        public void Method06_Execute_DoesNotThrow()
        {
            TestContext.WriteLine(@"--------------------------------------------------------------------------------");
            TestContext.WriteLine($@"{nameof(Method06_Execute_DoesNotThrow)} start.");
            var sw = Stopwatch.StartNew();

            Assert.DoesNotThrow(Program.Method06);

            sw.Stop();
            TestContext.WriteLine($@"{nameof(Method06_Execute_DoesNotThrow)} complete. Elapsed time: {sw.Elapsed}");
        }

        [Test]
        public void Method06DisplayResult_Execute_DoesNotThrow()
        {
            TestContext.WriteLine(@"--------------------------------------------------------------------------------");
            TestContext.WriteLine($@"{nameof(Method06DisplayResult_Execute_DoesNotThrow)} start.");
            var sw = Stopwatch.StartNew();

            Assert.DoesNotThrow(Program.Method06DisplayResult);

            sw.Stop();
            TestContext.WriteLine($@"{nameof(Method06DisplayResult_Execute_DoesNotThrow)} complete. Elapsed time: {sw.Elapsed}");
        }

        [Test]
        public void Method06RunSomeMethodsAsync_Execute_DoesNotThrow()
        {
            TestContext.WriteLine(@"--------------------------------------------------------------------------------");
            TestContext.WriteLine($@"{nameof(Method06RunSomeMethodsAsync_Execute_DoesNotThrow)} start.");
            var sw = Stopwatch.StartNew();

            for (var i = 0; i < MaxCount; i++)
            {
                var num = i;
                Assert.DoesNotThrowAsync(() => Program.Method06RunSomeMethodsAsync(new List<(Func<Task<int>> Func, string ActionText)> { (() => Program.Method06FactorialAsync(num), "FactorialAsync(num)") }));
            }

            sw.Stop();
            TestContext.WriteLine($@"{nameof(Method06RunSomeMethodsAsync_Execute_DoesNotThrow)} complete. Elapsed time: {sw.Elapsed}");
        }

        [Test]
        public void Method06FactorialAsync_Execute_DoesNotThrow()
        {
            TestContext.WriteLine(@"--------------------------------------------------------------------------------");
            TestContext.WriteLine($@"{nameof(Method06FactorialAsync_Execute_DoesNotThrow)} start.");
            var sw = Stopwatch.StartNew();

            for (var i = 0; i < MaxCount; i++)
            {
                var num = i;
                Assert.DoesNotThrowAsync(() => Program.Method06FactorialAsync(num));
            }

            sw.Stop();
            TestContext.WriteLine($@"{nameof(Method06FactorialAsync_Execute_DoesNotThrow)} complete. Elapsed time: {sw.Elapsed}");
        }

        #endregion

        #region Method07

        [Test]
        public void Method07_Execute_DoesNotThrow()
        {
            TestContext.WriteLine(@"--------------------------------------------------------------------------------");
            TestContext.WriteLine($@"{nameof(Method07_Execute_DoesNotThrow)} start.");
            var sw = Stopwatch.StartNew();

            Assert.DoesNotThrow(Program.Method07);

            sw.Stop();
            TestContext.WriteLine($@"{nameof(Method07_Execute_DoesNotThrow)} complete. Elapsed time: {sw.Elapsed}");
        }

        [Test]
        public void Method07DisplayResult_Execute_DoesNotThrow()
        {
            TestContext.WriteLine(@"--------------------------------------------------------------------------------");
            TestContext.WriteLine($@"{nameof(Method07DisplayResult_Execute_DoesNotThrow)} start.");
            var sw = Stopwatch.StartNew();

            Assert.DoesNotThrow(Program.Method07DisplayResult);

            sw.Stop();
            TestContext.WriteLine($@"{nameof(Method07DisplayResult_Execute_DoesNotThrow)} complete. Elapsed time: {sw.Elapsed}");
        }

        [Test]
        public void Method07RunSomeMethodsAsync_Execute_DoesNotThrow()
        {
            TestContext.WriteLine(@"--------------------------------------------------------------------------------");
            TestContext.WriteLine($@"{nameof(Method07RunSomeMethodsAsync_Execute_DoesNotThrow)} start.");
            var sw = Stopwatch.StartNew();

            for (var i = 0; i < MaxCount; i++)
            {
                var num = i;
                Assert.DoesNotThrowAsync(() => Program.Method07RunSomeMethodsAsync(() => Program.Method07FactorialAsync(num)));
            }

            sw.Stop();
            TestContext.WriteLine($@"{nameof(Method07RunSomeMethodsAsync_Execute_DoesNotThrow)} complete. Elapsed time: {sw.Elapsed}");
        }

        [Test]
        public void Method07FactorialAsync_Execute_DoesNotThrow()
        {
            TestContext.WriteLine(@"--------------------------------------------------------------------------------");
            TestContext.WriteLine($@"{nameof(Method07FactorialAsync_Execute_DoesNotThrow)} start.");
            var sw = Stopwatch.StartNew();

            for (var i = 0; i < MaxCount; i++)
            {
                var num = i;
                Assert.DoesNotThrowAsync(() => Program.Method07FactorialAsync(num));
            }

            sw.Stop();
            TestContext.WriteLine($@"{nameof(Method07FactorialAsync_Execute_DoesNotThrow)} complete. Elapsed time: {sw.Elapsed}");
        }

        #endregion

        #region Task11

        [Test]
        public void Task11_Execute_DoesNotThrow()
        {
            TestContext.WriteLine(@"--------------------------------------------------------------------------------");
            TestContext.WriteLine($@"{nameof(Task11_Execute_DoesNotThrow)} start.");
            var sw = Stopwatch.StartNew();

            Assert.DoesNotThrow(Program.Task11);

            sw.Stop();
            TestContext.WriteLine($@"{nameof(Task11_Execute_DoesNotThrow)} complete. Elapsed time: {sw.Elapsed}");
        }

        #endregion
    }
}

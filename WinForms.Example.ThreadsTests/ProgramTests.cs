using System.Diagnostics;
using NUnit.Framework;
using WinForms.Example.Threads;

namespace WinForms.Example.ThreadsTests
{
    public class ProgramTests
    {
        #region Private fields and properties

        //

        #endregion

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
        public void Main_Execute_NoException()
        {
            TestContext.WriteLine(@"--------------------------------------------------------------------------------");
            TestContext.WriteLine($@"{nameof(Main_Execute_NoException)} start.");
            var sw = Stopwatch.StartNew();

            Assert.DoesNotThrow(() => Program.Main(new[] {"-skip"}));
            
            sw.Stop();
            TestContext.WriteLine($@"{nameof(Main_Execute_NoException)} complete. Elapsed time: {sw.Elapsed}");
        }
    }
}

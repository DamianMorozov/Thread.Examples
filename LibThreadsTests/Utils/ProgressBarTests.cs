using NUnit.Framework;
using System.Diagnostics;
using System.Windows.Forms;

namespace LibThreadsTests.Utils
{
    public class ProgressBarTests
    {
        #region Private fields and properties

        private ProgressBar _progressBar;

        #endregion

        /// <summary>
        /// Setup private fields.
        /// </summary>
        [SetUp]
        public void Setup()
        {
            TestContext.WriteLine(@"--------------------------------------------------------------------------------");
            TestContext.WriteLine($@"{nameof(Setup)} start.");

            _progressBar = new ProgressBar();

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
        public void Properties_SetValue_DoesNotThrow()
        {
            TestContext.WriteLine(@"--------------------------------------------------------------------------------");
            TestContext.WriteLine($@"{nameof(Properties_SetValue_DoesNotThrow)} start.");
            var sw = Stopwatch.StartNew();

            Assert.DoesNotThrow(() => LibThreads.Utils.ProgressBar.Properties.SetValue.Sync(_progressBar, 0));
            Assert.DoesNotThrowAsync(() => LibThreads.Utils.ProgressBar.Properties.SetValue.Async(_progressBar, 0));

            sw.Stop();
            TestContext.WriteLine($@"{nameof(Properties_SetValue_DoesNotThrow)} complete. Elapsed time: {sw.Elapsed}");
        }

        [Test]
        public void ModifyProgressBarColor_SetState_DoesNotThrow()
        {
            TestContext.WriteLine(@"--------------------------------------------------------------------------------");
            TestContext.WriteLine($@"{nameof(Properties_SetValue_DoesNotThrow)} start.");
            var sw = Stopwatch.StartNew();

            Assert.DoesNotThrow(() => LibThreads.Utils.ModifyProgressBarColor.SetState(_progressBar, 1));
            Assert.DoesNotThrow(() => LibThreads.Utils.ModifyProgressBarColor.SetState(_progressBar, 2));
            Assert.DoesNotThrow(() => LibThreads.Utils.ModifyProgressBarColor.SetState(_progressBar, 3));

            sw.Stop();
            TestContext.WriteLine($@"{nameof(Properties_SetValue_DoesNotThrow)} complete. Elapsed time: {sw.Elapsed}");
        }
    }
}

using NUnit.Framework;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace LibThreadsTests.Utils
{
    public class ControlTests
    {
        #region Private fields and properties

        private List<Control> _controls;

        #endregion

        /// <summary>
        /// Setup private fields.
        /// </summary>
        [SetUp]
        public void Setup()
        {
            TestContext.WriteLine(@"--------------------------------------------------------------------------------");
            TestContext.WriteLine($@"{nameof(Setup)} start.");

            _controls = new List<Control>() { new Label(), new Button(), new CheckBox(), new TextBox() };

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
        public void Properties_SetEnabled_NoException()
        {
            TestContext.WriteLine(@"--------------------------------------------------------------------------------");
            TestContext.WriteLine($@"{nameof(Properties_SetEnabled_NoException)} start.");
            var sw = Stopwatch.StartNew();

            foreach (var control in _controls)
            {
                Assert.DoesNotThrow(() => LibThreads.Utils.Control.Properties.SetEnabled.Sync(control, false));
                Assert.DoesNotThrowAsync(() => LibThreads.Utils.Control.Properties.SetEnabled.Async(control, false));
                Assert.DoesNotThrow(() => LibThreads.Utils.Control.Properties.SetEnabled.Sync(control, true));
                Assert.DoesNotThrowAsync(() => LibThreads.Utils.Control.Properties.SetEnabled.Async(control, true));
            }

            sw.Stop();
            TestContext.WriteLine($@"{nameof(Properties_SetEnabled_NoException)} complete. Elapsed time: {sw.Elapsed}");
        }

        [Test]
        public void Properties_SetText_NoException()
        {
            TestContext.WriteLine(@"--------------------------------------------------------------------------------");
            TestContext.WriteLine($@"{nameof(Properties_SetText_NoException)} start.");
            var sw = Stopwatch.StartNew();

            foreach (var control in _controls)
            {
                Assert.DoesNotThrow(() => LibThreads.Utils.Control.Properties.SetText.Sync(control, "Test text"));
                Assert.DoesNotThrowAsync(() => LibThreads.Utils.Control.Properties.SetText.Async(control, "Test text"));
                Assert.DoesNotThrow(() => LibThreads.Utils.Control.Properties.SetText.Sync(control, null));
                Assert.DoesNotThrowAsync(() => LibThreads.Utils.Control.Properties.SetText.Async(control, null));
                Assert.DoesNotThrow(() => LibThreads.Utils.Control.Properties.SetText.Sync(control, string.Empty));
                Assert.DoesNotThrowAsync(() => LibThreads.Utils.Control.Properties.SetText.Async(control, string.Empty));
            }

            sw.Stop();
            TestContext.WriteLine($@"{nameof(Properties_SetText_NoException)} complete. Elapsed time: {sw.Elapsed}");
        }

        [Test]
        public void Properties_SetVisible_NoException()
        {
            TestContext.WriteLine(@"--------------------------------------------------------------------------------");
            TestContext.WriteLine($@"{nameof(Properties_SetVisible_NoException)} start.");
            var sw = Stopwatch.StartNew();

            foreach (var control in _controls)
            {
                Assert.DoesNotThrow(() => LibThreads.Utils.Control.Properties.SetVisible.Sync(control, false));
                Assert.DoesNotThrowAsync(() => LibThreads.Utils.Control.Properties.SetVisible.Async(control, false));
                Assert.DoesNotThrow(() => LibThreads.Utils.Control.Properties.SetVisible.Sync(control, true));
                Assert.DoesNotThrowAsync(() => LibThreads.Utils.Control.Properties.SetVisible.Async(control, true));
            }

            sw.Stop();
            TestContext.WriteLine($@"{nameof(Properties_SetVisible_NoException)} complete. Elapsed time: {sw.Elapsed}");
        }

        [Test]
        public void Methods_Focus_NoException()
        {
            TestContext.WriteLine(@"--------------------------------------------------------------------------------");
            TestContext.WriteLine($@"{nameof(Methods_Focus_NoException)} start.");
            var sw = Stopwatch.StartNew();

            foreach (var control in _controls)
            {
                Assert.DoesNotThrow(() => LibThreads.Utils.Control.Methods.Focus.Sync(control));
                Assert.DoesNotThrowAsync(() => LibThreads.Utils.Control.Methods.Focus.Async(control));
            }

            sw.Stop();
            TestContext.WriteLine($@"{nameof(Methods_Focus_NoException)} complete. Elapsed time: {sw.Elapsed}");
        }

        [Test]
        public void Methods_Select_NoException()
        {
            TestContext.WriteLine(@"--------------------------------------------------------------------------------");
            TestContext.WriteLine($@"{nameof(Methods_Select_NoException)} start.");
            var sw = Stopwatch.StartNew();

            foreach (var control in _controls)
            {
                Assert.DoesNotThrow(() => LibThreads.Utils.Control.Methods.Select.Sync(control));
                Assert.DoesNotThrowAsync(() => LibThreads.Utils.Control.Methods.Select.Async(control));
            }

            sw.Stop();
            TestContext.WriteLine($@"{nameof(Methods_Select_NoException)} complete. Elapsed time: {sw.Elapsed}");
        }

        [Test]
        public void Methods_SetDoubleBuffered_NoException()
        {
            TestContext.WriteLine(@"--------------------------------------------------------------------------------");
            TestContext.WriteLine($@"{nameof(Methods_SetDoubleBuffered_NoException)} start.");
            var sw = Stopwatch.StartNew();

            foreach (var control in _controls)
            {
                Assert.DoesNotThrow(() => LibThreads.Utils.Control.Methods.SetDoubleBuffered(control, true));
            }

            sw.Stop();
            TestContext.WriteLine($@"{nameof(Methods_SetDoubleBuffered_NoException)} complete. Elapsed time: {sw.Elapsed}");
        }
    }
}

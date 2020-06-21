using System;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace LibThreads.Utils
{
    public class ProgressBar
    {
        public static class Properties
        {
            public static class SetValue
            {
                private delegate void SetDelegate(System.Windows.Forms.ProgressBar item, int value, int sleepTimeOutMs = 10);

                private static void SetWork(System.Windows.Forms.ProgressBar item, int value, int sleepTimeOutMs = 10)
                {
                    item.Value = value;
                    System.Windows.Forms.Application.DoEvents();
                    System.Threading.Thread.Sleep(sleepTimeOutMs);
                }

                public static Task Async(System.Windows.Forms.ProgressBar item, int value, int sleepTimeOutMs = 10)
                {
                    return Task.Run(() => Sync(item, value));
                }

                public static void Sync(System.Windows.Forms.ProgressBar item, int value, int sleepTimeOutMs = 10)
                {
                    if (item != null)
                    {
                        if (item.InvokeRequired)
                        {
                            item.BeginInvoke(new SetDelegate(SetWork), item, value, sleepTimeOutMs);
                        }
                        else
                        {
                            SetWork(item, value, sleepTimeOutMs);
                        }
                    }
                }
            }
        }
    }

    public static class ModifyProgressBarColor
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr w, IntPtr l);

        /// <summary>
        /// Set style.
        /// </summary>
        /// <param name="progressBar"></param>
        /// <param name="state">1 = normal (green); 2 = error (red); 3 = warning (yellow)</param>
        public static void SetState(this System.Windows.Forms.ProgressBar progressBar, int state)
        {
            SendMessage(progressBar.Handle, 1040, (IntPtr)state, IntPtr.Zero);
        }
    }
}

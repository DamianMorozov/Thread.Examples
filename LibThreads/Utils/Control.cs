﻿using System.Drawing;
using System.Reflection;
using System.Threading.Tasks;

namespace LibThreads.Utils
{
    public static class Control
    {
        public static class Properties
        {
            public static class SetText
            {
                private delegate void SetDelegate(System.Windows.Forms.Control item, string value);

                private static void SetWork(System.Windows.Forms.Control item, string value)
                {
                    item.Text = value;
                }

                public static Task Async(System.Windows.Forms.Control item, string value)
                {
                    return Task.Run(() => Sync(item, value));
                }

                public static void Sync(System.Windows.Forms.Control item, string value)
                {
                    if (item != null)
                    {
                        if (item.InvokeRequired)
                        {
                            item.BeginInvoke(new SetDelegate(SetWork), item, value);
                        }
                        else
                        {
                            SetWork(item, value);
                        }
                    }
                }
            }

            public static class SetVisible
            {
                private delegate void SetDelegate(System.Windows.Forms.Control item, bool value);

                private static void SetWork(System.Windows.Forms.Control item, bool value)
                {
                    item.Visible = value;
                }

                public static Task Async(System.Windows.Forms.Control item, bool value)
                {
                    return Task.Run(() => Sync(item, value));
                }

                public static void Sync(System.Windows.Forms.Control item, bool value)
                {
                    if (item != null)
                    {
                        if (item.InvokeRequired)
                        {
                            item.BeginInvoke(new SetDelegate(SetWork), item, value);
                        }
                        else
                        {
                            SetWork(item, value);
                        }
                    }
                }
            }

            public static class SetEnabled
            {
                private delegate void SetDelegate(System.Windows.Forms.Control item, bool value);

                private static void SetWork(System.Windows.Forms.Control item, bool value)
                {
                    item.Enabled = value;
                }

                public static Task Async(System.Windows.Forms.Control item, bool value)
                {
                    return Task.Run(() => Sync(item, value));
                }

                public static void Sync(System.Windows.Forms.Control item, bool value)
                {
                    if (item != null)
                    {
                        if (item.InvokeRequired)
                        {
                            item.BeginInvoke(new SetDelegate(SetWork), item, value);
                        }
                        else
                        {
                            SetWork(item, value);
                        }
                    }
                }
            }

            public static class SetBackColor
            {
                private delegate void SetDelegate(System.Windows.Forms.Control item, Color value);

                private static void SetWork(System.Windows.Forms.Control item, Color value)
                {
                    item.BackColor = value;
                }

                public static Task Async(System.Windows.Forms.Control item, Color value)
                {
                    return Task.Run(() => Sync(item, value));
                }

                public static void Sync(System.Windows.Forms.Control item, Color value)
                {
                    if (item != null)
                    {
                        if (item.InvokeRequired)
                        {
                            item.BeginInvoke(new SetDelegate(SetWork), item, value);
                        }
                        else
                        {
                            SetWork(item, value);
                        }
                    }
                }
            }

            public static class SetForeColor
            {
                private delegate void SetDelegate(System.Windows.Forms.Control item, Color value);

                private static void SetWork(System.Windows.Forms.Control item, Color value)
                {
                    item.ForeColor = value;
                }

                public static Task Async(System.Windows.Forms.Control item, Color value)
                {
                    return Task.Run(() => Sync(item, value));
                }

                public static void Sync(System.Windows.Forms.Control item, Color value)
                {
                    if (item != null)
                    {
                        if (item.InvokeRequired)
                        {
                            item.BeginInvoke(new SetDelegate(SetWork), item, value);
                        }
                        else
                        {
                            SetWork(item, value);
                        }
                    }
                }
            }
        }

        public static class Methods
        {
            public static void SetDoubleBuffered(System.Windows.Forms.Control control, bool value)
            {
                var pi = typeof(System.Windows.Forms.Control).GetProperty("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic);
                if (pi != null)
                {
                    pi.SetValue(control, value, null);

                    var mi = typeof(System.Windows.Forms.Control).GetMethod("SetStyle", BindingFlags.Instance | BindingFlags.InvokeMethod | BindingFlags.NonPublic);
                    mi?.Invoke(control, new object[]
                    {
                        System.Windows.Forms.ControlStyles.UserPaint |
                        System.Windows.Forms.ControlStyles.AllPaintingInWmPaint |
                        System.Windows.Forms.ControlStyles.OptimizedDoubleBuffer, true
                    });

                    mi = typeof(System.Windows.Forms.Control).GetMethod("UpdateStyles", BindingFlags.Instance | BindingFlags.InvokeMethod | BindingFlags.NonPublic);
                    mi?.Invoke(control, null);
                }
            }


            public static class Select
            {
                private delegate void SetDelegate(System.Windows.Forms.Control item);

                private static void SetWork(System.Windows.Forms.Control item)
                {
                    item.Select();
                }

                public static Task Async(System.Windows.Forms.Control item)
                {
                    return Task.Run(() => Sync(item));
                }

                public static void Sync(System.Windows.Forms.Control item)
                {
                    if (item != null)
                    {
                        if (item.InvokeRequired)
                        {
                            item.BeginInvoke(new SetDelegate(SetWork), item);
                        }
                        else
                        {
                            SetWork(item);
                        }
                    }
                }
            }

            public static class Focus
            {
                private delegate void SetDelegate(System.Windows.Forms.Control item);

                private static void SetWork(System.Windows.Forms.Control item)
                {
                    item.Focus();
                }

                public static Task Async(System.Windows.Forms.Control item)
                {
                    return Task.Run(() => Sync(item));
                }

                public static void Sync(System.Windows.Forms.Control item)
                {
                    if (item != null)
                    {
                        if (item.InvokeRequired)
                        {
                            item.BeginInvoke(new SetDelegate(SetWork), item);
                        }
                        else
                        {
                            SetWork(item);
                        }
                    }
                }
            }
        }
    }
}

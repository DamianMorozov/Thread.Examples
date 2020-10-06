using System.Threading.Tasks;

namespace WinForms.Utils
{
    public static class PictureBox
    {
        public static class Properties
        {
            public static class SetBitmap
            {
                private delegate void SetDelegate(System.Windows.Forms.PictureBox item, System.Drawing.Bitmap value);

                private static void SetWork(System.Windows.Forms.PictureBox item, System.Drawing.Bitmap value)
                {
                    item.Image = value;
                }

                public static Task Async(System.Windows.Forms.PictureBox item, System.Drawing.Bitmap value)
                {
                    return Task.Run(() => Sync(item, value));
                }

                public static void Sync(System.Windows.Forms.PictureBox item, System.Drawing.Bitmap value)
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

            public static class SetImage
            {
                private delegate void SetDelegate(System.Windows.Forms.PictureBox item, System.Drawing.Image value);

                private static void SetWork(System.Windows.Forms.PictureBox item, System.Drawing.Image value)
                {
                    item.Image = value;
                }

                public static Task Async(System.Windows.Forms.PictureBox item, System.Drawing.Image value)
                {
                    return Task.Run(() => Sync(item, value));
                }

                public static void Sync(System.Windows.Forms.PictureBox item, System.Drawing.Image value)
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

            public static class SetBackgroundImage
            {
                private delegate void SetDelegate(System.Windows.Forms.PictureBox item, System.Drawing.Image value);

                private static void SetWork(System.Windows.Forms.PictureBox item, System.Drawing.Image value)
                {
                    item.BackgroundImage = value;
                }

                public static Task Async(System.Windows.Forms.PictureBox item, System.Drawing.Image value)
                {
                    return Task.Run(() => Sync(item, value));
                }

                public static void Sync(System.Windows.Forms.PictureBox item, System.Drawing.Image value)
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
    }
}

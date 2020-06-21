using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

[assembly: InternalsVisibleTo("Console.Example.ThreadsTests")]
namespace Console.Example.Threads
{
    internal static class Program
    {
        #region Main methods

        /// <summary>
        /// Main method.
        /// </summary>
        /// <param name="args"></param>
        internal static void Main(string[] args = null)
        {
            var numberMenu = -1;
            while (numberMenu != 0)
            {
                PrintCaption(args);
                try
                {
                    if (args == null || !args.Contains("-skip"))
                        numberMenu = Convert.ToInt32(System.Console.ReadLine());
                    else
                        numberMenu = 0;
                }
                catch (Exception ex)
                {
                    System.Console.WriteLine("Error: " + ex.Message);
                    numberMenu = -1;
                }
                System.Console.WriteLine();
                PrintSwitch(numberMenu, args);
            }
        }

        /// <summary>
        /// Print caption.
        /// </summary>
        internal static void PrintCaption(string[] args = null)
        {
            if (args == null || !args.Contains("-skip"))
                System.Console.Clear();
            System.Console.WriteLine(@"----------------------------------------------------------------------");
            System.Console.WriteLine(@"---          Examples of Examples of threads & async/await         ---");
            System.Console.WriteLine(@"----------------------------------------------------------------------");
            System.Console.WriteLine("0. Exit from console.");
            System.Console.WriteLine("01. Async 01. Main() call async void DisplayResultAsync().");
            System.Console.WriteLine("02. Async 02. Main() call async Task DisplayResultAsync().Wait().");
            System.Console.WriteLine("03. Async 03. Main() call async Task DisplayResultAsync().GetAwaiter().GetResult().");
            System.Console.WriteLine("04. Async 04. Main() call DisplayResult(), which call async Task<int>.");
            System.Console.WriteLine("05. Async 05. DisplayResult() call async Task<object> RunSomeMethods(Func<Task<int>> func).");
            System.Console.WriteLine("06. Async 06. DisplayResult() call async Task<object> RunSomeMethods(List<(Func<Task<int>> func, string nam)> actions).");
            System.Console.WriteLine("07. Async 07. DisplayResult() call async Task<T> RunSomeMethods(Func<Task<T>> func).GetAwaiter().GetResult().");
            System.Console.WriteLine("11. Task.WaitAll.");
            System.Console.WriteLine(@"----------------------------------------------------------------------");
            System.Console.Write("Type switch: ");
        }

        /// <summary>
        /// Print switch.
        /// </summary>
        /// <param name="numberMenu"></param>
        /// <param name="args">-skip -- for skip ReadKey()</param>
        internal static void PrintSwitch(int numberMenu, string[] args = null)
        {
            if (args == null || !args.Contains("-skip"))
                System.Console.Clear();
            var isPrintMenu = false;
            switch (numberMenu)
            {
                case 1:
                    isPrintMenu = true;
                    Method01();
                    break;
                case 2:
                    isPrintMenu = true;
                    Method02();
                    break;
                case 3:
                    isPrintMenu = true;
                    Method03();
                    break;
                case 4:
                    isPrintMenu = true;
                    Method04();
                    break;
                case 5:
                    isPrintMenu = true;
                    Method05();
                    break;
                case 6:
                    isPrintMenu = true;
                    Method06();
                    break;
                case 7:
                    isPrintMenu = true;
                    Method07();
                    break;
                case 11:
                    isPrintMenu = true;
                    Task11();
                    break;
            }
            if (isPrintMenu)
            {
                System.Console.WriteLine(@"----------------------------------------------------------------------");
                System.Console.WriteLine("Type any key to return in main menu.");
                if (args == null || !args.Contains("-skip"))
                    System.Console.ReadKey();
            }
        }

        #endregion

        #region Method01

        internal static void Method01()
        {
            System.Console.WriteLine(@"----------------------------------------------------------------------");
            System.Console.WriteLine(@"---                           Async 01                             ---");
            System.Console.WriteLine(@"Main() call async void DisplayResultAsync().");
            System.Console.WriteLine(@"----------------------------------------------------------------------");

            Method01DisplayResult();
            System.Console.WriteLine(@"Main method is finished.");
        }

        internal static async void Method01DisplayResult(int num = 8)
        {
            var dtStart = DateTime.Now;
            var result = await Method01FactorialAsync(num).ConfigureAwait(false);
            System.Console.WriteLine("Factorial of a number {0} = {1}", num, result);
            System.Console.WriteLine("Time of calculation: " + Convert.ToString(DateTime.Now - dtStart));
        }

        internal static Task<int> Method01FactorialAsync(int x)
        {
            return Task.Run(() =>
            {
                System.Console.WriteLine(@"Task 'FactorialAsync' is started");
                var result = 1;
                for (var i = 1; i <= x; i++)
                {
                    result *= i;
                }
                System.Console.WriteLine(@"Task 'FactorialAsync' is finished");
                return result;
            });
        }

        #endregion

        #region Method02

        internal static void Method02()
        {
            System.Console.WriteLine(@"----------------------------------------------------------------------");
            System.Console.WriteLine(@"---                           Async 02                             ---");
            System.Console.WriteLine(@"Main() call async Task DisplayResultAsync().Wait().");
            System.Console.WriteLine(@"----------------------------------------------------------------------");

            await Method02DisplayResultAsync();

            System.Console.WriteLine(@"Main method is finished.");
        }

        internal static async Task Method02DisplayResultAsync()
        {
            System.Console.WriteLine(@"Task 'DisplayResultAsync' is started");

            var num = 8;

            var dtStart = DateTime.Now;
            var result = await Method02FactorialAsync(num).ConfigureAwait(false);

            System.Console.WriteLine("Factorial of a number {0} = {1}", num, result);
            System.Console.WriteLine("Time of calculation: " + Convert.ToString(DateTime.Now - dtStart));

            System.Console.WriteLine(@"Task 'DisplayResultAsync' is finished");
        }

        internal static Task<int> Method02FactorialAsync(int x)
        {
            return Task.Run(() =>
            {
                System.Console.WriteLine(@"Task 'FactorialAsync' is started");

                var result = 1;
                for (var i = 1; i <= x; i++)
                {
                    result *= i;
                }

                System.Console.WriteLine(@"Task 'FactorialAsync' is finished");

                return result;
            });
        }

        #endregion

        #region Method03

        internal static void Method03()
        {
            System.Console.WriteLine(@"----------------------------------------------------------------------");
            System.Console.WriteLine(@"---                           Async 03                             ---");
            System.Console.WriteLine(@"Main() call async Task DisplayResultAsync().GetAwaiter().GetResult().");
            System.Console.WriteLine(@"----------------------------------------------------------------------");

            var task = Method03DisplayResultAsync();
            task.GetAwaiter().GetResult();

            System.Console.WriteLine(@"Main method is finished.");
        }

        internal static async Task Method03DisplayResultAsync()
        {
            System.Console.WriteLine(@"Task 'DisplayResultAsync' is started");

            var num = 8;

            var dtStart = DateTime.Now;
            var result = await Method03FactorialAsync(num).ConfigureAwait(false);

            System.Console.WriteLine("Factorial of a number {0} = {1}", num, result);
            System.Console.WriteLine("Time of calculation: " + Convert.ToString(DateTime.Now - dtStart));

            System.Console.WriteLine(@"Task 'DisplayResultAsync' is finished");
        }

        internal static Task<int> Method03FactorialAsync(int x)
        {
            return Task.Run(() =>
            {
                System.Console.WriteLine(@"Task 'FactorialAsync' is started");

                var result = 1;
                for (var i = 1; i <= x; i++)
                {
                    result *= i;
                }

                System.Console.WriteLine(@"Task 'FactorialAsync' is finished");

                return result;
            });
        }

        #endregion

        #region Method04

        internal static void Method04()
        {
            System.Console.WriteLine(@"----------------------------------------------------------------------");
            System.Console.WriteLine(@"---                           Async 04                             ---");
            System.Console.WriteLine(@"Main() call DisplayResult(), which call async Task<int>.");
            System.Console.WriteLine(@"----------------------------------------------------------------------");

            Method04DisplayResult();

            System.Console.WriteLine(@"Main method is finished.");
        }

        internal static void Method04DisplayResult()
        {
            System.Console.WriteLine(@"Method 'DisplayResult' is started");

            var num = 8;

            var dtStart = DateTime.Now;
            var result = Method04FactorialAsync(num).GetAwaiter().GetResult();

            System.Console.WriteLine("Factorial of a number {0} = {1}", num, result);
            System.Console.WriteLine("Time of calculation: " + Convert.ToString(DateTime.Now - dtStart));

            System.Console.WriteLine(@"Method 'DisplayResult' is finished");
        }

        internal static Task<int> Method04FactorialAsync(int x)
        {
            return Task.Run(() =>
            {
                System.Console.WriteLine(@"Task 'FactorialAsync' is started");

                int result = 1;
                for (int i = 1; i <= x; i++)
                {
                    result *= i;
                }

                System.Console.WriteLine(@"Task 'FactorialAsync' is finished");

                return result;
            });
        }

        #endregion

        #region Method05

        internal static void Method05()
        {
            System.Console.WriteLine(@"----------------------------------------------------------------------");
            System.Console.WriteLine(@"---                           Async 05                             ---");
            System.Console.WriteLine(@"DisplayResult() call async Task<object> RunSomeMethods(Func<Task<int>> func).");
            System.Console.WriteLine(@"----------------------------------------------------------------------");

            Method05DisplayResult();

            System.Console.WriteLine(@"Main method is finished.");
        }

        internal static void Method05DisplayResult()
        {
            System.Console.WriteLine(@"Method 'DisplayResult' is started");

            var dtStart = DateTime.Now;

            var num = 8;

            var result = (int)Method05RunSomeMethodsAsync(() => Method05FactorialAsync(num)).GetAwaiter().GetResult();

            System.Console.WriteLine("Time of calculation: " + Convert.ToString(DateTime.Now - dtStart));
            System.Console.WriteLine("Factorial of a number {0} = {1}", num, result);

            System.Console.WriteLine(@"Method 'DisplayResult' is finished");
        }

        internal static async Task<object> Method05RunSomeMethodsAsync(Func<Task<int>> func)
        {
            return await Task.Run(() =>
            {
                var result = 0;
                if (func() is Task<int> funcInt)
                {
                    result = funcInt.GetAwaiter().GetResult();
                }
                return result;
            }).ConfigureAwait(false);
        }

        internal static Task<int> Method05FactorialAsync(int x)
        {
            return Task.Run(() =>
            {
                System.Console.WriteLine(@"Task 'FactorialAsync' is started");

                var result = 1;
                for (var i = 1; i <= x; i++)
                {
                    result *= i;
                }

                System.Console.WriteLine(@"Task 'FactorialAsync' is finished");

                return result;
            });
        }

        #endregion

        #region Method06

        internal static void Method06()
        {
            System.Console.WriteLine(@"----------------------------------------------------------------------");
            System.Console.WriteLine(@"---                           Async 06                             ---");
            System.Console.WriteLine(@"DisplayResult() call async Task<object> RunSomeMethods(List<(Func<Task<int>> func, string name)> actions).");
            System.Console.WriteLine(@"----------------------------------------------------------------------");

            Method06DisplayResult();

            System.Console.WriteLine(@"Main method is finished.");
        }

        internal static void Method06DisplayResult()
        {
            System.Console.WriteLine(@"Method 'DisplayResult' is started");

            var dtStart = DateTime.Now;

            var num = 8;

            var result = (int)Method06RunSomeMethodsAsync(
                new List<(Func<Task<int>> Func, string ActionText)> { (() => Method06FactorialAsync(num), "FactorialAsync(num)") }).GetAwaiter().GetResult();

            System.Console.WriteLine("Time of calculation: " + Convert.ToString(DateTime.Now - dtStart));
            System.Console.WriteLine("Factorial of a number {0} = {1}", num, result);

            System.Console.WriteLine(@"Method 'DisplayResult' is finished");
        }

        internal static async Task<object> Method06RunSomeMethodsAsync(List<(Func<Task<int>> func, string name)> actions)
        {
            return await Task.Run(() =>
            {
                var result = 0;
                foreach (var (func, _) in actions)
                {
                    if (func() is Task<int> funcInt)
                    {
                        result = funcInt.GetAwaiter().GetResult();
                    }
                }
                return result;
            }).ConfigureAwait(false);
        }

        internal static Task<int> Method06FactorialAsync(int x)
        {
            return Task.Run(() =>
            {
                System.Console.WriteLine(@"Task 'FactorialAsync' is started");

                int result = 1;
                for (int i = 1; i <= x; i++)
                {
                    result *= i;
                }

                System.Console.WriteLine(@"Task 'FactorialAsync' is finished");

                return result;
            });
        }

        #endregion

        #region Method07

        internal static void Method07()
        {
            System.Console.WriteLine(@"----------------------------------------------------------------------");
            System.Console.WriteLine(@"---                           Async 07                             ---");
            System.Console.WriteLine(@"DisplayResult() call async Task<T> RunSomeMethods(Func<Task<T>> func).GetAwaiter().GetResult().");
            System.Console.WriteLine(@"----------------------------------------------------------------------");

            Method07DisplayResult();

            System.Console.WriteLine(@"Main method is finished.");
        }

        internal static void Method07DisplayResult()
        {
            System.Console.WriteLine(@"Method 'DisplayResult' is started");

            var dtStart = DateTime.Now;

            var num = 8;

            var result = Method07RunSomeMethodsAsync(() => Method07FactorialAsync(num)).GetAwaiter().GetResult();

            System.Console.WriteLine("Time of calculation: " + Convert.ToString(DateTime.Now - dtStart));
            System.Console.WriteLine("Factorial of a number {0} = {1}", num, result);

            System.Console.WriteLine(@"Method 'DisplayResult' is finished");
        }

        internal static Task<T> Method07RunSomeMethodsAsync<T>(Func<Task<T>> func)
        {
            return Task.Run(() =>
            {
                T result = default;
                if (func() is Task<T> funcInt)
                {
                    result = funcInt.GetAwaiter().GetResult();
                }
                return result;
            });
        }

        internal static Task<T> Method07FactorialAsync<T>(T x)
        {
            return Task.Run(() =>
            {
                System.Console.WriteLine(@"Task 'FactorialAsync' is started");

                T result = default;
                if (x is int intX)
                {
                    var intResult = 1;
                    for (var i = 1; i <= intX; i++)
                    {
                        intResult *= i;
                    }
                    if (typeof(T) == typeof(int))
                        return (T)(object)intResult;
                }

                System.Console.WriteLine(@"Task 'FactorialAsync' is finished");

                return result;
            });
        }

        #endregion

        #region Task11

        internal static void Task11()
        {
            System.Console.WriteLine(@"----------------------------------------------------------------------");
            System.Console.WriteLine(@"---                           Task 01                              ---");
            System.Console.WriteLine(@"Task.WaitAll.");
            System.Console.WriteLine(@"----------------------------------------------------------------------");

            var cts = new CancellationTokenSource();
            var token = cts.Token;
            var tasks = new List<Task>();
            var rnd = new Random();
            var lockObj = new object();
            string[] words = { "reason", "editor", "rioter", "rental", "senior", "regain", "ordain", "rained" };

            foreach (var word in words)
            {
                tasks.Add(Task.Factory.StartNew((item) =>
                {
                    var chars = item.ToString().ToCharArray();
                    var order = new double[chars.Length];
                    token.ThrowIfCancellationRequested();
                    var wasZero = false;
                    lock (lockObj)
                    {
                        for (var ctr = 0; ctr < order.Length; ctr++)
                        {
                            order[ctr] = rnd.NextDouble();
                            if (order[ctr] == 0)
                            {
                                if (!wasZero)
                                {
                                    wasZero = true;
                                }
                                else
                                {
                                    cts.Cancel();
                                }
                            }
                        }
                    }
                    token.ThrowIfCancellationRequested();
                    Array.Sort(order, chars);
                    System.Console.WriteLine($"{item} --> {new string(chars)}");
                }, word, token));
            }

            try
            {
                Task.WaitAll(tasks.ToArray());
            }
            catch (AggregateException e)
            {
                foreach (var ie in e.InnerExceptions)
                {
                    if (ie is OperationCanceledException)
                    {
                        System.Console.WriteLine("The word scrambling operation has been canceled.");
                        break;
                    }
                    else
                    {
                        System.Console.WriteLine(ie.GetType().Name + ": " + ie.Message);
                    }
                }
            }
            finally
            {
                cts.Dispose();
            }

            System.Console.WriteLine(@"Main method is finished.");
        }

        #endregion
    }
}

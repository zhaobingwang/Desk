using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desk.Gist.Fundamentals.Event
{
    /// <summary>
    /// 事件
    /// https://docs.microsoft.com/zh-cn/dotnet/standard/events/how-to-raise-and-consume-events
    /// </summary>
    public class EventGist
    {
        #region Gist1 没有数据的事件
        public static void Run1()
        {
            var threshold = new Random().Next(10);
            Console.WriteLine($"The threshold is {threshold}");
            Counter1 counter = new Counter1(threshold);
            counter.ThresholdReached += Counter_ThresholdReached1;
            Console.WriteLine("press 'a' key to increase total");
            while (Console.ReadKey(true).KeyChar == 'a')
            {
                Console.WriteLine("adding one");
                counter.Add(1);
            }
        }


        private static void Counter_ThresholdReached1(object sender, EventArgs e)
        {
            Console.WriteLine("The threshold was reached.");
            Environment.Exit(0);
        }

        class Counter1
        {
            private int threshold;
            private int total;

            public Counter1(int passedThreshold)
            {
                threshold = passedThreshold;
            }

            public void Add(int x)
            {
                total += x;
                if (total >= threshold)
                {
                    OnThresholdReached(EventArgs.Empty);
                }
            }

            protected virtual void OnThresholdReached(EventArgs e)
            {
                EventHandler handler = ThresholdReached;
                if (handler != null)
                {
                    handler(this, e);
                }
            }

            public event EventHandler ThresholdReached;
        }
        #endregion

        #region Gist2 提供数据的事件，包含自定义事件数据对象
        public static void Run2()
        {
            var threshold = new Random().Next(10);
            Console.WriteLine($"The threshold is {threshold}");
            Counter2 counter = new Counter2(threshold);
            counter.ThresholdReached += Counter_ThresholdReached2;
            Console.WriteLine("press 'a' key to increase total");
            while (Console.ReadKey(true).KeyChar == 'a')
            {
                Console.WriteLine("adding one");
                counter.Add(1);
            }
        }

        private static void Counter_ThresholdReached2(object sender, ThresholdReachedEventArgs e)
        {
            Console.WriteLine($"The threshold of {e.Threshold} was reached at {e.TimeReached}.");
            Environment.Exit(0);
        }

        class Counter2
        {
            private int threshold;
            private int total;

            public Counter2(int passedThreshold)
            {
                threshold = passedThreshold;
            }

            public void Add(int x)
            {
                total += x;
                if (total >= threshold)
                {
                    ThresholdReachedEventArgs args = new ThresholdReachedEventArgs();
                    args.Threshold = threshold;
                    args.TimeReached = DateTime.Now;
                    OnThresholdReached(args);
                }
            }

            protected virtual void OnThresholdReached(ThresholdReachedEventArgs e)
            {
                EventHandler<ThresholdReachedEventArgs> handler = ThresholdReached;
                if (handler != null)
                {
                    handler(this, e);
                }
            }

            public event EventHandler<ThresholdReachedEventArgs> ThresholdReached;
        }
        #endregion

        #region Gist3 声明事件的委托，通常不需要为事件声名委托，因为可以使用 EventHandler 或者 EventHandler<TEventArgs> 委托。 只有在极少数情况下才应声明委托，例如，在向无法使用泛型的旧代码提供类时，就需要如此
        public static void Run3()
        {
            var threshold = new Random().Next(10);
            Console.WriteLine($"The threshold is {threshold}");
            Counter2 counter = new Counter2(threshold);
            counter.ThresholdReached += Counter_ThresholdReached3;
            Console.WriteLine("press 'a' key to increase total");
            while (Console.ReadKey(true).KeyChar == 'a')
            {
                Console.WriteLine("adding one");
                counter.Add(1);
            }
        }

        private static void Counter_ThresholdReached3(object sender, ThresholdReachedEventArgs e)
        {
            Console.WriteLine($"The threshold of {e.Threshold} was reached at {e.TimeReached}.");
            Environment.Exit(0);
        }

        class Counter3
        {
            private int threshold;
            private int total;

            public Counter3(int passedThreshold)
            {
                threshold = passedThreshold;
            }

            public void Add(int x)
            {
                total += x;
                if (total >= threshold)
                {
                    ThresholdReachedEventArgs args = new ThresholdReachedEventArgs();
                    args.Threshold = threshold;
                    args.TimeReached = DateTime.Now;
                    OnThresholdReached(args);
                }
            }

            protected virtual void OnThresholdReached(ThresholdReachedEventArgs e)
            {
                ThresholdReachedEventHandler handler = ThresholdReached;
                if (handler != null)
                {
                    handler(this, e);
                }
            }

            public event ThresholdReachedEventHandler ThresholdReached;
        }
        #endregion
    }

    public class ThresholdReachedEventArgs : EventArgs
    {
        public int Threshold { get; set; }
        public DateTime TimeReached { get; set; }
    }

    public delegate void ThresholdReachedEventHandler(object sender, ThresholdReachedEventArgs e);
}

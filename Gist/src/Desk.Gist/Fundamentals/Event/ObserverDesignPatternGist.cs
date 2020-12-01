﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desk.Gist.Fundamentals.Event
{
    public class ObserverDesignPatternGist
    {
        public static void Run()
        {
            BaggageHandler provider = new BaggageHandler();
            ArrivalsMonitor observer1 = new ArrivalsMonitor("BaggageClaimMonitor1");
            ArrivalsMonitor observer2 = new ArrivalsMonitor("SecurityExit");

            provider.BaggageStatus(712, "杭州", 3);
            observer1.Subscribe(provider);
            provider.BaggageStatus(712, "深圳", 3);
            provider.BaggageStatus(400, "北京", 1);
            provider.BaggageStatus(712, "杭州", 3);
            observer2.Subscribe(provider);
            provider.BaggageStatus(511, "上海", 2);
            provider.BaggageStatus(712);
            observer2.Unsubscribe();
            provider.BaggageStatus(400);
            provider.LastBaggageClaimed();
        }
    }

    public class BaggageHandler : IObservable<BaggageInfo>
    {
        private List<IObserver<BaggageInfo>> observers;
        private List<BaggageInfo> flights;
        public BaggageHandler()
        {
            observers = new List<IObserver<BaggageInfo>>();
            flights = new List<BaggageInfo>();
        }
        public IDisposable Subscribe(IObserver<BaggageInfo> observer)
        {
            // Check whether observer is already registered. If not, add it
            if (!observers.Contains(observer))
            {
                observers.Add(observer);
                // Provide observer with existing data.
                foreach (var item in flights)
                {
                    observer.OnNext(item);
                }
            }
            return new Unsubscriber<BaggageInfo>(observers, observer);
        }

        public void BaggageStatus(int flightNo)
        {
            BaggageStatus(flightNo, string.Empty, 0);
        }

        public void BaggageStatus(int flightNo, string from, int carousel)
        {
            var info = new BaggageInfo(flightNo, from, carousel);
            // Carousel is assigned, so add new info object to list.
            if (carousel > 0 && !flights.Contains(info))
            {
                flights.Add(info);
                foreach (var observer in observers)
                {
                    observer.OnNext(info);
                }
            }
            else if (carousel == 0)
            {
                // Baggage claim for flight is done.
                var flightsToRemove = new List<BaggageInfo>();
                foreach (var flight in flights)
                {
                    if (info.FlightNumber == flight.FlightNumber)
                    {
                        flightsToRemove.Add(flight);
                        foreach (var observer in observers)
                        {
                            observer.OnNext(info);
                        }
                    }
                }
                foreach (var flightToRemove in flightsToRemove)
                {
                    flights.Remove(flightToRemove);
                }
                flightsToRemove.Clear();
            }
        }

        public void LastBaggageClaimed()
        {
            foreach (var observer in observers)
            {
                observer.OnCompleted();
            }
            observers.Clear();
        }
    }

    public class BaggageInfo
    {
        private int flightNo;
        private string origin;
        private int location;
        internal BaggageInfo(int flightNo, string from, int carousel)
        {
            this.flightNo = flightNo;
            this.origin = from;
            this.location = carousel;
        }

        public int FlightNumber
        {
            get
            {
                return flightNo;
            }
        }

        public string From
        {
            get
            {
                return origin;
            }
        }

        public int Carousel
        {
            get
            {
                return location;
            }
        }
    }

    internal class Unsubscriber<BaggageInfo> : IDisposable
    {
        private List<IObserver<BaggageInfo>> _observers;
        private IObserver<BaggageInfo> _observer;

        internal Unsubscriber(List<IObserver<BaggageInfo>> observers, IObserver<BaggageInfo> observer)
        {
            _observers = observers;
            _observer = observer;
        }
        public void Dispose()
        {
            if (_observers.Contains(_observer))
                _observers.Remove(_observer);
        }
    }

    public class ArrivalsMonitor : IObserver<BaggageInfo>
    {
        private string name;
        private List<string> flightInfos = new List<string>();
        private IDisposable cancellation;
        private string fmt = "{0,-20} {1,5}  {2, 3}";

        public ArrivalsMonitor(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException("The observer must be assigned a name.");
            }
            this.name = name;
        }

        public virtual void Subscribe(BaggageHandler provider)
        {
            cancellation = provider.Subscribe(this);
        }

        public virtual void Unsubscribe()
        {
            cancellation.Dispose();
            flightInfos.Clear();
        }

        public void OnCompleted()
        {
            flightInfos.Clear();
        }

        // No implementation needed: Method is not called by the BaggageHandler class.
        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        public void OnNext(BaggageInfo info)
        {
            bool updated = false;

            // Flight has unloaded its baggage; remove from the monitor.
            if (info.Carousel == 0)
            {
                var flightsToRemove = new List<string>();
                string flightNo = string.Format("{0,5}", info.FlightNumber);

                foreach (var flightInfo in flightInfos)
                {
                    if (flightInfo.Substring(21, 5).Equals(flightNo))
                    {
                        flightsToRemove.Add(flightInfo);
                        updated = true;
                    }
                }
                foreach (var flightToRemove in flightsToRemove)
                {
                    flightInfos.Remove(flightToRemove);
                }
                flightsToRemove.Clear();
            }
            else
            {
                // Add flight if it does not exist in the collection.
                string flightInfo = string.Format(fmt, info.From, info.FlightNumber, info.Carousel);
                if (!flightInfos.Contains(flightInfo))
                {
                    flightInfos.Add(flightInfo);
                    updated = true;
                }
            }

            if (updated)
            {
                flightInfos.Sort();
                Console.WriteLine("Arrivals information from {0}", this.name);
                foreach (var flightInfo in flightInfos)
                    Console.WriteLine(flightInfo);

                Console.WriteLine();
            }
        }
    }
}

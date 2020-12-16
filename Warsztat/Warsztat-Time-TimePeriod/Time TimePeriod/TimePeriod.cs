using System;

namespace TimeTimePeriod

{

    public struct TimePeriod : IEquatable<TimePeriod>, IComparable<TimePeriod>

    {

        private readonly byte _hours;

        private readonly byte _minutes;

        private readonly byte _seconds;

        private readonly long _interval;



        public long Interval { get => _interval; }

        public long Hours { get => _hours; }

        public long Minutes { get => _minutes; }

        public long Seconds { get => _seconds; }



        public TimePeriod(long interval)

        {

            if (interval <= 0)
            {
                throw new ArgumentOutOfRangeException("Nie możesz podać ujemnych sekund");
            }

            _interval = interval;

            _hours = (byte)(interval / 3600);

            interval %= 3600;

            _minutes = (byte)(interval / 60);

            interval %= 60;

            _seconds = (byte)interval;


        }



        public TimePeriod(string times)

        {

            string[] time = times.Split(':');

            if (byte.TryParse(time[0], out byte hour) && byte.TryParse(time[1], out byte minute) && byte.TryParse(time[2], out byte second))

            {
                if (minute >= 60)
                {
                    throw new ArgumentException("Zły format, dla minut przyjmij czas od 0 do 59");
                }

                if (second >= 60)
                {
                    throw new ArgumentException("Zły format, dla sekund przyjmij czas od 0 do 59");
                }
                _hours = hour;

                _minutes = minute;

                _seconds = second;

                _interval = hour * 3600 + minute * 60 + second;


            }

            else

                throw new FormatException("Zły format czasu");


        }

        public override string ToString()
        {
            string _minutes = "";
            string _seconds = "";
            if (Minutes < 10)
            {
                _minutes = "0" + Minutes.ToString();
            }
            else
            {
                _minutes = Minutes.ToString();
            }
            if (Seconds < 10)
            {
                _seconds = "0" + Seconds.ToString();
            }
            else
            {
                _seconds = Seconds.ToString();
            }

            return Hours + ":" + _minutes + ":" + _seconds;

        }



        public override int GetHashCode()

        {

            return Seconds.GetHashCode();

        }



        public long getInterval()

        {

            return _interval;

        }

        public bool Equals(TimePeriod x)

        {

            return this.getInterval() == x.getInterval();

        }



        public override bool Equals(Object obj)

        {

            return (obj is TimePeriod time) && this.Equals(time);

        }



        public static bool operator ==(TimePeriod x, TimePeriod y)

        {

            return x.getInterval() == y.getInterval();

        }



        public static bool operator !=(TimePeriod x, TimePeriod y)

        {

            return x.getInterval() != y.getInterval();

        }



        public int CompareTo(TimePeriod other)

        {

            if (other == null)
            {
                return 1;
            }

            return Interval.CompareTo(other.Interval);

        }

        public static bool operator >(TimePeriod x, TimePeriod y)
        {
            return x.CompareTo(y) > 0;
        }

        public static bool operator <(TimePeriod x, TimePeriod y)
        {
            return x.CompareTo(y) < 0;
        }

        public static bool operator >=(TimePeriod x, TimePeriod y)
        {
            return x.CompareTo(y) >= 0;
        }

        public static bool operator <=(TimePeriod x, TimePeriod y)
        {
            return x.CompareTo(y) <= 0;
        }

        public static TimePeriod operator -(TimePeriod x, TimePeriod y)

        {

            long diff = (x.getInterval() - y.getInterval());

            return new TimePeriod(diff);

        }

        public static TimePeriod operator +(TimePeriod x, TimePeriod y)

        {

            return new TimePeriod(x.getInterval() + y.getInterval());

        }

        public static TimePeriod operator *(TimePeriod x, int y)

        {

            return new TimePeriod(x.getInterval() * y);

        }

        public static TimePeriod operator /(TimePeriod x, int y)

        {

            return new TimePeriod(x.getInterval() / y);

        }



    }

}
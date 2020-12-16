using System;

namespace TimeTimePeriod

{

    public struct Time : IEquatable<Time>, IComparable<Time>

    {


        private readonly byte _hours;

        private readonly byte _minutes;

        private readonly byte _seconds;



        public byte Hours { get => _hours; }

        public byte Minutes { get => _minutes; }

        public byte Seconds { get => _seconds; }



        public long IloscSekWGodz()

        {

            return (Hours * 3600) + (Minutes * 60) + Seconds;

        }



        public Time(byte hours = 0, byte minutes = 0, byte seconds = 0)

        {

            if (hours < 24)
            {
                _hours = hours;
            }
            else throw new ArgumentException("Zły format, dla godziny przyjmij czas od 0 do 23");



            if (minutes < 60)
            {
                _minutes = minutes;
            }
            else throw new ArgumentException("Zły format, dla minut przyjmij czas od 0 do 59");



            if (seconds < 60)
            {
                _seconds = seconds;
            }
            else throw new ArgumentException("Zły format, dla sekund przyjmij czas od 0 do 59");

        }



        public Time(string times)

        {

            string[] time = times.Split(':');

            if (byte.TryParse(time[0], out byte hour) && byte.TryParse(time[1], out byte minute) && byte.TryParse(time[2], out byte second))

            {

                _hours = hour;

                _minutes = minute;

                _seconds = second;



                if (hour >= 24)
                {
                    throw new ArgumentException("Zły format, dla godziny przyjmij czas od 0 do 23");
                }



                if (minute >= 60)
                {
                    throw new ArgumentException("Zły format, dla minut przyjmij czas od 0 do 59");
                }



                if (second >= 60)
                {
                    throw new ArgumentException("Zły format, dla ekund przyjmij czas od 0 do 59");
                }



            }

            else
            {
                throw new FormatException("Zły format czasu");
            }



        }

        public static explicit operator Time(TimePeriod v)
        {
            throw new NotImplementedException();
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


            return _hours + ":" + _minutes + ":" + _seconds;

        }



        public override int GetHashCode()

        {

            return (Hours, Minutes, Seconds).GetHashCode();

        }



        public byte getHours()

        {

            return _hours;

        }

        public byte getMinutes()

        {

            return _minutes;

        }

        public byte getSeconds()

        {

            return _seconds;

        }

        public bool Equals(Time x)

        {

            return this.getHours() == x.getHours() && this.getMinutes() == x.getMinutes() && this.getSeconds() == x.getSeconds();

        }

        public override bool Equals(Object obj)

        {

            return (obj is Time time) && this.Equals(time);

        }



        static public bool operator ==(Time x, Time y)

        {

            return (x.getHours() == y.getHours() && x.getMinutes() == y.getMinutes() && x.getSeconds() == y.getSeconds());

        }

        static public bool operator !=(Time x, Time y)

        {

            return (x.getHours() != y.getHours() || x.getMinutes() != y.getMinutes() || x.getSeconds() != y.getSeconds());

        }



        public int CompareTo(Time other)

        {

            if (other == null)
            {
                return 0;
            }

            return this.IloscSekWGodz().CompareTo(other.IloscSekWGodz());

        }

        public static bool operator >(Time x, Time y)
        {
            return x.CompareTo(y) > 0;
        }

        public static bool operator <(Time x, Time y)
        {
            return x.CompareTo(y) < 0;
        }

        public static bool operator >=(Time x, Time y)
        {
            return x.CompareTo(y) >= 0;
        }

        public static bool operator <=(Time x, Time y)
        {
            return x.CompareTo(y) <= 0;
        }

        public static Time operator +(Time x, TimePeriod x1)
        {
            long Seconds;

            if (x.IloscSekWGodz() - x1.getInterval() <= 0)
            {
                Seconds = 345600 + (x.IloscSekWGodz() - x1.getInterval());
            }
            else
            {
                Seconds = x.IloscSekWGodz() - x1.getInterval();
            }

            int Hours = (int)(Seconds / 3600) % 24;
            Seconds = Seconds % 3600;
            int Minutes = (int)(Seconds / 60);
            Seconds = Seconds % 60;

            return new Time((byte)Hours, (byte)Minutes, (byte)Seconds);
        }

        public static Time operator -(Time x, TimePeriod x1)
        {
            long Seconds;

            if (x.IloscSekWGodz() - x1.getInterval() <= 0)
            {
                Seconds = 345600 + (x.IloscSekWGodz() - x1.getInterval());
            }
            else
            {
                Seconds = x.IloscSekWGodz() - x1.getInterval();
            }

            int Hours = (int)(Seconds / 3600) % 24;
            Seconds = Seconds % 3600;
            int Minutes = (int)(Seconds / 60);
            Seconds = Seconds % 60;

            return new Time((byte)Hours, (byte)Minutes, (byte)Seconds);
        }


    }

}
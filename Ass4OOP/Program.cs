namespace Ass4OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseClass p1 = new DerivedClass1();
            p1.DisplayMessage();
            BaseClass p2 = new DerivedClass2();
            p2.DisplayMessage();




            Duration D1 = new Duration(1, 10, 15);
            Console.WriteLine(D1);

            Duration D2 = new Duration(7800);
            Console.WriteLine(D2);

            Duration D3 = new Duration(666);
            Console.WriteLine(D3);

            D3 = D1 + D2;
            D3 = D1 + 7800;
            D3 = 666 + D3;
            D3 = ++D1;
            D3 = --D2;
            D1 = D1 - D2;

     
     

        }

    }
    #region part 2 Q123
    class Duration
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }
        public Duration(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }
        public Duration(int totalSeconds)
        {
            Hours = totalSeconds / 3600;
            totalSeconds %= 3600;
            Minutes = totalSeconds / 60;
            Seconds = totalSeconds % 60;
        }
        public override string ToString()
        {
            return $"Hours :{Hours}  Minutes : {Minutes} Seconds  : {Seconds}";
        }
        public override bool Equals(object? obj)
        {
            Duration other = obj as Duration;
            return other != null &&
                   Hours == other.Hours &&
                   Minutes == other.Minutes &&
                   Seconds == other.Seconds;
        }

        public override int GetHashCode()
        {
            return Hours ^ Minutes ^ Seconds;
        }
    }
    #endregion
    public static class DurationOperators
    {
        public static Duration Add(this Duration d1, Duration d2)
        {
            return new Duration(d1.ToTotalSeconds() + d2.ToTotalSeconds());
        }

        public static int ToTotalSeconds(this Duration d)
        {
            return d.Hours * 3600 + d.Minutes * 60 + d.Seconds;
        }
    }

    #region Q4
    public partial class Duration
    {
        public static Duration operator +(Duration d1, Duration d2)
            => new Duration(d1.ToTotalSeconds() + d2.ToTotalSeconds());

        public static Duration operator +(Duration d, int seconds)
            => new Duration(d.ToTotalSeconds() + seconds);

        public static Duration operator +(int seconds, Duration d)
            => d + seconds;

        public static Duration operator ++(Duration d)
            => new Duration(d.ToTotalSeconds() + 60); 

        public static Duration operator --(Duration d)
            => new Duration(d.ToTotalSeconds() - 60); 

        public static Duration operator -(Duration d1, Duration d2)
            => new Duration(d1.ToTotalSeconds() - d2.ToTotalSeconds());

        public static bool operator >(Duration d1, Duration d2)
            => d1.ToTotalSeconds() > d2.ToTotalSeconds();

        public static bool operator <(Duration d1, Duration d2)
            => d1.ToTotalSeconds() < d2.ToTotalSeconds();

        public static bool operator >=(Duration d1, Duration d2)
            => d1.ToTotalSeconds() >= d2.ToTotalSeconds();

        public static bool operator <=(Duration d1, Duration d2)
            => d1.ToTotalSeconds() <= d2.ToTotalSeconds();

        public static implicit operator bool(Duration d)
            => d.ToTotalSeconds() != 0;

        public static explicit operator DateTime(Duration d)
            => new DateTime().AddSeconds(d.ToTotalSeconds());
    }
#endregion

}

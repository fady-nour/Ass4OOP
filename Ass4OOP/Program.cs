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
        }
    }
    #region Q123
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

}

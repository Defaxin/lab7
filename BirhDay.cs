namespace ConsoleApp17
{
    internal class BirthDay
    {
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }

        public BirthDay(int d, int m, int y)
        {
            Day = d;
            Month = m;
            Year = y;
        }
        public override string ToString() => $"{Day}-{Month}-{Year}";
    }
    class ClBirthDay
    {
        public void NextWeekInYear(BirthDay b)
        {
            DateTime next = new DateTime(b.Year, b.Month, b.Day);
            Console.WriteLine(next.DayOfWeek.ToString());
        }
        public void NextDayInWeek(BirthDay b, int y)
        {
            DateTime next = new DateTime(y, b.Month, b.Day);
            Console.WriteLine(next.DayOfWeek.ToString());
        }
        public void DayToBirthDay(BirthDay b)
        {
            DateTime today = DateTime.Today;
            DateTime next = new DateTime(today.Year, b.Month, b.Day);
            if (next < today)
            {
                next = next.AddYears(1);
            }
            Console.WriteLine((next - today).Days);
        }
    }
}
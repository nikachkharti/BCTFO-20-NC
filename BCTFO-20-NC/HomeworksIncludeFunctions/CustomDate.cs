namespace Homeworks
{
    public class CustomDate
    {
        public uint Day { get; set; }
        public uint Month { get; set; }
        public uint Year { get; set; }

        public CustomDate(uint year, uint month, uint day)
        {
            Day = day;
            Month = month;
            Year = year;
        }

        public CustomDate AddDays(uint days)
        {
            return new CustomDate(Year, Month, Day += days);
        }

        public CustomDate AddMonths(uint months)
        {
            return new CustomDate(Year, Month += months, Day);
        }

        public CustomDate AddYears(uint years)
        {
            return new CustomDate(Year += years, Month, Day);
        }

        public static CustomDate operator -(CustomDate obj1, CustomDate obj2)
        {
            return new CustomDate(year: obj1.Year - obj2.Year, month: obj1.Month - obj2.Month, day: obj1.Day - obj2.Day);
        }

        public override string ToString()
        {
            return $"{Year}-{Month}-{Day}";
        }
    }
}

namespace SecondConsoleApp
{
    public class Lesson
    {
        public string Name { get; set; }
        public DateTime StartDate { get; set; }

        [ValidDates(nameof(StartDate))]
        public DateTime EndDate { get; set; }
    }
}

namespace TVProgramApp.Helpers
{
    public class DayOfWeekHelper
    {
        public static string GetDefaultDayOfWeek()
        {
            return GetDayOfWeekString(DateTime.Now.DayOfWeek);
        }
        private static string GetDayOfWeekString(DayOfWeek dayOfWeek) =>
            dayOfWeek switch
            {
                DayOfWeek.Monday => "Monday",
                DayOfWeek.Tuesday => "Tuesday",
                DayOfWeek.Wednesday => "Wednesday",
                DayOfWeek.Thursday => "Thursday",
                DayOfWeek.Friday => "Friday",
                DayOfWeek.Saturday => "Saturday",
                DayOfWeek.Sunday => "Sunday",
                _ => throw new ArgumentOutOfRangeException(nameof(dayOfWeek))
            };
    }
}

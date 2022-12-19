using System.Globalization;
namespace System
{
    static internal class DateTimeExtencions
    {
        public static string TempoDecorido(this DateTime thisObj)
        {
            TimeSpan duration = DateTime.Now.Subtract(thisObj);
            if (duration.TotalHours < 24)
            {
                return duration.TotalHours.ToString("F1", CultureInfo.InvariantCulture) + " Hours";
            }
            else 
            {
                return duration.TotalDays.ToString("F1", CultureInfo.InvariantCulture) + " Days";
            }
        }
    }
}

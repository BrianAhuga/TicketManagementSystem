namespace ClientUI.Extensions
{
    public static class DateTimeExtensions
    {
        public static string BeautifyDate(this DateTime dateTime)
        {
            return dateTime.ToString("dd MMMM yyyy hh:mm tt");
        }
    }
}

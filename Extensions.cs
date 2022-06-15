namespace CalculosWebApp
{
    public static class Extensions
    {
        public static int ToInt32<T>(this T num) => Convert.ToInt32(num);
        //public static double ToDouble<T>(this T num) => Convert.ToDouble(num);
        public static double? ToDouble<T>(this T? num) => num != null ? Convert.ToDouble(num) : null;
    }
}

namespace Util
{
    public static class Utilities
    {
        public static bool IsNullEmptyOrWhiteSpace(this string value) => String.IsNullOrWhiteSpace(value);
        

        public static bool IsZeroOrNegative(int value){
            return value <= 0 ? true : false;
        }

        public static bool IsPositive(int value) => value > 0 ? true : false;

        public static bool IsInTheFuture(DateOnly value) => value > DateOnly.FromDateTime(DateTime.Now);
        public static void Proces<T>(T value) { } // Testing stuff
    }
}
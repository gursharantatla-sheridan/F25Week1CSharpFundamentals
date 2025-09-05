namespace F25Week1CSharpFundamentals
{
    internal class Program
    {
        static int x;

        static void Main(string[] args)
        {
            int @double;
            //int x;

            int i = 5 + x;
            double d = 5.5;

            float f = 5.5F;
            decimal m = 5.5M;

            long l = 43532432L;

            var n = 5;
            //n = "John";

            Console.WriteLine(@"hello\nworld");

            int cars = 5, trucks = 3, bikes = 2;

            // string concatenation
            Console.WriteLine("There are " + cars + " cars, " + trucks + " trucks and " + bikes + " bikes");

            // string interpolation
            Console.WriteLine($"There are {cars} cars, {trucks} trucks and {bikes} bikes");
        }
    }
}

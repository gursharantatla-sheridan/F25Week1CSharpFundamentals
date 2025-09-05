namespace F25Week1CSharpFundamentals
{
    internal class Program
    {
        static int x;

        static void Main(string[] args)
        {
            int @double;
            //int x;

            //int i = 5 + x;
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


            int i = 5;
            int j = i;

            i++;
            Console.WriteLine(j);


            Circle c1 = new Circle();
            Console.WriteLine(c1.radius);
            c1.radius = 50;
            Console.WriteLine(c1.radius);

            Circle c2 = c1;
            c2.radius = 100;

            Console.WriteLine(c1.radius);


            string s1 = "hello";
            string s2 = s1;

            s2 = "bye";
            Console.WriteLine(s1);


            string? str = null;
            int? z = null;

            //int num = int.Parse(str);
            //Console.WriteLine(num);

            int num = Convert.ToInt32(str);
            Console.WriteLine(num);


            double price = 43244.243;
            Console.WriteLine(price.ToString("C"));

            double rate = 0.25;
            Console.WriteLine(rate.ToString("P1"));

            double number = 324324324.6454;
            Console.WriteLine(number.ToString("F3"));

            //int xx = number as int;


            Person p1 = new Person();
            p1.name = "John";

            Person p2 = p1;
            p2.name = "Anne";

            Console.WriteLine(p1.name);


        }
    }

    class Circle
    {
        public double radius;
    }

    class Person
    {
        public string name;
    }
}

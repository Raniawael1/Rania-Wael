using System;

namespace discrete
{
    class Program
    {
        private static int Begning;

        public static int End { get; private set; }
        public static int sum { get; private set; }
        public static int i { get; private set; }
        public static int n { get; private set; }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Please enter The Begning : ");

            Begning = int.Parse(Console.ReadLine());

            Console.WriteLine("please enter the End: ");

            End = int.Parse(Console.ReadLine());

            Console.WriteLine("The Perfect numbers within the given range : ");

            for (n = Begning; n <= End; n++)
            {
                i = 1;
                sum = 0;
                while (i < n)
                {
                    if (n % i == 0)
                        sum = sum + i;
                    i++;
                }
                if (sum == n)
                    Console.WriteLine("{0} ", n);
            }
            Console.WriteLine("  ");
        }
    }
}

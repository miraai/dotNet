using System;

namespace Hello
{
    class Program
    {
        public static void Greet(string name)
        {
            if (String.IsNullOrEmpty(name)) return;
            Console.WriteLine($"Hello {name}!");
        }

        public static void Combo()
        {
            string one = "a";
            string two = "f";
            string combined = one + two;
            Console.WriteLine($"Hello {combined}!");
        }

        public static void Shhh()
        {
            string loud = "loud";
            loud.ToUpper();
            string quiet = "QUIET";
            quiet.ToLower();
            Console.WriteLine($"Don't be {loud}, be {quiet}.");
        }

        public static void CurrentTime()
        {
            var currentTime = DateTime.Now;
            Console.WriteLine($"Current time: {currentTime}");
        }

        public static void DaysOfYear()
        {
            DateTime nextYear = new DateTime(DateTime.Today.Year + 1, 1, 1);
            TimeSpan duration = nextYear - DateTime.Today;
            Console.WriteLine($"There are {duration.TotalDays} days left in the year.");
        }

        public static void DaysOld()
        {
            var now = DateTime.Today.Date;
            var birthday = new DateTime(1994, 3, 29);
            TimeSpan daysold = now - birthday;
            Console.WriteLine($"You are {daysold} days old.");
        }

        public static int CalcLines()
        {
            Console.WriteLine("Input lines of code you want to calculate: ");
            int n = 3;
            int outp = 0;
            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());
                outp = outp + input;
            }

            Console.Write($"Number of written lines is: {outp}");
            Console.ReadLine();
            return 0;
        }

        static void Main(string[] args)
        {
            TestThis tt = new TestThis();
            //tt.ListGistLoop();

            CalcLines();
        }
    }
}
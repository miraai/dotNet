using System;
using System.Collections.Generic;
using System.Text;

namespace Hello
{
    class TestThis
    {
        public TestThis()
        {

        }

        public static void Multiplication()
        {
            Console.WriteLine("Multiplication Table:");
            Console.WriteLine("      1   2   3   4   5   6   7   8   9  10  11  12  13  14  15");
            for (int i = 1; i < 16; i++)
            {
                Console.Write($" {i} ");
                for (int j = 1; j < 16; j++)
                {
                    string multip = (i * j).ToString();
                    Console.Write(multip.PadLeft(4));
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }

        public static void ArrayEgg()
        {
            int[,] eggCart = new int[2, 6];
            int[] niz1 = { 1, 2, 3, 4 };
            int[] imee = new int[5];
            for (int i = 0; i < imee.Length; i++)
            {
                imee[i] += i;
            }

            foreach (var item in imee)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine($"Duzina je: {eggCart.Length}?");

            for(int i = 1; i < 3; i++)
            {
                Console.Write($" {i} ");
                for (int j = 1; j < 7; j++)
                {
                    Console.Write($" {j} ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }

        public static void ArrayOfStrings()
        {
            string input = "red,blue,yellow,green";
            string[] colors = input.Split(',');
            
            foreach (var item in colors)
            {
                Console.WriteLine(item.ToString());
            }

            string output = String.Join(" | ", colors);
            Console.WriteLine(output.ToUpper());
            Console.ReadLine();
        }

        public static void ListGist()
        {
            List<int> intAnts = new List<int>();

            Console.WriteLine("Add a number to the list (up to 5): ");
            for (int i = 0; i < 5; i++)
            {
                int input = int.Parse(Console.ReadLine());
                intAnts.Add(input);
            }

            intAnts.Sort();
            Console.WriteLine("Added numbers are: ");
            foreach (var item in intAnts)
            {
                Console.WriteLine(item.ToString());
            }

            int numAnts = intAnts.Count;
            Console.WriteLine($"There's {numAnts} numAnts in the intAnts list.");

            Console.WriteLine("What???");
            intAnts.ForEach(Console.WriteLine);

            Console.ReadLine();
        }

        public void ListGistLoop()
        {
            var lista = new List<int>() { 10, 20, 30, 40, 50 };

            Console.WriteLine("List contains: ");
            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine(lista[i]);
            }

            int[] niz = new[] { 1, 2, 3, 4, 5 };

            Console.WriteLine("Array contains: ");
            for (int i = 0; i < niz.Length; i++)
            {
                Console.WriteLine(niz[i]);
            }

            Console.ReadLine();
        }
    }
}

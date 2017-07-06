using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace KoalaLand
{
    class CreateKoalas
    {
        private List<Koalas> koalas = new List<Koalas>();
        Koalas koala;

        string nameKoala;
        int ageKoala;
        string favoriteFood;
        string colorKoala;
        string snuggles;
        int age;

        public List<Koalas> GetKoalasList()
        {
            return koalas;
        }
        public CreateKoalas()
        {
            
        }

        public void MakeKoalas()
        {
            Console.WriteLine("How many Koalas do you want to make: ");
            int numKoalas = int.Parse(Console.ReadLine());

            

            for (int i = 0; i < numKoalas; i++)
            {
                Console.WriteLine("Name your Koala: ");
                nameKoala = Console.ReadLine();

                Console.WriteLine("Age of your Koala: ");
                //try
                //{
                //    ageKoala = int.Parse(Console.ReadLine());
                //}
                //catch (System.FormatException ex)
                //{
                //    Console.WriteLine("Integer expected.");
                //    ageKoala = int.Parse(Console.ReadLine());
                //    throw ex;

                //}
                while (!verif(Console.ReadLine())) { }
                    
                Console.WriteLine("Koala's favorite food: ");
                favoriteFood = Console.ReadLine();

                Console.WriteLine("Color of your Koala: ");
                colorKoala = Console.ReadLine();

                Console.WriteLine("Does your Koala likes snuggles (yes/no): ");
                snuggles = Console.ReadLine().ToLower();
                if ((snuggles != "yes") || (snuggles != "no"))
                {
                    Console.WriteLine("Please answer with yes or no.");
                    snuggles = Console.ReadLine();
                }

                koala = new Koalas(nameKoala, ageKoala, favoriteFood, colorKoala, snuggles);
                koalas.Add(koala);
            }
        }

        public bool verif(string test)
        {
            try
            {
                ageKoala = int.Parse(test);
                return true;
            }
            catch (System.FormatException ex)
            {
                Console.WriteLine("Integer expected.");
                return false;

            }
        }

        public void ListKoalas()
        {
            foreach (var item in koalas)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public void AllKoalaNames()
        {
            IEnumerable<string> allKoalaNames = koalas.Select(x => x.GetName());
            List<Koalas> koalaNamesList = koalas.Where(x => x.GetSnuggles().ToLower().Equals("yes")).ToList();

            foreach (var item in allKoalaNames)
            {
                Console.WriteLine($"All Koala Names: {item.ToString()}");
            }

            foreach (var item in koalaNamesList)
            {
                Console.WriteLine($"Snugglie Koalas: {koalaNamesList.Count()}");
            }
            
        }

        public int CountKoalas()
        {
            int allKoalas = koalas.Count();
            return allKoalas;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace KoalaLand
{
    class CreateKoalas
    {
        private List<Koalas> koalas = new List<Koalas>();
        Koalas koala = new Koalas();
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

            string nameKoala;
            int ageKoala;
            string favoriteFood;
            string colorKoala;
            Boolean snuggles;

            for (int i = 0; i < numKoalas; i++)
            {
                Console.WriteLine("Name your Koala: ");
                nameKoala = Console.ReadLine();
                koala.SetName(nameKoala);

                Console.WriteLine("Age of your Koala: ");
                ageKoala = int.Parse(Console.ReadLine());
                koala.SetAge(ageKoala);

                Console.WriteLine("Koala's favorite food: ");
                favoriteFood = Console.ReadLine();
                koala.SetFavoriteFood(favoriteFood);

                Console.WriteLine("Color of your Koala: ");
                colorKoala = Console.ReadLine();
                koala.SetColor(colorKoala);

                Console.WriteLine("Does your Koala likes snuggles (True/False): ");
                snuggles = Boolean.Parse(Console.ReadLine());
                koala.SetSnuggles(snuggles);

                koalas.Add(koala);
            }
        }

        public void ListKoalas()
        {
            foreach (var item in koalas)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}

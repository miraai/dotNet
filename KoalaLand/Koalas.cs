using System;
using System.Collections.Generic;
using System.Text;

namespace KoalaLand
{
    class Koalas
    {
        private string name;
        private int age;
        private string favoriteFood;
        private string color;
        private string snuggles;


        public Koalas() { }
        public Koalas(string name, int age, string favoriteFood, string color, string snuggles)
        {
            this.name = name;
            this.age = age;
            this.favoriteFood = favoriteFood;
            this.color = color;
            this.snuggles = snuggles;
        }

        public string GetName()
        {
            return name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public int GetAge()
        {
            return age;
        }

        public void SetAge(int age)
        {
            this.age = age;
        }

        public string GetFavoriteFood()
        {
            return favoriteFood;
        }

        public void SetFavoriteFood(string favoriteFood)
        {
            this.favoriteFood = favoriteFood;
        }

        public string GetColor()
        {
            return color;
        }

        public void SetColor(string color)
        {
            this.color = color;
        }

        public string GetSnuggles()
        {
            return snuggles;
        }

        public void SetSnuggles(string snuggles)
        {
            this.snuggles = snuggles;
        }

        public override string ToString()
        {
            return "Koala " + name + ", Age: " + age + ", Color: " + color + ", Favorite Food: " + favoriteFood + ", Snuggles: " + snuggles;
        }
    }
}

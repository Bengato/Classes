using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        enum Months { January, February, March, April, May, JuneJuly, August, September, October, November, december }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            MyList brand = new MyList();
            Console.WriteLine(brand.toString() + " month is:" + Months.January + " or in numbers:" + ((int)Months.January) + 1);
            Movie[] movies = { new Movie{ name = "scar face", id = 1 }, new Movie { name = "the Hulk", id = 2 },new Movie { name = "Spiderman", id = 3 }, new Movie { name = "the planet of the apes", id = 4 } };
            IEnumerable<string> theMovies =
                from movie in movies
                where movie.name.Contains("the")
                orderby movie.id descending
                select movie.name;
            foreach (string movie in theMovies)
            {
                Console.WriteLine(movie);
            }
        }
    }
    class MyList
    {
        private int listLen = 0;
        private string listName = "";
        public MyList()
        {
            this.listLen = 5;
            this.listName = "My new list!";
        }
        public string toString()
        {
            return "List name:" + this.listName + " list length:" + this.listLen;
        }
    }
    class Movie
    {
        public string name = "";
        public int id;
        public Movie() : this("noname", 1)
        {

        }
        public Movie(string name, int id)
        {
            this.name = name;
            this.id = id;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleLab10_MovieList_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Movie List Application!" + Environment.NewLine);
            Console.WriteLine("The List contains movies from the following categories:");
            Console.WriteLine("(animated, drama, horror, and scifi)" + Environment.NewLine);
            Console.Write("Which category are you interested in? ");

            string genre = Console.ReadLine();

            List<Movie> MovieList = new List<Movie>() { };
            MovieList = MovieIO.MovieCatalog;

            foreach (Movie m in MovieList) {
                Console.WriteLine(m.name);
            }
        }
    }
}

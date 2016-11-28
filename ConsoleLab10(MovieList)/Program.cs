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

            bool answer = true;
            while (answer)
            {
                Console.WriteLine("(animated, drama, horror, and scifi)" + Environment.NewLine);
                Console.Write("Which category are you interested in? ");

                string genre = Console.ReadLine();

                List<Movie> MovieList = new List<Movie>() { };
                MovieList = MovieIO.MovieCatalog;

                //MovieList.OrderBy(movie => movie.genre).ToList();

                int i = 0;

                foreach (Movie movie in MovieList)
                {
                    if (movie.genre == genre)
                    {
                        i++;
                        Console.WriteLine(movie.name);
                        if (i >= 10) break;
                    }
                }
                Console.WriteLine("Would you like to continue? (yes or no)");
                string yORn = Console.ReadLine();
                if(yORn.ToLower() == "yes" || yORn.ToLower() == "y")
                {
                    answer = true;
                    Console.Clear();
                }
                else
                {
                    answer = false;
                }
            }
        }
    }
}

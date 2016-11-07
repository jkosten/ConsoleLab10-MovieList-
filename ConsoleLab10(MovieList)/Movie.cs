using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLab10_MovieList_
{
  public class Movie
    {
        public Movie(string name, string genre)
        {
            title = name;
            category = genre;
        }
        private string title;

        public string name
        {
            get { return title; }
        }
        private string category;

        public string genre
        {
            get { return category; }
        }
    }
}

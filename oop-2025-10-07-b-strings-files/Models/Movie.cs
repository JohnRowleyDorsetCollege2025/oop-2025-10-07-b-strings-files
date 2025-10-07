using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_2025_10_07_b_strings_files.Models
{
    public class Movie
    {
        public string Title { get; set; }
        public string Director { get; set; }
        public int ReleaseYear { get; set; }
        public string Genre { get; set; }
        public double Rating { get; set; }

        public Movie(string title, string director, int releaseYear, string genre, double rating)
        {
            Title = title;
            Director = director;
            ReleaseYear = releaseYear;
            Genre = genre;
            Rating = rating;
        }

        public override string ToString()
        {
            return $"{Title} ({ReleaseYear}) - {Genre} - Directed by {Director} - Rating: {Rating}/10";
        }
    }
}

using CinemaApp.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaApp.Models
{
    public class Movie
    {
        public Movie(string title, Genre genre, int rating)
        {
            if (rating < 1 || rating > 5)
            {
                throw new Exception("Rating must be between 1 and 5");
            }
            if (string.IsNullOrEmpty(title))
            {
                throw new Exception("You must enter a title");
            }

            //if exception is not thrown
            Title = title;
            Genre = genre;
            Rating = rating;
            TicketPrice = 5 * rating;
        }

        public string Title { get; set; }
        public Genre Genre { get; set; }
        public int Rating { get; set; }
        public double TicketPrice { get; set; }

        public static List<Genre> GetAllGenres()
        {
            return new List<Genre>() { Genre.Comedy, Genre.Horror, Genre.Action, Genre.Drama, Genre.SciFi };
        }
    }
}

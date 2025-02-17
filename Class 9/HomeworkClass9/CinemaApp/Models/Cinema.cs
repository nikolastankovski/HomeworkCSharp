﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CinemaApp.Models
{
    public class Cinema
    {
        public Cinema(string name, List<int> halls, List<Movie> movies)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new Exception("Cinema name must be entered");
            }
            if (halls == null || halls.Count == 0)
            {
                throw new Exception("There must be halls");
            }
            if (movies == null || movies.Count == 0)
            {
                throw new Exception("There must be movies");
            }

            Name = name;
            Halls = halls;
            Movies = movies;
        }

        public string Name { get; set; }
        public List<int> Halls { get; set; }
        public List<Movie> Movies { get; set; }

        public static void WatchMovie(Movie movie)
        {
            //movie is potentially null
            Console.WriteLine($"Watching {movie.Title}");
        }
    }
}

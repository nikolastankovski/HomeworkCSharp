using System;
using CinemaApp.Models;
using CinemaApp.Database;
using System.Threading;
using System.Collections.Generic;
using CinemaApp.Enums;
using System.Linq;

namespace CinemaApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Cinema cinema1 = Db.GetCinema1();
            Cinema cinema2 = Db.GetCinema2();

            Console.WriteLine("Welcome to the Cinema Application!");
            Console.WriteLine("----------------------------------");
            while (true)
            {
                Console.WriteLine("Cinemas: ");
                Console.WriteLine($"1. {cinema1.Name}");
                Console.WriteLine($"2. {cinema2.Name}");
                Console.Write("Please choose a cinema: ");

                int cinema;

                try
                {
                    cinema = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input. Please enter a number!");
                    Thread.Sleep(1000);
                    Console.Clear();
                    continue;
                }

                if (cinema == 1)
                {
                    GoToCinema(cinema1);
                    break;
                }
                else if (cinema == 2)
                {
                    GoToCinema(cinema2);
                    break;
                }
                else
                {
                    Console.WriteLine("That cinema doesn't exists. Try Again!");
                    Thread.Sleep(1000);
                    Console.Clear();
                }
            }

        }

        static void GoToCinema(Cinema cinema)
        {
            Console.Clear();
            Console.WriteLine($"Welcome to {cinema.Name}!");
            Console.WriteLine("--------------------------");

            while (true)
            {
                Console.WriteLine("1. See all the movies");
                Console.WriteLine("2. Filter by Genre");
                Console.Write("Your choice: ");
                int option;

                try
                {
                    option = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input. Please enter a number!");
                    Thread.Sleep(1000);
                    Console.Clear();
                    continue;
                }

                if (option == 1)
                {
                    WatchMovie(cinema.Movies);
                    break;
                }
                else if(option == 2)
                {
                    Genre genre = GetGenre(Movie.GetAllGenres());
                    List<Movie> filteredMovies = FilterMoviesByGenre(cinema.Movies, genre);
                    WatchMovie(filteredMovies);
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid option. Try Again!");
                    Thread.Sleep(1000);
                    Console.Clear();
                }
            }
        }

        static void PrintMovies(List<Movie> movies)
        {   
            for(int i = 1; i <= movies.Count; i++)
            {
                Console.WriteLine($"{i}. Title: {movies[i-1].Title}, Genre: {movies[i-1].Genre}, Rating: {movies[i-1].Rating}");
            }
        }

        static List<Movie> FilterMoviesByGenre(List<Movie> movies, Genre genre)
        {
            var filteredMovies = movies.Where(x => x.Genre == genre).ToList();

            return filteredMovies;
        }

        static Genre GetGenre(List<Genre> genres)
        {
            Genre genre;
            while (true)
            {
                Console.Clear();
                foreach (Genre currentGenre in genres)
                {
                    Console.WriteLine($"{(int)currentGenre}. {currentGenre}");
                }

                Console.Write("Select genre: ");

                string genreName = Console.ReadLine().ToLower();
                genre = genres.FirstOrDefault(x => x.ToString().ToLower() == genreName);

                if (genre == 0)
                {
                    try
                    {
                        int genreNum = int.Parse(genreName);
                        genre = genres.FirstOrDefault(x => (int)x == genreNum);

                        if (genre == 0)
                        {
                            throw new Exception(message: "Genre doesn't exist. Try Again!");
                        }
                        else
                        {
                            return genre;
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        Thread.Sleep(1000);
                        Console.Clear();
                    }

                }
                else
                {
                    return genre;
                }
            }
        }

        static void WatchMovie(List<Movie> movies)
        {
            while (true)
            {
                Console.Clear();
                PrintMovies(movies);
                Console.Write("Choose the movie you want to watch (enter it's number): ");

                try
                {
                    int movie = int.Parse(Console.ReadLine());

                    if(movie > 0 && movie <= movies.Count)
                    {
                        Cinema.WatchMovie(movies[movie - 1]);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("The movie doesn't exists. Try Again!");
                        Thread.Sleep(1000);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Please enter a number!");
                    Thread.Sleep(1000);
                }
            }
        }
    }
}

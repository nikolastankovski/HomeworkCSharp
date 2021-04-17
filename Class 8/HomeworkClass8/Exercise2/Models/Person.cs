using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise2.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public List<Song> FavouriteSongs { get; set; }

        public Person()
        {
            FavouriteSongs = new List<Song>();
        }

        public void GetFavSongs()
        {
            if (FavouriteSongs.Count == 0)
            {
                Console.WriteLine($"{FirstName} doesn't have favourite songs :(");
            }
            else
            {
                Console.WriteLine($"{FirstName}favourite songs are:");
                foreach (Song song in FavouriteSongs)
                {
                    Console.WriteLine(song.Title);
                }
            }
        }
    }
}

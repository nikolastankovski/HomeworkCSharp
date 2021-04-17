using System;
using Exercise2.Models;
using Exercise2.Enums;
using System.Collections.Generic;
using System.Linq;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Person> people = Database.GetPeople();
            List<Song> songs = Database.GetSongs();

            Person jerry = people.FirstOrDefault(x => x.FirstName.ToLower() == "jerry");
            Person maria = people.FirstOrDefault(x => x.FirstName.ToLower() == "maria");
            Person jane = people.FirstOrDefault(x => x.FirstName.ToLower() == "jane");
            Person stefan = people.FirstOrDefault(x => x.FirstName.ToLower() == "stefan");

            jerry.FavouriteSongs = songs.Where(x => x.Title.StartsWith("B")).ToList();
            maria.FavouriteSongs = songs.Where(x => x.Length > 6).ToList();
            jane.FavouriteSongs = songs.Where(x => x.Genre == Genre.Rock).ToList();
            stefan.FavouriteSongs = songs.Where(x => x.Genre == Genre.Hip_Hop && x.Length < 3).ToList();

            List<Person> fourOrMoreSongs = people.Where(x => x.FavouriteSongs.Count >= 4).ToList();

            foreach(Person person in fourOrMoreSongs)
            {
                Console.WriteLine($"Name: {person.FirstName}");
                foreach(Song song in person.FavouriteSongs)
                {
                    Console.WriteLine($"Song: {song.Title}");
                }
                Console.WriteLine("--------------------------");
            }
        }
    }
}

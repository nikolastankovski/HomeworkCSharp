using System;
using System.Collections.Generic;
using System.Text;
using Exercise2.Models;
using Exercise2.Enums;

namespace Exercise2
{
    public class Database
    {
        public static List<Person> GetPeople()
        {
            return new List<Person>()
            {
                new Person()
                {
                    FirstName = "Jerry",
                    LastName = "Jerry",
                    Age = 22
                },
                new Person()
                {
                    FirstName = "Maria",
                    LastName = "Maria",
                    Age = 25
                },
                new Person()
                {
                    FirstName = "Jane",
                    LastName = "Jane",
                    Age = 30
                },
                new Person()
                {
                    FirstName = "Stefan",
                    LastName = "Stefan",
                    Age = 19
                }
            };   
        }

        public static List<Song> GetSongs()
        {
            return new List<Song>()
            {
                new Song()
                {
                    Title = "In Trance",
                    Length = 4.38,
                    Genre = Genre.Rock
                },
                new Song()
                {
                    Title = "Stargazer",
                    Length = 8.27,
                    Genre = Genre.Rock
                },
                new Song()
                {
                    Title = "Tarot woman",
                    Length = 5.58,
                    Genre = Genre.Rock
                },
                new Song()
                {
                    Title = "Heaven and hell",
                    Length = 6.58,
                    Genre = Genre.Rock
                },
                new Song()
                {
                    Title = "Fade to Black",
                    Length = 6.58,
                    Genre = Genre.Rock
                },
                new Song()
                {
                    Title = "Telepatia",
                    Length = 2.41,
                    Genre = Genre.Hip_Hop
                },
                new Song()
                {
                    Title = "Jacques",
                    Length = 3.23,
                    Genre = Genre.Hip_Hop
                },
                new Song()
                {
                    Title = "Tequila",
                    Length = 3.31,
                    Genre = Genre.Hip_Hop
                },
                new Song()
                {
                    Title = "Booyah",
                    Length = 5.12,
                    Genre = Genre.Techno
                },
            };
        }
    }
}

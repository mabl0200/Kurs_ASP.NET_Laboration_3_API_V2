using Labb3.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Labb3.API.Models
{
    public class Labb3DbContext : DbContext
    {
        public Labb3DbContext(DbContextOptions<Labb3DbContext> options) : base(options)
        {

        }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Hobby> Hobbies { get; set; }
        public DbSet<Link> Links { get; set; }
        public DbSet<PersonHobby> PersonHobbies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Seed Data

            modelBuilder.Entity<Person>().HasData(new Person { PersonId = 1, FirstName = "Tobias", LastName = "Karlsson", PhoneNumber = "0701234569" });
            modelBuilder.Entity<Person>().HasData(new Person { PersonId = 2, FirstName = "Lisa", LastName = "Nilsson", PhoneNumber = "0707412589" });
            modelBuilder.Entity<Person>().HasData(new Person { PersonId = 3, FirstName = "Therese", LastName = "Skog", PhoneNumber = "0708523698" });
            modelBuilder.Entity<Person>().HasData(new Person { PersonId = 4, FirstName = "Jesper", LastName = "Svensk", PhoneNumber = "0701472536" });
            modelBuilder.Entity<Person>().HasData(new Person { PersonId = 5, FirstName = "Ture", LastName = "Sventon", PhoneNumber = "0703698521" });

            modelBuilder.Entity<Hobby>().HasData(new Hobby { HobbyId = 1, Title = "Chess", Description = "Chess is a board game played between two players" });
            modelBuilder.Entity<Hobby>().HasData(new Hobby { HobbyId = 2, Title = "Music", Description = "Playing and listening to music" });
            modelBuilder.Entity<Hobby>().HasData(new Hobby { HobbyId = 3, Title = "Football", Description = "Team sport where you score a goal by kicking a ball" });
            modelBuilder.Entity<Hobby>().HasData(new Hobby { HobbyId = 4, Title = "Cross-country skiing", Description = "Cross-country skiing is a form of skiing where skiers rely on their own locomotion to move across snow-covered terrain, rather than using ski lifts or other forms of assistance" });

            modelBuilder.Entity<Link>().HasData(new Link { LinkId = 1, HobbyId = 1, PersonId = 4, URL = "en.wikipedia.org/wiki/Chess" });
            modelBuilder.Entity<Link>().HasData(new Link { LinkId = 2, HobbyId = 2, PersonId = 3, URL = "open.spotify.com/" });
            modelBuilder.Entity<Link>().HasData(new Link { LinkId = 3, HobbyId = 3, PersonId = 1, URL = "laliga.com/en-GB" });
            modelBuilder.Entity<Link>().HasData(new Link { LinkId = 4, HobbyId = 4, PersonId = 5, URL = "fis-ski.com/en/cross-country" });
            modelBuilder.Entity<Link>().HasData(new Link { LinkId = 5, HobbyId = 4, PersonId = 2, URL = "lofsdalen.com/en/cross-country-skiing" });

            modelBuilder.Entity<PersonHobby>().HasData(new PersonHobby { PersonHobbyId = 1, HobbyId = 1, PersonId = 4 });
            modelBuilder.Entity<PersonHobby>().HasData(new PersonHobby { PersonHobbyId = 2, HobbyId = 2, PersonId = 3 });
            modelBuilder.Entity<PersonHobby>().HasData(new PersonHobby { PersonHobbyId = 3, HobbyId = 3, PersonId = 1 });
            modelBuilder.Entity<PersonHobby>().HasData(new PersonHobby { PersonHobbyId = 4, HobbyId = 4, PersonId = 5 });
            modelBuilder.Entity<PersonHobby>().HasData(new PersonHobby { PersonHobbyId = 5, HobbyId = 4, PersonId = 2 });
            modelBuilder.Entity<PersonHobby>().HasData(new PersonHobby { PersonHobbyId = 6, HobbyId = 3, PersonId = 2 });
            modelBuilder.Entity<PersonHobby>().HasData(new PersonHobby { PersonHobbyId = 7, HobbyId = 2, PersonId = 1 });
        }
    }
}

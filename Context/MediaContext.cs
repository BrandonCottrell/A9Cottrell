using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A9Cottrell.Models;

namespace A9Cottrell.Context
{
    public class MediaContext
    {
        public List<Movie> Movies { get; set; }
        public List<Show> Shows { get; set; }
        public List<Video> Videos { get; set; }

        public MediaContext()
        {
            Movies = new List<Movie>();
            Movies.Add(new Movie() { Id = 1, Title = "Toy Story", Genre = "Comedy" });
            Movies.Add(new Movie() { Id = 2, Title = "Toy Story 2", Genre = "Horror" });
            Movies.Add(new Movie() { Id = 3, Title = "Toy Story 3", Genre = "Action" });
            Movies.Add(new Movie() { Id = 4, Title = "Toy Story 4", Genre = "Adventure" });

            Shows = new List<Show>();
            Shows.Add(new Show() { Id = 1, Title = "Supernatural", Season = 2, Episode = 12, Writers = "Kripke" });
            Shows.Add(new Show() { Id = 2, Title = "Supernatural 2", Season = 3, Episode = 13, Writers = "Jones" });
            Shows.Add(new Show() { Id = 3, Title = "Supernatural 3", Season = 4, Episode = 14, Writers = "Smith" });
            Shows.Add(new Show() { Id = 4, Title = "Supernatural 4", Season = 5, Episode = 15, Writers = "Johnson" });

            Videos = new List<Video>();
            Videos.Add(new Video() { Id = 1, Title = "Lethal Weapon", Format = "VHS", Length = 100, Region = 0 });
            Videos.Add(new Video() { Id = 2, Title = "Lethal Weapon  2", Format = "BluRay", Length = 80, Region = 2 });
            Videos.Add(new Video() { Id = 3, Title = "Lethal Weapon  3", Format = "DVD", Length = 90, Region = 6 });
            Videos.Add(new Video() { Id = 4, Title = "Lethal Weapon  4", Format = "VHS", Length = 120, Region = 1 });
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A9Cottrell.Models
{
    public class Movie : Media
    {
        public string Genre { get; set; }

        public override void Display()
        {
            Console.WriteLine("");
            Console.WriteLine($"Movie ID: {Id}");
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Genre: {Genre}");
        }
    }
}

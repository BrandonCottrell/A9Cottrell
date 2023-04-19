using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A9Cottrell.Models
{
    public class Video : Media
    {
        public string Format { get; set; }
        public int Length { get; set; }
        public int Region { get; set; }

        public override void Display()
        {
            Console.WriteLine("");
            Console.WriteLine($"Video ID: {Id}");
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Format: {Format}");
            Console.WriteLine($"Length: {Length}");
            Console.WriteLine($"Region: {Region}");
        }
    }
}

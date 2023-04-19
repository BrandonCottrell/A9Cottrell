using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A9Cottrell.Models
{
    public abstract class Media
    {
        public int Id { get; set; }
        public string? Title { get; set; }

        public virtual void Display()
        {
            Console.WriteLine($"{Title}");
        }

    }
}

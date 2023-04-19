using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using A9Cottrell.Context;
using A9Cottrell.Models;

namespace A9Cottrell.Services;
public class MainService : IMainService
{
    private readonly IFileService _fileService;
    public MainService(IFileService fileService)
    {
        _fileService = fileService;
    }

    public void Invoke()
    {

        MediaContext context = new MediaContext();

        List<Media> media = new List<Media>();
        var movies = context.Movies;
        var shows = context.Shows;
        var videos = context.Videos;

        media.AddRange(context.Movies);
        media.AddRange(context.Videos);
        media.AddRange(context.Shows);

        Console.WriteLine("Please make a selection. ");
        Console.WriteLine("1. Search for media. ");
        Console.WriteLine("2. See all media. ");
        var initResponse = Console.ReadLine();

        if (initResponse == "1")
        {
            var i = 0;
            Console.WriteLine("What media are you looking for?");
            var searchString = Console.ReadLine();

            var results = media.Where(m => m.Title.Contains(searchString, StringComparison.CurrentCultureIgnoreCase));

            foreach (var m in results)
            {
                Console.WriteLine($"Your media: {m.Title}");
                i++;
            }
            Console.WriteLine("Number of results: " + i);

        } else if (initResponse == "2")
        {
            Console.WriteLine("Which media would you like to display?");
            Console.WriteLine("1. Movies");
            Console.WriteLine("2. Shows");
            Console.WriteLine("3. Videos");
            Console.WriteLine("4. All");
            var userInput = Console.ReadLine();

            if (userInput == "1")
            {
                foreach (var m in movies) // shows, movies, videos
                {
                    m.Display();
                }
            }
            else if (userInput == "2")
            {
                foreach (var m in shows) // shows, movies, videos
                {
                    m.Display();
                }
            }
            else if (userInput == "3")
            {
                foreach (var m in videos) // shows, movies, videos
                {
                    m.Display();
                }
            }
            else if (userInput == "4")
            {
                foreach (var m in media) // shows, movies, videos
                {
                    m.Display();
                }
            }
            else
            {
                Console.WriteLine("Not a valid input");
            }
        }



    }
}

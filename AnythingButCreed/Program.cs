using System;
using System.Collections.Generic;
using System.Linq;

namespace AnythingButCreed
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Song> goodSongs = new List<Song>();
            List<Song> allSongs = new List<Song>();

            allSongs.Add(new Song("Creed", "Can You Take Me Higher?"));
            allSongs.Add(new Song("Creed", "With Arms Wide Open"));
            allSongs.Add(new Song("Dolly Parton", "9 to 5"));
            allSongs.Add(new Song("Dolly Parton", "Why'd You Come in Here Lookin' Like That"));
            allSongs.Add(new Song("Dolly Parton", "Jolene"));
            allSongs.Add(new Song("Kenny Rogers", "Islands in the Stream"));
            allSongs.Add(new Song("Hey Cowboy!", "Cherry Jerry Citrus"));
            allSongs.Add(new Song("Doja Cat", "Get Into It (Yuh)"));
            allSongs.Add(new Song("Cocteau Twins", "Heaven or Las Vegas"));
            allSongs.Add(new Song("Bo Burnham", "Welcome to the Internet"));
            allSongs.Add(new Song("Al Green", "Let's Stay Together"));
            allSongs.Add(new Song("Al Green", "Have You Been Making out Ok"));

            goodSongs = allSongs.Where(x => x.Artist != "Creed").ToList();

            foreach (var song in goodSongs)
            {
                Console.WriteLine($"{song.Artist} sang {song.Name}");
            }
        }
    }
}

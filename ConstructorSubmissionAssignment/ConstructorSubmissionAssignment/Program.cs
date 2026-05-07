using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorSubmissionAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare constant variables, first a string for my favorite film and second for the year it was released
            const string FavoriteFilm = "Alien";
            const int FilmYear = 1979;

            // Print favorite film and release year to console
            Console.WriteLine("My favorite film of all time is " + FavoriteFilm + ", released in " + FilmYear);

            // Declare variable with keyword var  and assign value
            var myFavoriteBand = "The Smashing Pumpkins";
            var myFavoriteSong = "Mayonaise";

            //  Print declared variables to the console
            Console.WriteLine("\nMy favorite band of all time is: " + myFavoriteBand + ", and my favorite song is " + myFavoriteSong);

            // Declare the name of favoriteGame and assign values for properties "Name" and "Release"
            FavoriteGame favoriteGame = new FavoriteGame("Silent Hill 4: The Room", 2004);
            // Print my favorite game and its release year to the console
            Console.WriteLine("\nMy favorite video game of all time is " + favoriteGame.Name + " and it was released in " + favoriteGame.Release);

            // Wait for user to press a key
            Console.WriteLine("\nPress any key to exit the program...");
            Console.ReadKey();
        }
    }
}

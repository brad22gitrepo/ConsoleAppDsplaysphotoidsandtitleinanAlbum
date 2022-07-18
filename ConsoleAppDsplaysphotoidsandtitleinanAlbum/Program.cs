using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
//using System.Runtime.CompilerServices;


//UnitTestProject1
//[assembly: InternalsVisibleTo("UnitTestProject1")]
namespace ConsoleAppDsplaysphotoidsandtitleinanAlbum
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            } 
        }

        /// <summary>
        /// Display main menu, and let user type in input to display albums
        /// </summary>
        /// <returns>bool</returns>
        private static bool MainMenu()
        { 
            Console.WriteLine("Please type in # (1-10), to dislay photos.");
            Console.WriteLine("\nYou can also write 'bye' at any time to leave");
            Console.Write("\n>photo-album ");

            switch (Console.ReadLine())
            {
                case "1":
                    DisplayAlbum(1);
                    return true;
                case "2":
                    DisplayAlbum(2);
                    return true;
                case "3":
                    DisplayAlbum(3);
                    return true;
                case "4":
                    DisplayAlbum(4);
                    return true;
                case "5":
                    DisplayAlbum(5);
                    return true;
                case "6":
                    DisplayAlbum(6);
                    return true;
                case "7":
                    DisplayAlbum(7);
                    return true;
                case "8":
                    DisplayAlbum(8);
                    return true;
                case "9":
                    DisplayAlbum(9);
                    return true;
                case "10":
                    DisplayAlbum(10);
                    return true;
                case "bye":
                    Console.WriteLine("Goodbye! Push any key to get out of here!");
                    Console.ReadKey();
                    return false;

                default:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("That is not a valid number, please enter 1-10"); 
                    Console.WriteLine(" ");
                    Console.ForegroundColor = ConsoleColor.White;
                    return true;
            }
        }

        /// <summary>
        /// Display album data based on user input
        /// </summary>
        /// <param name="albumNumber"></param>
        private static void DisplayAlbum(int albumNumber)
        {
            string header = "Welcome to LT code project Option 1 - Photo Album";
            Console.Clear();
            Console.WriteLine(header);

            HttpClient client = new HttpClient();
            string url = "https://jsonplaceholder.typicode.com/photos?albumId=" + albumNumber;
            string response = client.GetStringAsync(url).Result;
            IEnumerable<PhotoAlbum> photos = JsonConvert.DeserializeObject<IEnumerable<PhotoAlbum>>(response);
            foreach (PhotoAlbum photo in photos)
            {
                Console.WriteLine("[" + photo.id + "] " + photo.title);
            }

            Console.WriteLine("\r\nPress any key to return back to main menu");
            Console.ReadKey();
            Console.Clear();
        }
    }

    /// <summary>
    /// Public class to store album json data from api
    /// </summary>
    public class PhotoAlbum
    {
        public string albumId { get; set; }
        public string id { get; set; }
        public string title { get; set; }
        public string url { get; set; }
        public string thumbnailUrl { get; set; }
    }
}

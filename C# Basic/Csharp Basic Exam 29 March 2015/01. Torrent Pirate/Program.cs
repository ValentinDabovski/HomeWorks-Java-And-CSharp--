using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Torrent_Pirate
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal megabytes = int.Parse(Console.ReadLine());
            decimal cinemaPrice = int.Parse(Console.ReadLine());
            decimal wifeHourlySpend = int.Parse(Console.ReadLine());

            const int movieSize = 1500;
            const int WiFiSpeed = 2;


            decimal downloadTime = megabytes / WiFiSpeed / 60m / 60m;
            decimal priceForDownload = downloadTime * wifeHourlySpend;
            decimal numberOfMovieDownloaded = megabytes / movieSize;
            decimal PriceInCinema = (numberOfMovieDownloaded * cinemaPrice);


            if ( PriceInCinema >= priceForDownload)
            {
                Console.WriteLine("mall -> {0:F2}lv",priceForDownload);
            }

            else if ( priceForDownload >= PriceInCinema)
            {
                Console.WriteLine("cinema -> {0:F2}lv",PriceInCinema);
            }
        }
    }
}

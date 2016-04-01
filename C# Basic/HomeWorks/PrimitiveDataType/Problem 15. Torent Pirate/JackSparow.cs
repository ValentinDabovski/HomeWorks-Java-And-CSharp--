using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_15.Torent_Pirate
{
    class JackSparow
    {
        static void Main(string[] args)
        {
            decimal downoladData = decimal.Parse(Console.ReadLine());
            decimal priceOfCinema = decimal.Parse(Console.ReadLine());
            decimal wifePerHourSpent = decimal.Parse(Console.ReadLine());
            const decimal movieSizeMB = 1500;
            const decimal wiFiMBsec = 2.0m;
            const int seconds = 60;
            const int minutes = 60;

            decimal downloadTime = (downoladData) / (wiFiMBsec) / (seconds) / (minutes);
            decimal numberOfMoviesDownloaded = (downoladData) / (movieSizeMB);
            decimal CinemaPrice = (numberOfMoviesDownloaded) * (priceOfCinema);
            decimal priceForDownloading = (downloadTime * wifePerHourSpent);

            if (CinemaPrice >= priceForDownloading)
            {
                Console.WriteLine("mall -> {0:0.00}lv", priceForDownloading);
            }

            else if (CinemaPrice <= priceForDownloading)
            {
                Console.WriteLine("cinema -> {0:0.00}lv", CinemaPrice);
            } 
        }
    }
}

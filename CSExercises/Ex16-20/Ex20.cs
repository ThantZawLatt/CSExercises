using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex20
    {
        public static void Main(string[] args)
        {
            double price;
            int tv, dvd, mp3, priceTV, priceDVD, priceMP3;
            int tv_1 = 900, dvd_1 = 500, mp3_1 = 700;
            System.Console.Write("Enter quantity for TV: ");
            tv = int.Parse(Console.ReadLine());
            System.Console.Write("Enter quantity for DVD: ");
            dvd = int.Parse(Console.ReadLine());
            System.Console.Write("Enter quantity for MP3: ");
            mp3 = int.Parse(Console.ReadLine());

            priceTV = (tv_1 * tv);
            priceDVD = (dvd * dvd_1);
            priceMP3 = (mp3 * mp3_1);
            price = priceTV + priceDVD;
            if (price > 10000)
            {
                price = price - (price * 0.15);
                price = price + priceMP3;
            }
            else if (price > 5000)
            {
                price = price - (price * 0.1);
                price = price + priceMP3;
            }
            else
            {
                price = price + priceMP3;
            }
            System.Console.WriteLine("Total price for this order is ${0}", price);
        }
    }
}
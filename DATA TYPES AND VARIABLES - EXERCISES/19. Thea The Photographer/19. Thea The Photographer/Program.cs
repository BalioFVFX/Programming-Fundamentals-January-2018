using System;

namespace _19._Thea_The_Photographer
{
    class Program
    {
        static void Main(string[] args)
        {

            int numberOfTakenPictures = int.Parse(Console.ReadLine());
            int filterTime = int.Parse(Console.ReadLine());
            double filterFactor = Math.Ceiling(double.Parse(Console.ReadLine()));
            int uploadTime = int.Parse(Console.ReadLine());



            double filteredPictures = Math.Ceiling(numberOfTakenPictures * filterFactor / 100);
            double totalPicturesUploadTime = (double)numberOfTakenPictures * filterTime;
            double filteredPicturesUploadTime = filteredPictures * uploadTime;

            double totalTime = filteredPicturesUploadTime + totalPicturesUploadTime;
            TimeSpan time = TimeSpan.FromSeconds(totalTime);

            int days = time.Days;
            int hours = time.Hours;
            int minutes = time.Minutes;
            int seconds = time.Seconds;

            Console.WriteLine($"{days}:{hours:d2}:{minutes:d2}:{seconds:d2}");
        }
    }
}
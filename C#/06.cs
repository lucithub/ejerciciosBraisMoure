using System;
using System.Drawing;
using System.Net;
using static System.Net.Mime.MediaTypeNames;
using SixLabors.ImageSharp;
using Image = SixLabors.ImageSharp.Image;

public class ImageAspectCalculator
{
    public static string GetAspectRatioFromUrl(string imageUrl)
    {
        try
        {
            using (WebClient client = new WebClient())
            {
                byte[] imageData = client.DownloadData(imageUrl);
                using (System.IO.MemoryStream ms = new System.IO.MemoryStream(imageData))
                {
                    using (Image image = Image.Load(ms))
                    {
                        int width = image.Width;
                        int height = image.Height;
                        int gcd = GreatestCommonDivisor(width, height);
                        return $"{width / gcd}:{height / gcd}";
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error getting image aspect ratio: {ex.Message}");
            return null;
        }
    }
    private static int GreatestCommonDivisor(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
}

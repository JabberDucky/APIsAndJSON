using System.Text.Json.Nodes;

namespace APIsAndJSON
{
    public class Program
    {
        static void Main(string[] args)
        {
             
            for(int i = 0; i < 5; i++) 
            {
                RonVSKanyeAPI.Kanye();
                RonVSKanyeAPI.Ron();
            }

            Console.WriteLine();
            Console.WriteLine("What's the weather like?");
            OpenWeatherMapAPI.CurrentWeather();
            Console.ReadLine();
        }

    }
}

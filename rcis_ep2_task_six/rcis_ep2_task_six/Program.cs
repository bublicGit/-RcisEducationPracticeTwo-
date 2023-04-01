using rcis_ep2_task_six;
using Newtonsoft.Json.Linq;

public class Program
{
    public static void Main()
    {
        string location = "Tomsk";
        string key = "f269f4f0033eab8b48ae0da7839b01dd";

        var request = new GetRequest($"https://api.openweathermap.org/data/2.5/weather?&q={location}&lang=ru&appid={key}");
        request.Run();

        string response = request.Response;
        var json = JObject.Parse(response);

        Console.Write($"В городе {location} ");
        Console.WriteLine($"температура {(int)json["main"]["temp"] - 273}°C, " +
                          $"ощущается как {(int)json["main"]["feels_like"] - 273}°C \n" +
                          $"На улице {json["weather"][0]["description"]}. ");
    }
}
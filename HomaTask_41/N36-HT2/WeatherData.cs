namespace HomaTask_41.N36_HT2;

public struct WeatherData
{
    public DateTime Time { get; set; }
    public string Place {get; set; }
    public double Temperature {get; set; }
    public double Humidity {get; set; }
    public double WindSpeed {get; set; }

    public WeatherData(DateTime time, string place, double temperature, double humidity, double windSpeed)
    {
        Time = time;
        Place = place;
        Temperature = temperature;
        Humidity = humidity;
        WindSpeed = windSpeed;
    }
}
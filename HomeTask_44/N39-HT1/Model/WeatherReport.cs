namespace HomeTask_44.N39_HT1.Model;

public class WeatherReport
{
    public string Location { get; set; }
    public double Temperature { get; set; }
    public double Pressure { get; set;}

    public WeatherReport(string location, double temperature, double pressure)
    {
        Location = location;
        Temperature = temperature;
        Pressure = pressure;
    }

    public override string ToString()
    {
        return $"{Location} {Temperature} {Pressure}";
    }
}
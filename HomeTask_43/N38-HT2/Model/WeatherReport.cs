namespace HomeTask_43.N38_HT2.Model;

public class WeatherReport
{
    public Guid Id { get; set; }
    public decimal Temperature { get; set; }
    public decimal Pressure { get; set; }
    public string Location { get; set; }
    public DateOnly Date { get; set; }

    public WeatherReport()
    {
        
    }

    public WeatherReport(decimal temperature, decimal pressure, string location, DateOnly date)
    {
        Id = Guid.NewGuid();
        Temperature = temperature;
        Pressure = pressure;
        Location = location;
        Date = date;
    }

    public override string ToString()
    {
        return $"{Id} {Temperature} {Pressure} {Location} {Date}";
    }
    
}
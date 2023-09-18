// See https://aka.ms/new-console-template for more information

using HomeTask_44.N39_HT1.Model;

Console.WriteLine("N39 HT_1");

var template = new List<object>{
    new User("John", "Doe"),
    new User("Fiona", "Doe"),
    new User("Lip", "Doe"),
    new WeatherReport("Sydney", 30, 20),
    new WeatherReport("New-York", 23, 25),
    new WeatherReport("Moscow", 32, 10),
    new WeatherReport("Tashkent", 10, 30),
};

foreach (var item in template)
{
    if (item is User { FirstName: "John" })
        Console.WriteLine(item);
    
    if (item is WeatherReport { Temperature: >= 30 })
        Console.WriteLine(item);
}
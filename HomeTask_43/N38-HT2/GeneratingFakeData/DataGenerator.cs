using Bogus;
using HomeTask_43.N38_HT2.Model;

namespace HomeTask_43.N38_HT2.GeneratingFakeData;

public class DataGenerator
{
    private List<Order> _orders;
    private List<UserAddress> _users;
    private List<BlogPost> _blogPosts;
    private List<Employee> _employees;
    private List<WeatherReport> _weatherReports;

    public DataGenerator()
    {
        _orders = new List<Order>();
        _users = new List<UserAddress>();
        _blogPosts = new List<BlogPost>();
        _employees = new List<Employee>();
        _weatherReports = new List<WeatherReport>();
    }

    public List<Order> GetOrders(int countOfFakeData)
    {
         var fakeOrders = new Faker<Order>()
                         .RuleFor(order => order.Name, order => order.Name.);
         return _orders = fakeOrders.Generate(countOfFakeData);
    }
}
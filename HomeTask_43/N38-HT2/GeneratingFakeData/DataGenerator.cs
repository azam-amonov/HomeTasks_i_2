using Bogus;
using HomeTask_43.N38_HT2.Model;

namespace HomeTask_43.N38_HT2.GeneratingFakeData;

public class DataGenerator
{
    private List<Order> _orders;
    private List<BlogPost> _blogPosts;
    private List<Employee> _employees;
    private List<UserAddress> _usersAddress;
    private List<WeatherReport> _weatherReports;

    public DataGenerator()
    {
        _orders = new List<Order>();
        _blogPosts = new List<BlogPost>();
        _employees = new List<Employee>();
        _usersAddress = new List<UserAddress>();
        _weatherReports = new List<WeatherReport>();
    }

    public List<Order> GetOrders(int countOfFakeData)
    {
         var fakeOrders = new Faker<Order>()
                         .RuleFor(order => order.OwnerName, order => order.Name.FullName())
                         .RuleFor(order => order.Amount, order => order.Random.Int(100,1000))
                         .RuleFor(order => order.IsActive, order => order.Random.Bool());
         
         return _orders = fakeOrders.Generate(countOfFakeData);
    }

    public List<UserAddress> GetUsersAddresses(int countOfFakeData)
    {
        var fakeUsersAddress = new Faker<UserAddress>()
                        .RuleFor(userAddress => userAddress.FirstName, userAddress => userAddress.Name.FirstName())
                        .RuleFor(userAddress => userAddress.LastName, userAddress => userAddress.Name.LastName())
                        .RuleFor(userAddress => userAddress.EmailAddress, userAddress => userAddress.Person.Email);

        return _usersAddress = fakeUsersAddress.Generate(countOfFakeData);
    }

    public List<BlogPost> GetBlogPosts(int countOfFakeData)
    {
        var fakeBlogPosts = new Faker<BlogPost>()
                        .RuleFor(blogPost => blogPost.Title, blogPost => blogPost.Music.Genre())
                        .RuleFor(blogPost => blogPost.Description, blogPost => blogPost.Lorem.Text())
                        .RuleFor(blogPost => blogPost.Comment, blogPost => blogPost.Random.Int(100, 1000))
                        .RuleFor(blogPost => blogPost.Like, blogPost => blogPost.Random.Int(1000, 10000));
        
        return _blogPosts = fakeBlogPosts.Generate(countOfFakeData);
    }
    
    
}
// See https://aka.ms/new-console-template for more information

using HomeTask_43.N38_HT1;

Console.WriteLine("N38_HT1");

var usersList = new List<User>
{
    new User("John", "Doe", "example@example.com"),
    new User("Ien", "Doe", "example@example.com"),
    new User("Fiona", "Doe", "sara_example@example.com"),
    new User("Sara", "Doe", "anna_example@example.com"),
    new User("Philipp", "Doe", "philipp_example@example.com"),
};

var userContainer = new UserContainer(usersList);

var result = usersList.Where(user => user.LastName.Contains("doe", StringComparison.OrdinalIgnoreCase)).ToList();

result.ForEach(Console.WriteLine);
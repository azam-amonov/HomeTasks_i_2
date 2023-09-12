namespace HomaTask_41.N36_HT1;

public record Person(string firstName, string lastName);

public record Employee(string firstName, string lastName, string email, string password) 
                : Person(firstName, lastName);

public record Manager(string firstName, string lastName, string email, string password, int status)
                : Employee(firstName, lastName, email, password);

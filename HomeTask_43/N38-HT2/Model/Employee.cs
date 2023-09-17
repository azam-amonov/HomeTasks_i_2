namespace HomeTask_43.N38_HT2.Model;

public class Employee
{
   public Guid Id { get; set; }
   public string FirsName { get; set; }
   public string LastName { get; set; }
   public string EmailAddress { get; set; }
   public string Position { get; set; }
   public decimal Salary { get; set; }

   public Employee()
   {
      
   }

   public Employee( string firsName, string lastName, string emailAddress, string position, decimal salary)
   {
      Id = Guid.NewGuid();
      FirsName = firsName;
      LastName = lastName;
      EmailAddress = emailAddress;
      Position = position;
      Salary = salary;
   }

   public override string ToString()
   {
      return $"{Id} {FirsName} {LastName} {EmailAddress} {Position} {Salary}";
   }
}
namespace HomeTask_43.N38_HT2.Model;

public class Order
{
    public Guid Id { get; set; }
    public Guid OwnerId {get; set; }
    public String Name { get; set; }
    public decimal Amount { get; set;}
    public string Status { get; set; }

    public Order()
    {
        
    }

    public Order( string name, decimal amount, string status)
    {
        Id = Guid.NewGuid();
        OwnerId = Guid.NewGuid();
        Name = name;
        Amount = amount;
        Status = status;
    }

    public override string ToString()
    {
        return $"{Id} {OwnerId} {Name} {Amount} {Status}";
    }
}
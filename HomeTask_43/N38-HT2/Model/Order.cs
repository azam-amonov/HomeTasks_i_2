namespace HomeTask_43.N38_HT2.Model;

public class Order
{
    public Guid Id { get; set; }
    public Guid OwnerId {get; set; }
    public String OwnerName { get; set; }
    public decimal Amount { get; set;}
    public bool IsActive { get; set; }

    public Order()
    {
        
    }

    public Order( string ownerName, decimal amount, bool isActive)
    {
        Id = Guid.NewGuid();
        OwnerId = Guid.NewGuid();
        OwnerName = ownerName;
        Amount = amount;
        IsActive = isActive;
    }

    public override string ToString()
    {
        return $"{Id} {OwnerId} {OwnerName} {Amount} {IsActive}";
    }
}
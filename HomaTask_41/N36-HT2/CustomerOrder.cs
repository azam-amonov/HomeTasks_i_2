namespace HomaTask_41.N36_HT2;

public record CustomerOrder(Guid Id, Guid OrderId, Guid CustomerId, string name, string email, List<object> orders);
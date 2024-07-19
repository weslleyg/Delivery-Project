namespace Domain.Entities;

public class Payment
{
    [Key]
    public int Id {get; set;}

    [Key]
    public int OrderID {get; set;}

    public string? PaymentType {get; set;}

    public string? Status {get; set;}

    public Order Order {get; set;}
}
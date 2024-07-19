namespace Domain.Entities;

public class OrderProducts
{
    [Key]
    public int Id {get; set;}

    [Key]
    public int ProductID {get; set;}

    [Key]
    public int OrderID {get; set;}

    public decimal Value {get; set;}

    public int amount {get; set;}

    public Order Order {get; set;}

    public Product Product {get; set;}
}

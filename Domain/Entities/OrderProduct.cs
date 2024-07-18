namespace Domain.Entities;

public class OrderProduct
{
    public int Id {get; set;}

    public decimal Value {get; set;}

    public int amount {get; set;}

    public int IdProduct {get; set;} 
    public ICollection<Product>? Products {get; set;}
}

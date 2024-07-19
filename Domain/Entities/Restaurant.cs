namespace Domain.Entities;

public class Restaurant
{
    [Key]
    public int Id {get; set;}

    public string? Name {get; set;}

    public string? Address {get; set;}

    public string? Phone {get; set;}

    public string? Category {get; set;}

    public string? PriceRange {get; set;}

    public int Rating {get; set;}

    public ICollection<Product> Products {get; set;}
    public ICollection<Order> Orders {get; set;}
    public ICollection<Promotion> Promotions {get; set;}
}

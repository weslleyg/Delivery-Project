namespace Domain.Entities;

public class Order
{
    [Key]
    public int Id { get; set; }

    public int UserID {get; set;}

    public int RestaurantID {get; set;}

    public string? Status { get; set; }

    public DateTime OrderDateTime {get; set;}

    public double TotalPrice {get; set;}

    
}

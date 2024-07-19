namespace Domain.Entities;

public class Promotion
{
    [Key]
    public int Id {get; set;}

    [Key]
    public int RestaurantID {get; set;}

    public string? PromotionType {get; set;}

    public string? Description {get; set;}

    public DateTime StartDate {get; set;}

    public DateTime ExpirationDate {get; set;}

    public Restaurant Restaurant {get; set;}
}

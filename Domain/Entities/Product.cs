namespace Domain.Entities;

public class Product
{
    [Key]
    public int Id {get; set;}

    [Required]
    [StringLength(100)]
    public string? Name {get; set;}

    [StringLength(200)]
    public string? Description {get; set;}

    [Required]
    [StringLength(100)]
    public string Category {get; set;}

    [Required]
    public decimal Price {get; set;}

    [Required]
    [NotMapped]
    public Restaurant Restaurant {get; set;}
    public ICollection<OrderProducts> OrderProducts {get; set;}
}

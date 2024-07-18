using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;

public class User
{
    public int Id { get; set; }

    [Required]
    [StringLength(100)]
    public string? Name { get; set; }

    [Required]
    [StringLength(150)]
    public string? Email { get; set; }

    [Required]
    [StringLength(80)]
    public string? Password { get; set; }

    [StringLength(150)]
    public string? UrlImage { get; set; }

    [StringLength(150)]
    public ICollection<String>? Addresses { get; set; }

    [StringLength(80)]
    public string? PhoneNumber { get; set; }


    [NotMapped]
    public ICollection<Order>? Orders { get; set; }
}

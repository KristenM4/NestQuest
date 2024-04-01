using System.ComponentModel.DataAnnotations.Schema;

namespace NestQuest.Models;
public class Property
{
    public int Id { get; set; }
    public string? StreetNumber { get; set; }
    public string? StreetName { get; set; }
    public string? City { get; set; }
    public string? PostCode { get; set; }
    public string? Description { get; set; }

    [Column(TypeName = "decimal(15, 2)")]
    public decimal Price { get; set; }
    public int Bedrooms { get; set; }
    public int Bathrooms { get; set; }
}

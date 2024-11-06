using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorAppDownload.Domain.Entities;

public class Product
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id")]
    public int Id { get; set; }

    [Column("product_code")]
    [MaxLength(100)]
    public string? Name { get; set; }

    [Column("product_name")]
    [MaxLength(20)]
    public string? ProductName { get; set; }

    [Column("price", TypeName = "decimal(7,2)")]
    public decimal Price { get; set; }
}

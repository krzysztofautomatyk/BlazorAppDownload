using CsvHelper.Configuration.Attributes;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorAppDownload.Domain.Entities;

public class Product
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id")]
    [Ignore] // CSVHELPER
    public int Id { get; set; }

    [Column("product_code")]
    [MaxLength(100)]
    [Name("product_code")]
    public string? ProductCode { get; set; }

    [Column("product_name")]
    [MaxLength(20)]
    [Name("product_name")]
    public string? ProductName { get; set; }

    [Column("price", TypeName = "decimal(7,2)")]
    [Name("price")]
    public decimal Price { get; set; }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcnesLibrary.Models;

public class Books
{

    [Key]
    public int BookId { get; set; }

    [StringLength(50, MinimumLength = 3)]
    [Required]
    public string Title { get; set; }

    [StringLength(60, MinimumLength = 3)]
    [Required]
    public string Author { get; set; }
    public string Genre { get; set; }

    [Range(1, 100)]
    [DataType(DataType.Currency)]
    [Required]
    [Column(TypeName = "Decimal(18,2)")]
    public decimal Price { get; set; }


}


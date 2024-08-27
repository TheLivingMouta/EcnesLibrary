using System.ComponentModel.DataAnnotations;

namespace EcnesLibrary.Models;

    public class Books
    {

    [Key]
    public int BookId { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public string Genre { get; set; }
    public decimal Price { get; set; }


    }


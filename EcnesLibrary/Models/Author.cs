using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcnesLibrary.Models
{
    public class Author
    {

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AuthorId { get; set; }

        [Required]
        public string AuthorName { get; set; }

        public ICollection<Books> Books { get; } = new List<Books>();

    }
}

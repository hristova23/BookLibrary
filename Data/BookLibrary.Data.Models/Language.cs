using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BookLibrary.Data.Models
{
    public class Language
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(DataValidations.NameMaxLenght)]
        public string Name { get; set; }

        public ICollection<Book> Books { get; set; } = new HashSet<Book>();
    }
}

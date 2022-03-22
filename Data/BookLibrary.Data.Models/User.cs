using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BookLibrary.Data.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(DataValidations.EmailMaxLenght)]
        public string Email { get; set; }

        [Required]
        [MinLength(DataValidations.PasswordMinLenght)]
        public string PasswordHash { get; set; }

        public ICollection<Book> OwnedBooks { get; set; } = new HashSet<Book>();
        public ICollection<FavoriteBook> FavoriteBooks { get; set; } = new HashSet<FavoriteBook>();
    }
}

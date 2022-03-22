using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BookLibrary.Data.Models     
{
    public class Book
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(DataValidations.NameMaxLenght)]
        public string Title { get; set; }

        [Required]
        [MaxLength(DataValidations.DescriptionMaxLenght)]
        public string Description { get; set; }

        [Required]
        [MaxLength(DataValidations.UrlMaxLenght)]
        public string PdfUrl { get; set; }

        public int ImageId { get; set; }
        public Image Image { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public int LanguageId { get; set; }
        public Language Language { get; set; }

        public ICollection<FavoriteBook> LikedByUsers { get; set; } = new HashSet<FavoriteBook>();
    }
}

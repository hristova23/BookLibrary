using System.ComponentModel.DataAnnotations;

namespace BookLibrary.Data.Models
{
    public class Image
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(DataValidations.FileMaxLenght)]
        public string Path { get; set; }

        [Required]
        [MaxLength(DataValidations.DescriptionMaxLenght)]
        public string Description { get; set; }// alt tag for HTML\

        public Book Book { get; set; }
    }
}

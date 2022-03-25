namespace BookLibrary.Services.Models.Book
{
    public class BookListingServiceModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string PdfUrl { get; set; }
        public int ImageId { get; set; }
        public int UserId { get; set; }
    }
}

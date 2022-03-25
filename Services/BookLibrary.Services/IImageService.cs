using BookLibrary.Data.Models;

namespace BookLibrary.Services
{
    public interface IImageService
    {
        Image Create(string path);
        void Delete(int id);
    }
}

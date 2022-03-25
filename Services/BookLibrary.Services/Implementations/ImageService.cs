using BookLibrary.Data;
using BookLibrary.Data.Models;
using System;
using System.Linq;

namespace BookLibrary.Services.Implementations
{
    public class ImageService : IImageService
    {
        private readonly BookLibraryDbContext data;

        public ImageService(BookLibraryDbContext data)
        {
            this.data = data;
        }

        public Image Create(string path)
        {
            if (path == null)
            {
                throw new InvalidOperationException("Path cannot be empty string");
            }

            Image image = new Image
            {
                Path = path
            };
            this.data.Images.Add(image);

            this.data.SaveChanges();

            return image;
        }

        public void Delete(int id)
        {
            this.data.Images
                .Remove(this.data.Images
                .Where(i => i.Id == id)
                .FirstOrDefault());

            this.data.SaveChanges();
        }
    }
}

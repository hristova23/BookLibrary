using BookLibrary.Data;
using BookLibrary.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookLibrary.Services.Implementations
{
    public class ImageService : IImageService
    {
        private readonly BookLibraryDbContext data;

        public ImageService(BookLibraryDbContext data)
        {
            this.data = data;
        }

        public int Create(string path)
        {
            if (path == null)
            {
                throw new InvalidOperationException("Path cannot be empty string");
            }

            this.data.Images.Add(new Image
            {
                Path = path
            });

            this.data.SaveChanges();

            return this.data.Images.Where(i => i.Path == path).FirstOrDefault().Id;
        }
    }
}

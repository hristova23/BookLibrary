using BookLibrary.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BookLibrary.Data
{
    public class BookLibraryDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            if (!builder.IsConfigured)
            {
                //builder.UseSqlServer("Server=.;Database=BookLibrary;Integrated Security=True;");
                builder.UseSqlServer("Server=DESKTOP-LTGBELC\\SQLEXPRESS;Database=BookLibrary;Integrated Security=True;");
            }
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Book>(book =>
            {
                book
                    .HasOne(b => b.Language)
                    .WithMany(l => l.Books)
                    .HasForeignKey(b => b.LanguageId)
                    .OnDelete(DeleteBehavior.Restrict);

                book
                    .HasOne(b => b.Image)
                    .WithOne(i => i.Book)
                    .HasForeignKey<Book>(b => b.ImageId)
                    .OnDelete(DeleteBehavior.Restrict);

                book
                    .HasOne(b => b.User)
                    .WithMany(a => a.OwnedBooks)
                    .HasForeignKey(b => b.UserId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            builder.Entity<FavoriteBook>(favoriteBook =>
            {
                favoriteBook
                    .HasKey(fb => new { fb.UserId, fb.BookId });

                favoriteBook
                    .HasOne(a => a.User)
                    .WithMany(f => f.FavoriteBooks)
                    .HasForeignKey(a => a.UserId)
                    .OnDelete(DeleteBehavior.Restrict);

                favoriteBook
                    .HasOne(b => b.Book)
                    .WithMany(u => u.LikedByUsers)
                    .HasForeignKey(b => b.BookId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            builder.Entity<User>(author =>
            {
                author
                    .HasIndex(u => u.Email)
                    .IsUnique();
            });
        }
    }
}

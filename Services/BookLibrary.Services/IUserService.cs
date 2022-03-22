using BookLibrary.Services.Models.User;
using System.Collections.Generic;

namespace BookLibrary.Services
{
    public interface IUserService
    {
        void Create(string email, string password, string confirmPassword);
        string HashPassword(string password);
        IEnumerable<UserListingServiceModel> SearchByEmail(string email);
    }
}

using BookLibrary.Data.Models;
using BookLibrary.Services.Models.User;
using System.Collections.Generic;

namespace BookLibrary.Services
{
    public interface IUserService
    {
        User Create(string firstName, string lastName, string email, string password, string confirmPassword);
        string HashPassword(string password);
        UserListingServiceModel SearchByEmail(string email);
    }
}

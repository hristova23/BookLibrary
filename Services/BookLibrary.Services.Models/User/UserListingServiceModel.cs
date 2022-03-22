using System;
using System.Collections.Generic;
using System.Text;

namespace BookLibrary.Services.Models.User
{
    public class UserListingServiceModel
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
    }
}
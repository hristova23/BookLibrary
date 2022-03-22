﻿using BookLibrary.Data;
using BookLibrary.Data.Models;
using BookLibrary.Services.Models.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace BookLibrary.Services.Implementations
{
    public class UserService : IUserService
    {
        private readonly BookLibraryDbContext data;

        public UserService(BookLibraryDbContext data)
        {
            this.data = data;
        }

        public void Create(string email, string password, string confirmPassword)
        {
            if (email == "" || password == "")
            {
                throw new InvalidOperationException("Please, fill all fields");
            }
            if (password.Trim() != confirmPassword.Trim())
            {
                throw new InvalidOperationException("Passwords must match");
            }
            if (this.data.Users.Any(u => u.Email == email))
            {
                throw new InvalidOperationException($"This email is already in use");
            }
            if (email.Length > DataValidations.EmailMaxLenght
                || password.Length > DataValidations.PasswordMaxLenght
                || password.Length < DataValidations.PasswordMinLenght)
            {
                throw new InvalidOperationException($"Password must be between {DataValidations.PasswordMinLenght} and {DataValidations.PasswordMaxLenght} characters long");
            }

            this.data.Users.Add(new User
            {
                Email = email,
                PasswordHash = HashPassword(password)
            });

            this.data.SaveChanges();
        }

        public string HashPassword(string password)
        {
            using var sha = SHA256.Create();
            var asBytes = Encoding.Default.GetBytes(password);
            var passwordHash = sha.ComputeHash(asBytes);
            return Convert.ToBase64String(passwordHash);
        }

        public IEnumerable<UserListingServiceModel> SearchByEmail(string email)
        {
            if (this.data.Users.Any(u => u.Email.ToLower() == email.ToLower()))
            {
                return this.data
                    .Users
                    .Where(u => u.Email.ToLower().Contains(email.ToLower()))
                    .Select(u => new UserListingServiceModel
                    {
                        Id = u.Id,
                        Email = u.Email,
                        PasswordHash = u.PasswordHash
                    })
                    .ToList();
            }
            return null;
        }
    }
}

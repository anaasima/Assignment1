using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using FINALAssignment.Data.AddAdultsService;
using FINALAssignment.Models;
using FINALAssignment.Pages;
using Models;

namespace FINALAssignment.Data
{
    public class IUserServiceImplementation : IUserService
    {
        private List<User> users;
        private IAddAdultsService _adultsService = new AddAdultsImplementation();

        public IUserServiceImplementation()
        {
            users = SeeUsers();
            
            if(!users.Any())
            {
                users.Add(new User
                {
                    Name = "theBOSS",
                    UserName = "AnaBoss",
                    BirthYear = 2001,
                    City = "Horsens",
                    Domain = "Admin",
                    Password = "bossy",
                    Role = "Boss",
                    SecurityLevel = 5,
                    ID = 0
                });
                WriteToFile();
            }
        }
        public User ValidateUser(string username, string password)
        {
            User first = users.FirstOrDefault(user => user.UserName.Equals(username));
            if (first == null) {
                throw new Exception("User not found");
            }

            if (!first.Password.Equals(password)) {
                throw new Exception("Incorrect password");
            }

            return first;
        }

        public User CreateUser(string name, string username, string password, int id)
        {
            User newUser = new User
            {
                Name = name,
                UserName = username,
                BirthYear = 0,
                City = "",
                Domain = "",
                Password = password,
                Role = "Adult",
                SecurityLevel = 0,
                ID = id
            };
            Adult adult = new Adult();
            adult.Name = name;
            adult.Sex = "";
            adult.JobTitle = "";
            adult.HairColor = "";
            adult.EyeColor = "";
            adult.Age = 0;
            adult.Weight = 0;
            adult.Height = 0;
            adult.Id = id;
            _adultsService.AddAdult(adult);
            users.Add(newUser);
            WriteToFile();
            return newUser;
        }

        public List<User> SeeUsers()
        {
            return JsonSerializer.Deserialize<List<User>>(File.ReadAllText("User.json"));
        }

        public void WriteToFile()
        {
            File.WriteAllText("User.json", JsonSerializer.Serialize(users));
        }
    }
}
using System;
using System.Collections.Generic;
using System.IO;
using Models;
using System.Linq;
using System.Text.Json;


namespace FamilyManagerApp.Data
{
    public class UserListService : IUserService
    {
        private string UsersFile = "Data/users.json";
        public List<User> Users { get; set; }

        public UserListService()
        {
            if (!File.Exists(UsersFile))
            {
                Seed();
                WriteUsersToFile();
            }
            else
            {
                string content = File.ReadAllText(UsersFile);
                Users = JsonSerializer.Deserialize<List<User>>(content);
            }
        }

        private void Seed()
        {
            Users = new List<User>();
            Users.Add(new User()
            {
                Username = "Adriana",
                Password = "1234",
                Role = Role.Admin
            });
        }

        private void WriteUsersToFile()
        {
            string usersAsJson = JsonSerializer.Serialize(Users);
            File.WriteAllText(UsersFile, usersAsJson);
        }

        public User ValidateUser(string userName, string password)
        {
            User first = Users.FirstOrDefault(user =>
                user.Username.Equals(userName, StringComparison.CurrentCultureIgnoreCase));
            if (first == null)
                throw new Exception("User not found");
            if (!first.Password.Equals(password))
                throw new Exception("Incorrect password");
            return first;
        }

        public void AddUser(User user)
        {
            Users.Add(user);
            WriteUsersToFile();
        }

        public List<User> GetUserList()
        {
            return Users;
        }
    }
}
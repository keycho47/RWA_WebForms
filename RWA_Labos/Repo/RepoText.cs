using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace RWA_Labos.Repo
{
    public class RepoText : IBaseSelector
    {
        

        private static string filePath = @"C:\Users\Kico\Desktop\test.txt";

        public RepoText()
        {
        }

        public List<User> GetAllUsers()
        {
            List<User> users = new List<User>();

            List<string> lines = File.ReadAllLines(filePath).ToList();

            foreach (var line in lines)
            {
                string[] value = line.Split(';');
                User user = new User
                {
                    IDUser = int.Parse(value[0]),
                    Firstname = value[1],
                    Lastname = value[2],
                    Phone = value[3],
                    Password = value[4],
                    City = value[5],
                    Role = value[6],
                    Email = value[7]
                };
                users.Add(user);
            }

            return users;
        }

        public User getUserById(int id)
        {
            User u = new User();
            List<User> useri = new List<User>();

            useri = GetAllUsers();
            u = useri.Find(x => x.IDUser == id);

            return u;
        }
        private static void writeInFile(List<User> users)
        {
            List<string> output = new List<string>();

            foreach (var user in users)
            {
                output.Add($"{ user.IDUser };{ user.Firstname };{ user.Lastname };{ user.Phone };{ user.Password };{ user.City };{ user.Role };{user.Email}");
            }

            File.WriteAllLines(filePath, output);
        }

        public void DeleteUser(int id)
        {
            List<User> users = GetAllUsers();
            users.RemoveAt(users.FindIndex(x => x.IDUser.Equals(id)));
            writeInFile(users);
        }

        public void UpdateUser(int userId, string name, string lastname, string phone, string password, string city, string role, string email)
        {
            List<User> users = GetAllUsers();

            User user = new User();
            user.Firstname = name;
            user.Lastname = lastname;
            user.Password = password;
            user.Role = role;
            user.Phone = phone;
            user.City = city;
            user.Email = email;

            users[users.FindIndex(x => x.IDUser.Equals(userId))] = user;

            writeInFile(users);
        }

        public void AddUser(string name, string lastname, string phone, string password, string city, string role, string emails)
        {
            List<User> users = GetAllUsers();
            User user = new User
            {
                IDUser = users.Last().IDUser + 1,
                Firstname = name,
                Lastname = lastname,
                Phone = phone,
                Password = password,
                City = city,
                Role = role,
                Email = emails
            };
            
            users.Add(user);

            writeInFile(users);
        }

    }

    
}
using RWA_Labos.Repo;
using System.Collections.Generic;

namespace RWA_Labos
{
    public interface IBaseSelector
    {
        List<User> GetAllUsers();
        void DeleteUser(int id);
        void UpdateUser(int userId,string name,string lastname,string phone,string password,string city,string role, string email);
        void AddUser(string name,string lastname,string phone,string password,string city,string role, string email);
    }
}
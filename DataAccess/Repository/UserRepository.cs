using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class UserRepository : IUserRepository
    {
        public bool AddUser(userContext user) => UserDAO.Instance.AddUser(user);

        public bool DeleteUser(int id) => UserDAO.Instance.DeleteUser(id);

        public List<userContext> GetAllUsers() => UserDAO.Instance.GetAllUsers();

        public userContext GetUser(string email) => UserDAO.Instance.GetUser(email);

        public userContext GetUser(int id) => UserDAO.Instance.GetUser(id);

        public List<string> GetUserRoles() => UserDAO.Instance.GetUserRoles(); // Returns a list of unique roles


        public bool UpdateUser(userContext user) => UserDAO.Instance.UpdateUser(user);
    }
}

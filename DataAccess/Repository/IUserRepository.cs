using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IUserRepository
    {
        userContext GetUser(string email);
        userContext GetUser(int id);
        bool AddUser(userContext user);
        bool UpdateUser(userContext user);
        bool DeleteUser(int id);
        List<string> GetUserRoles(); // New method to get all unique roles

        List<userContext> GetAllUsers();
   

    }
}

using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class UserDAO
    {
        private ASSPRN221Context userContext;
        private static UserDAO instance;
        public static UserDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new UserDAO();
                }
                return instance;
            }
        }

        public UserDAO()
        {
            userContext = new ASSPRN221Context();
        }

        // Thêm người dùng
        public bool AddUser(userContext user)
        {
            bool isSuccess = false;
            try
            {
                userContext.Users.Add(user);
                userContext.SaveChanges();
                isSuccess = true;
            }
            finally
            {
                // handle any cleanup if needed
            }
            return isSuccess;
        }

        // Lấy người dùng theo email
        public userContext GetUser(string email)
        {
            return userContext.Users.SingleOrDefault(x => x.Email.Equals(email));
        }

        // Lấy người dùng theo id
        public userContext GetUser(int Id)
        {
            return userContext.Users.FirstOrDefault(x => x.Id == Id);
        }

        // Lấy tất cả người dùng
        public List<userContext> GetAllUsers()
        {
            return userContext.Users.ToList();
        }

        // Cập nhật người dùng
        public bool UpdateUser(userContext user)
        {
            bool isSuccess = false;
            try
            {
                userContext.Users.Update(user);
                userContext.SaveChanges();
                isSuccess = true;
            }
            finally
            {
                // handle any cleanup if needed
            }
            return isSuccess;
        }

        // Xóa người dùng
        public bool DeleteUser(int id)
        {
            bool isSuccess = false;
            try
            {
                // Instead of retrieving the user and then deleting, use Find
                var user = userContext.Users.Find(id);
                if (user != null)
                {
                    userContext.Users.Remove(user);
                    userContext.SaveChanges();
                    isSuccess = true;
                }
            }
            catch (Exception ex)
            {
                // Log or handle the exception as needed
                Console.WriteLine(ex.Message);
            }
            return isSuccess;
        }
        public List<string> GetUserRoles()
        {
            return userContext.Users
                              .GroupBy(user => user.Role)
                              .Select(group => group.First().Role)
                              .ToList();
        }


    }
}

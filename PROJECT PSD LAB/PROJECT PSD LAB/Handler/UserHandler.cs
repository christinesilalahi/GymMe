using PROJECT_PSD_LAB.Factory;
using PROJECT_PSD_LAB.Models;
using PROJECT_PSD_LAB.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PROJECT_PSD_LAB.Handler
{
    public class UserHandler
    {
        public static string InsertUser(string name, string email, DateTime dob, string gender, string role, string password)
        {
            return UserRepository.InsertUser(name, email, dob, gender, role, password);
        }

        public static MsUser checkUserLogin(string username, string password)
        {
            return UserRepository.checkUserLogin(username, password);   
        }

        public static string GetUserRole(string username, string password)
        {
            return UserRepository.GetUserRole(username, password);
        }
        public static MsUser GetUserByUsername(string username)
        {
            return UserRepository.GetUserByUsername(username);
        }

        public static bool UpdateUserProfile(string currentUsername, string newUsername, string email, string gender, DateTime dob)
        {
            return UserRepository.UpdateUserProfile(currentUsername, newUsername, email, gender, dob);
        }

        public static bool UpdateUserPassword(string username, string oldPassword, string newPassword)
        {
            return UserRepository.UpdateUserPassword(username, oldPassword, newPassword);
        }
        public static List<MsUser> GetAllCustomers()
        {
            return UserRepository.GetAllCustomers();
        }
    }
}
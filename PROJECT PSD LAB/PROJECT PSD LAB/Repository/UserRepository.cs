using PROJECT_PSD_LAB.Factory;
using PROJECT_PSD_LAB.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace PROJECT_PSD_LAB.Repository
{
    public class UserRepository
    {
        public static string InsertUser(string name, string email, DateTime dob, string gender, string role, string password)
        {
            LocalDatabaseEntities db = new LocalDatabaseEntities();
            MsUser newUser = UserFactory.createUser(name, email, dob, gender, role, password);
            db.MsUsers.Add(newUser);
            db.SaveChanges();
            return "Registration Success";
        }

        public static MsUser checkUserLogin(string username, string password)
        {
            LocalDatabaseEntities db = new LocalDatabaseEntities();
            MsUser findUser = (from user in db.MsUsers where user.UserName == username && user.UserPassword == password select user).FirstOrDefault();
            return findUser;
        }

        public static string GetUserRole(string username, string password)
        {

            using (LocalDatabaseEntities db = new LocalDatabaseEntities())
            {
                var user = db.MsUsers
                            .FirstOrDefault(u => u.UserName == username && u.UserPassword == password);

                if (user != null)
                {
                    System.Diagnostics.Debug.WriteLine($"User found: {user.UserName}, Role: {user.UserRole}");
                    return user.UserRole;
                }
                System.Diagnostics.Debug.WriteLine("User not found or password incorrect.");
                return null;
            }
        }
        public static MsUser GetUserByUsername(string username)
        {
            using (LocalDatabaseEntities db = new LocalDatabaseEntities())
            {
                return db.MsUsers.FirstOrDefault(u => u.UserName == username);
            }
        }

        public static bool UpdateUserProfile(string currentUsername, string newUsername, string email, string gender, DateTime dob)
        {
            using (LocalDatabaseEntities db = new LocalDatabaseEntities())
            {
                var user = db.MsUsers.FirstOrDefault(u => u.UserName == currentUsername);
                if (user != null)
                {
                    user.UserName = newUsername;
                    user.UserEmail = email;
                    user.UserGender = gender;
                    user.UserDOB = dob;

                    db.SaveChanges();
                    return true;
                }
                return false;
            }
        }

        public static bool UpdateUserPassword(string username, string oldPassword, string newPassword)
        {
            using (LocalDatabaseEntities db = new LocalDatabaseEntities())
            {
                var user = db.MsUsers.FirstOrDefault(u => u.UserName == username && u.UserPassword == oldPassword);
                if (user != null)
                {
                    user.UserPassword = newPassword; // Ensure to hash the new password before storing
                    db.SaveChanges();
                    return true;
                }
                return false;
            }
        }
        public static List<MsUser> GetAllCustomers()
        {
            LocalDatabaseEntities db = new LocalDatabaseEntities();
            return db.MsUsers.Where(u => u.UserRole.Equals("Customer", StringComparison.OrdinalIgnoreCase)).ToList();
        }
    }
}
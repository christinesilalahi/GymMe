using PROJECT_PSD_LAB.Models;
using PROJECT_PSD_LAB.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PROJECT_PSD_LAB.Views
{
    public partial class Profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadUserProfile();
            }
        }

        private void LoadUserProfile()
        {
            // Assuming username is used to identify the current user
            string username = User.Identity.Name;
            var user = UserRepository.GetUserByUsername(username);

            if (user != null)
            {
                txtUsername.Text = user.UserName;
                txtEmail.Text = user.UserEmail;
                ddlGender.SelectedValue = user.UserGender;
                txtDOB.Text = user.UserDOB.ToString("dd MMMM yyyy");
            }
        }

        protected void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string email = txtEmail.Text;
            string gender = ddlGender.SelectedValue;
            string dob = txtDOB.Text;

            if (ValidateProfileUpdate(username, email, gender, dob))
            {
                DateTime dt = Convert.ToDateTime(dob);
                string currentUsername = User.Identity.Name;

                bool success = UserRepository.UpdateUserProfile(currentUsername, username, email, gender, dt);

                lblProfileMessage.Text = success ? "Profile updated successfully." : "Failed to update profile.";
            }
        }

        protected void btnUpdatePassword_Click(object sender, EventArgs e)
        {
            string oldPassword = txtOldPassword.Text;
            string newPassword = txtNewPassword.Text;

            if (ValidatePasswordUpdate(oldPassword, newPassword))
            {
                string currentUsername = User.Identity.Name;
                bool success = UserRepository.UpdateUserPassword(currentUsername, oldPassword, newPassword);

                lblPasswordMessage.Text = success ? "Password updated successfully." : "Failed to update password.";
            }
        }

        private bool ValidateProfileUpdate(string username, string email, string gender, string dob)
        {
            if (username.Length < 5 || username.Length > 15 || !System.Text.RegularExpressions.Regex.IsMatch(username, "^[a-zA-Z ]+$"))
            {
                lblProfileMessage.Text = "Username must be between 5 and 15 characters and can only contain alphabets and spaces.";
                return false;
            }

            if (!email.EndsWith(".com"))
            {
                lblProfileMessage.Text = "Email must end with '.com'.";
                return false;
            }

            if (string.IsNullOrEmpty(gender))
            {
                lblProfileMessage.Text = "Gender must be chosen.";
                return false;
            }

            if (string.IsNullOrEmpty(dob))
            {
                lblProfileMessage.Text = "Date of Birth cannot be empty.";
                return false;
            }

            if (!DateTime.TryParse(dob, out _))
            {
                lblProfileMessage.Text = "Invalid date of birth.";
                return false;
            }

            return true;
        }

        private bool ValidatePasswordUpdate(string oldPassword, string newPassword)
        {
            if (string.IsNullOrEmpty(oldPassword))
            {
                lblPasswordMessage.Text = "Old password cannot be empty.";
                return false;
            }

            if (string.IsNullOrEmpty(newPassword) || newPassword.Length < 8 || !newPassword.Any(char.IsUpper) || !newPassword.Any(char.IsLower) || !newPassword.Any(char.IsDigit) || !newPassword.Any(char.IsPunctuation))
            {
                lblPasswordMessage.Text = "New password must be at least 8 characters long and include uppercase, lowercase, digit, and special character.";
                return false;
            }

            return true;
        }
    }
}
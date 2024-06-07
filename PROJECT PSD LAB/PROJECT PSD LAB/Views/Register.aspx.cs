using PROJECT_PSD_LAB.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PROJECT_PSD_LAB.Views
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void calDOB_SelectionChanged(object sender, EventArgs e)
        {
            DateTime date = calDOB.SelectedDate;
            txtDOB.Text = date.ToString("dd MMMM yyyy");
        }
        protected void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string email = txtEmail.Text;
            string gender = ddlGender.SelectedValue;
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;
            string dob = txtDOB.Text;

            if (ValidateRegistration(username, email, gender, password, confirmPassword, dob))
            {
                DateTime dt = Convert.ToDateTime(dob);
                if (Page.IsValid)
                {

                    string role = "Customer";
                    lblMessage.Text = UserRepository.InsertUser(username, email, dt, gender, role, password);
                    Response.Redirect("~/Views/Login.aspx");
                }
            }
        }

        private bool ValidateRegistration(string username, string email, string gender, string password, string confirmPassword, string dob)
        {
            if (username.Length < 5 || username.Length > 15)
            {
                lblMessage.Text = "Username must be between 5 and 15 characters.";
                return false;
            }

            if (!email.EndsWith(".com"))
            {
                lblMessage.Text = "Email must end with '.com'.";
                return false;
            }

            if (!DateTime.TryParse(dob, out DateTime dateOfBirth))
            {
                lblMessage.Text = "Invalid date of birth.";
                return false;
            }

            if (string.IsNullOrEmpty(gender))
            {
                lblMessage.Text = "Gender must be chosen.";
                return false;
            }

            if (password != confirmPassword)
            {
                lblMessage.Text = "Passwords do not match.";
                return false;
            }

            //if (dateOfBirth > DateTime.Now.AddYears(-18))
            //{
            //    lblMessage.Text = "You must be at least 18 years old.";
            //    return false;
            //}

            return true;
        }
    }
}
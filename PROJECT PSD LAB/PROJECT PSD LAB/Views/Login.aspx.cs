using PROJECT_PSD_LAB.Controller;
using PROJECT_PSD_LAB.Models;
using PROJECT_PSD_LAB.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PROJECT_PSD_LAB.Views
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
                string username = txtUsername.Text;
                string password = txtPassword.Text;
                bool rememberMe = chkRememberMe.Checked;

                if (ValidateLogin(username, password))
                {
                    MsUser checkUser = UserController.checkUserLogin(username, password);
                    Console.WriteLine(checkUser);
                    if(checkUser != null)
                    {     
                        lblMessage.Text = checkUser.UserName;
                    }
                    else
                    {
                        lblMessage.Text = "User doesn't exist";

                    }
                //if (checkUser != null)
                //{
                //    if (!string.IsNullOrEmpty(role))
                //    {
                //        //HttpCookie cookie = new HttpCookie(role);
                //        if (role.Equals("Customer", StringComparison.OrdinalIgnoreCase) || role.Equals("Admin", StringComparison.OrdinalIgnoreCase))
                //        {
                //            FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(1, username, DateTime.Now, DateTime.Now.AddMinutes(30), rememberMe, role, FormsAuthentication.FormsCookiePath);
                //            string encTicket = FormsAuthentication.Encrypt(ticket);
                //            HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName, encTicket);
                //            if (rememberMe)
                //            {
                //                cookie.Expires = DateTime.Now.AddDays(30);
                //            }
                //            Response.Cookies.Add(cookie);
                Session["User"] = checkUser;
                Response.Redirect("~/Views/Home.aspx");

                //            // check role
                //            //lblMessage.Text = "Customer";
                //        }
                //        //lblMessage.Text = "PEPE";
                //    }
                //    else
                //    {
                //        lblMessage.Text = "Invalid username or password";
                //    }
                //}
            }
            

        }

        private bool ValidateLogin(string username, string password)
        {
            if (string.IsNullOrEmpty(username))
            {
                lblMessage.Text = "Username cannot be empty";
                return false;
            }

            if (string.IsNullOrEmpty(password))
            {
                lblMessage.Text = "Password cannot be empty";
                return false;
            }

            return true;
        }

    }
}
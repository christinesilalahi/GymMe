<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="PROJECT_PSD_LAB.Views.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login Page</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>THIS IS LOGIN PAGE !!!!</h1>
        </div>
        <asp:Label ID="lblMessage" runat="server" ForeColor="Red" />
        <asp:Label ID="lblDebug" runat="server" ForeColor="Blue"></asp:Label>
        <div>
            <asp:Label ID="lblUsername" Text="Username" runat="server" />
            <asp:TextBox ID="txtUsername" runat="server" />
        </div>
        <div>
            <asp:Label ID="lblPassword" Text="Password" runat="server" />
            <asp:TextBox ID="txtPassword" runat="server" />
        </div>
        <asp:CheckBox ID="chkRememberMe" Text="Remember Me" runat="server" />
        <br />
        <asp:Button ID="btnLogin" Text="Login" runat="server" OnClick="btnLogin_Click" />
        <br />
        <asp:HyperLink ID="hlRegister" NavigateUrl="~/Views/Register.aspx" runat="server"> Don't have an account yet? Register here</asp:HyperLink>
    </form>
</body>
</html>

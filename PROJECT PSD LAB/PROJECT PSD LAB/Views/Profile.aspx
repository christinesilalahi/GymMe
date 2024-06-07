<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="PROJECT_PSD_LAB.Views.Profile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Update Profile</h2>
            <asp:Label ID="lblProfileMessage" runat="server" ForeColor="Red"></asp:Label>
            <br />
            <asp:Label ID="lblUsername" runat="server" Text="Username:"></asp:Label>
            <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblEmail" runat="server" Text="Email:"></asp:Label>
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblGender" runat="server" Text="Gender:"></asp:Label>
            <asp:DropDownList ID="ddlGender" runat="server">
                <asp:ListItem Value="" Text="Select Gender"></asp:ListItem>
                <asp:ListItem Value="Male" Text="Male"></asp:ListItem>
                <asp:ListItem Value="Female" Text="Female"></asp:ListItem>
            </asp:DropDownList>
            <br />
            <asp:Label ID="lblDOB" runat="server" Text="Date of Birth:"></asp:Label>
            <asp:TextBox ID="txtDOB" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="btnUpdateProfile" runat="server" Text="Update Profile" OnClick="btnUpdateProfile_Click" />
        </div>
        <br />
        <div>
            <h2>Change Password</h2>
            <asp:Label ID="lblPasswordMessage" runat="server" ForeColor="Red"></asp:Label>
            <br />
            <asp:Label ID="lblOldPassword" runat="server" Text="Old Password:"></asp:Label>
            <asp:TextBox ID="txtOldPassword" runat="server" TextMode="Password"></asp:TextBox>
            <br />
            <asp:Label ID="lblNewPassword" runat="server" Text="New Password:"></asp:Label>
            <asp:TextBox ID="txtNewPassword" runat="server" TextMode="Password"></asp:TextBox>
            <br />
            <asp:Button ID="btnUpdatePassword" runat="server" Text="Update Password" OnClick="btnUpdatePassword_Click" />
        </div>
    </form>
</body>
</html>

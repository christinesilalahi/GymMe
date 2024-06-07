<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ManageSupplement.aspx.cs" Inherits="PSD_FINAL_LAB__1.Views.ManageSupplement" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Manage Supplement</title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Manage Supplement</h1>
        <div>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" OnRowDeleting="GridView1_RowDeleting" OnRowEditing="GridView1_RowEditing" DataKeyNames="SupplementID" OnRowDataBound="GridView1_RowDataBound">
                <Columns>
                    <asp:BoundField DataField="SupplementName" HeaderText="Name" SortExpression="SupplementName" />
                    <asp:BoundField DataField="SupplementExpiryDate" HeaderText="Expiry Date" SortExpression="SupplementExpiryDate" />
                    <asp:BoundField DataField="SupplementPrice" HeaderText="Price" SortExpression="SupplementPrice" />
                    <asp:BoundField DataField="SupplementTypeID" HeaderText="Type ID" SortExpression="SupplementTypeID" />
                    <asp:ButtonField CommandName="Edit" Text="Update"/>
                    <asp:ButtonField ButtonType="Button" CommandName="Delete" Text="Delete" />
                </Columns>
                <EmptyDataTemplate>
                    <asp:Label ID="NoDataLabel" runat="server" Text="There is no data available." ForeColor="Red" Font-Bold="True" />
                </EmptyDataTemplate>
            </asp:GridView>
        </div>
        <br />
        <asp:Button ID="InsertBtn" runat="server" Text="Insert A New Supplement" OnClick="InsertBtn_Click" />
    </form>
</body>
</html>


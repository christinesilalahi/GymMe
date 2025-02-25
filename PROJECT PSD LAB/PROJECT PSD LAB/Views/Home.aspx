﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Master/Site.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="PROJECT_PSD_LAB.Views.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Home Page</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Welcome to GymMe</h2>
    <asp:Label ID="lblRole" runat="server" Text="Label"></asp:Label>
    <asp:GridView ID="CustomerGV" runat="server" AutoGenerateColumns="False" Visible="False">
        <Columns>
            <asp:BoundField DataField="UserId" HeaderText="User ID" SortExpression="UserId" />
            <asp:BoundField DataField="UserName" HeaderText="Username" SortExpression="UserName" />
            <asp:BoundField DataField="UserEmail" HeaderText="Email" SortExpression="UserEmail" />
            <asp:BoundField DataField="UserGender" HeaderText="Gendeer" SortExpression="UserGender" />
            <asp:BoundField DataField="UserDOB" HeaderText="Date of Birth" SortExpression="UserDOB" />
        </Columns>
        
    </asp:GridView>
</asp:Content>

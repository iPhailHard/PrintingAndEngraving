﻿<%--<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="Printing_and_Engraving_Site.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:AdminConnectionString %>" ProviderName="<%$ ConnectionStrings:AdminConnectionString.ProviderName %>" SelectCommand="SELECT * FROM [Users]" DeleteCommand="DELETE FROM [Users] WHERE [PersonID] = ?" InsertCommand="INSERT INTO [Users] ([PersonID], [UserName], [UserPassword], [UserRoleID]) VALUES (?, ?, ?, ?)" UpdateCommand="UPDATE [Users] SET [UserName] = ?, [UserPassword] = ?, [UserRoleID] = ? WHERE [PersonID] = ?">
        <DeleteParameters>
            <asp:Parameter Name="PersonID" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="PersonID" Type="Int32" />
            <asp:Parameter Name="UserName" Type="String" />
            <asp:Parameter Name="UserPassword" Type="String" />
            <asp:Parameter Name="UserRoleID" Type="Int32" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="UserName" Type="String" />
            <asp:Parameter Name="UserPassword" Type="String" />
            <asp:Parameter Name="UserRoleID" Type="Int32" />
            <asp:Parameter Name="PersonID" Type="Int32" />
        </UpdateParameters>
    </asp:SqlDataSource>
    <br />
    Modify Users<br />
<br />
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="PersonID" DataSourceID="SqlDataSource1">
        <Columns>
            <asp:BoundField DataField="PersonID" HeaderText="PersonID" InsertVisible="False" ReadOnly="True" SortExpression="PersonID" />
            <asp:BoundField DataField="UserName" HeaderText="UserName" SortExpression="UserName" />
            <asp:BoundField DataField="UserPassword" HeaderText="UserPassword" SortExpression="UserPassword" />
            <asp:BoundField DataField="UserRoleID" HeaderText="UserRoleID" SortExpression="UserRoleID" />
            <asp:CommandField ShowEditButton="True" />
            <asp:CommandField ShowDeleteButton="True" />
        </Columns>
    </asp:GridView>
<br />

</asp:Content>--%>

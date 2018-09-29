<%@ Page Title="Login" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Printing_and_Engraving_Site.Login" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    <h2><%: Title %>.</h2>
    <h3>This is the login page.</h3>
    <p>This is where we login.</p>

            <asp:Login ID="lgnUserLogin" runat="server" OnAuthenticate="lgnUserLogin_Authenticate" DestinationPageUrl="~/Default.aspx">
    </asp:Login>

</asp:Content>
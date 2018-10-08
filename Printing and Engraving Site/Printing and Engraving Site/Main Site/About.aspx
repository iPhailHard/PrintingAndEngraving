<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="Printing_and_Engraving_Site.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <div id="mission statement">
    <h3>Mission Statement</h3>
        <p>"To offer the best services at agreeable prices. Every customer will be happy with their purchase."</p>
        <p>&nbsp;</p>
        </div>
    <div id="About Us">
        <h3>About Us</h3>
    <p>We started out as an engraving company in 1908, doing work on precious metals and fine &lt;insert information here&gt;</p>
        <p>&nbsp;</p>
        </div>
        <div id="contact us">
            <h3>Contact Us</h3>
            <p>Any questions? Concerns? Comments?
                <br /> Contact us today!
            </p> 
            <ul><li>Phone Number: (888) 555-1251</li>
                <li>Email: <a href="testmail@test.com">testmail@test.com</a></li>
               <li> Address: 800 West Sherman Way, Wallaby, OK 88888-9999</li> </ul>
    </div>
</asp:Content>

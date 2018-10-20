<%@ Page Title="Home" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Printing_and_Engraving_Site.Home" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    
    <style>
     body{
         background-color:#5768F7;
     }

     h1{
            color: silver;
            font-family:'Franklin Gothic Medium', 'Arial Narrow', Arial, sans-serif;
            font-size:85px;
            font-weight:bold;
            position:fixed;
            top:15px;
            left:700px;
     }

     h2{
            color: black;
            font-family:'Franklin Gothic Medium', 'Arial Narrow', Arial, sans-serif;
            font-size:55px;
            font-weight:bold;

     }
     h3{
            color: black;
            font-family:'Franklin Gothic Medium', 'Arial Narrow', Arial, sans-serif;
            font-size:55px;
            font-weight:bold;

     }

     p2{
            color:silver;
            font-family:'Bodoni MT';
            font-size:30px;
            font-weight:bold;
     }
     p3{
            color:silver;
            font-family:'Bodoni MT';
            font-size:30px;
            font-weight:bold;
     }
 </style>
    
    <h1>Services</h1>
    
     <table>
        <tr>
            <td>

    <table>
        <tr>
            <td>
            <div>
                <h2>
                    Embroidery
                </h2>
                <p2>We began with just a screen print, but as we moved to embroidery, 
                    we became so good at it we had to put it in our name. 
                    Look your best in our high quality shirts and hats for teams or businesses.</p2>
            </div>
            </tr>
                <tr>
            <td>
    <div>    
    <h3>
        Engraving
    </h3>
        
        <p3>While we only offer trophies and plaques, we’re certain we can engrave almost anything. 
            If you don’t see it in our catalog, bring your item down and we’ll see what we can do!</p3>
    </div>
                </td>
            </tr>
        <tr>
 
            <td>
            <div class="jumbotron">
           <p>Text/Image/Font textbox/input boxes go here</p>
           </div>
            </td>
            </tr>
        </table>



</asp:Content>
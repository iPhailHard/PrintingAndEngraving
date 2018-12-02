<%@ Page Title="Order" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmCheckout.aspx.cs" Inherits="Printing_and_Engraving_Site.frmCheckout" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
       <style>
        body{
            background-color:#5768F7;
        }
        
        h2{
            color: silver;
            font-family:'Franklin Gothic Medium', 'Arial Narrow', Arial, sans-serif;
            font-size:85px;
            font-weight:bold;
            position:fixed;
            top:15px;
            left:700px;
        }

        </style>
    
     <h2>Checkout</h2>
    

            <div>
                <asp:Label ID="lblDetails" Text="Checkout Details" runat="server" style="align-content:center; font-size:large"></asp:Label>
                <p style="align-content:center; font-size:medium">Please verify your payment information is correct before submitting order.</p>

    </div>
    <div id="divPaymentForm">
        <div>
        <asp:Label Text="Payment Information" style="align-content:center; " runat="server" />
        </div>
        <div>
            <asp:Label ID="lblTotalPrice" runat="server" Text="Total Price: " /><asp:TextBox ID="txtTotalPrice" runat="server" />
        <asp:Label ID="lblCardNumber" runat="server" Text="Card Number: " /><asp:TextBox ID="txtCardNumber" runat="server" ></asp:TextBox><br />
        <asp:Label ID="lblCardHolderName" runat="server" Text="Card Holder Name: " /><asp:TextBox ID="txtCardName" runat="server" ></asp:TextBox><br />
        <asp:Label ID="lblCardHolderAddress1" runat="server" Text="Address 1: " /><asp:TextBox ID="txtCardAdd1" runat="server" ></asp:TextBox><br />
        <asp:Label ID="lblCardHolderAddress2" runat="server" Text="Address 2: " /><asp:TextBox ID="txtCardAdd2" runat="server" ></asp:TextBox><br />
        <asp:Label ID="lblCardHolderCity" runat="server" Text="City: " /><asp:TextBox ID="txtCardCity" runat="server" ></asp:TextBox><br />
        <asp:Label ID="lblCardHolderState" runat="server" Text="State: " /><asp:TextBox ID="txtCardState" runat="server" ></asp:TextBox><br />
        <asp:Label ID="lblCardHolderZip" runat="server" Text="Zip: " /><asp:TextBox ID="txtCardZip" runat="server" ></asp:TextBox><br />
     </div>
        <div><asp:Button runat="server" ID="btnPaymentSubmit" OnClick="btnPaymentSubmit_Click" Text="Submit Payment" /> <asp:Button runat="server" ID="btnCancel" /></div>
    </div>
</asp:Content>
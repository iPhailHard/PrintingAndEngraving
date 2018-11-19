<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucOrderConfirmation.ascx.cs" Inherits="Printing_and_Engraving_Site.Customer.UserControls.ucOrderConfirmation" %>

<div>
    <p style="align-content:center; font-weight:700;">Please confirm your order is correct, add a custom message, and continue shopping or proceed to checkout!</p>
    <br />
    <br />
    
    <asp:Label runat="server" ID="lblItemName" Text="Item: " style="align-content:center;"></asp:Label> <asp:TextBox runat="server" ID="txtItemName" ReadOnly="true" style="align-content:center;"></asp:TextBox> <br />
    <asp:Label runat="server" ID="lblItemCode" Text="Item Code: " style="align-content:center;"></asp:Label> <asp:TextBox runat="server" ID="txtItemCode" ReadOnly="true" style="align-content:center;"></asp:TextBox> <br />
    <asp:Label runat="server" ID="lblItemPrice" Text="Item Price: " style="align-content:center;"></asp:Label> <asp:TextBox runat="server" ID="txtItemPrice" ReadOnly="true" style="align-content:center;"></asp:TextBox> <br />
    <asp:Label runat="server" ID="lblItemQuantity" Text="Quantity: " style="align-content:center;"></asp:Label> <asp:TextBox  runat="server" ID="txtItemQuantity" ReadOnly="true" style="align-content:center;"></asp:TextBox> <br />
    <asp:Label runat="server" ID="lblTotalPrice" Text="Total Price: " style="align-content:center;"></asp:Label> <asp:TextBox  runat="server" ID="txtItemTotal" ReadOnly="true" style="align-content:center;"></asp:TextBox> <br />
</div>
<br />
<br />
<br />
<div>
    <p style="font-size:medium; font-weight:700;">Create Your Custom Message Below!</p>
    <br />
    <asp:TextBox runat="server" ID="txtCustomEngravingMessage"></asp:TextBox>
</div>
<br />
<br />

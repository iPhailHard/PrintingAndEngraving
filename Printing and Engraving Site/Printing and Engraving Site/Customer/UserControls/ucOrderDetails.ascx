<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucOrderDetails.ascx.cs" Inherits="Printing_and_Engraving_Site.Customer.UserControls.ucOrderDetails" %>
    <header>
</header>
    
<%--<asp:Image ID="itemImage" runat="server"  />--%>
<table class="blueLegend">
        <tbody>
            <tr>
                <td>Item &nbsp;&nbsp;&nbsp;</td>
                
                <td><asp:Label runat="server" ID="lblItemName" Text=""><%--Text="<%# Eval("ItemName") %>"--%></asp:Label></td>
                </tr>
            <tr>
                <td>Item Code &nbsp;&nbsp;&nbsp;</td>
                <td><asp:Label runat="server" ID="lblItemCode" Text=""><%--<%# Eval("ItemCode") %>--%></asp:Label></td>
                </tr>
            <tr>
                <td>Item Description &nbsp;&nbsp;&nbsp;</td>
                <td><asp:Label runat="server" ID="lblItemDescription" Text=""><%--<%# Eval("ItemDescription") %>--%></asp:Label></td>
                </tr>
            <tr>
                <td>Item Price &nbsp;&nbsp;&nbsp;</td>
                
                <td><asp:Label runat="server" ID="lblItemPrice" Text=""><%--<%# Eval("ItemPrice") %>--%></asp:Label></td>
            </tr>
    </tbody>
</table>
    

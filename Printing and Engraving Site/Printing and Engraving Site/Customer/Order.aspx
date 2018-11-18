<%@ Page Title="Order" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Order.aspx.cs" Inherits="Printing_and_Engraving_Site.Order" %>

<%@ Register Src="~/Customer/UserControls/ucOrderDetails.ascx" TagPrefix="uc1" TagName="ucOrderDetails" %>
<%@ Register Src="~/Customer/UserControls/ucOrderConfirmation.ascx" TagPrefix="uc1" TagName="ucOrderConfirmation" %>



<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        body{
            background-color:lightslategray;
        }
        
        h2{
            color: darkblue;
            font-family:'Franklin Gothic Medium', 'Arial Narrow', Arial, sans-serif;
            font-size:85px;
            font-weight:bold;
            position:fixed;
            top:15px;
            left:700px;
        }

     

        
    </style>
    
    <h2>Orders</h2>
    
    <asp:UpdatePanel ID="updatePanel" runat="server">
        <ContentTemplate>
    <asp:Multiview runat="server" ID="mvOrderDetails">
        <asp:View runat="server" ID="vwOrderItems" >
    <div style="color:darkblue;">
    
        <table style="color:darkblue">
            <tr>
                <td>
                    <asp:Label runat="server" ID="ItemName">Item</asp:Label>
                </td>
                                <td>
                    <asp:Label runat="server" ID="Label1">Item Code</asp:Label>
                </td>
                                <td>
                    <asp:Label runat="server" ID="Label2">Item Description</asp:Label>
                </td>
                                <td>
                    <asp:Label runat="server" ID="Label3">Item Price</asp:Label>
                </td>
                <td>
                </td>
            </tr>
        </table>
    </div>
    <div>
        <asp:Repeater ID="repItemInformation" runat="server" OnItemCommand="repItemInformation_ItemCommand">
            <HeaderTemplate>
        
            <%--<tr>
                <td>
                    <asp:Label runat="server" ID="ItemName">Item</asp:Label>
                </td>
                <td>
                    <asp:Label runat="server" ID="Label1">Item Code</asp:Label>
                </td>
                <td>
                    <asp:Label runat="server" ID="Label2">Item Description</asp:Label>
                </td>
                <td>
                    <asp:Label runat="server" ID="Label3">Item Price</asp:Label>
                </td>
                <td>
                    <asp:Label runat="server">Item Image</asp:Label>
                </td>
            </tr>--%>
        
            </HeaderTemplate>
            <ItemTemplate>
                <tr style="color:darkblue">
                    <td>
                        <asp:Label ID="lblItemName" runat="server" Text='<%# Eval("ItemName") %>'></asp:Label>
                        <asp:Label ID="lblItemCode" runat="server" Text='<%# Eval("ItemCode") %>'></asp:Label>
                        <asp:Label ID="lblItemDescription" runat="server" Text='<%# Eval("ItemDescription") %>'></asp:Label>
                        <asp:Label ID="lblItemPrice" runat="server" Text='<%# Eval("ItemPrice") %>'></asp:Label>
                                            <asp:ImageButton runat="server" ID="ibImage" alt="View Item" CommandName="orderDetails" CommandArgument='<%#Eval("ItemID") %>' ></asp:ImageButton>
                    </td>
                    </tr>
               <br runat="server" Visible="<%# (Container.ItemIndex % 1) == 0 %>" />

            </ItemTemplate>
        </asp:Repeater>
        </div>
            </asp:View>
                <asp:View ID="orderDetails" runat="server">
                    <div style="color: darkblue;">
                        <asp:Button ID="buttonBack" runat="server" OnClick="buttonBack_Click" Text="Back to Items" />
                    <uc1:ucOrderDetails runat="server" ID="ucOrderDetails" />
                <asp:Button ID="btnAddItemToOrder" runat="server" Text="Add Item to Order" OnClick="btnAddItemToOrder_Click"/>
                        </div>
                </asp:View>
        <asp:View ID="vwOrderConfirmation" runat="server" >
            <div style="color:darkblue;">
            <uc1:ucOrderConfirmation runat="server" id="ucOrderConfirmation" />
        </div>
       </asp:View>
        </asp:MultiView>
            </ContentTemplate>
        </asp:UpdatePanel>
    <%--Find a way to redirect to order details based on order ID. Should be good examples at work. --%>
    </asp:Content>
<%@ Page Title="Order" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Order.aspx.cs" Inherits="Printing_and_Engraving_Site.Order" %>

<%--<%@ Register Src="~/Customer/UserControls/ucOrderDetails.ascx" TagPrefix="uc1" TagName="ucOrderDetails" %>--%>


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
    
    <h2>Orders</h2>
    <div>
    
        <table>
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
                    <asp:ImageButton runat="server" ID="ibImage" />
                </td>
            </tr>
        </table>
    </div>
    <div>
        <asp:Repeater ID="repItemInformation" runat="server" OnItemCommand="repItemInformation_ItemCommand">
            <HeaderTemplate>
                <table>
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
        </table>
            </HeaderTemplate>
            <ItemTemplate>
                <tr>
                    <td>
                        <asp:Label ID="lblItemName" runat="server" Text='<%# Eval("ItemName") %>'></asp:Label>
                    </td>
                    </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblItemCode" runat="server" Text='<%# Eval("ItemCode") %>'></asp:Label>
                    </td>
                    </tr>
                <tr>
                    </tr>
                    <tr><td>
                        <asp:Label ID="lblItemDescription" runat="server" Text='<%# Eval("ItemDescription") %>'></asp:Label>
                    </td>
                                
                    </tr> <tr>
                    <td>
                        <asp:Label ID="lblItemPrice" runat="server" Text='<%# Eval("ItemPrice") %>'></asp:Label>
                    </td>
                               
                    </tr>
                <tr>
                    <td>
                        <asp:ImageButton runat="server" ID="ibImage"  CommandName="orderDetails" CommandArgument='<%#Eval("ItemID") %>' PostBackUrl="~/Customer/OrderDets.aspx"/>
                    </td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>
        </div>
    <asp:Multiview runat="server" ID="mvOrderDetails">
                <asp:View ID="orderDetails" runat="server">
                    <div>
                    <%--<uc1:ucOrderDetails runat="server" ID="ucOrderDetails" />--%>
                        </div>
                </asp:View>

    
        </asp:MultiView>
    <%--Find a way to redirect to order details based on order ID. Should be good examples at work. --%>
    </asp:Content>
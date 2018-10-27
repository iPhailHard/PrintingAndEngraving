<%@ Page Title="Order" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Order.aspx.cs" Inherits="Printing_and_Engraving_Site.Order" %>

<%@ Register Src="~/Customer/UserControls/ucOrderDetails.ascx" TagPrefix="uc1" TagName="ucOrderDetails" %>


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
    
    <asp:UpdatePanel ID="updatePanel" runat="server">
        <ContentTemplate>
    <asp:Multiview runat="server" ID="mvOrderDetails">
        <asp:View runat="server" ID="vwOrderItems">
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
                <%# (Container.ItemIndex + 1) % 1 == 0 ? "<tr>" : string.Empty %>
                
                    <td>
                        <asp:Label ID="lblItemName" runat="server" Text='<%# Eval("ItemName") %>'></asp:Label>
                    </td>
                    <td>
                
                    
                        <asp:Label ID="lblItemCode" runat="server" Text='<%# Eval("ItemCode") %>'></asp:Label>
                    </td>
                    <td>
                    
                
                    
                    
                        <asp:Label ID="lblItemDescription" runat="server" Text='<%# Eval("ItemDescription") %>'></asp:Label>
                    
                           </td>
                    <td>     
                    
                    
                        <asp:Label ID="lblItemPrice" runat="server" Text='<%# Eval("ItemPrice") %>'></asp:Label>
                    
                             </td>
                    <td>  
                    
                                            <asp:ImageButton runat="server" ID="ibImage" alt="View Item" CommandName="orderDetails" CommandArgument='<%#Eval("ItemID") %>' ></asp:ImageButton>
                    </td>
                <%# (Container.ItemIndex + 1) % 1 == 0 ? "<tr>" : string.Empty %>
            </ItemTemplate>
        </asp:Repeater>
        </div>
            </asp:View>
                <asp:View ID="orderDetails" runat="server">
                    <div>
                    <uc1:ucOrderDetails runat="server" ID="ucOrderDetails" />
                        </div>
                </asp:View>
        </asp:MultiView>
            </ContentTemplate>
        </asp:UpdatePanel>
    <%--Find a way to redirect to order details based on order ID. Should be good examples at work. --%>
    </asp:Content>
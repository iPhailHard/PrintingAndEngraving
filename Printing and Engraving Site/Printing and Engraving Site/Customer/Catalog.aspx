<%@ Page Title="Catalog" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Catalog.aspx.cs" Inherits="Printing_and_Engraving_Site.Catalog" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2 style="color:cornflowerblue"><%: Title %>.</h2>
    <h3>Check out some of our services!</h3>
    <p>These examples are just some of the items with example services we are offering to you! Proceed to our <a href="Services.aspx">Services Page</a> to see what we can do for you!</p>
    <p>&nbsp;</p>
    <p>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="ItemsCatalog">
            <Columns>
                <asp:BoundField DataField="ItemCode" HeaderText="Item Code" SortExpression="ItemCode" />
                <asp:BoundField DataField="ItemDescription" HeaderText="Item Description" SortExpression="ItemDescription" />
                <asp:BoundField DataField="ItemName" HeaderText="Item Name" SortExpression="ItemName" />
                <asp:BoundField DataField="ItemPrice" HeaderText="Item Price" SortExpression="ItemPrice" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="ItemsCatalog" runat="server" ConnectionString="Data Source=printingandengraving.database.windows.net;Initial Catalog=PrintingAndEngraving;User ID=bjaune;Password=ThisIsMyPassWord@AZURE1;MultipleActiveResultSets=True;Application Name=EntityFramework" ProviderName="System.Data.SqlClient" SelectCommand="SELECT [ItemCode], [ItemDescription], [ItemName], [ItemImage], [ItemPrice] FROM [Items] ORDER BY [ItemCode], [ItemName]"></asp:SqlDataSource>
    </p> <hr />

    <br /><br /><p>Find something you like? Don't forget to <a href="Order.aspx">Order</a> it!</p>
    

<%--    <table>
        <tr>
            <td>

    <table>
        <tr>
            <td>
            <div>
                <p>
                    T-Shirts
                </p>
            </div>
            </tr>
                <tr>
            <td>
    <div>    
    <p>
            Trophies
        </p>
    </div>
                </td>
            </tr>
        <tr>
            <td>
   <div>
    <p>
            Plaques
        </p>
    </div>
                </td>
            </tr>
    </table>
                </td>
            <td>
                                                        <div class="jumbotron">
           <p>Product displays here...</p>
        </div>
            </td>
            </tr>
        </table>--%>

</asp:Content>
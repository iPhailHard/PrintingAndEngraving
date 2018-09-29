<%@ Page Title="Catalog" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Catalog.aspx.cs" Inherits="Printing_and_Engraving_Site.Catalog" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>This is the catalog page</h3>
    <p>This is the main catalog page.</p> <hr />

    <table>
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
        </table>

</asp:Content>
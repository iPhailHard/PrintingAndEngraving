<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="userMessages.aspx.cs" Inherits="Printing_and_Engraving_Site.userMessages" %>


<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
<asp:PlaceHolder ID="phSuccessMessage" runat="server" EnableViewState="false">
    <div ID="divSuccess" style="padding: 10px; margin: 5px; border-radius: 5px; color:#3c763d; background-color: #DFF2BF; font-size: 16px; z-index:1001;">
        <asp:Label ID="lblSuccessMessage" runat="server" EnableViewState="false"></asp:Label>
        <i class="fa fa-times" style="color:gray; cursor:pointer; float:right;" title="Close message" onclick="CloseSuccessMessage()"></i>
    </div>
</asp:PlaceHolder>
    <asp:PlaceHolder ID="phErrorMessage" runat="server" EnableViewState="false">
    <div ID="divError" style="padding: 10px; margin: 5px; border-radius: 5px; color:#D8000C; background-color: ##FFBABA; font-size: 16px; z-index:1001;">
        <asp:Label ID="lblErrorMessage" runat="server" EnableViewState="false"></asp:Label>
        <i class="fa fa-times" style="color:gray; cursor:pointer; float:right;" title="Close message" onclick="CloseErrorMessage()"></i>
    </div>
</asp:PlaceHolder>
    </asp:Content>

<script type="text/javascript">
    $(document).ready(function () {
        AdjustMessage();
        $window.scroll(function (event) { AdjustMessage(); });
    });
    function AdjustMessage() {
        if ($window.ScrollTop() > 50) {
            $("divSuccess").css("position", "fixed").css("right", "10px").css("top", "10px");

            $("divError").css("position", "fixed").css("right", "10px").css("top", "10px");
        }
        else
        {
            $("divSuccess").css("position", "static");
            $("divError").css("position", "static"); //Are these supposed to be separate if statements?

        }
        
    }
    function CloseErrorMessage() {
        $("divError").slideToggle();
    };
    function CloseSuccessMessage()
    {
        $("divSuccess").slideToggle();
    }
</script>
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoadImages.aspx.cs" Inherits="Printing_and_Engraving_Site.LoadImages" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
       <style type="text/css">  
        .style1  
        {  
            width: 283px;  
        }  
        .style2  
        {  
            width: 247px;  
        }  
    </style> 
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <table style="width:100%;">  
            <tr>  
                <td class="style1">  
                    Image Name:</td>  
                <td class="style2">  
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>  
                </td>  
                <td>  
                     </td>  
            </tr>  
            <tr>  
                <td class="style1">  
                    Upload Your Image:</td>  
                <td class="style2">  
                    <asp:FileUpload ID="FileUpload1" runat="server" />  
                </td>  
                <td>  
                    <asp:Label ID="Label1" runat="server"></asp:Label>  
                </td>  
            </tr>  
            <tr>  
                <td class="style1">  
                     </td>  
                <td class="style2">  
                    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Upload" />  
                </td>  
                <td>  
                     </td>  
            </tr>  
        </table>  
        </div>
    </form>
</body>
</html>

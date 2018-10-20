<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="Printing_and_Engraving_Site.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        body{
            background-color:#5768F7;
        }
        
        h3{
            color: silver;
            font-family:'Franklin Gothic Medium', 'Arial Narrow', Arial, sans-serif;
            font-size:85px;
            font-weight:bold;
            position:fixed;
            top:15px;
            left:700px;
        }

        h4{
            color: silver;
            font-family:'Franklin Gothic Medium', 'Arial Narrow', Arial, sans-serif;
            font-size:50px;
            font-weight:bold;

        }

        address{
            color: silver;
            font-family:'Franklin Gothic Medium', 'Arial Narrow', Arial, sans-serif;
            font-size:25px;
            font-weight:bold;
        }
        label{
            color: silver;
            font-family:'Franklin Gothic Medium', 'Arial Narrow', Arial, sans-serif;
            font-size:25px;
            font-weight:bold;
        }

    </style>
    <h3>Contact Us</h3>
    <address>
        3221 Paladin Ave<br />
        Lake Geneva, Wisconsin 53147<br />
        <abbr title="Phone">Phone Number:</abbr>
        (262) 727-1938
    </address>

    <h4>Hours</h4>
    <table>
        <thead>
            <tr>
            <th>Monday</th>
                 <td> 9:30 AM - 6:00 PM</td>
                </tr>
            <tr>
                <th>Tuesday</th>
             <td> 9:30 AM - 6:00 PM</td>
                </tr>
            <tr>
            <th>Wednesday</th>
                 <td> 9:30 AM - 6:00 PM</td>
                </tr>
            <tr>
            <th>Thursday</th>
                 <td> 9:30 AM - 6:00 PM</td>
                </tr>
            <tr>
            <th>Friday</th>
                 <td> 9:30 AM - 6:00 PM</td>
                </tr>
            <tr>
            <th>Saturday</th>
            <td>10:00 AM - 3:00 PM</td>

                </tr>
            <tr>
            <th>Sunday</th>
            <td>      CLOSED      </td>
                </tr>
        </thead>
    </table>

    <div class="container">
<%--  <form action="action_page.php">

    <label for="fname">First Name</label>
    <input type="text" id="fname" name="firstname" placeholder="Your name..">

    <label for="lname">Last Name</label>
    <input type="text" id="lname" name="lastname" placeholder="Your last name..">

    <label for="country">Country</label>
    <select id="country" name="country">
      <option value="australia">Australia</option>
      <option value="canada">Canada</option>
      <option value="usa">USA</option>
    </select>

    <label for="subject">Subject</label>
    <textarea id="subject" name="subject" placeholder="Write something.." style="height:200px"></textarea>

    <input type="submit" value="Submit">

  </form>--%>
</div>

    <%--<address>
        <strong>Support:</strong>   <a href="mailto:Support@example.com">Support@example.com</a><br />
        <strong>Marketing:</strong> <a href="mailto:Marketing@example.com">Marketing@example.com</a>
    </address>--%>


</asp:Content>

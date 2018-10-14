<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="Printing_and_Engraving_Site.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Contact Us</h3>
    <address>
        3221 Paladin Avenue,<br />
        Lake Geneva, WI 53147-6399<br />
        <abbr title="Phone">P:</abbr>
        (262) 727-1938
        <abbr title="Fax">F:</abbr>
        (262) 727-1940
    </address>

    <h3>Hours</h3>
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

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="Employee_Project.Profile" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>My Profile</title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="text-align:center; margin-top:50px;">
            <h2>My Profile</h2>
            <hr />
            <p><strong>Name:</strong> <asp:Label ID="lblName" runat="server" /></p>
            <p><strong>Phone:</strong> <asp:Label ID="lblPhone" runat="server" /></p>
            <p><strong>Email:</strong> <asp:Label ID="lblEmail" runat="server" /></p>
            <br />
            <asp:Button ID="btnBack" runat="server" Text="Back to Home" OnClick="btnBack_Click" />
        </div>
    </form>
</body>
</html>

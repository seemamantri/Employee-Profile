<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Employee_Project.Home" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Home Page</title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="text-align:center; margin-top:50px;">
            <h2>Welcome to Employee System</h2>
            <h4><asp:Label ID="lblUser" runat="server"></asp:Label></h4>
            <br />
            <asp:Button ID="btnProfile" runat="server" Text="View Profile" OnClick="btnProfile_Click" />
            &nbsp;&nbsp;
            <asp:Button ID="btnLogout" runat="server" Text="Logout" OnClick="btnLogout_Click" />
           

        </div>
    </form>
</body>
</html>
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Employee_Project.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="text-align:center;margin-top=50px;">
            <h2>Employee Login</h2>

            Email:<asp:TextBox ID="txtEmail" runat="server"></asp:TextBox><br /><br />
            Phone:<asp:TextBox ID="txtPhone" runat="server"></asp:TextBox><br /><br />

            <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" /><br /><br />

            <button type="button" onclick="location.href='Register.aspx'">Back to Registration Page</button>



            <asp:Label ID="lblMsg" runat="server" ForeColor="Red"></asp:Label>
        </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Employee_Project.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>User Registration</title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="text-align:center;margin-top:50px;">
            <h2>Employee Registration</h2>
            Name:<asp:TextBox ID="txtName" runat="server"></asp:TextBox><br /><br />
            Phone:<asp:TextBox ID="txtPhone" runat="server"></asp:TextBox><br /><br />
            Email:<asp:TextBox ID="txtEmail" runat="server"></asp:TextBox><br /><br />

            <asp:Button ID="btnSave" runat="server" Text="save" OnClick="btnSave_Click" /><br /><br />

            <button type="button" onclick="location.href='Login.aspx'">Go to Login Page</button>

            <asp:Label ID="lblMsg" runat="server" ForeColor="Green"></asp:Label>
        

        </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="WebApplication8.Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="StyleSheet1.css" rel="stylesheet" type="text/css">
    <title></title>
</head>
<body>
    <img src="justGrace.png" alt="logo">
    <div class='login-page'>
        <form class="form" runat="server">
            <div>
            </div>
            <p>
                Enter Student Details Below
            </p>
            <p>
                <br />
                Student First Name:<br />
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <br />
                Student Surname:
            </p>
            <p>
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </p>
            <p>
                Password:
            </p>
            <p>
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            </p>
            <p>
                Select Guardian:
            </p>
            <p>
                <asp:DropDownList ID="DropDownList1" runat="server">
                </asp:DropDownList>
            </p>
            <p>
                <asp:Button ID="Button1" runat="server" Text="Register" OnClick="Button1_Click" />
                <asp:Button ID="Button2" runat="server" Text="Discard" OnClick="Button2_Click" />
            </p>
        </form>
    </div>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GuardianSignUp.aspx.cs" Inherits="WebApplication8.GuardianSignUp" %>

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
                Enter Guardian Details Below
            </p>
            <p>
                Guardian First Name:
            </p>
            <p>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </p>
            <p>
                Guardian Surname:
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
                Email Address:
            </p>
            <p>
                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            </p>
            <p>
                Physical Address:
            </p>
            <p>
                <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            </p>
            <p>
                Contact Number:
            </p>
            <p>
                <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
            </p>
            <p>
                ID Number:
            </p>
            <p>
                <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
            </p>
            <p>
                <asp:Button ID="Button1" runat="server" Text="Register" OnClick="Button1_Click" />
                <asp:Button ID="Button2" runat="server" Text="Discard" OnClick="Button2_Click" />
            </p>

        </form>
    </div>
</body>
</html>

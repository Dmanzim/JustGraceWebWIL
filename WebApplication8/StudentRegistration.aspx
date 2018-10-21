<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentRegistration.aspx.cs" Inherits="WebApplication8.Registration" %>

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
                <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
            </p>
            <p>
                Guardian Surname:
            </p>
            <p>
                <asp:TextBox ID="txtSurname" runat="server"></asp:TextBox>
            </p>
            <p>
                Password:
            </p>
            <p>
                <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
            </p>
            <p>
                Email Address:
            </p>
            <p>
                <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            </p>
            <p>
                Physical Address:
            </p>
            <p>
                <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
            </p>
            <p>
                Contact Number:
            </p>
            <p>
                <asp:TextBox ID="txtContactNo" runat="server"></asp:TextBox>
            </p>
            <p>
                ID Number:
            </p>
            <p>
                <asp:TextBox ID="txtIdNumber" runat="server"></asp:TextBox>
            </p>
            <p>
                <asp:Button ID="btnRegister" runat="server" Text="Register" OnClick="Button1_Click" BackColor="#99CCFF" />
                <asp:Button ID="btnDiscard" runat="server" Text="Discard" OnClick="Button2_Click" BackColor="#99CCFF" />
            </p>
            <p>
                <asp:Label ID="lblRegisterSuccess" runat="server"></asp:Label>
            </p>

        </form>
    </div>
</body>
</html>

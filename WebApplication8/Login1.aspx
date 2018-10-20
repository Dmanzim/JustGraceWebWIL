<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login1.aspx.cs" Inherits="WebApplication8.Tester" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="StyleSheet1.css" rel="stylesheet" type="text/css">
    <title></title>
</head>
<body>
    <img src="justGrace.png" alt="logo">
    <form class="form" runat="server">
        <div>
        </div>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:wil3ConnectionString %>" SelectCommand="SELECT * FROM [tbl_AbuseReport]"></asp:SqlDataSource>
        <br />
        Username:<br />
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        Password:<br />
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="btnLogin" runat="server" Text="Login" />
        <br />
        <asp:Button ID="btnRegistration" runat="server" OnClick="btnRegistration_Click" Text="Register" />
        <br />
        <br />
        <br />
        <br />
    </form>
</body>
</html>

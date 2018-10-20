<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplication8.Tester" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="StyleSheet1.css" rel="stylesheet" type="text/css">
    <title></title>
</head>
<body>
    <img src="justGrace.png" alt="logo">
    <div>
            <form class="form" runat="server">
                <div>               
                
                        <br />
                        Username:<br />
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                        <br />
                        Password:<br />
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                        <br />
                        <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" BackColor="#99CCFF" />
                        <br />
                        <asp:Button ID="btnRegistration" runat="server" OnClick="btnRegistration_Click" Text="Register" BackColor="#99CCFF" />
                        <br />
                        <br />
                        <br />
                        <br />
                    </div>
            </form>
        </div>
</body>
</html>

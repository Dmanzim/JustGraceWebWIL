<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RecordEducator.aspx.cs" Inherits="WebApplication8.RecordEducator" %>

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
                Record Educator:
            </p>
            <p>
                First Name:
            </p>
            <p>
                <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
            </p>
            <p>
                Last Name:
            </p>
            <p>
                <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
            </p>
            <p>
                Contact Number:
            </p>
            <p>
                <asp:TextBox ID="txtContactNumber" runat="server"></asp:TextBox>
            </p>
            <p>
                Email Address:
            </p>
            <p>
                <asp:TextBox ID="txtEmailAddress" runat="server" OnTextChanged="TextBox4_TextChanged"></asp:TextBox>
            </p>
            <p>
                National ID:
            </p>
            <p>
                <asp:TextBox ID="txtNationalId" runat="server"></asp:TextBox>
            </p>
            <p>
                Password:
            </p>
            <p>
                <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
            </p>
            <p>
                <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="Button1_Click" BackColor="#99CCFF" />
                <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="Button2_Click" BackColor="#99CCFF" />
            </p>
        </form>
    </div>
</body>
</html>

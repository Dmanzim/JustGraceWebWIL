<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MissingStudents.aspx.cs" Inherits="WebApplication8.MissingStudents" %>

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
                Record Missing Students:
            </p>
            <p>
                Please note a message will be sent to the guardian regarding their childs missed session.
            </p>
            <p>
                Lesson Date:
            </p>
            <p>
                <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
            </p>
            <p>
                Lesson Missed:
            </p>
            <p>
                <asp:DropDownList ID="DropDownList1" runat="server">
                </asp:DropDownList>
            </p>
            <p>
                Student Name:
            </p>
            <asp:BulletedList ID="BulletedList1" runat="server">
                <asp:ListItem>Student Name0</asp:ListItem>
                <asp:ListItem>StudentName1</asp:ListItem>
                <asp:ListItem>StudentName2</asp:ListItem>
            </asp:BulletedList>
            <asp:Button ID="Button1" runat="server" Text="Record" OnClick="Button1_Click" />
            <asp:Button ID="Button2" runat="server" Text="Cancel" OnClick="Button2_Click" />
            <br />
        </form>
    </div>
</body>
</html>

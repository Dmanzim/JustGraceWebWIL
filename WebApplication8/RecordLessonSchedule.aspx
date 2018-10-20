<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RecordLessonSchedule.aspx.cs" Inherits="WebApplication8.RecordLessonSchedule" %>

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
                Record Lesson Schedule:
            </p>
            <p>
                Please note that all students will be able to see these:
            </p>
            <p>
                Lesson Date:
            </p>
            <p>
                <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
            </p>
            <p>
                Description:
            </p>
            <p>
                <asp:TextBox ID="TextBox1" runat="server" Height="53px" Width="362px"></asp:TextBox>
            </p>
            <p>
                Duration in hours:
            </p>
            <p>
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </p>
            <p>
                Teacher:
            </p>
            <p>
                <asp:DropDownList ID="DropDownList1" runat="server">
                </asp:DropDownList>
            </p>
            <p>
                <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="Button1_Click" BackColor="#99CCFF" />
                <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="Button2_Click" BackColor="#99CCFF" />
            </p>

        </form>
    </div>
</body>
</html>

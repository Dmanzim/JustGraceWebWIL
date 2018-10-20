<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AbuseReport.aspx.cs" Inherits="WebApplication8.AbuseReport" %>

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
                Record Abuse Reports Below:
            </p>
            <p>
                Please note that all of this information is confidential and will be kept between you and the Student.
            </p>
            <p>
                Student Name:
            </p>
            <%--<p>--%>
                <asp:DropDownList ID="DropDownList1" runat="server">
                </asp:DropDownList>
            </p>
            <p>
                Description:
            </p>
            <p>
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </p>
            <p>
                Action Taken:
            </p>
            <p>
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            </p>
            <p>
                Comments:
            </p>
            <p>
                <asp:TextBox ID="TextBox4" runat="server" Height="74px" Width="360px"></asp:TextBox>
            </p>
            <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="Button1_Click" BackColor="#99CCFF" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="Button2_Click" BackColor="#99CCFF" />
        </form>
    </div>
</body>
</html>

﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PushNotification.aspx.cs" Inherits="WebApplication8.PushNotification" %>

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
                Push Notifications:<br />
                Please note that this information will be sent out to the andriod users:<br />
                <br />
                Date to Send:<br />
                <asp:Calendar ID="calDateToSend" runat="server"></asp:Calendar>
                <br />
                Description:<br />
                <asp:TextBox ID="txtDescription" runat="server" Height="17px" Width="361px"></asp:TextBox>
                <br />
                Message:<br />
                <asp:TextBox ID="txtMessage" runat="server" Height="58px" Width="361px"></asp:TextBox>
                <br />
                Recipients:<br />
                <asp:CheckBoxList ID="chkboxLstSendTo" runat="server" ValidateRequestMode="Disabled" Width="383px">
                    <asp:ListItem>Students</asp:ListItem>
                    <asp:ListItem>Guardians</asp:ListItem>
                    <asp:ListItem>Staff</asp:ListItem>
                </asp:CheckBoxList>
                <br />
                <br />
                <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="Button1_Click" BackColor="#99CCFF" />
                <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="Button2_Click" BackColor="#99CCFF" />
                <br />
            </div>
        </form>
    </div>
</body>
</html>

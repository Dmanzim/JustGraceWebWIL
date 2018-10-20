﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MissingStudents.aspx.cs" Inherits="WebApplication8.MissingStudents" %>

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
                <asp:Calendar ID="calLessonDate" runat="server"></asp:Calendar>
            </p>
            <p>
                Lesson Missed:
            </p>
            <p>
                <asp:DropDownList ID="ddlLesson" runat="server">
                </asp:DropDownList>
            </p>
            <p>
                Student Name:
            </p>
            <p>
            <asp:DropDownList ID="ddlStudentName" runat="server">
                </asp:DropDownList>
                </p>
            <br />
            <asp:Button ID="btnRecord" runat="server" Text="Record" OnClick="Button1_Click" BackColor="#99CCFF" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="Button2_Click" BackColor="#99CCFF" />
                
            <br />
        </form>
    </div>
</body>
</html>

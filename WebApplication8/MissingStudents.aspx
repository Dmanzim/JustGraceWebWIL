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
                Record Student Attendance:
            </p>
            <p>
                Please note a message will be sent to the guardian regarding their childs missed session.
            </p>
            <p>
                Lesson Date:
            </p>
            <p>
                <asp:Calendar ID="calLessonDate" runat="server" OnSelectionChanged="calLessonDate_SelectionChanged"></asp:Calendar>
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
            <p>
                Attended:<br>
                <asp:DropDownList ID="ddlAttended" runat="server" OnSelectedIndexChanged="ddlAttended_SelectedIndexChanged">
                    <asp:ListItem Value="0">Did not attend</asp:ListItem>
                    <asp:ListItem Value="1">Attended</asp:ListItem>
                </asp:DropDownList>
            </p>
            <br />
            <asp:Button ID="btnRecord" runat="server" Text="Record" OnClick="btnRecord_Click" BackColor="#99CCFF" /><br>
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="Button2_Click" BackColor="#99CCFF" />
                
            <br />
        </form>
    </div>
</body>
</html>

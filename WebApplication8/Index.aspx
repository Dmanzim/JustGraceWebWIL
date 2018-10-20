<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="WebApplication8.Index" %>

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
            Index:<br />
            <br>
            <asp:Button ID="BtnAbuseReport" runat="server" Text="Abuse Report" OnClick="BtnAbuseReport_Click" BackColor="#99CCFF" />
            <br>
            <asp:Button ID="btnGuardianSignUp" runat="server" Text="Guardian Sign Up" OnClick="btnGuardianSignUp_Click" BackColor="#99CCFF" />
            <br>
            <asp:Button ID="btnMissingStudents" runat="server" Text="Missing Students" OnClick="btnMissingStudents_Click" BackColor="#99CCFF" />
            <br>
            <asp:Button ID="btnPushNotification" runat="server" Text="Push Notification" OnClick="btnPushNotification_Click" BackColor="#99CCFF" />
            <br>
            <asp:Button ID="btnRecordEducator" runat="server" Text="Record Educator" OnClick="btnRecordEducator_Click" BackColor="#99CCFF" />
            <br />
            <asp:Button ID="btnRecordLessonSchedule" runat="server" Text="Record Lesson Schedule" OnClick="btnRecordLessonSchedule_Click" BackColor="#99CCFF" />
            <br />
            <asp:Button ID="btnRegistration" runat="server" Text="Registration" OnClick="btnRegistration_Click" BackColor="#99CCFF" />
            <br>
        </form>
    </div>
</body>
</html>

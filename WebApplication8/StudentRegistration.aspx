<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentRegistration.aspx.cs" Inherits="WebApplication8.Registration" %>

<!DOCTYPE html>

<html>
<title>JustGrace</title>
<meta name="viewport" content="width=device-width, initial-scale=1">
<link rel="stylesheet" href="StyleSheet1.css">
    <body>

<link href="//maxcdn.bootstrapcdn.com/bootstrap/3.3.0/css/bootstrap.min.css" rel="stylesheet" id="bootstrap-css">
<script src="//maxcdn.bootstrapcdn.com/bootstrap/3.3.0/js/bootstrap.min.js"></script>
<script src="//code.jquery.com/jquery-1.11.1.min.js"></script>

   <div id="wrapper">

        
                <div id="sidebar-wrapper">
            <ul class="sidebar-nav">
                <li class="sidebar-brand">
                    <a href="#">
                        JustGrace
                    </a>
                </li>
                <li>
                    <a href="<%= Page.ResolveUrl("~//Login.aspx") %>">Login</a>
                </li>
                <li>
                    <a href="<%= Page.ResolveUrl("~//AbuseReport.aspx") %>">Record Abuse Report</a>
                </li>
                <li>
                    <a href="<%= Page.ResolveUrl("~//GuardianSignUp.aspx") %>">Guardian Sign Up</a>
                </li>                
                <li>
                    <a href="<%= Page.ResolveUrl("~//Attendance.aspx") %>">Student Attendance</a>
                </li>
                <li>
                   <a href="<%= Page.ResolveUrl("~//PushNotification.aspx") %>" >Create Push Notification</a>
                </li>
                <li>
                   <a href="<%= Page.ResolveUrl("~//RegisterEmployee.aspx") %>">Employee Registration</a>
                </li>
                <li>
                   <a href="<%= Page.ResolveUrl("~//StudentRegistration.aspx") %>">Student Registration</a>
                </li>                
                <li>
                    <div class="dropdown">
  <span>Reports</span>
  <div class="dropdown-content">
    <p><a href="<%= Page.ResolveUrl("~//RptAttendance.aspx") %>">Attendance</a</p>
      <p><a href="<%= Page.ResolveUrl("~//RptAbuse.aspx") %>">Abuse</a</p>
      <p><a href="<%= Page.ResolveUrl("~//RptLessons.aspx") %>">Lessons</a</p>
      <p><a href="<%= Page.ResolveUrl("~//RptStudents.aspx") %>">Students</a</p>
      
      
  </div>
</div>
                </li>
                <li>
                   <a href="<%= Page.ResolveUrl("~//Login.aspx") %>">Logout</a>
                </li> 
            </ul>
        </div>
        
        <div id="page-content-wrapper">
            <div class="container-fluid">
                <div class="row">


   <img src="justGrace.png" alt="logo">
                    <div class="col-lg-12">
                        <a href="#menu-toggle" class="btn btn-default" id="menu-toggle">Toggle Menu</a>
                    </div>
        <form class="form" runat="server">
            <div>
            </div>
            <p>
                <h2>Register Student:</h2>
            </p>
            <p>
                Enter Guardian Details Below
            </p>
            <p>
                Guardian First Name:
            </p>
            <p>
                <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
            </p>
            <p>
                Guardian Surname:
            </p>
            <p>
                <asp:TextBox ID="txtSurname" runat="server"></asp:TextBox>
            </p>
            <p>
                Password:
            </p>
            <p>
                <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
            </p>
            <p>
                Email Address:
            </p>
            <p>
                <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            </p>
            <p>
                Guardian:
            </p>
            <p>
                <asp:DropDownList ID="ddlGuardian" runat="server" Width="155px"></asp:DropDownList>
            </p>
            <p>
                <asp:Button ID="btnRegister" runat="server" Text="Register" OnClick="Button1_Click" BackColor="#99CCFF" />
                <asp:Button ID="btnDiscard" runat="server" Text="Discard" OnClick="Button2_Click" BackColor="#99CCFF" />
            </p>
            <p>
                <asp:Label ID="lblRegisterSuccess" runat="server"></asp:Label>
            </p>

        </form>
    </div>
</body>
</html>

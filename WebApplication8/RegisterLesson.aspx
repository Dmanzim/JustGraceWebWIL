<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterLesson.aspx.cs" Inherits="WebApplication8.RecordLessonSchedule" %>

<!DOCTYPE html>
<html>
<title>W3.CSS</title>
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
                    <a href="<%= Page.ResolveUrl("~//AbuseReport.aspx") %>">Abuse Report</a>
                </li>
                <li>
                    <a href="<%= Page.ResolveUrl("~//GuardianSignUp.aspx") %>">Guardian Sign Up</a>
                </li>
                <li>
                    <a href="<%= Page.ResolveUrl("~//Login.aspx") %>">Login</a>
                </li>
                <li>
                    <a href="<%= Page.ResolveUrl("~//MissingStudents.aspx") %>">Missing Student</a>
                </li>
                <li>
                   <a href="<%= Page.ResolveUrl("~//PushNotification.aspx") %>" >Push Notifications</a>
                </li>
                <li>
                   <a href="<%= Page.ResolveUrl("~//RecordEducator.aspx") %>">Record Educator</a>
                </li>
                <li>
                   <a href="<%= Page.ResolveUrl("~//Registration.aspx") %>">Registration</a>
                </li>
                <li>
                   <a href="<%= Page.ResolveUrl("~//Reporting.aspx") %>">Reporting</a>
                </li>
                <li>
                    <div class="dropdown">
  <span>Reports</span>
  <div class="dropdown-content">
    <p>Report1</p>
      <p>Report2</p>
      <p>Report3</p>
      
      
  </div>
</div>
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
                Record Lesson Schedule:
            </p>
            <p>
                Please note that all students will be able to see these:
            </p>
            <p>
                Lesson Date:
            </p>
            <p>
                <asp:Calendar ID="calLessonDate" runat="server"></asp:Calendar>
            </p>
            <p>
                Description:
            </p>
            <p>
                <asp:TextBox ID="txtDescription" runat="server" Height="53px" Width="362px"></asp:TextBox>
            </p>
            <p>
                Duration in hours:
            </p>
            <p>
                <asp:TextBox ID="txtHours" runat="server"></asp:TextBox>
            </p>
            <p>
                Teacher:
            </p>
            <p>
                <asp:DropDownList ID="ddlTeacher" runat="server">
                </asp:DropDownList>
            </p>
            <p>
                <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="Button1_Click" BackColor="#99CCFF" />
                <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="Button2_Click" BackColor="#99CCFF" />
            </p>

        </form>
					
					
					
					
					
					
					
					
					
					
                </div>
            </div>
        </div>

    </div>
    <script>
    $("#menu-toggle").click(function(e) {
        e.preventDefault();
        $("#wrapper").toggleClass("toggled");
    });
    </script>

<div class="w3-container" style="margin-left:160px">
</div>

<script>
function myAccFunc() {
    var x = document.getElementById("demoAcc");
    if (x.className.indexOf("w3-show") == -1) {
        x.className += " w3-show";
        x.previousElementSibling.className += " w3-green";
    } else { 
        x.className = x.className.replace(" w3-show", "");
        x.previousElementSibling.className = 
        x.previousElementSibling.className.replace(" w3-green", "");
    }
}

function myDropFunc() {
    var x = document.getElementById("demoDrop");
    if (x.className.indexOf("w3-show") == -1) {
        x.className += " w3-show";
        x.previousElementSibling.className += " w3-green";
    } else { 
        x.className = x.className.replace(" w3-show", "");
        x.previousElementSibling.className = 
        x.previousElementSibling.className.replace(" w3-green", "");
    }
}
</script>

</body>
</html>


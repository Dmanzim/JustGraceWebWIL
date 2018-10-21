<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RptAbuse.aspx.cs" Inherits="WebApplication8.RptAbuse" %>

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
                   <a href="<%= Page.ResolveUrl("~//RegisterEmployee.aspx") %>">Record Educator</a>
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
    <p><a href="<%= Page.ResolveUrl("~//RptAttendance.aspx") %>">Attendance</a</p>
      <p><a href="<%= Page.ResolveUrl("~//RptAbuse.aspx") %>">Abuse</a</p>
      <p><a href="<%= Page.ResolveUrl("~//RptLessons.aspx") %>">Lessons</a</p>
      
      
  </div>
</div>
                </li>
            </ul>
        </div>
        
        <div id="page-content-wrapper">
            <div class="container-fluid">
                <div class="row">
                    
					
					
					
					
					
					
					
					
				<div class = 'auto-style1'>
        <form class="form1"  runat="server">
            <div>
    <img src="justGrace.png" alt="logo" class="auto-style6">
                <br />
                <asp:Button ID="btnStudentFilter" runat="server" Text="Enable/Disable Student Filter" OnClick="btnStudentFilter_Click" />
                <br />
                <br />
                <asp:Button ID="btnDateFilter" runat="server" Text="Enable/Disable Date Filter" OnClick="btnDateFilter_Click" Width="256px" />
                <br />
                <br />
                <asp:Label ID="Label1" runat="server" Text="Student :"></asp:Label>
                <br />
                <asp:DropDownList ID="ddlStudent" runat="server" Width="187px"></asp:DropDownList>
                <br />
                <br />
                <div class="auto-style2">
                
                        <div id="date1" class="auto-style5"> 
                            <asp:Label ID="Label2" runat="server" Text="Date From :"></asp:Label>
                            <asp:Calendar ID="CalDateFrom" runat="server"></asp:Calendar>
                        </div>
                        <div id="date2" class="auto-style3">
                            <asp:Label ID="Label3" runat="server" Text="Date To :"></asp:Label>
                            <asp:Calendar ID="CalDateTo" runat="server"></asp:Calendar>                            
                        </div>
                    <br />
                            
                    
                        <br />
                        <br />
                </div>
                <asp:Button ID="btnRefresh" runat="server" Text="Refresh" OnClick="btnRefresh_Click" />
            </div>
            <br />
            <br />
            <asp:GridView ID="gvAbuse" runat="server" Height="331px" Width="915px" CssClass="auto-style7"></asp:GridView>
        </form>
    </div>
    	
					
    



					
					
					
					
					
					
					
					
					
					
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


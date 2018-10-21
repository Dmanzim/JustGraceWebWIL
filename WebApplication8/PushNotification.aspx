<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PushNotification.aspx.cs" Inherits="WebApplication8.PushNotification" %>

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
                   <a href="<%= Page.ResolveUrl("~//RegisterEmployee.aspx") %>">Register Employee</a>
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
                    
					
					
					
					
					
					
					
					
					
					
					
					
					
				
    
    
    
   
    <img src="justGrace.png" alt="logo">
                    <div class="col-lg-12">
                        <a href="#menu-toggle" class="btn btn-default" id="menu-toggle">Toggle Menu</a>
                    </div>
        <form class="form" runat="server">
            <div>
                <h2>Push Notifications:</h2><br />
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
                <br />
                Recipients:<br />
                <asp:CheckBox ID="chkSendToStudent" runat="server" Text="Send To Student" />
                <br />
                <asp:CheckBox ID="chkSendToGuardian" runat="server" Text="Send To Guardian" />
                <br />
                <asp:CheckBox ID="chkSendToEmployee" runat="server" Text="Send To Employee" />
                <br />
                <br />
                <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="Button1_Click" BackColor="#99CCFF" Width="252px" />
                <br />
                <br />
                <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="Button2_Click" BackColor="#99CCFF" Width="251px" />
                <br />
            </div>
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
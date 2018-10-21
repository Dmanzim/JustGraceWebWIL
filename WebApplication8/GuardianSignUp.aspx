<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GuardianSignUp.aspx.cs" Inherits="WebApplication8.GuardianSignUp" %>

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
                Physical Address:
            </p>
            <p>
                <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
            </p>
            <p>
                Contact Number:
            </p>
            <p>
                <asp:TextBox ID="txtContactNo" runat="server"></asp:TextBox>
            </p>
            <p>
                ID Number:
            </p>
            <p>
                <asp:TextBox ID="txtIdNumber" runat="server"></asp:TextBox>
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

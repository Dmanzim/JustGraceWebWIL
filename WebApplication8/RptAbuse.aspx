<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RptAbuse.aspx.cs" Inherits="WebApplication8.RptAbuse" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="StyleSheet1.css" rel="stylesheet" type="text/css">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 837px;
            padding: 2% 0 0;
            margin: 0px auto auto auto;
        }
        .auto-style2 {
            height: 60px;
            width: 696px;
        }
        .auto-style3 {
            position: relative;
            left: 602px;
            top: -347px;
            width: 312px;
        }
        .auto-style5 {
            position: relative;
            left: 277px;
            top: -147px;
            width: 312px;
        }
        .auto-style6 {
            width: 223px;
            height: 111px;
        }
        .auto-style7 {
            margin-right: 0px;
        }
    </style>
</head>
<body>
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
    

&nbsp;
</body>
</html>

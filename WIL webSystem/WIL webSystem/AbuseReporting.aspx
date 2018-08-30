<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AbuseReporting.aspx.cs" Inherits="WIL_webSystem.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Record Abuse repors below:</h2>
    <p>Please note that all of this information is confidential and will be kept between you and the Student.        
    </p><br />
    
        <h4>Student Name:</h4>
        <asp:DropDownList ID="DropDownList1" runat="server" Height="16px" Width="361px">
        </asp:DropDownList>
        <br />
        <h4>Description :</h4>
        <asp:TextBox ID="TextBox1" runat="server" Width="680px"></asp:TextBox>
        <br />
        <h4>Action Taken :</h4>
        <asp:TextBox ID="TextBox2" runat="server" Width="680px" Height="18px"></asp:TextBox>
        <br />
        <h4>Comments :</h4>
        <asp:TextBox ID="TextBox3" runat="server" Width="678px" Height="84px"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="Button1" runat="server" Text="Save" Height="39px" Width="112px" />  <asp:Button ID="Button2" runat="server" Text="Cancel" Height="39px" Width="112px" />
    </p>
</asp:Content>

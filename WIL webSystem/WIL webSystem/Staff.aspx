<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Staff.aspx.cs" Inherits="WIL_webSystem.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Record Educator:</h2>
    <br />
    
        <h4>First Name:</h4>
        <asp:TextBox ID="TextBox4" runat="server" Width="285px"></asp:TextBox>
        <br />
        <h4>Last Name:</h4>
        <asp:TextBox ID="TextBox5" runat="server" Width="285px"></asp:TextBox>
        <br />
        <h4>Contact Number:</h4>
        <asp:TextBox ID="TextBox6" runat="server" Width="285px"></asp:TextBox>
        <br />
        <h4>Email Address:</h4>
        <asp:TextBox ID="TextBox7" runat="server" Width="285px"></asp:TextBox>
        <br />
        <h4>National ID :</h4>
        <asp:TextBox ID="TextBox1" runat="server" Width="285px"></asp:TextBox>
        <br />
        <h4>Password :</h4>
        <asp:TextBox ID="TextBox2" runat="server" Width="283px" Height="18px"></asp:TextBox>
        <br />   
        <h4>Salary :</h4>
        <asp:TextBox ID="TextBox3" runat="server" Width="283px" Height="18px"></asp:TextBox>
        <br /> 
    </p>
    <p>
        <asp:Button ID="Button1" runat="server" Text="Save" Height="39px" Width="112px" />  <asp:Button ID="Button2" runat="server" Text="Cancel" Height="39px" Width="112px" />
    </p>
</asp:Content>

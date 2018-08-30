<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Lessons.aspx.cs" Inherits="WIL_webSystem.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Record Lesson Schedule :</h2>
    <p>Please note that all students will be able to see these:</p><br />
    
        <h4>Lesson Date :</h4>
        <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
        <br />
        <h4>Description :</h4>
        <asp:TextBox ID="TextBox1" runat="server" Width="680px" Height="65px"></asp:TextBox>
        <br />
        <h4>Duration in hours :</h4>
        <asp:TextBox ID="TextBox2" runat="server" Width="175px"></asp:TextBox>
        <br />
        <h4>Teacher :</h4>
        <asp:DropDownList ID="DropDownList1" runat="server" Height="19px" Width="416px"></asp:DropDownList>
    </p>
    <p>
        <asp:Button ID="Button1" runat="server" Text="Save" Height="39px" Width="112px" />  <asp:Button ID="Button2" runat="server" Text="Cancel" Height="39px" Width="112px" />
    </p>
</asp:Content>

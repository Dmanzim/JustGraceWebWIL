<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PushNotification.aspx.cs" Inherits="WIL_webSystem.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Push Notifications:</h2>
    <p>Please note that this information will be sent out to the android users :        
    </p><br />
    
        <h4>Date to Send :</h4>
        <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
        <br />
        <h4>Description :</h4>
        <asp:TextBox ID="TextBox1" runat="server" Width="680px"></asp:TextBox>
        <br />
        <h4>Message :</h4>
        <asp:TextBox ID="TextBox2" runat="server" Width="680px" Height="65px"></asp:TextBox>
        <br />
        <h4>Recipients :</h4>
        <asp:CheckBox ID="Students" runat="server" /><br />
        <asp:CheckBox ID="Guardians" runat="server" /><br />
        <asp:CheckBox ID="Staff" runat="server" />
    </p>
    <p>
        <asp:Button ID="Button1" runat="server" Text="Save" Height="39px" Width="112px" />  <asp:Button ID="Button2" runat="server" Text="Cancel" Height="39px" Width="112px" />
    </p>
</asp:Content>

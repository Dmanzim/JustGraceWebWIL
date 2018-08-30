<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AttendanceRecord.aspx.cs" Inherits="WIL_webSystem.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Record Missing Students:</h2>
    <p>Please note a message will be sent to the guardian regarding their childs missed session.</p><br />
        <h4>Lesson Date :</h4>
        <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
        <br />
        <h4>Lesson Missed :</h4>
        <asp:DropDownList ID="DropDownList1" runat="server" Height="16px" Width="361px">
        </asp:DropDownList>
        <br />
        <h4>Student Name :</h4>
        <asp:CheckBoxList ID="CheckBoxList1" runat="server">
            <asp:ListItem>Paul Hill</asp:ListItem>
            <asp:ListItem>Tim Chandler</asp:ListItem>
            <asp:ListItem>Matthew Till</asp:ListItem>
            <asp:ListItem>Deven Myberg</asp:ListItem>
    </asp:CheckBoxList>       
    </p>
    <p>
        <asp:Button ID="btnAttendanceRecord" runat="server" Text="Record" Height="39px" Width="112px" OnClick="btnAttendanceRecord_Click" />  <asp:Button ID="Button2" runat="server" Text="Cancel" Height="39px" Width="112px" />
    </p>
</asp:Content>

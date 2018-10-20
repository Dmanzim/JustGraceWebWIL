<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Tester.aspx.cs" Inherits="WebApplication8.Tester" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <img src="justGrace.png" alt="logo">
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="fld_AbuseID" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="fld_AbuseID" HeaderText="fld_AbuseID" ReadOnly="True" SortExpression="fld_AbuseID" />
                <asp:BoundField DataField="fld_Description" HeaderText="fld_Description" SortExpression="fld_Description" />
                <asp:BoundField DataField="fld_ActionTaken" HeaderText="fld_ActionTaken" SortExpression="fld_ActionTaken" />
                <asp:BoundField DataField="fld_Comment" HeaderText="fld_Comment" SortExpression="fld_Comment" />
                <asp:BoundField DataField="fld_Date" HeaderText="fld_Date" SortExpression="fld_Date" />
                <asp:BoundField DataField="fld_RecordedBy" HeaderText="fld_RecordedBy" SortExpression="fld_RecordedBy" />
                <asp:BoundField DataField="fld_StudentID" HeaderText="fld_StudentID" SortExpression="fld_StudentID" />
                <asp:BoundField DataField="fld_GuardianID" HeaderText="fld_GuardianID" SortExpression="fld_GuardianID" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:wil3ConnectionString %>" SelectCommand="SELECT * FROM [tbl_AbuseReport]"></asp:SqlDataSource>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Connected_Disconnected.aspx.cs" Inherits="ADOAssignment.Connected_Disconnected" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Label" Visible="False"></asp:Label>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Label" Visible="False"></asp:Label>
            <br />
            <br />
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
            <br />
            <br />
            <br />
            <asp:Button ID="ConnectedBtn" runat="server" OnClick="ConnectedBtn_Click" Text="Connected" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="DisconnectedBtn" runat="server" OnClick="DisconnectedBtn_Click" Text="Disconnected" />
        </div>
    </form>
</body>
</html>

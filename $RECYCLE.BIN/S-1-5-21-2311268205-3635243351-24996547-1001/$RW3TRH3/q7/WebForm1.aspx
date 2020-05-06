<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="q7.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            width: 319px;
        }
    </style>
</head>
<body>&nbsp;<form id="form1" runat="server">

    <div style="background-color:cornsilk">
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="click event" />
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" OnCommand="Button2_Command" CommandName="button2" Text="command on first button" />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <asp:Button ID="Button3" runat="server" OnCommand="Button2_Command" CommandName="button3" Text="Command on second button" />
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <br />
        <br />
        
        
        </div>
    </form>
</body>
</html>

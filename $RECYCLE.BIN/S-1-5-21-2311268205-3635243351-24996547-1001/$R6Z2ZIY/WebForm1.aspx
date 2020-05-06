<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="q2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 310px; margin-right: 456px; margin-left: 200px; width: 360px;">
    <form id="form1" runat="server" >
        <div style="background-color:coral" >
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server" Height="37px" Width="308px" BorderColor="#000066" ReadOnly="True" ></asp:TextBox>
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button7" runat="server" Text="7" Width="68px" OnClick="Button7_Click" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button8" runat="server" Text="8" Width="68px" OnClick="Button8_Click" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button9" runat="server" Text="9" Width="68px" OnClick="Button9_Click" />
&nbsp;&nbsp;&nbsp
            <asp:Button ID="add" runat="server" Text="+" Width="68px" OnClick="add_Click" />
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button4" runat="server" Text="4" Width="68px" OnClick="Button4_Click" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button5" runat="server" Text="5" Width="68px" OnClick="Button5_Click" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button6" runat="server" Text="6" Width="68px" OnClick="Button6_Click" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="minus" runat="server" Text="-" Width="68px" OnClick="minus_Click" />
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" Text="1" Width="68px" OnClick="Button1_Click" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" Text="2" Width="68px" OnClick="Button2_Click" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button3" runat="server" Text="3" Width="68px" OnClick="Button3_Click" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="multiply" runat="server" Text="*" Width="68px" OnClick="multiply_Click" />
            &nbsp;<br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="clear" runat="server" Text="clear" Width="68px" OnClick="clear_Click" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="point" runat="server" Text="." Width="68px" OnClick="point_Click" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button0" runat="server" Text="0" Width="68px" OnClick="Button0_Click" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="divide" runat="server" Text="/" Width="68px" OnClick="divide_Click" />
            <br />
            &nbsp;<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="reset" runat="server" Text="reset" Width="135px" style="margin-left: 6px" OnClick="reset_Click" />
        &nbsp;<asp:Button ID="equal" runat="server" Text="=" Width="135px" style="margin-left: 6px" OnClick="equal_Click" />
        </div>
    </form>
</body>
</html>

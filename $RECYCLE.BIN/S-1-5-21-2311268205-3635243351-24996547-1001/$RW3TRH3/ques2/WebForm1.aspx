<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ques2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="width: 322px; margin-left: 280px; background-color:chocolate; height: 321px;" >
        &nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server" Height="36px" Width="293px"  onkeypress="return event.charCode >= 48 && event.charCode <= 57" style="margin-top: 17px">
            
            </asp:TextBox>
            <br />
            <br />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button7" runat="server" ForeColor="#000099" Text="7" Width="58px" OnClick="Button7_Click" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button8" runat="server" ForeColor="#000099" Text="8" Width="58px" OnClick="Button8_Click" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button9" runat="server" ForeColor="#000099" Text="9" Width="58px" OnClick="Button9_Click" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="add" runat="server" ForeColor="#000099" Text="+" Width="58px" OnClick="add_Click" />
            <br />
            <br />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button4" runat="server" ForeColor="#000099" Text="4" Width="58px" OnClick="Button4_Click" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button5" runat="server" ForeColor="#000099" Text="5" Width="58px" OnClick="Button5_Click" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button6" runat="server" ForeColor="#000099" Text="6" Width="58px" OnClick="Button6_Click" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="minus" runat="server" ForeColor="#000099" Text="-" Width="58px" OnClick="minus_Click" />
            <br />
            <br />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" ForeColor="#000099" Text="1" Width="58px" OnClick="Button1_Click" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" ForeColor="#000099" Text="2" Width="58px" OnClick="Button2_Click" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button3" runat="server" ForeColor="#000099" Text="3" Width="58px" OnClick="Button3_Click" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="multiply" runat="server" ForeColor="#000099" Text="*" Width="58px" OnClick="multiply_Click" />
            <br />
            <br />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="clear" runat="server" ForeColor="#000099" Text="clear" Width="58px" OnClick="clear_Click" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="button0" runat="server" ForeColor="#000099" Text="0" Width="58px" OnClick="button0_Click" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="point" runat="server" ForeColor="#000099" Text="." Width="58px" OnClick="point_Click" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="divide" runat="server" ForeColor="#000099" Text="/" Width="58px" OnClick="divide_Click" />
            <br />
            <br />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="reset" runat="server" ForeColor="#000099" Text="reset" Width="128px" OnClick="reset_Click" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="equal" runat="server" ForeColor="#000099" Text="=" Width="131px" OnClick="equal_Click" />
            <br />
        </div>
    </form>
</body>
</html>

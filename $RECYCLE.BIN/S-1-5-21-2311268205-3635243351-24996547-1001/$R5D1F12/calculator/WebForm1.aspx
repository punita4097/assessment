<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="calculator.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <style>
        #form1
        {
            align-self:center;
            align-content:center;
        }
        #Textbox1
        {
           text-align:right;
            text-decoration-color:blue;
        }
    </style>
    
</head>
<body style="height: 316px; width: 328px">
    <form id="form1" style="background-color:burlywood" runat="server">
        <div title="Calculator">


            <asp:TextBox ID="TextBox1" runat="server" Height="38px" style="margin-top: 19px" Width="279px" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button7" runat="server" Text="7" Width="60px" OnClick="Button7_Click" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button8" runat="server" Text="8" Width="60px" OnClick="Button8_Click" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button9" runat="server" Text="9" Width="60px" OnClick="Button9_Click" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="plus" runat="server" Text="+" Width="60px" OnClick="plus_Click" />
            <br />
            <br />


            <asp:Button ID="Button4" runat="server" Text="4" Width="60px" OnClick="Button4_Click" style="height: 26px" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button5" runat="server" Text="5" Width="60px" OnClick="Button5_Click" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button6" runat="server" Text="6" Width="60px" OnClick="Button6_Click" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="minus" runat="server" Text="-" Width="60px" OnClick="minus_Click" />


            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="1" Width="60px" OnClick="Button1_Click" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" Text="2" Width="60px" OnClick="Button2_Click" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button3" runat="server" Text="3" Width="60px" OnClick="Button3_Click" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="multiply" runat="server" Text="*" Width="60px" OnClick="multiply_Click" />


            <br />
            <br />
            <asp:Button ID="Button0" runat="server" Text="0" Width="60px" OnClick="Button0_Click" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="dot" runat="server" Text="." Width="60px" OnClick="dot_Click" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="equal" runat="server" Text="=" Width="60px" OnClick="equal_Click" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="divide" runat="server" Text="/" Width="60px" OnClick="divide_Click" />


        </div>
       
        <br />
        <asp:Button ID="clear" runat="server" Text="clr" Width="135px" OnClick="clear_Click" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="reverse" runat="server" Text="reverse" Width="138px" OnClick="reverse_Click" />
       
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="VicLyfe2._0.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:TextBox ID="TextBox1" runat="server" ForeColor="#FFCC00" OnTextChanged="TextBox1_TextChanged">asfsdfsdf</asp:TextBox>
   <button onclick="{location.href='A_View'}" style="width: 200px; height: 50px; background-color: Red; color: white">
    <font size=10px>A</font></button>
        
        <asp:Panel ID="Panel1" runat="server" Height="299px">
            <asp:TextBox ID="TextBox2" runat="server" Height="232px" Width="581px"></asp:TextBox>
        </asp:Panel>
        
    </form>
</body>
</html>

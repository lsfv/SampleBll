﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="test.aspx.cs" Inherits="SampleSite.test" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            login<br />
            <asp:TextBox ID="TextBox3" runat="server" OnTextChanged="TextBox3_TextChanged"></asp:TextBox>
            <br />
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Button" />
            <br />
            <br />
            <br />
            <br />
            add<br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
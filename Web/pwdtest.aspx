﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="pwdtest.aspx.cs" Inherits="pwdtest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="Button1" runat="server" Text="变更总后台所有账户的密码" OnClick="Button1_Click" />
        <asp:Button ID="Button2" runat="server" Text="变更前台所有账户的密码" OnClick="Button2_Click" />
    </div>
    </form>
</body>
</html>
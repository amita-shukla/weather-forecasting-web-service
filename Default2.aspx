﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </div>

      <div>
          <asp:DropDownList ID="DropDownList1" runat="server">
          </asp:DropDownList>
          <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    </div>
     <div>
          <asp:DropDownList ID="DropDownList2" runat="server">
          </asp:DropDownList>
         <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
    </div>
     <div>
         <asp:Button ID="Button1" runat="server" Text="Button" onclick="Button1_Click" />
    </div>
    </form>
</body>
</html>

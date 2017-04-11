<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DefaultWebForm.aspx.cs" Inherits="DefaultWebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="User Name"></asp:Label>
        <asp:TextBox ID="TextBoxuserName" runat="server"></asp:TextBox>
        <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
        <asp:TextBox ID="TextBoxpassword" runat="server"></asp:TextBox>

        <asp:Button ID="CheckCall" runat="server" Text="Check & SayHello" OnClick="CheckCall_Click" />
    </div>
    </form>
</body>
</html>

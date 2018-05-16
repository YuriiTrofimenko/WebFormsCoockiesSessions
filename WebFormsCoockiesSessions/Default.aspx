<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebFormsCoockiesSessions.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label runat="server" ID="lang"><%= language%></asp:Label>
    </div>
    <div>
        <asp:Button Text="RU" ID="RU" runat="server" OnClick="RU_Click" />
    </div>
    <div>
        <asp:Button Text="Default" ID="Default_lang" runat="server" OnClick="Default_Click" />
    </div>
    <div>
        <asp:Label runat="server" ID="userLabel"><%= currentUserName%></asp:Label>
    </div>
        <div>
            <asp:TextBox ID="login" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Button Text="SignIn" ID="SignIn" runat="server" OnClick="SignIn_Click" />
        </div>
    </form>
</body>
</html>

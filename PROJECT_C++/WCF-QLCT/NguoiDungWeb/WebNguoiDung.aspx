<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebNguoiDung.aspx.cs" Inherits="NguoiDungWeb.WebNguoiDung" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Button ID="btnLoad" runat="server" Text="Load" OnClick="btnLoad_Click" />
    
    </div>
        <asp:GridView ID="gvNguoiDung" runat="server" Height="172px">
        </asp:GridView>
    </form>
</body>
</html>

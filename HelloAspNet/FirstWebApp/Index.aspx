<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="FirstWebApp.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>ASP.NET 웹 페이지</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Hello ASP.NET!</h1>
        </div>
        <input id="TxtOther" name="TxtOther" type="text" runat="server"/><br />  <!-- 직접 입력 -->

        <asp:TextBox ID="TxtDisplay" runat="server"></asp:TextBox>  <!-- 드래그로 인한 자동생성 -->
        <asp:Button ID="BtnClick" runat="server" OnClick="BtnClick_Click" Text="Click" style="height: 21px" /><br />
        <asp:Label ID="LblResult" runat="server"></asp:Label>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>

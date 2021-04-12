<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmStandardControl.aspx.cs" Inherits="FirstWebApp.FrmStandardControl" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>표준 컨트롤</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>표준 컨트롤</h1>

            <asp:Label ID="LblDateTime" runat="server" /><br />

            <asp:TextBox ID="TxtUserID" runat="server" TextMode="SingleLine" /><br />
            <asp:TextBox ID="TxtPassword" runat="server" TextMode="Password" /><br />
            <asp:TextBox ID="TxtDesc" runat="server" TextMode="MultiLine" /><br />

            <%--서버컨트롤이 아님, js와는 연계되지만 C# 연계는 안됨--%>
            <input type="button" value="버튼1" id="BtnInput" onclick=""/><br /> 

            <%--서버컨트롤 : runat="server" --%> 
            <input type="button" value="버튼2" id="BtnHtml" runat="server" /><br />
            <asp:Button Text="로그인" runat="server" id="BtnServer" OnClick="BtnServer_Click"/>

        </div>
    </form>
</body>
</html>

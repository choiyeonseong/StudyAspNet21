<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmRichControl.aspx.cs" Inherits="FirstWebApp.FrmRichControl" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Calendar runat="server" ID="CalMain" BackColor="#00cc99" BorderColor="#99ff66"
                BorderWidth="1px" DayNameFormat="Shortest" OnSelectionChanged="CalMain_SelectionChanged">
                <DayHeaderStyle BackColor="#ffcc66" Font-Bold="true" Height="1px" />
            </asp:Calendar>
        </div>
    </form>
</body>
</html>

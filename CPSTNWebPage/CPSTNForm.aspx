<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CPSTNForm.aspx.cs" Inherits="CPSTNWebPage.CPSTNForm" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <object id="Control" height="400" width="400">
            <param name="System" value="MySystem" />
        </object>
        <% //JRichard_InventoryUI.FrmParent FormParent = new JRichard_InventoryUI.FrmParent();
           //FormParent.Show();
           public object System() {
               return new JRichard_InventoryUI.FrmParent();
           }
        %>
    </div>
    </form>
</body>
</html>

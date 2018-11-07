<%@ Page Language="vb" AutoEventWireup="true" CodeFile="Default.aspx.vb" Inherits="T300128" %>

<%@ Register Assembly="DevExpress.Web.v15.2, Version=15.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <dx:ASPxGridView ID="grid" runat="server" ClientInstanceName="grid">
            <Columns>
                <dx:GridViewDataSpinEditColumn FieldName="Income1"></dx:GridViewDataSpinEditColumn>
                <dx:GridViewDataSpinEditColumn FieldName="Income2"></dx:GridViewDataSpinEditColumn>
            </Columns>
            <Settings ShowFilterBar="Visible" />
            <SettingsFilterControl ShowOperandTypeButton="true"></SettingsFilterControl>
        </dx:ASPxGridView>
    </form>
</body>
</html>
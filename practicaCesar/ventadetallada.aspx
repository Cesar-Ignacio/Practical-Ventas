<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ventadetallada.aspx.cs" Inherits="practicaCesar.ventadetallada" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td>id venta:</td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>id venta detallada:</td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>id articulo:</td>
                <td>
                    <asp:DropDownList ID="ddarticulos" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddarticulos_SelectedIndexChanged">
                    </asp:DropDownList>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>precio:</td>
                <td>
                    <asp:TextBox ID="tbprecio" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>cantidad:</td>
                <td>
                    <asp:TextBox ID="tbcantidad" runat="server"></asp:TextBox>
                    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Calcular" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>total:</td>
                <td>
                    <asp:TextBox ID="tbtotal" runat="server" Enabled="False"></asp:TextBox>
                </td>
                <td>
                    <asp:Button ID="Button1" runat="server" Text="Button" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>

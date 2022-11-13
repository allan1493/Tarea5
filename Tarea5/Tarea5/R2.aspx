<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="R2.aspx.cs" Inherits="Tarea5.R2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 531px">
            Pregunta 2<br />
            <asp:Image ID="Image1" runat="server" Height="389px" ImageUrl="~/Imagenes/r2.png" Width="719px" />
            <br />
            Seleccionar respuesta:
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem>a</asp:ListItem>
                <asp:ListItem>b</asp:ListItem>
                <asp:ListItem>c</asp:ListItem>
                <asp:ListItem>d</asp:ListItem>
                <asp:ListItem>e</asp:ListItem>
                <asp:ListItem>f</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Siguiente" />
        </div>
    </form>
</body>
</html>

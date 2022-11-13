<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="R3.aspx.cs" Inherits="Tarea5.R3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body style="height: 672px">
    <form id="form1" runat="server">
        <div style="height: 330px">
            Pregunta 3<br />
            <br />
            <asp:Image ID="Image1" runat="server" Height="323px" ImageUrl="~/Imagenes/r3.png" Width="659px" />
            <br />
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
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Finalizar" />
            <br />
            <br />
        </div>
    </form>
</body>
</html>

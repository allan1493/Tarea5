<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="R1.aspx.cs" Inherits="Tarea5.R1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 728px">
            Digite los siguientes datos<br />
            <br />
            <br />
            Cedula:
            <asp:TextBox ID="TCedula" runat="server" Width="172px"></asp:TextBox>
            <br />
            <br />
            Nombre:
            <asp:TextBox ID="TNombre" runat="server" Width="226px"></asp:TextBox>
            <br />
            <br />
            Genero:
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem Value="F">Femenino</asp:ListItem>
                <asp:ListItem Value="M">Masculino</asp:ListItem>
            </asp:DropDownList>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Continuar" Width="272px" />
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            <br />
            <asp:Image ID="Image1" runat="server" Height="332px" ImageUrl="~/Imagenes/r1.png" Visible="False" Width="836px" />
            <br />
            Seleccionar respuestas:
            <asp:DropDownList ID="DropDownList2" runat="server" Visible="False">
                <asp:ListItem>a</asp:ListItem>
                <asp:ListItem>b</asp:ListItem>
                <asp:ListItem>c</asp:ListItem>
                <asp:ListItem>d</asp:ListItem>
                <asp:ListItem>e</asp:ListItem>
                <asp:ListItem>f</asp:ListItem>
            </asp:DropDownList>
            <br />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Siguiente" Visible="False" Width="300px" />
        </div>
    </form>
</body>
</html>

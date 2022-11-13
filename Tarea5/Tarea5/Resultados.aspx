<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Resultados.aspx.cs" Inherits="Tarea5.Resultados" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Resultados</div>
        <div>
            Respuestas Usuario
            <asp:GridView ID="GridView1" runat="server"></asp:GridView>
        </div>
        <div>
            <br />
            <br />
            Respuestas prueba
            <asp:GridView ID="GridView2" runat="server"></asp:GridView>
        </div>
        <div>
            <br />
            <br />
            <br />
            Puntaje
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </div>
        <div>
            <asp:Button ID="Menu" runat="server" Text="Volver al menu" OnClick="Menu_Click" />
        </div>
    </form>
</body>
</html>

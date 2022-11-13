<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="paciente.aspx.cs" Inherits="tarea4.paciente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p style="text-align:center"><b>Hospital PrograII</b></p>
        </div>




        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" DataKeyNames="cedula" DataSourceID="SqlHospital">
            <Columns>
                <asp:BoundField DataField="cedula" HeaderText="cedula" ReadOnly="True" SortExpression="cedula" />
                <asp:BoundField DataField="nombre" HeaderText="nombre" SortExpression="nombre" />
                <asp:BoundField DataField="edad" HeaderText="edad" SortExpression="edad" />
                <asp:BoundField DataField="genero" HeaderText="genero" SortExpression="genero" />
                <asp:BoundField DataField="provincia" HeaderText="provincia" SortExpression="provincia" />
                <asp:BoundField DataField="canton" HeaderText="canton" SortExpression="canton" />
                <asp:BoundField DataField="distrito" HeaderText="distrito" SortExpression="distrito" />
                <asp:BoundField DataField="telefono" HeaderText="telefono" SortExpression="telefono" />
                <asp:CheckBoxField DataField="seguro" HeaderText="seguro" SortExpression="seguro" />
            </Columns>
            <FooterStyle BackColor="White" ForeColor="#000066" />
            <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
            <RowStyle ForeColor="#000066" />
            <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#007DBB" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#00547E" />
        </asp:GridView>
        <asp:TextBox ID="Tnombre" runat="server"></asp:TextBox>
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Paciente" />
        <asp:SqlDataSource ID="SqlHospital" runat="server" ConnectionString="<%$ ConnectionStrings:HOSPITALConnectionString %>" SelectCommand="SELECT * FROM [Paciente]"></asp:SqlDataSource>




        <asp:Button ID="Button1" runat="server" Text="Porcentaje Categorias" OnClick="Button1_Click" />
        <asp:Button ID="Button2" runat="server" style="margin-top: 23px" Text="Porcentaje Generos" OnClick="Button2_Click" />
        <asp:Button ID="Button4" runat="server" Text="Porcentaje Seguro" OnClick="Button4_Click" />
        <p>
            &nbsp;<asp:Label ID="Label1" runat="server" Visible="False"></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label4" runat="server" Text="Label" Visible="False"></asp:Label>
        </p>
        <p>
            <asp:Label ID="Label2" runat="server" Visible="False"></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label5" runat="server" Text="Label" Visible="False"></asp:Label>
        </p>
        <p>
            <asp:Label ID="Label3" runat="server" Visible="False"></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label6" runat="server" Text="Label" Visible="False"></asp:Label>
        </p>




        <asp:GridView ID="GridView2" runat="server">
        </asp:GridView>




    </form>
    

</body>
</html>

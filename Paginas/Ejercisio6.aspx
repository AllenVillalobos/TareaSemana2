<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercisio6.aspx.cs" Inherits="TareaSemana2.Paginas.Ejercisio6" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label>Calcule Su Salario</asp:Label>
            <br />
            <br />
            <asp:Label>Ingrese Su Salario Por Horas</asp:Label>
            <br />
            <br />
            <asp:TextBox ID="txtSalario" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label>Ingrese Sus Horas Trabajadas</asp:Label>
            <br />
            <br />
            <asp:TextBox ID="txtHoras" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label>Ingrese Sus Horas Extras Trabajadas</asp:Label>
            <br />
            <br />
            <asp:TextBox ID="txtHorasExt" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnCalcular" runat="server" Text="Calcular" OnClick="calcularSalario" />
            <br />
            <br />
            <asp:Label ID="lblMensaje" runat="server" Font-Size="Smaller"></asp:Label>
        </div>
    </form>
</body>
</html>

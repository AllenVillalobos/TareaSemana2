<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercisio5.aspx.cs" Inherits="TareaSemana2.Paginas.Ejercisio5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label>Ingrese Un Numero</asp:Label>
            <br />
            <br />
            <asp:TextBox ID="txtNumero" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnEnviar" runat="server" Text="Ver Numeros Primos" OnClick="primos" />
            <br />
            <br />
            <asp:Label ID="lblPrimos" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>

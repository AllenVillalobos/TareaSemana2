<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercisio4.aspx.cs" Inherits="TareaSemana2.Paginas.Ejercisio4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label>Ingrese Su Contraseña</asp:Label>
            <br />
            <br />
            <asp:TextBox ID="txtContrasennia" TextMode="Password" required="true" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="bntVerificar" runat="server" Text="Login" OnClick="verificar" />
            <br />
            <br />
            <asp:Label ID="lblMensaje1" runat="server">3</asp:Label>
            <asp:Label ID="lblMensaje2" runat="server">:Intentos Restantes</asp:Label>
        </div>
    </form>
</body>
</html>

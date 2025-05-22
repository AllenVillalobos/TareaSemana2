<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercisio2.aspx.cs" Inherits="TareaSemana2.Paginas.Ejercisio2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label>Ingrese Una Temperatura en Grados Celsius</asp:Label>
            <br />
            <br />
            <asp:TextBox runat="server" ID="txtGradosCelsius"></asp:TextBox>
            <br />
            <br />
            <asp:Button runat="server" ID="btnConvertir" Text="Convertir" OnClick="btnConvertirGrados" />
            <br />
            <br />
            <asp:Label ID="lblMensaje" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>

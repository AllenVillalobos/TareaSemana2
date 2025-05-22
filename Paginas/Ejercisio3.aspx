<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercisio3.aspx.cs" Inherits="TareaSemana2.Paginas.Ejercisio3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Intente Dividir Un Numero</h1>
            <br />
            <br />
            <asp:Label>Divisor</asp:Label>
            <asp:TextBox ID="txtdivisor" runat="server" required="true"></asp:TextBox>
            <br />
            <br />
            <asp:Label>Dividendo</asp:Label>
            <asp:TextBox ID="txtdividendo" runat="server" required="true"></asp:TextBox>
            <br />
            <br />
            <asp:Button Text="Dividir" ID="btnDividir" OnClick="dividir" runat="server"/>
            <br />
            <br />
            <asp:Label ID="lblMensaje" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>

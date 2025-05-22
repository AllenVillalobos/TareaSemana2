<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercisio1.aspx.cs" Inherits="TareaSemana2.Paginas.Ejercisio1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label>Ingrese Su Edad</asp:Labe>
                <br />
                <br />
                <asp:TextBox ID="txtEdad" runat="server" required="true"></asp:TextBox>
                <br />
                <br />
                <asp:Button ID="btnEnviar" Text="Envie Su Edad" runat="server" OnClick="bntVerificar" />
                <br />
                <br />
                <asp:Label ID="lblMensaje" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>

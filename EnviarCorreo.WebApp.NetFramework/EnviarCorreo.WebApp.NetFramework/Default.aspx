<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="EnviarCorreo.WebApp.NetFramework.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Enviar Correo</h1>
            <label>Llena todo el formulario para enviar un correo</label>
            <br />
            <label>Correo de origen:</label>
            <asp:TextBox ID="txtEmailOrigen" runat="server"></asp:TextBox>
            <br />
            <label>Correo destinatario:</label>
            <asp:TextBox ID="txtEmailDestinatary" runat="server"></asp:TextBox>
            <br />
            <label>Asunto:</label>
            <asp:TextBox ID="txtEmailSubject" runat="server"></asp:TextBox>
            <br />
            <label>Cuerpo:</label>
            <asp:TextBox ID="txtEmailBody" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="btnSendEmail" runat="server" Text="Enviar correo" OnClick="btnSendEmail_Click" />
        </div>
    </form>
</body>
</html>

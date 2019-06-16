<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="PaginaWebTeste.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
            color: #000099;
            font-size: xx-large;
        }
        .auto-style2 {
            color: #000000;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <br />
            <br />
            Testes 12-06-2019</div>
        <p>
            &nbsp;</p>
        <p style="text-align: center; color: #FF0000; font-size: large">
            Digite o primeiro número:
            <asp:TextBox ID="TextBoxPrimeiroNumero" runat="server" OnTextChanged="TextBoxPrimeiroNumero_TextChanged"></asp:TextBox>
        </p>
        <p style="text-align: center; color: #FF0000; font-size: large">
            Digite o segundo número:
            <asp:TextBox ID="TextBoxSegundoNumero" runat="server"></asp:TextBox>
        </p>
        <p style="text-align: center; color: #FF0000; font-size: large">
            <asp:Button ID="ButtonCalcular" runat="server" OnClick="ButtonCalcular_Click" Text="Calcular" />
        </p>
        <p style="text-align: center; color: #FF0000; font-size: large">
            <span class="auto-style2">A soma dos dois números é:</span>
            <asp:Label ID="LabelResultado" runat="server" style="color: #003300"></asp:Label>
        </p>
    </form>
    <p style="text-align: center; color: #FF0000; font-size: large">
        &nbsp;</p>
    <p style="text-align: center; color: #FF0000; font-size: large">
        &nbsp;</p>
    <p style="text-align: center; color: #FF0000; font-size: large">
        &nbsp;</p>
    <p style="text-align: center; color: #FF0000; font-size: large">
        &nbsp;</p>
    <p style="text-align: center; color: #FF0000; font-size: large">
        ///////////////////////////////////////////////////////////////////////////////////////////////</p>
</body>
</html>

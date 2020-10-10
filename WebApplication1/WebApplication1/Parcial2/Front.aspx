<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Front.aspx.vb" Inherits="WebApplication1.Front" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <table class="nav-justified">
            <tr>
                <td class="text-center" colspan="2"><strong><span style="font-size: xx-large">LIQUIDACIÓN MATRÍCULA</span></strong>&nbsp;</td>
            </tr>
            <tr>
                <td style="font-size: x-large">P<span style="font-weight: bold">ROGRAMA:</span></td>
                <td class="text-center">
                    <asp:DropDownList ID="cboPrograma" runat="server" style="font-size: x-large">
                        <asp:ListItem>INGENIERÍA SISTEMAS</asp:ListItem>
                        <asp:ListItem>INGENIERÍA ELECTRÓNICA</asp:ListItem>
                        <asp:ListItem>OTROS</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td style="font-size: x-large"><strong>ESTRATO VIVIENDA:</strong></td>
                <td class="text-center">
                    <asp:TextBox ID="txtEstratoVivienda" runat="server" style="font-size: x-large" TextMode="Number"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="font-size: x-large"><strong>ESTRATO COLEGIO:</strong></td>
                <td class="text-center">
                    <asp:TextBox ID="txtEstratoColegio0" runat="server" style="font-size: x-large" TextMode="Number"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="font-size: x-large"><strong>CRÉDITOS:</strong></td>
                <td class="text-center">
                    <asp:TextBox ID="txtCreditos" runat="server" style="font-size: x-large" TextMode="Number"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="text-center">
                    <asp:Button ID="btnCalcular" runat="server" BackColor="#0033CC" Font-Bold="True" ForeColor="White" OnClick="btnCalcular_Click" style="font-size: xx-large" Text="CALCULAR" Width="280px" />
                </td>
                <td class="text-center">
                    <asp:Button ID="btnLimpiar" runat="server" BackColor="#0033CC" Font-Bold="True" ForeColor="White" style="font-size: xx-large" Text="LIMPIAR" Width="280px" />
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Label ID="lblError" runat="server" style="font-size: x-large"></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="font-size: x-large"><span style="font-weight: bold">Valor pago antes descuento:</span></td>
                <td class="text-center">
                    <asp:Label ID="lblPorcentajeCuotaInicial" runat="server" style="font-size: x-large"></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="font-size: x-large"><span style="font-weight: bold">Porcentaje descuento:</span></td>
                <td class="text-center">
                    <asp:Label ID="lblValorCuotaInicial" runat="server" style="font-size: x-large"></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="font-size: x-large"><span style="font-weight: bold">Valor descuento:</span></td>
                <td class="text-center">
                    <asp:Label ID="lblCredito" runat="server" style="font-size: x-large"></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="font-size: x-large"><strong>T</strong><span style="font-weight: bold">otal a pagar:</span></td>
                <td class="text-center">
                    <asp:Label ID="lblTasa" runat="server" style="font-size: x-large"></asp:Label>
                </td>
            </tr>
            </table>
</asp:Content>

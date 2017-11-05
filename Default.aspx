<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        #form1 {
            height: 1042px;
        }
        #TextArea1 {
            margin-top: 20px;
            margin-bottom: 0px;
            height: 98px;
            width: 230px;
        }
        #txtArea_compra {
            height: 118px;
        }
        #txtArea_compra0 {
            height: 118px;
        }
        #txtArea_venda {
            height: 121px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label_id" runat="server"></asp:Label>
            <br />
            <br />
        </div>
        <hr />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Empresa a ser consultada:"></asp:Label>
        &nbsp;<asp:TextBox ID="txtBox_consultar" runat="server" Height="16px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label_resposta_consultar" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Button ID="Button_consultar" runat="server" Text="Consultar" OnClick="Button_consultar_Click1" />
        <br />
        <hr />
        <div style="height: 280px; width: 450px">
            COMPRA DE AÇÕES<br />
            <br />
        Ação a ser comprada:
        <asp:TextBox ID="txtBox_nome_empresa" runat="server" Height="16px" style="margin-bottom: 0px"></asp:TextBox>
            <br />
            <br />
        Quantidade desejada:
        <asp:TextBox ID="txtBox_qtdAcao" runat="server" Height="16px"></asp:TextBox>
            <br />
            <br />
        Valor Máximo:
        <asp:TextBox ID="txtBox_vlrMax" runat="server" Height="16px"></asp:TextBox>
            <br />
            <br />
        <asp:Label ID="label_compra" runat="server"></asp:Label>
        <br />
            <br />
        <asp:Button ID="Button_comprar" runat="server" OnClick="Button_comprar_Click" Text="Comprar" />
        <br />
        </div>
        <hr />
        <div style="width: 450px; height: 280px">
            VENDA DE AÇÕES<br />
            <br />
        Ação a ser vendida: <asp:TextBox ID="txtBox_empresa" runat="server"></asp:TextBox>
        <br />
        <br />
        Quantidade a vender: <asp:TextBox ID="txtBox_qtd" runat="server"></asp:TextBox>
        <br />
        <br />
        Valor mínimo:
        <asp:TextBox ID="txtBox_vlrMin" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label_venda" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Button ID="BtnVender" runat="server" OnClick="BtnVender_Click" Text="Vender" />
        </div>
        <div style="width: 450px; height: 281px">
            <br />
            MOSTRAR OPERAÇÕES:<br />
            <br />
            <asp:Button ID="Btn_mostrar_operacoes" runat="server" OnClick="Btn_mostrar_operacoes_Click" Text="Consultar Operações" />
            <br />
            <br />
            <asp:TextBox ID="txtBox_venda" runat="server" TextMode="multiline" Columns="50" Rows="8" ></asp:TextBox>
            <br />
            <br />
            <br />
            </div>
        <br />
        <br />
        <br />
        <br />
        <br />
    </form>
</body>
</html>

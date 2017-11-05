<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SessaoCliente.aspx.cs" Inherits="SessaoCliente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        #form1 {
            height: 257px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 0px">
        </div>
        <label>Digite seu id (0 - 1000):<asp:TextBox ID="TextBox1" runat="server" Width="246px"></asp:TextBox>
        <br />
        <asp:Button ID="Btn_GeraID" runat="server" Text="Ok" OnClick="Btn_GeraID_Click" />
        <br />
        </label>
&nbsp;<div>
        </div>
    </form>
</body>
</html>

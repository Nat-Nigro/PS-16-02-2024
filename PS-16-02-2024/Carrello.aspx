<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Carrello.aspx.cs" Inherits="PS_16_02_2024.Carrello" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-T3c6CoIi6uLrA9TneNEoa7RxnatzjcDSCmG1MXxSR1GAsXEV/Dwwykc2MPK8M2HN" crossorigin="anonymous" />

    <title></title>
</head>
<body>
    <form id="form1" runat="server">
       <asp:Repeater ID="CarrelloRepeater" runat="server">
            <ItemTemplate>
                <div>
                    <span><%# Eval("Nome") %></span> -
                    <span><%# Eval("Prezzo", "{0:C}") %></span>
                    <asp:Button ID="Rimuovi" runat="server" Text="Rimuovi" CommandArgument='<%# Eval("IdProdotto") %>' OnCommand="Rimuovi_Command1" />
                </div>
            </ItemTemplate>
        </asp:Repeater>
        <asp:Button ID="Svuota" runat="server" Text="Svuota Carrello" OnClick="Svuota_Click" />
    </form>
</body>
</html>

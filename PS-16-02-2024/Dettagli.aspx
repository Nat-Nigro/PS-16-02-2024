<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Dettagli.aspx.cs" Inherits="PS_16_02_2024.Dettagli" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-T3c6CoIi6uLrA9TneNEoa7RxnatzjcDSCmG1MXxSR1GAsXEV/Dwwykc2MPK8M2HN" crossorigin="anonymous" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container mt-5">
    <div class="row">
        <div class="col mb-4">
            <div class="card" style="width: 18rem; margin-bottom: 20px;">
                <img id="imgProdotto" class="card-img-top" runat="server" alt="Immagine Prodotto"/>
                <div class="card-body">
                    <h5 id="lblNome" class="card-title" runat="server"></h5>
                    <p id="lblDescrizione" class="card-text" runat="server"></p>
                    <p id="lblPrezzo" class="card-text" runat="server"></p>
                    <asp:Button ID="AggiungiAlCarrello" runat="server" Text="Aggiungi al Carrello" CssClass="btn btn-primary" OnClick="AggiungiAlCarrello_Click" />
                </div>
            </div>
        </div>
    </div>
</div>
    </form>
</body>
</html>

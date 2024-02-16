<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PS_16_02_2024._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <!-- Recuperiamo il valore della proprietà oggetto associato al contenitore, tramite Eval  -->
        <h1>Benvenuti nel nostro store</h1>
        <div class="container mt-5">
            <div class="row row-cols-1 row-cols-md-2">
                <asp:Repeater ID="ProductRepeater" runat="server">
                    <ItemTemplate>
                        <div class="col mb-4">
                            <div class="card" style="width: 18rem; margin-bottom: 20px;">
                                <img class="card-img-top" src='<%# Eval("ImgUrl") %>' alt="Immagine Prodotto">
                                <div class="card-body">
                                    <h5 class="card-title"><%# Eval("Nome") %></h5>
                                   <asp:Button ID="Dettaglio" runat="server" Text="Mostra Dettaglio" CssClass="btn btn-primary" CommandArgument='<%# Eval("IdProdotto") %>' OnCommand="Dettaglio_Click" />
                            </div>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
            </div>
        </div>


    </main>

</asp:Content>

using System;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PS_16_02_2024
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) // Chiamo il metodo DataBind() sulla pagina che lo contiene, collego quindi fonte dei dati con l'interfaccia
            {
                ProductRepeater.DataSource = GestioneProdotti.ListaProdotti;
                ProductRepeater.DataBind();
            }
        }

        // Evento che ci indirizza per la pagina dettaglio del prodotto selezionato
        // Specifichaimo il path da seguire, con idProdotto che cambierà a seconda della selezione su card
        protected void Dettaglio_Click(object sender, CommandEventArgs e)
        {
            string idProdotto = e.CommandArgument.ToString();
            Response.Redirect($"Dettagli.aspx?id={idProdotto}");
        }
    }
}
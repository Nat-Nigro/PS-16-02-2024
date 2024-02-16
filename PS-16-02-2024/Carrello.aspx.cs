using System;
using System.Web.UI.WebControls;

namespace PS_16_02_2024
{
    public partial class Carrello : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                AggiornaCarrello();
            }
        }

        private void AggiornaCarrello()
        {
            var listaCarrello = Session["Carrello"] as ListaCarrello;
            if (listaCarrello != null && listaCarrello.Prodotti.Count > 0)
            {
                CarrelloRepeater.DataSource = listaCarrello.Prodotti;
                CarrelloRepeater.DataBind();
            }
        }

        protected void Rimuovi_Command1(object sender, CommandEventArgs e)
        {
            int idProdotto = Convert.ToInt32(e.CommandArgument);
            var listaCarrello = Session["Carrello"] as ListaCarrello;
            if (listaCarrello != null)
            {
                listaCarrello.RimuoviProdotto(idProdotto);
                Session["Carrello"] = listaCarrello;
                AggiornaCarrello();
            }
        }

        protected void Svuota_Click(object sender, EventArgs e)
        {
            var listaCarrello = Session["Carrello"] as ListaCarrello;
            if (listaCarrello != null)
            {
                listaCarrello.SvuotaCarrello();
                Session["Carrello"] = listaCarrello;
                AggiornaCarrello();
            }
        }
    }
}
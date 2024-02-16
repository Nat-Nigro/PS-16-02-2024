using System;
using System.Linq;

namespace PS_16_02_2024
{
    public partial class Dettagli : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string idProdotto = Request.QueryString["id"];
                if (!string.IsNullOrEmpty(idProdotto))
                {
                    // Conversione ID del prodotto in stringa, e successiva ricerca del prodotto con determinato ID
                    // Passiamo le informazioni de quel ID alla variabile "prodotto" 
                    int prodottoId = Convert.ToInt32(idProdotto);
                    Prodotti prodotto = GestioneProdotti.ListaProdotti.FirstOrDefault(p => p.IdProdotto == prodottoId);

                    if (prodotto != null)
                    {
                        imgProdotto.Src = prodotto.ImgUrl;
                        lblNome.InnerText = prodotto.Nome;
                        lblDescrizione.InnerText = prodotto.Descrizione;
                        lblPrezzo.InnerText = $"Prezzo: {prodotto.Prezzo:C}";
                    }
                }
            }
        }

        // Recuperiamo l'id del prodotto tramite querystring, che poi memorizziamo nella sessione dell'utente
        protected void AggiungiAlCarrello_Click(object sender, EventArgs e)
        {
            int prodottoId = Convert.ToInt32(Request.QueryString["id"]);
            Prodotti prodotto = GestioneProdotti.ListaProdotti.FirstOrDefault(p => p.IdProdotto == prodottoId);

            if (prodotto != null)
            {
                Carrello carrello;
                if (Session["Carrello"] == null)
                {
                    carrello = new Carrello();
                }
                else
                {
                    carrello = (Carrello)Session["Carrello"];
                }


                Session["Carrello"] = carrello;

                Response.Redirect("Carrello.aspx");
            }
        }
    }
}
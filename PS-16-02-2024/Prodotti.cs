using System.Collections.Generic;

namespace PS_16_02_2024
{
    public class Prodotti
    // Dichiariamo le proprietà dei prodotti, prima di crearli
    {
        public int IdProdotto { get; set; }
        public string Nome { get; set; }
        public string Descrizione { get; set; }
        public string ImgUrl { get; set; }
        public decimal Prezzo { get; set; }

    }// Adesso procediamo alla popolazione 
    public static class GestioneProdotti
    {
        public static List<Prodotti> ListaProdotti = new List<Prodotti>()
            {
                new Prodotti {IdProdotto = 1, Nome = "TheRock", Descrizione = "Data di nascita 2 maggio 1972 a Hayward, California (USA). Dwayne Johnson ha oggi 51 anni ed è del segno zodiacale Toro.",
                ImgUrl="Content/Images/therock.png", Prezzo= 29.99m},

                new Prodotti {IdProdotto = 2, Nome = "Pistola", Descrizione = "Perfetta per allontanare i nemici, ma anche gli amici. Con questa avrai tutto gratis",
                ImgUrl = "Content/Images/pistola.png", Prezzo = 9.99m},

                new Prodotti {IdProdotto = 3, Nome = "Limoni", Descrizione = "Limoni amari, ma anche dolci, perfetto da spremere sulle cozze",
                ImgUrl = "Content/Images/limoni.png", Prezzo = 3.99m},

                new Prodotti {IdProdotto = 4, Nome = "DeathNote", Descrizione = "Abbinato con la pistola ti donerà un potere supremo, conquista il mondo!",
                ImgUrl = "Content/Images/deathnote.jpg", Prezzo = 199.87m},

                new Prodotti {IdProdotto = 5, Nome = "Gabbiano romano", Descrizione = "Gabbiano pescato da Viale Eritrea, BECCATI STO GABBIANO!",
                ImgUrl = "Content/Images/gabbianojpeg.jpeg", Prezzo = 234.66m}
            };
    }
}
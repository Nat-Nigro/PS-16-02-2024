using System.Collections.Generic;
using System.Linq;

namespace PS_16_02_2024
{
    public class ListaCarrello
    {
        // Proprietà che rappresenta la lista dei prodotti nel carrello 
        public List<Prodotti> Prodotti { get; set; }

        public ListaCarrello()
        {
            Prodotti = new List<Prodotti>();
        }

        // Metodo per aggiungere un prodotto al carrello
        public void AggiungiProdotto(Prodotti prodotto)
        {
            Prodotti.Add(prodotto);
        }

        // Metodo per rimuovere un prodotto dal carrello 
        public void RimuoviProdotto(int idProdotto)
        {
            Prodotti prodottoDaRimuovere = Prodotti.FirstOrDefault(p => p.IdProdotto == idProdotto);
            if (prodottoDaRimuovere != null)
            {
                Prodotti.Remove(prodottoDaRimuovere);
            }
        }

        // Metodo per svuotare completamente il carrello
        public void SvuotaCarrello()
        {
            Prodotti.Clear();
        }
    }
}
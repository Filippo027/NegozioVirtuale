using System.Collections.Generic;

public class Carrello : IVisualizzabile{
    private List<Prodotto> prodotti;

    public Carrello(){
        prodotti = new List<Prodotto>();
    }

    public void AggiungiProdotto(Prodotto p){
        prodotti.Add(p);
    }

    public void RimuoviProdotto(Prodotto p){
        prodotti.Remove(p);
    }

    public float CalcolaTotale(){
        float totale = 0;
        foreach (var p in prodotti)
            totale += p.Prezzo;
        return totale;
    }

    public void Visualizza(){
        UnityEngine.Debug.Log("Carrello:");
        foreach (var p in prodotti)
            p.Visualizza();
        UnityEngine.Debug.Log($"Totale: {CalcolaTotale()}€");
    }

    public List<Prodotto> GetProdotti()
    {
        return prodotti;
    }
}

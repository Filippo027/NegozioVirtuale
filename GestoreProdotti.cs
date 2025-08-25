using System.Collections.Generic;

public class GestoreProdotti{
    private static GestoreProdotti instance;
    public static GestoreProdotti Instance{
        get{
            if (instance == null)
                instance = new GestoreProdotti();
            return instance;
        }
    }

    private List<Prodotto> prodotti;
    private Stack<Prodotto> cronologiaVisualizzazioni;

    private GestoreProdotti(){
        prodotti = new List<Prodotto>();
        cronologiaVisualizzazioni = new Stack<Prodotto>();

        AggiungiProdotto(new Occhiale("Ray-Ban Aviator", 120f, "Occhiale classico da sole", "Oro"));
        AggiungiProdotto(new Occhiale("Oakley Sport", 150f, "Occhiale sportivo leggero", "Nero"));
        AggiungiProdotto(new Occhiale("Gucci Glam", 250f, "Occhiale elegante di lusso", "Rosso"));
        AggiungiProdotto(new Accessorio("Custodia Rigida", 20f, "Protegge gli occhiali", "Plastica"));
        AggiungiProdotto(new Accessorio("Panno Pulizia", 5f, "Panno microfibra per lenti", "Microfibra"));
    }

    public void AggiungiProdotto(Prodotto p){
        prodotti.Add(p);
    }

    public void VisualizzaProdotto(Prodotto p){
        p.Visualizza();
        cronologiaVisualizzazioni.Push(p);
    }

    public List<Prodotto> RicercaPerNome(string nome){
        List<Prodotto> risultati = new List<Prodotto>();
        foreach (var p in prodotti){
            if (p.Nome.ToLower().Contains(nome.ToLower()))
                risultati.Add(p);
        }
        return risultati;
    }

    public void OrdinaPerPrezzo(){
        for (int i = 1; i < prodotti.Count; i++){
            Prodotto key = prodotti[i];
            int j = i - 1;
            while (j >= 0 && prodotti[j].Prezzo > key.Prezzo){
                prodotti[j + 1] = prodotti[j];
                j--;
            }
            prodotti[j + 1] = key;
        }
    }

    public List<Prodotto> GetProdotti(){
        return prodotti;
    }

    public Stack<Prodotto> GetCronologia(){
        return cronologiaVisualizzazioni;
    }
}

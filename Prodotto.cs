public abstract class Prodotto : IVisualizzabile{
    public string Nome { get; set; }
    public float Prezzo { get; set; }
    public string Descrizione { get; set; }
    public string Categoria { get; set; }

    public Prodotto(string nome, float prezzo, string descrizione, string categoria){
        Nome = nome;
        Prezzo = prezzo;
        Descrizione = descrizione;
        Categoria = categoria;
    }

    public abstract void MostraDettagli();

    public void Visualizza(){
        MostraDettagli();
    }
}

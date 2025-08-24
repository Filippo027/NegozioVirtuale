public abstract class Prodotto{
    public string Nome { get; private set; }
    public float Prezzo { get; private set; }
    public string Descrizione { get; private set; }

    public Prodotto(string nome, float prezzo, string descrizione){
        Nome = nome;
        Prezzo = prezzo;
        Descrizione = descrizione;
    }

    public abstract void Visualizza();
}

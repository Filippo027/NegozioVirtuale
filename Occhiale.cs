public class Occhiale : Prodotto
{
    public string Colore { get; set; }

    public Occhiale(string nome, float prezzo, string descrizione, string colore) : base(nome, prezzo, descrizione, "Occhiali"){
        Colore = colore;
    }

    public override void MostraDettagli(){
        UnityEngine.Debug.Log($"{Nome} - {Colore} - {Prezzo}€\n{Descrizione}");
    }
}

using UnityEngine;

public class Occhiale : Prodotto{
    public string Colore { get; private set; }

    public Occhiale(string nome, float prezzo, string descrizione, string colore) 
      //chiamata costruttore classe Prodotto
        : base(nome, prezzo, descrizione){
        Colore = colore;
    }

    public override void Visualizza(){
        Debug.Log($"Occhiale: {Nome}, Prezzo: {Prezzo}, Colore: {Colore}, Descrizione: {Descrizione}");
    }
}

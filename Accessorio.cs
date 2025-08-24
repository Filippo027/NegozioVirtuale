using UnityEngine;

public class Accessorio : Prodotto{
    public string Materiale { get; private set; }

    public Accessorio(string nome, float prezzo, string descrizione, string materiale)
        : base(nome, prezzo, descrizione){
        Materiale = materiale;
    }

    public override void Visualizza(){
        Debug.Log($"Accessorio: {Nome}, Prezzo: {Prezzo}, Materiale: {Materiale}, Descrizione: {Descrizione}");
    }
}

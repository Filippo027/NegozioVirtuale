public class Accessorio : Prodotto
{
    public string Materiale { get; set; }

    public Accessorio(string nome, float prezzo, string descrizione, string materiale)
        : base(nome, prezzo, descrizione, "Accessori")
    {
        Materiale = materiale;
    }

    public override void MostraDettagli()
    {
        UnityEngine.Debug.Log($"{Nome} - {Materiale} - {Prezzo}€\n{Descrizione}");
    }
}

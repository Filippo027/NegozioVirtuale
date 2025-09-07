using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIProdottoCarrello : MonoBehaviour{
    public TextMeshProUGUI testo;
    public Button rimuoviButton;

    public void Imposta(Prodotto p, System.Action onRimuovi){
        testo.text = $"{p.Nome} - {p.Prezzo}€";
        rimuoviButton.onClick.RemoveAllListeners();
        rimuoviButton.onClick.AddListener(() => onRimuovi());
    }
}

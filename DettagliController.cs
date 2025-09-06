using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class DettagliController : MonoBehaviour{
    public GameObject dettagliPanel; 
    public TextMeshProUGUI nomeText;
    public TextMeshProUGUI descrizioneText;
    public TextMeshProUGUI prezzoText;
    public Button aggiungiButton;

    private Prodotto prodottoCorrente;

    void Start(){
        dettagliPanel.SetActive(false);

        
        aggiungiButton.onClick.AddListener(() =>
        {
            CarrelloControllerUI.Instance.AggiungiAlCarrello(prodottoCorrente);
            Debug.Log($"{prodottoCorrente.Nome} aggiunto al carrello");
        });
    }

    public void MostraDettagli(Prodotto p){
        prodottoCorrente = p;
        nomeText.text = p.Nome;
        descrizioneText.text = p.Descrizione;
        prezzoText.text = $"{p.Prezzo}€";
        dettagliPanel.SetActive(true);
    }

    public void ChiudiDettagli(){
        dettagliPanel.SetActive(false);
    }
}

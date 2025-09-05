using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections.Generic;

public class CarrelloControllerUI : MonoBehaviour{
    public static CarrelloControllerUI Instance;

    [Header("Riferimenti UI")]
    public GameObject carrelloPanel;
    public GameObject catalogoPanel;
    public Transform contentPanel;
    public GameObject prodottoPrefab;
    public TextMeshProUGUI totaleText;
    public Button compraButton;
    public Button chiudiButton;

    [Header("Riferimenti Dettagli")]
    public Button aggiungiAlCarrelloButton;

    private List<Prodotto> prodottiCarrello;
    private Prodotto prodottoCorrente;

    void Awake(){
        if (Instance == null){
            Instance = this;
            DontDestroyOnLoad(gameObject);
            Debug.Log("CarrelloControllerUI attivo: " + gameObject.name);
        }
        else{
            Debug.LogWarning("CarrelloControllerUI duplicato distrutto: " + gameObject.name);
            Destroy(gameObject);
            return;
        }

        prodottiCarrello = new List<Prodotto>();

        if (carrelloPanel != null) carrelloPanel.SetActive(false);
        if (compraButton != null) compraButton.onClick.AddListener(Compra);
        if (chiudiButton != null) chiudiButton.onClick.AddListener(ChiudiCarrello);

        if (aggiungiAlCarrelloButton != null){
            aggiungiAlCarrelloButton.onClick.RemoveAllListeners();
            aggiungiAlCarrelloButton.onClick.AddListener(() =>
            {
                if (prodottoCorrente != null){
                    Debug.Log($"Aggiungo al carrello: {prodottoCorrente.Nome}");
                    AggiungiAlCarrello(prodottoCorrente);
                }
                else{
                    Debug.LogWarning("Prodotto corrente nullo! Non posso aggiungere al carrello.");
                }
            });
        }
    }

    public void ImpostaProdottoCorrente(Prodotto p){
        prodottoCorrente = p;
        Debug.Log($"Prodotto corrente impostato: {p.Nome}");
    }

    public void ApriCarrello(){
        if (carrelloPanel != null) carrelloPanel.SetActive(true);
        if (catalogoPanel != null) catalogoPanel.SetActive(false);
        AggiornaLista();
    }

    public void ChiudiCarrello(){
        if (carrelloPanel != null) carrelloPanel.SetActive(false);
        if (catalogoPanel != null) catalogoPanel.SetActive(true);
    }

    public void AggiungiAlCarrello(Prodotto p){
        if (p == null){
            Debug.LogError("Tentato di aggiungere un prodotto NULL al carrello!");
            return;
        }

        prodottiCarrello.Add(p);
        Debug.Log($"Aggiunto al carrello: {p.Nome} (hash {p.GetHashCode()}), totale prodotti: {prodottiCarrello.Count}");
        AggiornaLista();
    }

    public void RimuoviDalCarrello(Prodotto p){
        if (p == null) return;

        prodottiCarrello.Remove(p);
        Debug.Log($"Prodotto rimosso dal carrello: {p.Nome}. Prodotti rimanenti: {prodottiCarrello.Count}");
        AggiornaLista();
    }

    private void AggiornaLista(){
        if (contentPanel == null || prodottoPrefab == null){
            Debug.LogError("CarrelloControllerUI: contentPanel o prodottoPrefab non assegnato!");
            return;
        }

        foreach (Transform child in contentPanel)
            Destroy(child.gameObject);

        float totale = 0;

        foreach (var p in prodottiCarrello){
            GameObject obj = Instantiate(prodottoPrefab, contentPanel);
            obj.transform.localScale = Vector3.one;
            obj.transform.SetAsFirstSibling();

            UIProdottoCarrello ui = obj.GetComponent<UIProdottoCarrello>();
            if (ui != null)
                ui.Imposta(p, () => RimuoviDalCarrello(p));

            totale += p.Prezzo;
        }

        if (totaleText != null)
            totaleText.text = $"Totale: {totale}€";
    }

    private void Compra(){
        Debug.Log($"Prodotti nel carrello al momento dell'acquisto: {prodottiCarrello.Count}");
        foreach (var p in prodottiCarrello)
            Debug.Log($" - {p.Nome} (hash {p.GetHashCode()})");

        if (prodottiCarrello.Count == 0){
            Debug.Log("Carrello vuoto, impossibile completare l'acquisto!");
            return;
        }

        Debug.Log($"Acquisto completato! Prodotti acquistati: {prodottiCarrello.Count}");
        prodottiCarrello.Clear();
        AggiornaLista();
        ChiudiCarrello();
    }
}

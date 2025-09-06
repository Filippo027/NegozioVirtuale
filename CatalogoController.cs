using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.Collections.Generic;

public class CatalogoController : MonoBehaviour{
    public Transform contentPanel; 
    public GameObject prodottoPrefab; 
    public TMP_InputField ricercaField;

    private List<Prodotto> prodotti;

    void Start(){
        prodotti = GestoreProdotti.Instance.GetProdotti();
        MostraProdotti(prodotti);
    }

    public void MostraProdotti(List<Prodotto> lista){

        foreach (Transform child in contentPanel){
            Destroy(child.gameObject);
        }

        
        foreach (var p in lista){
            GameObject obj = Instantiate(prodottoPrefab, contentPanel);
            
           
            obj.transform.localScale = Vector3.one;
            obj.transform.localPosition = Vector3.zero;

            
            TextMeshProUGUI testo = obj.GetComponentInChildren<TextMeshProUGUI>();
            if (testo != null){
                testo.text = $"{p.Nome} - {p.Prezzo}€";
            }

           
            Button btn = obj.GetComponentInChildren<Button>();
            if (btn != null){
              
                btn.onClick.RemoveAllListeners();
                btn.onClick.AddListener(() => VisualizzaDettagli(p));
            }
        }
    }

    public void Ricerca(){
        string testo = ricercaField.text;
        List<Prodotto> risultati = GestoreProdotti.Instance.RicercaPerNome(testo);
        MostraProdotti(risultati);
    }

    public void OrdinaPrezzo(){
        GestoreProdotti.Instance.OrdinaPerPrezzo();
        MostraProdotti(GestoreProdotti.Instance.GetProdotti());
    }

    public DettagliController dettagliController;

    void VisualizzaDettagli(Prodotto p){
        dettagliController.MostraDettagli(p);
    }

}

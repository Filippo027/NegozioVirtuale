using UnityEngine;
using TMPro; 
using UnityEngine.UI;

public class LoginController : MonoBehaviour{
    public TMP_InputField usernameField;  
    public TMP_InputField passwordField;  
    public TextMeshProUGUI messaggioErrore; 

    public GameObject loginPanel;
    public GameObject catalogoPanel;

    public void Login(){
        string username = usernameField.text; 
        string password = passwordField.text;

        var utente = GestoreUtenti.Instance.Login(username, password);
        if (utente != null){
            messaggioErrore.text = "";
            loginPanel.SetActive(false);
            catalogoPanel.SetActive(true);
        }
        else{
            messaggioErrore.text = "Username o password errati!";
        }
    }

    public void Registrati(){
        string username = usernameField.text;
        string password = passwordField.text;

        if (GestoreUtenti.Instance.RegistraUtente(username, password)){
            messaggioErrore.text = "Registrazione avvenuta con successo!";
        }
        else{
            messaggioErrore.text = "Username già esistente!";
        }
    }
}

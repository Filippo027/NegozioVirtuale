using System.Collections.Generic;

public class GestoreUtenti{
    private static GestoreUtenti instance;
    public static GestoreUtenti Instance{
        get{
            if (instance == null)
                instance = new GestoreUtenti();
            return instance;
        }
    }

    private List<Utente> utenti;

    private GestoreUtenti(){
        utenti = new List<Utente>();
    }

    public bool RegistraUtente(string username, string password){
        foreach (var u in utenti){
            if (u.Username == username)
                return false;
        }
        utenti.Add(new Utente(username, password));
        return true;
    }

    public Utente Login(string username, string password){
        foreach (var u in utenti){
            if (u.Username == username && u.VerificaPassword(password))
                return u;
        }
        return null;
    }

    public List<Utente> GetUtenti(){
        return utenti;
    }
}

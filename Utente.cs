public class Utente{
    public string Username { get; private set; }
    private string password;

    public Utente(string username, string password){
        Username = username;
        this.password = password;
    }

    public bool VerificaPassword(string pwd){
        return password == pwd;
    }
}

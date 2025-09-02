using System.Collections.Generic;

public class Utente
{
    public string Username { get; private set; }
    private string password;

    public Carrello Carrello { get; private set; }

    public Utente(string username, string password)
    {
        Username = username;
        this.password = password;
        Carrello = new Carrello();
    }

    public bool VerificaPassword(string pwd)
    {
        return password == pwd;
    }
}

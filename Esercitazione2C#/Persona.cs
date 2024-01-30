using System;

public class Persona
{
	public Persona()
	{
    public string Nome { get; set; }
    public string Cognome { get; set; }
    public int Eta { get; set; }

    public Persona()
    {
        Nome = "Non definito";
        Cognome = "Non definito";
        Eta = 0;
    }
    public Persona(string nome, string cognome, int eta)
    {
        Nome = nome;
        Cognome = cognome;
        Eta = eta;
    }

    public string GetInformazioniPersona()
    {
        return $"Nome: {Nome}, Cognome: {Cognome}, Età: {Eta} anni";
    }
}
}

namespace Esercitazione2C_;

class Program
{
    static void Main(string[] args)
    {
        Persona persona1 = new Persona(); 
        Console.WriteLine("Informazioni sulla persona 1:");
        Console.WriteLine(persona1.GetInformazioniPersona());

        Persona persona2 = new Persona("Mario", "Rossi", 30);
        Console.WriteLine("\nInformazioni sulla persona 2:");
        Console.WriteLine(persona2.GetInformazioniPersona());
    }
}

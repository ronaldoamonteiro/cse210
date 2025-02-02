public class Entry
{
    // Propriedades públicas com acesso privado para set
    public string Date { get; private set; }
    public string Prompt { get; private set; }
    public string Text { get; private set; }

    // Construtor para inicializar os atributos
    public Entry(string date, string prompt, string text)
    {
        Date = date;
        Prompt = prompt;
        Text = text;
    }
}

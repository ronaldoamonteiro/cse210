public class Jornal{
List<Entry> entries = new List<Entry>();

public void AddEntry(string date, string prompt, string response){
    entries.Add(new Entry(date, prompt, response));
}



}
using System.IO; 

public class Jornal{
List<Entry> entries = new List<Entry>();
string fileName = "";
string fileText = "";

public void AddEntry(string date, string prompt, string response){
    entries.Add(new Entry(date, prompt, response));
    

}

public void DisplayEntries(){
    foreach (var entry in entries)
        {
            Console.WriteLine(entry.ToString());
        }
}

public void Save(){
    Console.WriteLine("Write the file name: ");
    fileName = Console.ReadLine();
    using (StreamWriter outputFile = new StreamWriter(fileName))
    {
        // You can add text to the file with the WriteLine method
            foreach (var entry in entries)
        {
            
            outputFile.WriteLine(entry.ToString());
        }
    }
}

public void Load(){
    Console.WriteLine("What is the file name: ");
    fileName = Console.ReadLine();
    string[] lines = System.IO.File.ReadAllLines(fileName);
    foreach (string line in lines)
    {
        fileText+= line + "\n";
    }
    Console.WriteLine(fileText);
}

}
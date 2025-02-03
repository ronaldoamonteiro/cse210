public class PromptManager{
//umma lista
    List<string> prompt = new List<string>
    {
        "What is one thing I learned today that I want to remember?",
        "How did I show kindness or serve someone today?",
        "What moment today made me feel the most grateful?",
        "What challenge did I face today, and how did I handle it?",
        "If I could give my past self one piece of advice for today, what would it be?"
    };
    Random random = new Random();
    public string GetRandomPrompt(){
        return prompt[random.Next(0,4)];
    }
}
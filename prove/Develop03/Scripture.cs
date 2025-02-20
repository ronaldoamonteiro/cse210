using System;
using System.Collections.Generic;
using System.Linq;

class Scripture
{
    private Reference reference;
    private List<Word> words;
    private Random random = new Random();

    public Scripture(Reference reference, string text)
    {
        this.reference = reference;
        words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void HideWords()
    {
        // Hides a small number of random words
        int wordsToHide = 3; // Gradual number of words hidden per round
        int hiddenCount = 0;

        // Only hides words that are still visible
        List<Word> visibleWords = words.Where(w => !w.IsHidden()).ToList();

        while (hiddenCount < wordsToHide && visibleWords.Count > 0)
        {
            int index = random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index); // Removes from the list of visible words to avoid duplicates
            hiddenCount++;
        }
    }

    public bool IsCompletelyHidden()
    {
        return words.All(word => word.IsHidden());
    }

    public string GetRenderedText()
    {
        return $"{reference}\n" + string.Join(" ", words.Select(word => word.GetRenderedText()));
    }
}

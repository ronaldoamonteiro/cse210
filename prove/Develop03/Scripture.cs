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
        // Oculta um número pequeno de palavras aleatórias
        int wordsToHide = 3; // Número gradual de palavras ocultadas por rodada
        int hiddenCount = 0;

        // Apenas esconde palavras que ainda estão visíveis
        List<Word> visibleWords = words.Where(w => !w.IsHidden()).ToList();

        while (hiddenCount < wordsToHide && visibleWords.Count > 0)
        {
            int index = random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index); // Remove da lista de visíveis para evitar duplicações
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

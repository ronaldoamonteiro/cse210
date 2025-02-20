class Reference
{
    private string book;
    private int chapter;
    private int verseStart;
    private int? verseEnd; // Nullable to accept a single verse or a range

    public Reference(string book, int chapter, int verseStart, int? verseEnd = null)
    {
        this.book = book;
        this.chapter = chapter;
        this.verseStart = verseStart;
        this.verseEnd = verseEnd;
    }

    public override string ToString()
    {
        return verseEnd == null ? $"{book} {chapter}:{verseStart}" : $"{book} {chapter}:{verseStart}-{verseEnd}";
    }
}

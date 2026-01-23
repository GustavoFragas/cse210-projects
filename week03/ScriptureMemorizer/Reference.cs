public class Reference
{
    private string _book;
    private string _chapter;
    private string _verse;
    private string _endVerse;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter.ToString();
        _verse = verse.ToString();
        _endVerse = "";
    }

    public Reference(string book, int chapter, int verse, int endVerse)
    {
        _book = book;
        _chapter = chapter.ToString();
        _verse = verse.ToString();
        _endVerse = endVerse.ToString();
    }

    public string GetDisplayText()
    {
        if (_endVerse == "")
        {
            return $"{_book} {_chapter}:{_verse}";
        }
        else
        {
            return $"{_book} {_chapter}:{_verse}-{_endVerse}";
        }
    }
}

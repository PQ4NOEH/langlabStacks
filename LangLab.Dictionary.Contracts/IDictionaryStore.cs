namespace LangLab.Dictionary.Contracts
{
    public interface IDictionaryStore
    {
        TextTranslation GetTranslation(string text, string fromLanguage, string toLanguage);
    }
}

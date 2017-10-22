using System.Collections.Generic;

namespace LangLab.Dictionary.Contracts
{
    public enum PartOfSpeech
    {
        Noun = 0,
        Verb = 2,
        Adverb = 4,
        Adjetive = 6,
        Pronoun = 8,
        Preposition = 10,
    }
    public class TextTranslation
    {
        public string Text { get; set; }
        public string TranslationFromLanguage { get; set; }
        public string TranslationToLanguage { get; set; }
        public List<Translation> Acceptions { get; set; } = new List<Translation>();

    }

    public class Translation
    {
        public List<string> TranslationText { get; set; } = new List<string>();
        public PartOfSpeech POS { get; set; }
        public List<string> Synonyms { get; set; } = new List<string>();
        public List<string> Antonyms { get; set; } = new List<string>();
        public List<string> Examples { get; set; } = new List<string>();
        public List<string> Definitions { get; set; } = new List<string>();
        public string SoundUrl { get; set; }

    }
}

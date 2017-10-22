using LangLab.Dictionary.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace LangLab.Dictionary.Stores
{
    public class DictionaryStore : IDictionaryStore
    {
        public TextTranslation GetTranslation(string text, string fromLanguage, string toLanguage)
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Larpchive_Of_Our_Own
{
    public class Languages : BaseEntity
    {
        private string languageNameInEnglish;
        private string languageNameInOriginalLangauge;
        private string lettersInAlpabetticalOrder;

        public string LanguageNameInEnglish { get => languageNameInEnglish; set => languageNameInEnglish = value; }
        public string LanguageNameInOriginalLangauge { get => languageNameInOriginalLangauge; set => languageNameInOriginalLangauge = value; }
        public string LettersInAlpabetticalOrder { get => lettersInAlpabetticalOrder; set => lettersInAlpabetticalOrder = value; }
    }
}

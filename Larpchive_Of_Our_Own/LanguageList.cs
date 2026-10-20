using System;
using System.Collections.Generic;
using System.Text;

namespace Larpchive_Of_Our_Own
{
    public class LanguageList : List<Languages>
    {
        public LanguageList() { }
        public LanguageList(IEnumerable<Languages> list) : base(list) { }
        public LanguageList(IEnumerable<BaseEntity> list) : base(list.Cast<Languages>().ToList()) { }
    }
}

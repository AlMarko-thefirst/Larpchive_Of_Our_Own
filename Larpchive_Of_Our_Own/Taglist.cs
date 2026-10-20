using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Larpchive_Of_Our_Own
{
    public class TagList : List<Tags>
    {
        public TagList() { }
        public TagList(IEnumerable<Tags> list) : base(list) { }
        public TagList(IEnumerable<BaseEntity> list) : base(list.Cast<Tags>().ToList()) { }
    }
}

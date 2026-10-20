using System;
using System.Collections.Generic;
using System.Text;

namespace Larpchive_Of_Our_Own
{
    public class ChapterList : List<Chapters>
    {
        public ChapterList() { }
        public ChapterList(IEnumerable<Chapters> list) : base(list) { }
        public ChapterList(IEnumerable<BaseEntity> list) : base(list.Cast<Chapters>().ToList()) { }
    }
}

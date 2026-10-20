using System;
using System.Collections.Generic;
using System.Text;

namespace Larpchive_Of_Our_Own
{
    public class PrivacyList : List<Privacy>
    {
        public PrivacyList() { }
        public PrivacyList(IEnumerable<Privacy> list) : base(list) { }
        public PrivacyList(IEnumerable<BaseEntity> list) : base(list.Cast<Privacy>().ToList()) { }
    }
}

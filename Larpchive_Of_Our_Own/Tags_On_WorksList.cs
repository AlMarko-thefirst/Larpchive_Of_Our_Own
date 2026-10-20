using System;
using System.Collections.Generic;
using System.Text;

namespace Larpchive_Of_Our_Own
{
    public class Tags_On_WorksList : List<Tags_On_Works>
    {
        public Tags_On_WorksList() { }
        public Tags_On_WorksList(IEnumerable<Tags_On_Works> list) : base(list) { }
        public Tags_On_WorksList(IEnumerable<BaseEntity> list) : base(list.Cast<Tags_On_Works>().ToList()) { }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Larpchive_Of_Our_Own
{
    public class WorksList : List<Works>
    {
        public WorksList() { }
        public WorksList(IEnumerable<Works> list) : base(list) { }
        public WorksList(IEnumerable<BaseEntity> list) : base(list.Cast<Works>().ToList()) { }
    }
}

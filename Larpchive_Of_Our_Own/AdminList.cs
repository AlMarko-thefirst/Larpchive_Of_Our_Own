using System;
using System.Collections.Generic;
using System.Text;

namespace Larpchive_Of_Our_Own
{
    public class AdminList : List<Admin>
    {
        public AdminList() { }
        public AdminList(IEnumerable<Admin> list) : base(list) { }
        public AdminList(IEnumerable<BaseEntity> list) : base(list.Cast<Admin>().ToList()) { }
    }
}

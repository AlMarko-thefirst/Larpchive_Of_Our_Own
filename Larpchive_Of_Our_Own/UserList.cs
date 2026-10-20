using System;
using System.Collections.Generic;
using System.Text;

namespace Larpchive_Of_Our_Own
{
    public class UserList : List<Users>
    {
        public UserList() { }
        public UserList(IEnumerable<Users> list) : base(list) { }
        public UserList(IEnumerable<BaseEntity> list) : base(list.Cast<Users>().ToList()) { }
    }
}

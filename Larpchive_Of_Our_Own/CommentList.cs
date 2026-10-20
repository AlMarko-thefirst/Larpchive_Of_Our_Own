using System;
using System.Collections.Generic;
using System.Text;

namespace Larpchive_Of_Our_Own
{
    public class CommentList : List<Comments>
    {
        public CommentList() { }
        public CommentList(IEnumerable<Comments> list) : base(list) { }
        public CommentList(IEnumerable<BaseEntity> list) : base(list.Cast<Comments>().ToList()) { }
    }
}

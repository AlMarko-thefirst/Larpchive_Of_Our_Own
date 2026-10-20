using System;
using System.Collections.Generic;
using System.Text;

namespace Larpchive_Of_Our_Own
{
    public class AgeRatingList : List<AgeRating>
    {
        public AgeRatingList() { }
        public AgeRatingList(IEnumerable<AgeRating> list) : base(list) { }
        public AgeRatingList(IEnumerable<BaseEntity> list) : base(list.Cast<AgeRating>().ToList()) { }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Larpchive_Of_Our_Own
{
    public class AgeRating : BaseEntity
    {
        private string age_Rating;

        public string Age_Rating { get => age_Rating; set => age_Rating = value; }
    }
}

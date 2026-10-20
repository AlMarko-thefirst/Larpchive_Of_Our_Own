using System;
using System.Collections.Generic;
using System.Text;

namespace Larpchive_Of_Our_Own
{
    public class Privacy : BaseEntity
    {
        private string pricacyLevel;
        public string PrivacyLevel { get => pricacyLevel; set => pricacyLevel = value; }
    }
}

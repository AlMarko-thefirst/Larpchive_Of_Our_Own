using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Larpchive_Of_Our_Own
{
    public class Tags_On_Works : BaseEntity
    {
        private Works workId;
        private Tags workTags;
        public Works WorkId { get => workId; set => workId = value; }
        public Tags WorkTags { get => workTags; set => workTags = value; }
    }
}

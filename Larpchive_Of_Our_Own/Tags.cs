using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Larpchive_Of_Our_Own
{
    public class Tags : BaseEntity
    {
        private string tagname;

        public string Tagname { get => tagname; set => tagname = value; }
    }
}

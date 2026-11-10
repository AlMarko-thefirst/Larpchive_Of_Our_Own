using System;
using System.Collections.Generic;
using System.Text;
using Larpchive_Of_Our_Own;

namespace ApiInterface
{
    public interface IApi
    {
        public Task<TagList> GetAllTags();
        public Task<int> InsertATag(Tags t);
        public Task<int> UpdateATag(Tags t);
    }

}

using System;
using System.Collections.Generic;
using System.Text;

namespace Larpchive_Of_Our_Own
{
    public class Chapters : BaseEntity
    {
        private Works workID;
        private int chapterNum;
        private string chapterName;
        private string summary;
        private string notes;
        private string story;
        public int ChapterNum { get => chapterNum; set => chapterNum = value; }
        public string ChapterName { get => chapterName; set => chapterName = value; }
        public string Summary { get => summary; set => summary = value; }
        public string Notes { get => notes; set => notes = value; }
        public string Story { get => story; set => story = value; }
        public Works WorkID { get => workID; set => workID = value; }
    }
}

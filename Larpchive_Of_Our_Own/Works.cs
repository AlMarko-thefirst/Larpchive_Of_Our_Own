using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Larpchive_Of_Our_Own
{
    public class Works : BaseEntity
    {
        private string workName;
        public string WorkName { get => workName; set => workName = value; }
        private string description;
        public string Description { get => description; set => description = value; }
        private string chapterGoal;
        private Languages language;
        private Users author;
        private DateTime dateOfRealease;
        private Privacy privacy;
        private AgeRating ageRating;

       

        public string ChapterGoal { get => chapterGoal; set => chapterGoal = value; }
        public Languages Language { get => language; set => language = value; }
        public Users Author { get => author; set => author = value; }
        public DateTime DateOfRelease { get => dateOfRealease; set => dateOfRealease = value; }
        public Privacy Privacy { get => privacy; set => privacy = value; }
        public AgeRating AgeRating { get => ageRating; set => ageRating = value; }
      
        
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Larpchive_Of_Our_Own
{
    public class Comments : BaseEntity
    {
        private string comment;
        private Works workID;
        private Users userID;
        private DateTime dateOfComment;
        private int rating;
        public string Comment { get => comment; set => comment = value; }
        public Works WorkId { get => workID; set => workID = value; }
        public Users UserId { get => userID; set => userID = value; }
        public DateTime DateOfComment { get => dateOfComment; set => dateOfComment = value; }
        public int Rating { get => rating; set => rating = value; }
    }
}

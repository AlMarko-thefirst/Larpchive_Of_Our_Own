using System;
using System.Collections.Generic;
using System.Text;

namespace Larpchive_Of_Our_Own
{
    public class Users : BaseEntity
    {
        private string email;
        public string Email { get => email; set => email = value; }
        private string username;
        public string Username { get => username; set => username = value; }
        private DateTime dateOfCreation;
        public DateTime DateOfCreation { get => dateOfCreation; set => dateOfCreation = value; }
        private bool isverified;
        public bool IsVerified { get => isverified; set => isverified = value; }

    }
}

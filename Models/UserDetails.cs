using System;

namespace Models
{
    public class UserDetails
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }
        public string Photo { get; set; }
        public string Provider { get; set; }
        public int ContactNo { get; set; }
        public DateTime DOB { get; set;}
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool IsDelete { get; set; }
        public DateTime ModifiedOn { get; set; }
    }
}
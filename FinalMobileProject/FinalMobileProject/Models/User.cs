using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using SQLite;

namespace FinalMobileProject.Models
{
    [Table("Users")]
    public class User
    {
        private int _id;
        [PrimaryKey, AutoIncrement]
        public int Id {
            get
            {
                return _id;
            }
            set
            {
                this._id = value;
            }
        }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string ContactNumber { get; set; }
        public string BillingAddress { get; set; }
        
        public string UserType { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace FinalMobileProject.Models
{
    class User
    {
        public string Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string ContactNumber { get; set; }
        public string BillingAddress { get; set; }
        public string DeliveryAddress { get; set; }
        public string UserType { get; set; }
    }
}

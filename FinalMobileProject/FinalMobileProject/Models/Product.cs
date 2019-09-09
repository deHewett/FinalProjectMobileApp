using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace FinalMobileProject.Models
{
    class Product
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Image { get; set; }
        public string Title { get; set; }
        public string Price { get; set; }
        public string Description { get; set; }
    }
}

using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalMobileProject.Models
{
    class Bottle
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Image { get; set; }
        public string Title { get; set; }
        public string Price { get; set; }
        public string Description { get; set; }
    }
}

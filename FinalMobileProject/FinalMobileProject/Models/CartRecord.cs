using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalMobileProject.Models
{
    class CartRecord
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

       
        public string Name { get; set; }
        public string Price { get; set; }
        public string Qty { get; set; }
        public string Total { get; set; }
        public string Image { get; set; }
        public CartRecord()
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace FinalMobileProject.Models
{
    public enum MenuItemType
    {
        Prodcuts,
        Bags
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}

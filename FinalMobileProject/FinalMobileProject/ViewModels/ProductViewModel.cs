using FinalMobileProject.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace FinalMobileProject.ViewModels
{

    class ProductViewModel
    {
        public ObservableCollection<Product> FoodList { get; set; }
        public ProductViewModel()
        {
            FoodList = new ObservableCollection<Product>();
            FoodList.Add(new Product { Image = "https://i.pinimg.com/736x/c9/e6/fa/c9e6fa742b7f3aaeab8f76d2e35458e9.jpg", Title = "ColorFul Straw", Price = "$10", Description = "This is the coloeful straw" });
        }
    }
}

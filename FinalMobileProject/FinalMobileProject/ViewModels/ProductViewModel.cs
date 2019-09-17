using FinalMobileProject.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace FinalMobileProject.ViewModels
{

    class ProductViewModel
    {
        public ObservableCollection<Product> FoodList { get; set; }

        public Command <Product> RemoveCommand
        {
            get
            {
                return new Command<Product>((product) =>
                {
                    FoodList.Remove(product);
                }
                );
            }
        }
        public ProductViewModel()
        {
            FoodList = new ObservableCollection<Product>();
            FoodList.Add(new Product { Image = "https://i.pinimg.com/736x/c9/e6/fa/c9e6fa742b7f3aaeab8f76d2e35458e9.jpg", Title = "ColorFul Straw", Price = "10", Description = "Add a cool, shiny twist to your welcome drinks with these metal straws! Straw pack, Includes 4 straws and 1 cleaning brush, Reusable, Metal and plastic(brush) and stainless steel(straws), Straw: 20.5cm(L) x 0.6cm(Dia.), Brush: 17.3cm(L), For domestic use only, Clean according to instructions on the care label" });
            FoodList.Add(new Product { Image = "https://steelysdrinkware.com/wp-content/gallery/colored-bent-straw/1_Printed_Steel_Straws_Color.jpg", Title = "Metal Straw", Price = "15", Description = "Add a cool, shiny twist to your welcome drinks with these metal straws! Straw pack, Includes 4 straws and 1 cleaning brush, Reusable, Metal and plastic(brush) and stainless steel(straws), Straw: 20.5cm(L) x 0.6cm(Dia.), Brush: 17.3cm(L), For domestic use only, Clean according to instructions on the care label" });
            FoodList.Add(new Product { Image = "https://i.etsystatic.com/12197109/r/il/91a97b/1234545957/il_fullxfull.1234545957_p053.jpg", Title = "Eco-Friendly Bag - White", Price = "10", Description = "Our new Ecopack Compostable Retail Bags are plastic free and certified compostable. They meet the new government legislation as they are over 70 micron in thickness. Available in small, medium and large. Size : 40cm(w) X 49cm(h)" });
            FoodList.Add(new Product { Image = "https://images-na.ssl-images-amazon.com/images/I/51cEkvlnVzL._SX425_.jpg", Title = "Compostable Punched Handle Bags", Price = "20", Description = "Take your branding to a new level with customised non-woven totes. These totes our most economical bag option for fundraising, promotional giveaways and special events. Size : 350mm(w) + 90mm(g) x 400mm(h), Minimum order quantity for custom branding is 200 pieces, No minimum order for unbranded bags, Click on request a quote for custom branding or contact us" });
            FoodList.Add(new Product { Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQIFcKeM70VoNXsu9__uxkdzZ60003UlVjbiLLDPx2c3052Lay7aA", Title = "Black Reusable Bag", Price = "10", Description = "Add a cool, shiny twist to your welcome drinks with these metal straws! Straw pack, Includes 4 straws and 1 cleaning brush, Reusable, Metal and plastic(brush) and stainless steel(straws), Straw: 20.5cm(L) x 0.6cm(Dia.), Brush: 17.3cm(L), For domestic use only, Clean according to instructions on the care label" });
            FoodList.Add(new Product { Image = "https://cdn.shopify.com/s/files/1/1728/2157/products/05-62587_STEEL_WIDEMOUTH_WATERBOTTLE_32OZ_SMOKYBIRCH_A.jpg?v=1553026837", Title = "Gray Metal Bottle", Price = "19", Description = "Add a cool, shiny twist to your welcome drinks with these metal straws! Straw pack, Includes 4 straws and 1 cleaning brush, Reusable, Metal and plastic(brush) and stainless steel(straws), Straw: 20.5cm(L) x 0.6cm(Dia.), Brush: 17.3cm(L), For domestic use only, Clean according to instructions on the care label" });
            FoodList.Add(new Product { Image = "https://images-na.ssl-images-amazon.com/images/I/91MgvDw4fWL._SX466_.jpg", Title = "Metallic Silver Typo", Price = "20", Description = "Add a cool, shiny twist to your welcome drinks with these metal straws! Straw pack, Includes 4 straws and 1 cleaning brush, Reusable, Metal and plastic(brush) and stainless steel(straws), Straw: 20.5cm(L) x 0.6cm(Dia.), Brush: 17.3cm(L), For domestic use only, Clean according to instructions on the care label" });
            FoodList.Add(new Product { Image = "https://image.dhgate.com/0x0s/f2-albu-g6-M01-A9-A0-rBVaR1rJqMKAVHHiAAKDZbDDPps641.jpg/shiny-color-cola-shape-water-bottles-500ml.jpg", Title = "Colorful Thermal Bottles", Price = "25", Description = "Add a cool, shiny twist to your welcome drinks with these metal straws! Straw pack, Includes 4 straws and 1 cleaning brush, Reusable, Metal and plastic(brush) and stainless steel(straws), Straw: 20.5cm(L) x 0.6cm(Dia.), Brush: 17.3cm(L), For domestic use only, Clean according to instructions on the care label" });





        }
    }
}

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
            FoodList.Add(new Product { Image = "https://ae01.alicdn.com/kf/HTB1TVWDavNNTKJjSspkq6yeWFXaw/100pcs-lot-Stainless-Steel-Drinking-Straws-Cleaner-Brush-Reusable-Unfolded-Straight-Metal-Straw-Gold-Black-Kitchen.jpg", Title = "Drinking Starw", Price = "10", Description = "Our new Ecopack Compostable Retail Bags are plastic free and certified compostable. They meet the new government legislation as they are over 70 micron in thickness. Available in small, medium and large. Size : 40cm(w) X 49cm(h)" });
            FoodList.Add(new Product { Image = "https://image.dhgate.com/0x0/f2/albu/g3/M00/45/21/rBVaHFoT3--AWNIXAANEpwf0rP0285.jpg", Title = "Staniless Steel Straw", Price = "20", Description = "Take your branding to a new level with customised non-woven totes. These totes our most economical bag option for fundraising, promotional giveaways and special events. Size : 350mm(w) + 90mm(g) x 400mm(h), Minimum order quantity for custom branding is 200 pieces, No minimum order for unbranded bags, Click on request a quote for custom branding or contact us" });
            FoodList.Add(new Product { Image = "https://i5.walmartimages.com/asr/eff895b3-2b3f-43f1-97cc-31335bf4751d_1.96a8f564dd8bb217fb0bfd4720687a61.jpeg?odnHeight=450&odnWidth=450&odnBg=FFFFFF", Title = "Collapsible Straw", Price = "10", Description = "Add a cool, shiny twist to your welcome drinks with these metal straws! Straw pack, Includes 4 straws and 1 cleaning brush, Reusable, Metal and plastic(brush) and stainless steel(straws), Straw: 20.5cm(L) x 0.6cm(Dia.), Brush: 17.3cm(L), For domestic use only, Clean according to instructions on the care label" });
            FoodList.Add(new Product { Image = "https://media.karousell.com/media/photos/products/2018/10/11/black_stainless_steel_straw__reusable_straw__set_b6_1539191340_1f17b994.jpg", Title = "Black Stainless Straw", Price = "19", Description = "Add a cool, shiny twist to your welcome drinks with these metal straws! Straw pack, Includes 4 straws and 1 cleaning brush, Reusable, Metal and plastic(brush) and stainless steel(straws), Straw: 20.5cm(L) x 0.6cm(Dia.), Brush: 17.3cm(L), For domestic use only, Clean according to instructions on the care label" });
            FoodList.Add(new Product { Image = "https://image.dhgate.com/0x0/f2/albu/g6/M00/AB/49/rBVaSFu7a8KAOgFyAAHLCASz8QU122.jpg", Title = "Coloured Reusable Straw", Price = "20", Description = "Add a cool, shiny twist to your welcome drinks with these metal straws! Straw pack, Includes 4 straws and 1 cleaning brush, Reusable, Metal and plastic(brush) and stainless steel(straws), Straw: 20.5cm(L) x 0.6cm(Dia.), Brush: 17.3cm(L), For domestic use only, Clean according to instructions on the care label" });
            FoodList.Add(new Product { Image = "https://cdn.shopify.com/s/files/1/0799/5921/products/image_5aa6a950-64f6-4a64-8a46-62e9b86b59f6_3024x.jpg?v=1542640869", Title = "Reusable 8.5", Price = "25", Description = "Add a cool, shiny twist to your welcome drinks with these metal straws! Straw pack, Includes 4 straws and 1 cleaning brush, Reusable, Metal and plastic(brush) and stainless steel(straws), Straw: 20.5cm(L) x 0.6cm(Dia.), Brush: 17.3cm(L), For domestic use only, Clean according to instructions on the care label" });





        }
    }
}
